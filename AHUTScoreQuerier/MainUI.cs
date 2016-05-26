using System;
using System.Windows.Forms;

namespace RF.ScoreQuerier
{
    public partial class ScoreQuerierMainForm : Form
    {
        private Student m_student;

        public ScoreQuerierMainForm()
        {
            InitializeComponent();            
            InitStudentInfo();
            InitComboBoxData();
        }

        private void InitComboBoxData()
        {
            cboSchoolTerm.SelectedIndex = 0;

            int minyear = 2005;
            int maxyear = DateTime.Now.Year;
            cboSchoolYear.Items.Add("==请选择==");
            for (int i = maxyear - 1; i >= minyear; i--)
                cboSchoolYear.Items.Add(i.ToString() + "-" + (i + 1).ToString());
            cboSchoolYear.SelectedIndex = 0;
        }

        private void btnQueryScore_Click(object sender, EventArgs e)
        {
            if (txtSchoolNumber.Text == string.Empty || txtIDNumber.Text == string.Empty)
            {
                MessageBox.Show("请填写正确的信息!");
                return;
            }
            prcGetScore.Value = 0;
            prcGetScore.Value = 40;
            m_student = new Student(txtName.Text, txtSchoolNumber.Text, txtIDNumber.Text);
            string schoolYear = cboSchoolYear.SelectedIndex == 0 ? string.Empty : cboSchoolYear.SelectedItem.ToString();
            SchoolTermOptions schoolTerm = (SchoolTermOptions)cboSchoolTerm.SelectedIndex;
            try
            {
                m_student.GetSubjectScore(schoolYear, schoolTerm, "查询", "全部成绩");
            }
            catch (ScoreQuerierException exception)
            {
                MessageBox.Show(exception.Message);
            }
            prcGetScore.Value = 100;
            lvwSubjects.Items.Clear();
            txtGPA.Clear();
            lblCountOfSubjects.Text = string.Empty;

            for(int i = 0; i < m_student.Subjects.Count; i++)
            {
                lvwSubjects.Items.Add(m_student.Subjects[i].NumberOfSubject);
                lvwSubjects.Items[i].SubItems.Add(m_student.Subjects[i].NameOfSubject);
                lvwSubjects.Items[i].SubItems.Add(m_student.Subjects[i].Credits.ToString());
                lvwSubjects.Items[i].SubItems.Add(m_student.Subjects[i].Attribute);
                lvwSubjects.Items[i].SubItems.Add(m_student.Subjects[i].NumberOfTeacher);
                lvwSubjects.Items[i].SubItems.Add(m_student.Subjects[i].NameOfTeacher);
                lvwSubjects.Items[i].SubItems.Add(m_student.Subjects[i].FinalScore.ToString());
                lvwSubjects.Items[i].SubItems.Add(m_student.Subjects[i].UsualScore.ToString());
            }
            txtGPA.Text = m_student.GPA.ToString();
            lblCountOfSubjects.Text = "共: " + m_student.Subjects.Count.ToString() + "门课程数据!";

        }

        private void txtSchoolNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !(e.KeyChar >= '0' && e.KeyChar <= '9'))
                e.Handled = true;
        }

        private void txtIDNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !(e.KeyChar >= '0' && e.KeyChar <= '9'))
                e.Handled = true;
        }

        private void InitStudentInfo()
        {
            string name, number, id ;
            StudentXML.InitStudentInfo(out name, out number, out id);
            txtName.Text = name;
            txtSchoolNumber.Text = number;
            txtIDNumber.Text = id;
        }

        private void ScoreQuerierMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StudentXML.SaveStudentInfo(m_student);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvwSubjects.Items.Clear();
            txtGPA.Clear();
            lblCountOfSubjects.Text = string.Empty;
        }
    }
}
