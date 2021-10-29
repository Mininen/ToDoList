using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Entities;

namespace GUI
{
    public partial class AddTask : Form
    {
        BusinessManager bm { get; set; }
        public AddTask(BusinessManager businessManager)
        {
            bm = businessManager;
            InitializeComponent();
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text;
            string description = DescriptionTB.Text;
            DateTime dueDate = dateTimePicker.Value;
            DateTime now = new DateTime();
            var date = now.Date;

            if (dueDate >= date && name != "") 
            {
                bm.addTask(name, description, dueDate);
                MessageBox.Show("Task Added!");

                this.Hide();
                Form1 form1 = new Form1(bm);
                form1.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Tasks must have a name and deadline have to be in the future!");
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No new task added");
            this.Hide();
            Form1 form1 = new Form1(bm);
            form1.ShowDialog();
            this.Close();
        }
    }
}
