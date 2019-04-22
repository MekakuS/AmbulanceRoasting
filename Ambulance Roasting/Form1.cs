using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Officers_Click(object sender, EventArgs e)
        {
            Form2 opening = new Form2();
            opening.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void Ambulances_Click(object sender, EventArgs e)
        {
            Form4 opening = new Form4();
            opening.Show();
            this.Hide();
        }

        private void CheckRosters_Click(object sender, EventArgs e)
        {
            Form6 opening = new Form6();
            opening.Show();
            this.Hide();
        }
    }
}
