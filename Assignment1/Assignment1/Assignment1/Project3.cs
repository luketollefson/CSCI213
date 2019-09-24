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
    public partial class Project3 : Form
    {
        public Project3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;

            List<(int, int)> population = new List<(int, int)>();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFileDialog1.FileName);

                int year = 1950;

                while (!inputFile.EndOfStream)
                {
                    if (int.TryParse(inputFile.ReadLine(), out int pop))
                    {
                        population.Add((year, pop));
                        year++;
                    }
                }
            }

            var changeInPop =
                from el in population
                let last = el
                select {}



            averageChange.Text = "Average Anual Change from 1950 to 1990: "
                + ((population.First().Item1 + population.Last().Item2) / (decimal)population.Count());
        }
    }
}
