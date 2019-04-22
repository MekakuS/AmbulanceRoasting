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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            var context = new MyContext();
            var the_ambulance_table = from ez in context.my_ambulance_table let ID = ez.ambulance_id let Station = ez.station select new {ID, Station};
            dataGridView1.DataSource = the_ambulance_table.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selected_row = dataGridView1.Rows[e.RowIndex]; 
                string my_ID = selected_row.Cells["ID"].Value.ToString();
                string my_Station = selected_row.Cells["Station"].Value.ToString().Trim();
                Form5 opening = new Form5();

                var context_3 = new MyContext();
                var each_staff = from ez in context_3.my_staff_table select ez;
                foreach (var i in each_staff)
                {
                    string value = (string)i.assigned_ambulance;
                    if (value == my_ID) { opening.textBox3.AppendText(i.first_name + " " + i.last_name + "\n"); }
                }
                opening.textBox1.AppendText(my_ID);
                opening.textBox2.AppendText(my_Station);
                opening.label1.Text = "Ambulance: " + my_ID;
                opening.Show();
                this.Hide();
            }
            catch (Exception ex) { }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 opening = new Form1();
            opening.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 opening = new Form5();
            opening.Show();
            this.Hide();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
