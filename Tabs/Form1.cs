using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tabs
{
    public partial class Form1 : Form
    {
        public int pos = 0;
        public string filename = "";
        //a map for searching by movie name
        private Dictionary<string, Movie> map;

        public Form1()
        {
            InitializeComponent();

            //disable controls in all but first tab
            tabControl1.TabPages[1].Enabled = false;
            tabControl1.TabPages[2].Enabled = false;
            tabControl1.TabPages[3].Enabled = false;      

        }

        //disable controls in disabled tabs
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = !e.TabPage.Enabled;
        }

        //add a new record in the end of the file
        void addrecord(string name, string number)
        {
            Movie mov = new Movie();
            mov.name = name;
            mov.number = number;

            pos += 1;
            //write a new record to a file
            writeToFile(mov, pos, Movie.Size);
        }

        //a Movie class
        class Movie
        {

            private string mname;
            private string mnumber;


            public string name
            { //name property

                set { mname = value; }
                get { return mname; }

            }
            public string number
            { //number property

                set { mnumber = value; }
                get { return mnumber; }

            }

            public int Position { set; get; }

            public static int Size {
                get
                {
                    int size = 2 * 15 + 2 * 20;
                    return size;
                }
            }

            override public string ToString()
            {
                return mname;
            }



        }

        //write a record to the file at a certain position
        void writeToFile(Movie obj, int pos, int size)
        {

            FileStream fout;
            BinaryWriter bw;

            try
            {
                //create a file stream object
                fout = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);

                //create a binary writer object
                bw = new BinaryWriter(fout);

                fout.Position = pos * size;
                bw.Write(obj.name);
                bw.Write(obj.number);
                //close objects
                bw.Close();
                fout.Close();

            }
            catch (IOException e)
            {
                MessageBox.Show("Couldn't write to a file:" + e.Message);
            }

        }

        //populate listbox on Select tab with records in the file
        void readFromFile()
        {
            FileStream fn;
            BinaryReader br;

            
            map = new Dictionary<string, Movie>();

            int currentrecord = 0;
            lbxSelect.Items.Clear();

            try
            {
                //open file to read data
                fn = new FileStream(filename, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fn);

                //read next record
                int i;
                for (i = 1; i <= (int)(fn.Length) / Movie.Size; i++)
                {
                    Movie mov = new Movie();
                    currentrecord += 1; //update currentrecord position

                    fn.Seek(currentrecord * Movie.Size, 0);

                    mov.name = br.ReadString().ToString();
                    mov.number = br.ReadString().ToString();
                    mov.Position = i;

                    lbxSelect.Items.Add(mov);

                    //populate the map
                    map.Add(mov.name, mov); 

                }

                //update pos to the current position
                pos = currentrecord;

                //close objects
                br.Close();
                fn.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show("Couldn't read a file:" + e.Message);
            }
        }

        //read record from a file
        private void readRecordInfoFromFile(BinaryReader br, Movie mov)
        {
            mov.name = br.ReadString().ToString();
            mov.number = br.ReadString().ToString();
        }

        //search the map to find movies with names that contain a string name
        private List<Movie> FindMovies(string name)
        {
            List<Movie> result = new List<Movie>();

            foreach (string key in map.Keys)
            {
                if (key.Contains(name))
                {
                    result.Add(map[key]);
                }
            }
            return result;
        }

        //populate the form using a Movie object
        private void fillInputForm(Movie mov)
        {
            tbName.Text = mov.name;
            tbNumber.Text = mov.number;
        }

        //open or create a new database file
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //get the filename
            filename = tbFilename.Text;
            //if empty, assign default
            if (filename == "")
            {
               filename = "database.txt";
            }

            //enable the controls in other tabs
            tabControl1.TabPages[1].Enabled = true;
            tabControl1.TabPages[2].Enabled = true;
            tabControl1.TabPages[3].Enabled = true;

            //switch to Select tab        
            tabControl1.SelectedIndex = 2;

            //populate listbox on Select tab and create a map<name, movie>
            readFromFile();          

        }

        //save a record to the file 
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputForm())
            {
                //check if there is a record with this name already
                if (!map.ContainsKey(tbName.Text))
                {
                    //if there is no movie with this name, add a new one
                    addrecord(tbName.Text, tbNumber.Text);

                    //clear the search 
                    lbxMovieFound.Items.Clear();
                }
                else
                {
                    //else update the record of that movie
                    Movie mov = map[tbName.Text];
                    int position = mov.Position;

                    //update Movie object
                    getMovieInfoFromForm(mov);

                    //write updated info to the file
                    writeToFile(mov, position, Movie.Size);
                }

                //populate listbox on Select tab and create a map<name, movie>
                readFromFile();
            }                 
        }

        //validate form input
        private bool ValidateInputForm()
        {
            return true;
        }

        //populate Movie object using form values
        private void getMovieInfoFromForm(Movie mov)
        {
            mov.name = tbName.Text;
            mov.number = tbNumber.Text;
        } 

        //reads the info of a movie with a selected name, opens Input tab with that info
        private void btnRead_Click(object sender, EventArgs e)
        {
            Movie selected = (Movie)lbxSelect.SelectedItem;
            if (selected != null)
            {
                fillInputForm(selected);
                tabControl1.SelectedIndex = 1;
            }
        }

        //find a movie
        private void btnFind_Click(object sender, EventArgs e)
        {
            //clear the list of found movies
            lbxMovieFound.Items.Clear();

            //get the string to searh
            string name = tbFindMovie.Text;

            //perfform search
            List<Movie> found = FindMovies(name);

            //show results
            foreach (Movie mov in found)
            {
                lbxMovieFound.Items.Add(mov);
            }           
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Movie mov = (Movie)lbxMovieFound.SelectedItem;
            if (mov != null)
            {
                int position = mov.Position;

                //To Delete a file:
                //1.Create a new file.
                //2.Copy all the valid records from the original file into the new file.
                //3.Close the original file and use the Kill statement to delete it.
                //4.Use the Name statement to rename the new file with the name of the original file.

                FileStream fout;
                BinaryWriter bw;

                FileStream fn;
                BinaryReader br;

                try
                {
                    //create a file stream object
                    fout = new FileStream("tmp.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    fn = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    
                    //create a binary writer 
                    bw = new BinaryWriter(fout);
                    
                    //create a binary reader
                    br = new BinaryReader(fn);

                    //copy all records before the deleted one
                    for (int i = 1; i < position; i++)
                    {
                        Movie m = new Movie();
                        fn.Seek(i * Movie.Size, 0);
                        readRecordInfoFromFile(br, m);

                        fout.Position = i * Movie.Size;
                        bw.Write(m.name);
                        bw.Write(m.number);           
                    }

                    //copy all recoreds after the deleted one
                    for (int i = position + 1; i <= (int)(fn.Length) / Movie.Size; i++)
                    {
                        Movie m = new Movie();
                        fn.Seek(i * Movie.Size, 0);
                        readRecordInfoFromFile(br, m);
                        fout.Position = (i - 1) * Movie.Size;
                        bw.Write(m.name);
                        bw.Write(m.number);
                    }

                    //close objects
                    bw.Close();
                    fout.Close();

                    br.Close();
                    fn.Close();

                    //delete the old file and rename a new one
                    File.Delete(filename);
                    File.Move("tmp.txt", filename);
                    
                    //remove the item from the search list
                    lbxMovieFound.Items.Remove(lbxMovieFound.SelectedItem);

                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }

                //populate listbox on Select tab and create a map<name, movie>
                readFromFile();
            }        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Movie selected = (Movie)lbxMovieFound.SelectedItem;
            if (selected != null)
            {
                fillInputForm(selected);
                tabControl1.SelectedIndex = 1;
            }
           
        }
    }
}
