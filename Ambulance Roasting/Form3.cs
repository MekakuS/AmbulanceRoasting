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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            var context_3 = new MyContext();
            var Ambulance2 = from e in context_3.my_ambulance_table select e;
            foreach (var i in Ambulance2) { comboBox2.Items.Add(i.ambulance_id); }
            comboBox2.Items.Insert(0, "None");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 opening = new Form2();
            opening.Show();
            this.Hide();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //my save button 
        {
            string my_first_name = textBox1.Text.Trim();
            string my_last_name = textBox2.Text.Trim();
            string my_officer_id = textBox3.Text.Trim();
            string my_skill_level = comboBox1.Text.Trim();
            string my_ambulance = comboBox2.Text.Trim();

            

            if (my_first_name.Length == 0) { MessageBox.Show("Must have first name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
            else if (my_last_name.Length == 0){MessageBox.Show("Must have last name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
            else if (my_officer_id.Length != 6) { MessageBox.Show("Must have 6 digits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
            else {
                string the_label = label1.Text.Trim();
                if (the_label == "Ambulance Officer: New")
                { // are they adding new person?

                    int checking_to_see_if_officer_id_exsist = 0;
                    var context2 = new MyContext();
                    var staffMemberst = from es in context2.my_staff_table select es;
                    foreach (var i in staffMemberst) { if ((string)i.officer_id.Trim() == my_officer_id) { checking_to_see_if_officer_id_exsist = 1; break; } }
                    if (checking_to_see_if_officer_id_exsist == 1) { MessageBox.Show("officer ID must be unique", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else { 
                    var context = new MyContext();
                    var person = new staff_table();
                    person.first_name = my_first_name;
                    person.last_name = my_last_name;
                    person.officer_id = my_officer_id;
                    person.skill_level = my_skill_level;
                    if (my_ambulance == "None") { person.assigned_ambulance = null; }
                    else { person.assigned_ambulance = my_ambulance; }
                    context.my_staff_table.Add(person);
                    context.SaveChanges();
                    Form2 opening = new Form2();
                    opening.Show();
                    this.Hide();
                    }
                }
                else {
                    var context23 = new MyContext();
                    var staffMemberstest = from esz in context23.my_staff_table select esz;
                    foreach (var i in staffMemberstest) {
                        if((string) i.officer_id.Trim() == my_officer_id){
                            i.first_name = my_first_name;
                            i.last_name = my_last_name;
                            i.officer_id = my_officer_id;
                            i.skill_level = my_skill_level;
                            if (my_ambulance == "None") { i.assigned_ambulance = null; }
                            else { i.assigned_ambulance = my_ambulance; }
                            break;
                        }
                    
                    }
                    context23.SaveChanges();
                    Form2 opening = new Form2();
                    opening.Show();
                    this.Hide();
                }
            }


        }
    }
}
