using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice5App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue<Customer> customers = new Queue<Customer>();
        //Customer aCustomer = new Customer();
        private int i = 1;
        private void enqueueButton_Click(object sender, EventArgs e)
        {
            Customer aCustomer = new Customer();
            aCustomer.serialNo = i++;
            aCustomer.name = nameEnqueueTextBox.Text;
            aCustomer.complain = complainEnqueueTextBox.Text;

            customers.Enqueue(aCustomer);

            string[] row = { aCustomer.serialNo.ToString(), aCustomer.name, aCustomer.complain };
            var listViewItem = new ListViewItem(row);
            waitingQueueListView.Items.Add(listViewItem);

            MessageBox.Show(aCustomer.name + @"'s serial no is: " + aCustomer.serialNo);

            nameEnqueueTextBox.Text = string.Empty;
            complainEnqueueTextBox.Text = string.Empty;

        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            Customer aCustomer = new Customer();

            if (waitingQueueListView.Items.Count == 0)
            {
                MessageBox.Show("There is no items in waiting dequeue");
            }
            else
            {
                aCustomer = customers.Dequeue();

                serialNoTextBox.Text = aCustomer.serialNo.ToString();
                nameDequeueTextBox.Text = aCustomer.name;
                complainDequeueTextBox.Text = aCustomer.complain;

                waitingQueueListView.Items.RemoveAt(0);
            }
        }
    }
}
