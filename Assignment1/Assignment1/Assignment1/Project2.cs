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

namespace Assignment1
{
    public partial class Project2 : Form
    {
        public Project2()
        {
            InitializeComponent();
        }

        private void Project2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<char> key = new List<char>(
                new char[] { 'B', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D',
                    'B', 'C', 'D', 'A', 'D', 'C', 'C', 'B', 'D', 'A' });

            StreamReader inputFile;

            List<char> studentAns = new List<char>();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFileDialog1.FileName);

                while (!inputFile.EndOfStream)
                {
                    if (char.TryParse(inputFile.ReadLine(), out char result))
                    {
                        studentAns.Add(result);
                    }
                }
            }

            var correct = studentAns.Zip(key, (a, b) => a == b);

            int totalCorrect = 0;

            for (int i = 0; i < correct.Count(); i++)
            {
                if (!correct.ElementAt(i))
                    listBox1.Items.Add(i + 1);
                else
                    totalCorrect++;
            }

            correctLabel.Text = "Number of Correct Answers: " + totalCorrect;
            incorrectLabel.Text = "Number of Incorrect Answers: " + (20 - totalCorrect);

            if (totalCorrect >= 15)
            {
                MessageBox.Show("The student passed with " + totalCorrect + " out of 20", "Pass");
            }
            else
            {
                MessageBox.Show("The student failed with " + totalCorrect + " out of 20", "Fail");
            }
        }
    }
}
