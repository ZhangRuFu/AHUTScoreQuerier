using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace RF.ScoreQuerier
{
    public static class StudentXML
    {
        public static void InitStudentInfo(out string studentName, out string studentNumber, out string studentIDCard)
        {
            XmlDocument xmldoc = new XmlDocument();
            try
            {
                xmldoc.Load("StudentInfo.data");
            }
            catch (FileNotFoundException exception)
            {
                studentIDCard = null;
                studentName = null;
                studentNumber = null;
                return;
            }
            XmlNodeList studentinfo = xmldoc.DocumentElement.ChildNodes;
            studentName = studentinfo.Item(0).InnerText;
            studentNumber = studentinfo.Item(1).InnerText;
            studentIDCard = DecryptoID(studentinfo.Item(2).InnerText);
        }

        public static void SaveStudentInfo(Student student)
        {
            if (student == null)
                return;
            bool isExsited = true;
            XmlDocument xmldoc = new XmlDocument();
            try
            {
                xmldoc.Load("StudentInfo.data");
            }
            catch (FileNotFoundException exception)
            {
                isExsited = false;
            }

            if (isExsited)
            {
                XmlNodeList studentinfo = xmldoc.DocumentElement.FirstChild.ChildNodes;
                if (student.Name == studentinfo.Item(0).InnerText)
                    return;
            }
            xmldoc.RemoveAll();
            XmlElement root = xmldoc.CreateElement("student");
            XmlElement name = xmldoc.CreateElement("name");
            XmlElement schoolnumber = xmldoc.CreateElement("schoolnumber");
            XmlElement idcard = xmldoc.CreateElement("idcard");

            name.AppendChild(xmldoc.CreateTextNode(student.Name));
            schoolnumber.AppendChild(xmldoc.CreateTextNode(student.SchoolNumber));
            idcard.AppendChild(xmldoc.CreateTextNode(EncryptoID(student.IDCard)));

            root.AppendChild(name);
            root.AppendChild(schoolnumber);
            root.AppendChild(idcard);

            xmldoc.AppendChild(root);

            xmldoc.Save("Studentinfo.data");
        }


        private static string EncryptoID(string data)
        {
            byte[] datastream = Encoding.UTF8.GetBytes(data);
            for (int i = 0; i < datastream.Length - 1; i++)
                datastream[i] += (byte)(i * 3 + 1);
            return Encoding.UTF8.GetString(datastream);

        }

        private static string DecryptoID(string data)
        {
            byte[] datastream = Encoding.UTF8.GetBytes(data);
            for (int i = 0; i < datastream.Length - 1; i++)
                datastream[i] -= (byte)(i * 3 + 1);
            return Encoding.UTF8.GetString(datastream) ;
        }
    }
}
