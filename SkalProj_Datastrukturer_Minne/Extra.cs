using System;
using System.Collections.Generic;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    class Extra
    {
        Util util = new Util();
        bool exit = true;

        public void RecursiveEven()
        {
            Console.Clear();

            exit = true;
            do
            {
                Console.WriteLine("\nPlease enter some input to calculate"
                                 + "\n0. to return to the main menu");

                string inputNumber = util.read();
                int num1 = 0;
                num1 = util.paresToInt(inputNumber, num1);
                if (num1 != 0)
                {
                    for (int i = 1; i <= num1; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write($"{i} ");

                        }
                    }
                }
                else
                {
                    exit = false;
                }
            } while (exit);



        }
        public void RecursiveEven2()
        {
            Console.Clear();
            exit = true;
            do
            {
                Console.WriteLine("\nPlease enter some input to calculate"
                    + "\n0. to return to the main menu");
                string fInputNumber = util.read();
                int fnum2 = 0;
                fnum2 = util.paresToInt(fInputNumber, fnum2);
                if (fnum2 != 0)
                {
                    RecursiveEvenImplementation(fnum2);
                }
                else
                {
                    exit = false;
                }
            } while (exit);
        }


     

        public void Fibonaccisekvensen()
        {
            Console.Clear();
            exit = true;
            do
            {
                Console.WriteLine("\nPlease enter some input to calculate"
                    + "\n0. to return to the main menu");
                string fInputNumber = util.read();
                int fnum2 = 0;
                fnum2 = util.paresToInt(fInputNumber, fnum2);
                if (fnum2 != 0)
                {
                    Fibonaccisekvensen2(fnum2);
                }
                else
                {
                    exit = false;
                }
            } while (exit);
        }

        public void Fibonaccisekvensen1()
        {
            Console.Clear();
            exit = true;
            do
            {
                Console.WriteLine("\nPlease enter some input to calculate"
                    + "\n0. to return to the main menu");
                string fInputNumber = util.read();
                int fnum = 0;
                fnum = util.paresToInt(fInputNumber, fnum);
                if (fnum != 0)
                {
                    FibonaccisekvensenImplemntaion(fnum);
                }
                else
                {
                    exit = false;
                }
            } while (exit);
        }


        bool correct = true;
        private int RecursiveEvenImplementation(int n)
        {
            correct = true;
            while (correct)
            {
                if (n % 2 == 0 && n != 0)
                {
                    Console.Write($"{n} ");

                }
                else if (n == 0)
                {
                    correct = false;
                }
                n--;
            }

            return n;
        }


        private void FibonaccisekvensenImplemntaion(int n)
        {
            int i = 2;
            int a = (i - 2);
            int b = (i - 1);
            int c = 0;

            Console.Write("{0} {1} ", a, b);
            for (i = 2; i <= n; i++)
            {
                c = (a + b);
                Console.Write(c.ToString() + " ");
                a = i - 2;
                b = i - 1;
            }

        }

        int i = 2;
        bool stillIn = true;
        private int Fibonaccisekvensen2(int n)
        {
            int r = 0;
            while (stillIn)
            {
                if (i <= n)
                {
                    Console.WriteLine(r);
                    r = ((i - 1) + (i - 2));
                    i++;

                }
                else
                {
                    stillIn = false;
                }
            }
            return i;
        }
    }
}
