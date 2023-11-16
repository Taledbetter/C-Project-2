//Chapter 5, Lab 2
//Filename: Orders
//Name: Tiffany Ledbetter
//Date: 11/5/2023

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlace_Click(object sender, EventArgs e)
        {
            string quantity = textBoxQuantityNum.Text;

            if (!string.IsNullOrEmpty(quantity))
            {
                using (StreamWriter input = File.AppendText("Orders.txt"))
                {
                    input.WriteLine(quantity);
                }
                textBoxQuantityNum.Clear();
            }
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            listBoxQuantity.Items.Clear();
            int count = 1;
            int totalQuantity = 0;

            using (StreamReader output = File.OpenText("Orders.txt"))
            {
                string line;
                listBoxQuantity.Items.Add("Order#      Quantity");
                listBoxQuantity.Items.Add("---------------------------------------");
                while ((line = output.ReadLine()) != null)
                {
                    int quantity = int.Parse(line);
                    totalQuantity += quantity;
                    listBoxQuantity.Items.Add(count++ + " -                  " + quantity);
                }

                listBoxQuantity.Items.Add("---------------------------------------");
                listBoxQuantity.Items.Add("Total quantity order " + totalQuantity);
                output.Close();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxQuantity.Items.Clear();
            textBoxQuantityNum.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
