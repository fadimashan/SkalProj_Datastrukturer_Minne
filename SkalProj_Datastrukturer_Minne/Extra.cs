using System;
using System.Collections.Generic;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    class Extra
    {
        bool exit = true;
        string enterNumber = "Please enter a number";

        public void RecursiveEven()
        {
            Console.Clear();
            exit = true;
            do
            {
                Console.WriteLine("\nPlease enter a number to print the even from 0 to the number"
                                 + "\n0. to return to the main menu");

                string inputNumber = Console.ReadLine();
                int num1 = 0;
                num1 = inputNumber.ParesToInt(num1);
                if (num1 != 0 && num1 > 0)
                {
                    for (int i = 1; i <= num1; i++)
                    {
                        if (i % 2 == 0)
                        {
                            ($"{i} ").Print();
                        }
                    }
                }
                else if (num1 < 0)
                {
                    enterNumber.PrintLine();
                }
                else
                {
                    exit = false;
                }
            } while (exit);
        }


        //Check and Print the output 
        public void RecursiveEven2()
        {
            Console.Clear();
            exit = true;
            do
            {
                ("\nPlease enter a number to print the even from 0 to the number"
                + "\n0. to return to the main menu").PrintLine();
                string fInputNumber = Console.ReadLine();
                int num2 = 0;
                num2 = fInputNumber.ParesToInt(num2);
                if (num2 != 0 && num2 > 0)
                {
                    RecursiveEvenImp(num2);
                }
                else if (num2 < 0)
                {
                    enterNumber.PrintLine();
                }
                else
                {
                    exit = false;
                }
            } while (exit);
        }

        //Implement the even numbers
        private int RecursiveEvenImp(int n)
        {
            correct = true;
            while (correct)
            {
                if (n % 2 == 0 && n != 0)
                {
                    ($"{n} ").Print();

                }
                else if (n == 0)
                {
                    correct = false;
                }

                n--;
            }

            return n;
        }


        public void Fibonaccisekvensen()
        {
            Console.Clear();
            exit = true;
            do
            {
                ("\nPlease enter a number to count the result with Fibonacci sequence"
                + "\n0. to return to the main menu").PrintLine();
                string fInputNumber = Console.ReadLine();
                int fnum2 = 0;
                fnum2 = fInputNumber.ParesToInt(fnum2);
                if (fnum2 != 0 && fnum2 > 0)
                {
                    Console.Clear();
                    FibonaccisekvensenImp(fnum2);
                }
                else if (fnum2 < 0)
                {
                    enterNumber.PrintLine();
                }
                else
                {
                    exit = false;
                }
            } while (exit);
        }

        int i = 2;
        bool stillIn = true;
        private int FibonaccisekvensenImp(int n)
        {
            int r = 0;
            ("0 \n1").PrintLine();
            while (stillIn)
            {
                if (i < n)
                {

                    r = ((i - 1) + (i - 2));
                    r.ToString().PrintLine();
                    i++;
                }
                else
                {
                    stillIn = false;
                }
            }
            return i;
        }


        // Second way to Fibonaccisekvensen
        public void Fibonaccisekvensen2()
        {
            Console.Clear();
            exit = true;
            do
            {
                ("\nPlease enter a number to count the result with Fibonacci sequence"
                + "\n0. to return to the main menu").PrintLine();
                string fInputNumber = Console.ReadLine();
                int fnum = 0;
                fnum = fInputNumber.ParesToInt(fnum);
                if (fnum != 0 && fnum > 0)
                {
                    Console.Clear();
                    FibonaccisekvensenImp2(fnum);
                }
                else if (fnum < 0)
                {
                    enterNumber.PrintLine();
                }
                else
                {
                    exit = false;
                }
            } while (exit);
        }


        bool correct = true;
        private void FibonaccisekvensenImp2(int n)
        {
            int i = 2;
            int a = (i - 2);
            int b = (i - 1);
            int c = 0;

            Console.WriteLine("{0} ", a, b);
            for (i = 2; i <= n; i++)
            {
                c = (a + b);
                (c.ToString() + " ").PrintLine();
                a = i - 2;
                b = i - 1;
            }

        }

    }
}
