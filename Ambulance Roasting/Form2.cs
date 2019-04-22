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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            var context = new MyContext();
            var staffMembers1 = from ez in context.my_staff_table let ID = ez.officer_id let Name = ez.first_name + " " + ez.last_name let Skill = ez.skill_level let Ambulance = ez.assigned_ambulance select new { ID, Name,Skill,Ambulance };
            dataGridView1.DataSource = staffMembers1.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 opening = new Form1();
            opening.Show();
            this.Hide();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 opening = new Form3();
            opening.comboBox1.SelectedItem = "Basic";
            opening.comboBox2.SelectedItem = "None";
            opening.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selected_row = dataGridView1.Rows[e.RowIndex];
            string my_ID = selected_row.Cells["ID"].Value.ToString();
            string my_Name = selected_row.Cells["Name"].Value.ToString().Trim();
            String[] Name_list = my_Name.Split();
            string my_Skill = selected_row.Cells["Skill"].Value.ToString();

            string final_ambulance = null;

            if (selected_row.Cells["Ambulance"].Value != null) { final_ambulance = selected_row.Cells["Ambulance"].Value.ToString(); }
            else { final_ambulance = "None"; }

            Form3 opening = new Form3();
            opening.textBox1.AppendText(Name_list[0]);
            opening.textBox2.AppendText(Name_list[1]);
            opening.textBox3.AppendText(my_ID);
            opening.comboBox1.SelectedItem = my_Skill;
            opening.comboBox2.SelectedItem = final_ambulance;
            opening.label1.Text = "Ambulance Officer: " + my_Name;
            opening.Show();
            this.Hide();
        }
    }
}
