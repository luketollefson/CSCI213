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

namespace FilesApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                string name;
                double grade;
                StreamReader inFile;
                inFile = File.OpenText("abc.txt");

                while (!inFile.EndOfStream)
                {
                    name = inFile.ReadLine();
                    grade = Convert.ToDouble(inFile.ReadLine());
                    // add data to the listBox
                    listBox1.Items.Add(name + " " + grade);                    

                }
                inFile.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
