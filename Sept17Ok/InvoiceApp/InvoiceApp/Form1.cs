using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Invoice> myInvoices = new List<Invoice>();

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myInvoices.Add(new Invoice(111, "AAA", 6, 356));
            myInvoices.Add(new Invoice(112, "ABB", 3, 626));
            myInvoices.Add(new Invoice(113, "CCC", 24, 536));
            myInvoices.Add(new Invoice(114, "DDD", 14, 526));
            myInvoices.Add(new Invoice(115, "EEE", 4, 89));

            // show data - from the List to dataGridView1
            // dataGridView1.DataSource = myInvoices;

            var result =
                from x in myInvoices
                orderby x.PartDescription
                select x;

            // show sorted data
            dataGridView1.DataSource = result.ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int partNum = Convert.ToInt32(textBox1.Text);

            Invoice partInfo =
               (from x in myInvoices
                where x.PartNumber == partNum
                select x).First();

            // output
            listBox1.Items.Add(partInfo.PartNumber);
            listBox1.Items.Add(partInfo.PartDescription);
            listBox1.Items.Add(partInfo.Quantity);
            listBox1.Items.Add(partInfo.Price);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string partName = textBox2.Text;

            Invoice partInfo =
               (from x in myInvoices
                where x.PartDescription.StartsWith(partName)
                select x).First();

            // output
            listBox1.Items.Add(partInfo.PartNumber);
            listBox1.Items.Add(partInfo.PartDescription);
            listBox1.Items.Add(partInfo.Quantity);
            listBox1.Items.Add(partInfo.Price);
        }
    }
}
