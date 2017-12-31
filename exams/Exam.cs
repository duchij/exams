using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace exams
{
    class Exam
    {

        private XmlDocument testXml;

        private XPathDocument xPath;

        public Exam()
        {
            this.loadExam(@"data/test.xml");
        }

        public void loadExam(string fileName)
        {

            try
            {
                string data = File.ReadAllText(fileName);

                this.testXml = new XmlDocument();
                this.testXml.LoadXml(data.ToString());
               // this.xPath = new XPathDocument(fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }


        public Question[] fillData()
        {

            XmlNodeList test = this.testXml.SelectNodes("//exam/test");
            int questLn = test.Count;

            Question[] quest = new Question[questLn];

            int i = 0;

            foreach (XmlNode t  in test)
            {

                XmlNode qNode = t.SelectSingleNode("question");
                XmlNodeList answ = t.SelectNodes("answer");
                quest[i] = new Question(qNode.InnerText, answ);
                i++;
            }


            return quest;

            //Question[] q2 = quest;

            
        }
    }
}
