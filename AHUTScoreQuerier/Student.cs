using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF.ScoreQuerier
{
    /// <summary>
    /// 包含学生姓名、学号、身份证包括课程信息的类
    /// </summary>
    public class Student
    {
        private string m_name;
        private string m_schoolnumber;
        private string m_IDCard;
        private float m_GPA;

        private List<Subject> m_subjects;

        #region //属性
        public string Name
        {
            get { return m_name; }
            internal set { m_name = value; } 
        }
        public string SchoolNumber
        {
            get { return m_schoolnumber; }
            internal set { m_schoolnumber = value; }
        }
        public string IDCard
        {
            get { return m_IDCard; }
            internal set { m_IDCard = value; }
        }
        public float GPA
        {
            get { return m_GPA; }
            internal set { m_GPA = value; }
        }
        public List<Subject> Subjects
        {
            get { return m_subjects; }
        }


        #endregion

        //构造函数
        /// <summary>
        /// 学生类的构造器
        /// </summary>
        /// <param name="name">学生姓名</param>
        /// <param name="schoolnumber">学生学号</param>
        /// <param name="IDCard">学生身份证号码</param>
        public Student(string name, string schoolnumber, string IDCard)
        {
            m_name = name;
            m_schoolnumber = schoolnumber;
            m_IDCard = IDCard;
            m_subjects = new List<Subject>();
        }

        internal Student()
        {
            m_name = null;
            m_IDCard = null;
            m_schoolnumber = null;
            m_GPA = 0;
            m_subjects = null;
        }

        //获取成绩
        /// <summary>
        /// 学生类的获取成绩方法，将自动从查询成绩的网页上获取成绩
        /// </summary>
        /// <param name="schoolYear">查询指定学年的成绩</param>
        /// <param name="schoolTerm">查询指定学期的成绩</param>
        /// <returns>返回是否成功获取到成绩</returns>
        public bool GetSubjectScore(string schoolYear, SchoolTermOptions schoolTerm, string queryPurpose, string queryType)
        {
            return ScoreQuerier.QueryStudentScore(this, schoolYear, schoolTerm, queryPurpose, queryType);
        }
    }
}
