using System;
using System.Linq;
using System.Text;

namespace RF.ScoreQuerier
{
    /// <summary>
    /// 学期的枚举类型
    /// </summary>
    public enum SchoolTermOptions { ALL, First, Second } ;

    /// <summary>
    /// 课程信息类
    /// </summary>
    public class Subject
    {
        //数据域
        private string _schoolYear;
        private SchoolTermOptions _schoolterm;
        private string _numberOfSubject;
        private string _nameOfSubject;
        private float _credits;
        private string _attribute;
        private string _numberOfTeacher;
        private string _nameOfTeacher;
        byte _finalScore;
        byte _usualScore;

        #region //属性
        /// <summary>
        /// <value>返回课程所在学年</value>
        /// </summary>
        public string SchoolYear
        {
            get { return _schoolYear; }
        }
        /// <summary>
        /// <value>返回课程所在学期</value>
        /// </summary>
        public SchoolTermOptions SchoolTerm
        {
            get { return _schoolterm; }
        }
        /// <summary>
        /// <value>返回课程代码</value>
        /// </summary>
        public string NumberOfSubject
        {
            get { return _numberOfSubject; }
        }
        /// <summary>
        /// <value>返回课程名称</value>
        /// </summary>
        public string NameOfSubject
        {
            get { return _nameOfSubject; }
        }
        /// <summary>
        /// <value>返回课程学分</value>
        /// </summary>
        public float Credits
        {
            get { return _credits; }
        }
        /// <summary>
        /// <value>返回课程属性</value>
        /// </summary>
        public string Attribute
        {
            get { return _attribute; }
        }
        /// <summary>
        /// <value>返回教师工号</value>
        /// </summary>
        public string NumberOfTeacher
        {
            get { return _numberOfTeacher; }
        }
        /// <summary>
        /// <value>返回教师姓名</value>
        /// </summary>
        public string NameOfTeacher
        {
            get { return _nameOfTeacher; }
        }
        /// <summary>
        /// <value>返回课程总评成绩</value>
        /// </summary>
        public byte FinalScore
        {
            get { return _finalScore; }
        }
        /// <summary>
        /// <value>返回课程平时成绩</value>
        /// </summary>
        public byte UsualScore
        {
            get { return _usualScore; }
        }
        #endregion

        //构造函数
        public Subject(string schoolYear, SchoolTermOptions schoolterm, string numberOfSubject, string nameOfSubject, float credits, string attribute, string numberOfTeacher, string nameOfTeacher, byte finalScore, byte ususalScore)
        {
            _schoolYear = schoolYear;
            _schoolterm = schoolterm;
            _numberOfSubject = numberOfSubject;
            _nameOfSubject = nameOfSubject;
            _credits = credits;
            _attribute = attribute;
            _numberOfTeacher = numberOfTeacher;
            _nameOfTeacher = nameOfTeacher;
            _finalScore = finalScore;
            _usualScore = ususalScore;
        }

        //拷贝构造函数
        public Subject(Subject subject)
            : this(subject._schoolYear, subject._schoolterm, subject._numberOfSubject, subject._nameOfSubject, subject._credits, subject._attribute, subject._numberOfTeacher, subject._nameOfTeacher, subject._finalScore, subject._usualScore) { }
    }
}
