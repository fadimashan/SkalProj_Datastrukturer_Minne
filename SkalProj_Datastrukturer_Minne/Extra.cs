using System;
using System.Collections.Generic;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    class Extra
    {


        public Extra()
        {
          

        }

        public int R1(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");

                }
            }
            return 0;
        }

        public void Fibonaccisekvensen(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            Console.Write("{0} {1} ", a, b);
            for (int i = 2; i < n; i++)
            {
                c = (a + b);
                Console.Write(c.ToString() + " ");
                a = b;
                b = c;


            }

        }

    }
}
