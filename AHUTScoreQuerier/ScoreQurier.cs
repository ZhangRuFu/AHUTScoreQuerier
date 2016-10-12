using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Web;
using System.IO;
using System.Xml;

namespace RF.ScoreQuerier
{
    /// <summary>
    /// 成绩查询功能主要实现类(静态类)
    /// </summary>
    public static class ScoreQuerier
    {
        private static string m_schoolYear;
        private static SchoolTermOptions m_schoolTerm;

        private static string m_url;
        private static string m_viewState;
        private static string m_viewStateGenerator;
        private static string m_eventValidation;

        private static Student m_student;

        private enum QueryMode { Score, GPA, NumbertoName } ;
        private static char[] m_requestTransformContent = "__VIEWSTATE=%2FwEPDwUKLTc5MTY3NzY2OA9kFgICAw9kFg4CBQ8QZBAVDw09Peivt%2BmAieaLqT09CTIwMTUtMjAxNgkyMDE0LTIwMTUJMjAxNC0yMDE1CTIwMTMtMjAxNAkyMDEzLTIwMTQJMjAxMi0yMDEzCTIwMTEtMjAxMwkyMDExLTIwMTIJMjAxMC0yMDExCTIwMDktMjAxMAkyMDA4LTIwMDkJMjAwNy0yMDA4CTIwMDYtMjAwNwkyMDA1LTIwMDYVDwAJMjAxNS0yMDE2CTIwMTQtMjAxNQkyMDE0LTIwMTUJMjAxMy0yMDE0CTIwMTMtMjAxNAkyMDEyLTIwMTMJMjAxMS0yMDEzCTIwMTEtMjAxMgkyMDEwLTIwMTEJMjAwOS0yMDEwCTIwMDgtMjAwOQkyMDA3LTIwMDgJMjAwNi0yMDA3CTIwMDUtMjAwNhQrAw9nZ2dnZ2dnZ2dnZ2dnZ2dkZAIHDxBkEBUDDT096K%2B36YCJ5oupPT0BMgExFQMAATIBMRQrAwNnZ2dkZAIdD2QWAgIFDzwrABEAZAIfD2QWAgIBDzwrABEAZAIjDw8WAh4HVmlzaWJsZWdkFgICCQ88KwARAGQCJQ9kFgICAw8QZGQWAWZkAicPZBYCAgEPPCsAEQEBEBYAFgAWAGQYBAUJR3JpZFZpZXczD2dkBQlHcmlkVmlldzEPZ2QFDEdyaWRWaWV3X2NqMA9nZAULR3JpZFZpZXdfY2oPZ2QnnWvp%2BsBkaYbJWOejvp5DO93kh7gdNN2DDnmcWMNfkw%3D%3D&__VIEWSTATEGENERATOR=DCA2160B&__EVENTVALIDATION=%2FwEWKAK12vfNBQLs0bLrBgLs0fbZDALWrMSACwKHx9OABAKEx5fABgKEx5fABgKFx%2FuABQKFx%2FuABQKax7%2FABwKax6OABgKbx6OABgKYx%2BdBAsKF4K8GAs2FiJQIAsqF5O0IAsOF8PcLAsCFjO0JAvGV4pUFAv%2F6yPsJAv76yPsJAvbLmuYBAq7k2jACzqvD4A4CrvycrAcCi%2BuC%2BwwCn%2FnbgQ0C4d349AoC9PbF%2FAwCrZj0xQsCrZiIoQQC0sqYtwoC6MqwtAcC1srwtQoChobTsw4C7NGKtQUC1pTPmwIC7NHufAK7q7GGCALWiurYD5n2NOO8WnWV9AUpd%2FJTqaRG92mqzlfPA%2B6EI5m6%2BqVU&TextBox1=&TextBox2=&drop_xn=&drop_xq=&drop_type=%E5%85%A8%E9%83%A8%E6%88%90%E7%BB%A9&TextBox3=&TextBox4=000000000&Button2=%E6%9F%A5%E8%AF%A2&hid_dqszj=".ToCharArray();
        private static char[] m_requestGPAContent = "__VIEWSTATE=%2FwEPDwUKLTc5MTY3NzY2OA9kFgICAw9kFg4CBQ8QZBAVDw09Peivt%2BmAieaLqT09CTIwMTUtMjAxNgkyMDE0LTIwMTUJMjAxNC0yMDE1CTIwMTMtMjAxNAkyMDEzLTIwMTQJMjAxMi0yMDEzCTIwMTEtMjAxMwkyMDExLTIwMTIJMjAxMC0yMDExCTIwMDktMjAxMAkyMDA4LTIwMDkJMjAwNy0yMDA4CTIwMDYtMjAwNwkyMDA1LTIwMDYVDwAJMjAxNS0yMDE2CTIwMTQtMjAxNQkyMDE0LTIwMTUJMjAxMy0yMDE0CTIwMTMtMjAxNAkyMDEyLTIwMTMJMjAxMS0yMDEzCTIwMTEtMjAxMgkyMDEwLTIwMTEJMjAwOS0yMDEwCTIwMDgtMjAwOQkyMDA3LTIwMDgJMjAwNi0yMDA3CTIwMDUtMjAwNhQrAw9nZ2dnZ2dnZ2dnZ2dnZ2dkZAIHDxBkEBUDDT096K%2B36YCJ5oupPT0BMgExFQMAATIBMRQrAwNnZ2dkZAIdD2QWAgIFDzwrABEAZAIfD2QWAgIBDzwrABEAZAIjD2QWAgIJDzwrABEAZAIlD2QWAgIDDxBkZBYBZmQCJw9kFgICAQ88KwARAQEQFgAWABYAZBgEBQlHcmlkVmlldzMPZ2QFCUdyaWRWaWV3MQ9nZAUMR3JpZFZpZXdfY2owD2dkBQtHcmlkVmlld19jag9nZAo2KkwtUfe00MOJM33Y1lvTHDhO8kBBBYikofXDt%2B0d&__VIEWSTATEGENERATOR=DCA2160B&__EVENTVALIDATION=%2FwEWJAKngcNYAuzRsusGAuzR9tkMAtasxIALAofH04AEAoTHl8AGAoTHl8AGAoXH%2B4AFAoXH%2B4AFAprHv8AHAprHo4AGApvHo4AGApjH50ECwoXgrwYCzYWIlAgCyoXk7QgCw4Xw9wsCwIWM7QkC8ZXilQUC%2F%2FrI%2BwkC%2FvrI%2BwkC9sua5gECruTaMALOq8PgDgKu%2FJysBwKL64L7DAKf%2BduBDQLh3fj0CgL09sX8DAKtmPTFCwKtmIihBALSypi3CgLoyrC0BwLWyvC1CgKGhtOzDgLWiurYDwL11%2BuLAhnj71d3eE5lXvwxSDeC564xYM7GDt5mKDyk&TextBox1=000000000&TextBox2=&drop_xn=&drop_xq=&drop_type=%E5%85%A8%E9%83%A8%E6%88%90%E7%BB%A9&Button_xfj=%E7%AC%AC%E4%B8%80%E4%B8%93%E4%B8%9A%E5%B9%B3%E5%9D%87%E5%AD%A6%E5%88%86%E7%BB%A9&hid_dqszj=".ToCharArray();

        static ScoreQuerier()
        {
            m_schoolTerm = SchoolTermOptions.First;
            m_schoolYear = null;
            m_url = "http://211.70.149.134:8080/stud_score/brow_stud_score.aspx";
            m_viewState = null;
            m_viewStateGenerator = null;
            m_eventValidation = null;
            m_student = null;
        }

        /// <summary>
        /// 查询学生成绩
        /// </summary>
        /// <param name="student">需要查询成绩的学生</param>
        /// <param name="schoolYear">指定查询的学年</param>
        /// <param name="schoolTerm">指定查询的学期</param>
        /// <returns></returns>
        public static bool QueryStudentScore(Student student, string schoolYear, SchoolTermOptions schoolTerm, string queryPurpose, string queryType)
        {
            m_student = student;
            m_schoolTerm = schoolTerm;
            m_schoolYear = schoolYear;

            try
            {
                GetThreeParam();
                HttpWebRequest requestGPA = GeneratePostData("第一专业平均学分绩", queryType);
                GetFinalInfo(requestGPA, QueryMode.GPA);
                if (queryPurpose == "查询")
                {
                    GetThreeParam();
                    HttpWebRequest requestScore = GeneratePostData(queryPurpose, queryType);
                    GetFinalInfo(requestScore, QueryMode.Score);
                }
            }
            catch (ScoreQuerierException querierexception)
            {
                throw querierexception;
            }
            catch
            {
                throw (new ScoreQuerierException("您的网络连接错误或者成绩查询网站已更改"));
            }
            return true;
        }

        

        /// <summary>
        /// 获取POST提交表单信息时的三个参数
        /// </summary>
        /// <returns></returns>
        private static void GetThreeParam()
        {
            //如果第二次查询，三个参数就已知了
            if (m_eventValidation != null && m_viewState != null && m_viewStateGenerator != null)
                return;

            //打开成绩查询网页，获取__VIEWSTATE、__VIEWSTATEGENERATOR、__EVENTVALIDATION
            HttpWebRequest requestThreeParam = WebRequest.CreateHttp(m_url);
            requestThreeParam.Method = "GET";

            //发送请求，获取响应
            HttpWebResponse responseThreeParam = (HttpWebResponse)requestThreeParam.GetResponse();
            if (responseThreeParam.StatusCode != HttpStatusCode.OK)
                throw (new ScoreQuerierException("获取参数回应时发生错误!::responseThreeParam.StatusCode != HttpStatusCode.OK"));

            //读取响应内容
            StreamReader readerThreeParam = new StreamReader(responseThreeParam.GetResponseStream(), Encoding.GetEncoding(responseThreeParam.CharacterSet));
            string content = readerThreeParam.ReadToEnd();

            //使用正则表达式获取3个值
            Regex regexParam = new Regex(@"id=""__VIEWSTATE"" value=""(?<VIEWSTATE>.+?)"" />[\s\S]+?id=""__VIEWSTATEGENERATOR"" value=""(?<VIEWSTATEGENERATOR>.+?)"" />[\s\S]+?id=""__EVENTVALIDATION"" value=""(?<EVENTVALIDATION>.+?)"" />");
            Match matchThreeParam = regexParam.Match(content);

            m_viewState = matchThreeParam.Groups["VIEWSTATE"].ToString();
            m_viewStateGenerator = matchThreeParam.Groups["VIEWSTATEGENERATOR"].ToString();
            m_eventValidation = matchThreeParam.Groups["EVENTVALIDATION"].ToString();

            //清理
            responseThreeParam.Close();
            readerThreeParam.Close();
        }

        /// <summary>
        /// 生成请求信息
        /// </summary>
        /// <returns>返回请求信息的对象</returns>
        private static HttpWebRequest GeneratePostData(string queryPurpose, string queryType)
        {
            //生成post数据
            string strpostdata = "__VIEWSTATE=" + HttpUtility.UrlEncode(m_viewState)
                + "&__VIEWSTATEGENERATOR=" + HttpUtility.UrlEncode(m_viewStateGenerator)
                + "&__EVENTVALIDATION=" + HttpUtility.UrlEncode(m_eventValidation)
                + "&TextBox1=" + m_student.SchoolNumber
                + "&TextBox2=" + m_student.IDCard
                + "&drop_xn=" + m_schoolYear
                + "&drop_xq=" + (m_schoolTerm == SchoolTermOptions.ALL ? string.Empty : ((int)m_schoolTerm).ToString())
                + "&drop_type=" + HttpUtility.UrlEncode(queryType).ToUpper()
                + (queryPurpose == "查询" ? "&Button_cjcx=" : "&Button_xfj=") + HttpUtility.UrlEncode(queryPurpose).ToUpper()
                + "&hid_dqszj=";

            byte[] postdata = Encoding.UTF8.GetBytes(strpostdata);

            //模拟提交表单，获取所有成绩
            HttpWebRequest requestScore = WebRequest.CreateHttp(m_url);
            requestScore.Method = "POST";
            requestScore.ContentType = "application/x-www-form-urlencoded";
            requestScore.ContentLength = postdata.Length;
            requestScore.GetRequestStream().Write(postdata, 0, postdata.Length);

            return requestScore;
        }

        private static HttpWebRequest GeneratePostData(char[] studentNumber, QueryMode mode)
        {
            int position ;
            char[] requestContent;
            if (mode == QueryMode.GPA)
            {
                position = 1197;
                requestContent = m_requestGPAContent;
            }
            else
            {
                position = 1352;
                requestContent = m_requestTransformContent;
            }
            for (int i = 0; i < studentNumber.Length; i++)
                requestContent[position + i] = studentNumber[i];
            byte[] stream = Encoding.UTF8.GetBytes(requestContent);

            HttpWebRequest request = WebRequest.CreateHttp(m_url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = stream.Length;
            request.GetRequestStream().Write(stream, 0, stream.Length);

            return request;
        }


        /// <summary>
        /// 提交请求信息获取成绩
        /// </summary>
        /// <param name="requestScore">网站请求</param>
        /// <returns>返回获得的请求的网页内容</returns>
        private static void GetFinalInfo(HttpWebRequest request, QueryMode mode)
        {
            //获取响应
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode != HttpStatusCode.OK)
                throw (new ScoreQuerierException("获取FinalInfo回应时发生错误!::response.StatusCode != HttpStatusCode.OK"));
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(response.CharacterSet));
            string content = reader.ReadToEnd();

            //清理
            request.GetRequestStream().Close();
            response.Close();
            reader.Close();

            switch (mode)
            {
                case QueryMode.GPA:
                    MatchGPA(content);
                    break;
                case QueryMode.Score:
                    MatchScore(content);
                    break;
                case QueryMode.NumbertoName:
                    MatchTransform(content, true);
                    break;
            }
        }

        /// <summary>
        /// 从网页返回的信息中匹配学生成绩信息
        /// </summary>
        /// <param name="score">网页返回的信息</param>
        private static void MatchScore(string scoreContent)
        {
            //正则表达式匹配成绩
            Regex regexScore = new Regex(@"<td>.+?\d{4}-\d{4}.+?>[12].+?>(?<numberOfSubject>\d{8}).+?>(?<nameOfSubject>[\w\[\]]+).+?>(?<credit>[\d\.]+).+?>(?<Attribute>[\u4e00-\u9fa5]+).+?>(?<numberOfTeacher>\d{4}).+?>(?<nameOfTeacher>[\u4e00-\u9fa5]+)[\s\S]+?>(?<finalScore>\d{2,3})[\s\S]+?>([\d{2,3}A-D][\s\S]+?>){2}(?<usualScore>(&nbsp)|(\d{2,3}))");
            MatchCollection matches = regexScore.Matches(scoreContent);

            foreach (Match tmp in matches)
                m_student.Subjects.Add(new Subject(m_schoolYear, m_schoolTerm, tmp.Groups["numberOfSubject"].Value, tmp.Groups["nameOfSubject"].Value,
                    Convert.ToSingle(tmp.Groups["credit"].Value), tmp.Groups["Attribute"].Value, tmp.Groups["numberOfTeacher"].Value,
                    tmp.Groups["nameOfTeacher"].Value, Convert.ToByte(tmp.Groups["finalScore"].Value),
                    Convert.ToByte(tmp.Groups["usualScore"].Value == "&nbsp" ? "0" : tmp.Groups["usualScore"].Value)));
        }
        private static void MatchGPA(string GPAContent)
        {
            //匹配GPA
            Regex regex = new Regex(@"Label2[01].+?>(\d{2,5})");
            
            MatchCollection matches = regex.Matches(GPAContent);
            if (matches.Count != 0)
                m_student.GPA = Convert.ToSingle(matches[0].Groups[1].Value) / Convert.ToSingle(matches[1].Groups[1].Value);
            else
            {
                throw (new ScoreQuerierException("GPA is 0"));
            }
        }
        private static void MatchTransform(string transformContent, bool isNumbertoName)
        {
            //暂时只处理NumberToName情况
            Regex regex = new Regex(">" + m_student.SchoolNumber + @"[\s\S]+?>(?<StudentName>\w{2,5})<");
            //Console.WriteLine(regex.IsMatch(transformContent));
            Match match = regex.Match(transformContent);
            m_student.Name = match.Groups["StudentName"].Value;
        }

        public static Student[] GetClassmatesGPA(string startNumber, uint sumOfClassmates)
        {
            Student[] classmates = new Student[sumOfClassmates];
            for (int i = 0; i < classmates.Length; i++)
                classmates[i] = new Student();
            GetThreeParam();
            char[] studentNumber = startNumber.ToCharArray();
            for (int i = 0; i < sumOfClassmates; i++)
            {
                //查询GPA
                classmates[i].SchoolNumber = new string(studentNumber);
                m_student = classmates[i];
                HttpWebRequest request = GeneratePostData(studentNumber, QueryMode.GPA);
                try
                {
                    GetFinalInfo(request, QueryMode.GPA);
                }
                catch (ScoreQuerierException e)
                {
                    if (e.Message == "GPA is 0")
                    {
                        m_student.GPA = 0;
                        m_student.Name = "[已退学]";
                        m_student.IDCard = string.Empty;
                        StudentNumberIncrement(studentNumber);
                        continue;
                    }
                }
                
                //学号-姓名转换
                request = GeneratePostData(studentNumber, QueryMode.NumbertoName);
                GetFinalInfo(request, QueryMode.NumbertoName);
                StudentNumberIncrement(studentNumber);
            }
            return classmates;
        }

        private static void StudentNumberIncrement(char[] studentnumber)
        {
            int i = studentnumber.Length - 1;
            do
            {
                if (++studentnumber[i] == '9' + 1)
                    studentnumber[i] = '0';
            } while (studentnumber[i--] == '0');
        }
    }

    public class ScoreQuerierException : Exception
    {
        public ScoreQuerierException(string message) : base(message) { }
    }
}
