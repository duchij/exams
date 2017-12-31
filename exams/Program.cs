using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exams
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciujeme test
            //TODO: je nutne spravit aby sme mohli definovat ktory subor, t.c. ten jeden :)
            Exam ex = new Exam();

            Question[] questions =  ex.fillData();//naplnime data, dal by som to konstruktora, ale aby sme to videli :)

            int qCnt = questions.Length;
            Random rnd = new Random();


            //tu musi byt lepsia iteracia asi nie forom ale do while, kym sa neskoncia otazky 
            //alebo nedobehne cas...
            for (int i=0; i < qCnt; i++)
            {
                int q = rnd.Next(0, qCnt);
                //Vypiseme otazku
                Console.WriteLine(questions[q].question);

                int ans = questions[q].answ.Length;
                //vypiseme mozne odpovede
                for (int j=0; j<ans; j++)
                {
                    Console.WriteLine("{0}. {1}", j, questions[q].answ[j].label);
                }
                //dame 
                Console.WriteLine("Vasa odpoved (moze byt aj viacej spravnych) oddelte ich ciarkami:");
                Console.ReadKey();
            }

           




        }
    }
}
