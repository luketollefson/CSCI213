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
    public partial class Project1 : Form
    {
        public Project1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;

            List<decimal> myList = new List<decimal>();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFileDialog1.FileName);

                while (!inputFile.EndOfStream)
                {
                    string line = inputFile.ReadLine();
                    listBox1.Items.Add(line);
                    if (decimal.TryParse(line, out decimal result)) {
                        myList.Add(result);
                    }
                }
            }

            totalLabel.Text = "Total = " + myList.Sum();
            averageLabel.Text = "Average = " + myList.Average();
            maximumLabel.Text = "Maximum = " + myList.Max();
            minimumLabel.Text = "Minimum = " + myList.Min();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
