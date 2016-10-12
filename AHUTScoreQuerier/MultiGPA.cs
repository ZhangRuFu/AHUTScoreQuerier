using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RF.ScoreQuerier
{
    public partial class MultiGPA : Form
    {
        public MultiGPA()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string startNumber = txtStartNumber.Text;
            string count = txtEndNumber.Text;
            Student[] student = ScoreQuerier.GetClassmatesGPA(startNumber, Convert.ToUInt32(count));

            //Sql Server
            OleDbConnection con = new OleDbConnection(@"Provider=SQLOLEDB;server=DESKTOP-OC99H24\SQLEXPRESS;Trusted_Connection=yes;Database=CS");
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            foreach (Student stu in student)
            {
                string sql = string.Format("INSERT INTO CS(Name, GPA) VALUES('{0}', {1})", stu.Name, stu.GPA);
                com.CommandText = sql;
                com.ExecuteNonQuery();
            }
            con.Close();

        }

        private void chkUseCount_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseCount.CheckState == CheckState.Checked)
                lblEndNumber.Text = "人数:";
            else
                lblEndNumber.Text = "终止学号:";
        }
    }
}
