using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace exams
{

    public struct Answer
    {
       public string label;
       public bool correct;
    }

    class Question
    {

        public string question
        {
            get; set;
        }

        public Answer[] answ;

        


        public Question(string question, XmlNodeList answers)
        {
           

            this.question = question;

            int aLn = answers.Count;

            

            this.answ = new Answer[aLn];

           // int i = 0;

            foreach (XmlNode node in answers)
            {

                int id = int.Parse(node.Attributes["id"].Value.ToString());

                answ[id].label = node.InnerText;

                string b = node.Attributes["correct"].Value.ToString();

                answ[id].correct = bool.Parse(b);
            }

        }

    }
}
