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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            var context_3 = new MyContext();
            var each_ambulance = from ez in context_3.my_ambulance_table select ez;

            foreach (var i in each_ambulance)
            { //starts
                TextBox my_box = new TextBox();
                my_box.ReadOnly = true;
                my_box.MinimumSize = new Size(410, 50);

                my_box.Font = new Font("Arial", 11, FontStyle.Regular);
                my_box.Multiline = true;
                my_box.AppendText((string)i.ambulance_id);
                my_box.BackColor = Color.FromArgb(192, 80, 77);
                flowLayoutPanel1.Controls.Add(my_box);

                var context_4 = new MyContext();
                var each_staff = from ez in context_4.my_staff_table where ez.assigned_ambulance == i.ambulance_id select ez;

                int counter_check_if_there_there_is_2_or_3 = each_staff.Count();
               
                foreach (var officer_data in each_staff)
                {
                    
                    if ((string)i.ambulance_id == (string)officer_data.assigned_ambulance)
                    {
                       
                        my_box.AppendText("\t\t" + officer_data.officer_id + "  (" + officer_data.skill_level + ")\r\n");
                        
                        if (counter_check_if_there_there_is_2_or_3 >= 2 && counter_check_if_there_there_is_2_or_3 <= 3 && ((string)officer_data.skill_level == "Intermediate" || (string)officer_data.skill_level == "Advanced"))
                        {
                            my_box.BackColor = Color.FromArgb(155, 187, 89);
                            
                        }
                        
                    }
                    Size size = TextRenderer.MeasureText(my_box.Text, my_box.Font);
                    my_box.Height = size.Height;

                }
               
            }//ends
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
