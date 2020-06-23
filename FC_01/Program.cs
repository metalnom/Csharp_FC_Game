using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography;

namespace FC_01
{
    class Program
    {
        static void Main(string[] args)
        {
            const string LINE = "--------------------------------------------------";
            const int END_LINE = 50;

            int runA = 0;
            int runB = 0;
            int runC = 0;
            int runD = 0;
            int rndNum;

            Random rnd = new Random();

            while (true)
            {
                Thread.Sleep(300);
                Console.Clear();

                ++runA;
                ++runB;
                ++runC;
                ++runD;

                rndNum = rnd.Next(1, 4);

                switch (rndNum)
                {
                    case 0:
                        ++runA;
                        break;
                    case 1:
                        ++runB;
                        break;
                    case 2:
                        ++runC;
                        break;
                    case 3:
                        ++runD;
                        break;
                }

                Console.WriteLine(LINE);

                for (int i = 0; i < runA; i++)
                    Console.Write(" ");
                Console.WriteLine("1");

                for (int i = 0; i < runB; i++)
                    Console.Write(" ");
                Console.WriteLine("2");

                for (int i = 0; i < runC; i++)
                    Console.Write(" ");
                Console.WriteLine("3");

                for (int i = 0; i < runD; i++)
                    Console.Write(" ");
                Console.WriteLine("4");

                Console.WriteLine(LINE);

                if (runA >= END_LINE || runB >= END_LINE || runC >= END_LINE || runD >= END_LINE)
                {
                    string strResult = "결과 : ";
                    string strNum = "";

                    if (runA >= END_LINE)
                        strNum = "1번 우승!";
                    else if (runB >= END_LINE)
                        strNum = "2번 우승!";
                    else if (runC >= END_LINE)
                        strNum = "3번 우승!";
                    else if (runD >= END_LINE)
                        strNum = "4번 우승!";

                    Console.Write(strResult);
                    Console.WriteLine(strNum);
                    break;
                }
            }
        }
    }
}
