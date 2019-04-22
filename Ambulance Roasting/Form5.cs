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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 opening = new Form4();
            opening.Show();
            this.Hide();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//saving part
        {
            string AmbulanceID_input = textBox1.Text;
            string num_amb = AmbulanceID_input.Substring(1,AmbulanceID_input.Length-1);
            string Station_input = textBox2.Text.Trim();

            if (AmbulanceID_input[0] != 'A') { MessageBox.Show("Ambulance ID must consist of an A followed by a number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (num_amb.Length >= 4 || num_amb.Length == 0) { MessageBox.Show("Ambulance ID numbers must between then lengths 1 and 3", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (Station_input.Length <= 0) { MessageBox.Show("Station must have more then 0 letters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else { 
                string the_label = label1.Text.Trim();
                if (the_label == "Ambulance: New")
                {
                    int checking_to_see_if_ambulance_id_exsist = 0;
                    var context2 = new MyContext();
                    var ambulance_checker = from es in context2.my_ambulance_table select es;
                    foreach (var i in ambulance_checker) { if ((string)i.ambulance_id.Trim() == AmbulanceID_input) { checking_to_see_if_ambulance_id_exsist = 1; break; } }
                    if (checking_to_see_if_ambulance_id_exsist == 1) { MessageBox.Show("Ambulance ID  already in the database", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else
                    {
                        var context = new MyContext();
                        var ambulance_add = new ambulance_table();
                        ambulance_add.ambulance_id = AmbulanceID_input;
                        ambulance_add.station = Station_input;
                        context.my_ambulance_table.Add(ambulance_add);
                        context.SaveChanges();
                        Form4 opening = new Form4();
                        opening.Show();
                        this.Hide();

                    }
                }
                else 
                {
                    string intro = label1.Text.Trim();
                    string[] the_list = intro.Split();
                    string previous_ID = the_list[1].Trim();
                    var db = new MyContext();
                    var currentAmbulance = (from o in db.my_ambulance_table.Where(a => a.ambulance_id == previous_ID) select o).SingleOrDefault();
                
                        //1. changing the existing infomration in the ambulance_table
                        var context11 = new MyContext();
                        var ambulance_checker1 = from esx in context11.my_ambulance_table select esx;
                        foreach (var i in ambulance_checker1) { if ((string)i.ambulance_id == previous_ID) { context11.my_ambulance_table.Remove(i); break; } }
                        var ambulance_re_add = new ambulance_table();
                        ambulance_re_add.ambulance_id = AmbulanceID_input;
                        ambulance_re_add.station = Station_input;
                        context11.my_ambulance_table.Add(ambulance_re_add);

                        //2. changing the before existing information in staff_table with the same ID to the new ID
                        var staff_checker1 = from esxx in context11.my_staff_table select esxx;
                        foreach (var i in staff_checker1) { if ((string)i.assigned_ambulance == previous_ID) { i.assigned_ambulance = AmbulanceID_input; } }
                        if (db.my_ambulance_table.Any(a => a.ambulance_id == ambulance_re_add.ambulance_id && a.ambulance_id != previous_ID)) { MessageBox.Show("Ambulance ID  already there", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        else
                        {
                            context11.SaveChanges();
                            Form4 opening = new Form4();
                            opening.Show();
                            this.Hide();
                        }

                    
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
