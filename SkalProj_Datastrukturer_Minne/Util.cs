using System;
using System.Collections.Generic;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    class Util
    {
        int result = 0;

        public bool checkIfInt(string str, int number)
        {
            
            if (int.TryParse(str, out number))
            {
                result = number;
            }

            return int.TryParse(str, out number);
        } 
        
        public int paresToInt(string str, int number)
        {
            if (checkIfInt(str, number))
            {
                number = result;
                return number;
            }
            else
            {
                return 999999999;
            }
        }

        public void write(string str)
        {
            Console.Write(str);
        }
        public void writeLine(string str)
        {
            Console.WriteLine(str);
        }

        public string read()
        {
            return Console.ReadLine();
        }




    }
}
