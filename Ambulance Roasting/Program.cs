using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;

namespace Assignment3
{
    
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class MyContext : DbContext
    {
        public MyContext() : base("MySqlConnection") { } public DbSet<staff_table> my_staff_table { get; set; }
        public DbSet<ambulance_table> my_ambulance_table { get; set; }
    }
    [Table("staff_table")]
    public class staff_table
    {
        
        public string last_name { get; set; }
        public string first_name { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string officer_id { get; set; }
        public string skill_level { get; set; }
        public string assigned_ambulance { get; set; }
        [ForeignKey("assigned_ambulance")]
        public ambulance_table ambulance_assigned { get; set; }
    }
    [Table("ambulance_table")]
    public class ambulance_table
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string ambulance_id { get; set; }
        public string station { get; set; }
    }
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
