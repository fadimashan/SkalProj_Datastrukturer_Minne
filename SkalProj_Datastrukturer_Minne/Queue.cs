using System;
using System.Collections.Generic;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    class Queue
    {

        public List<string> enqueue = new List<string>();
        public Dictionary<string,int> newEnqueue = new Dictionary<string,int>();
      
        public Queue()
        {
           
        }

        public void AddPerHash(string str)
        {
            if (!newEnqueue.ContainsKey(str))
            {
                newEnqueue.Add(str, 1);
                enqueue.Add(str);
            }else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This name is alrady added!");
                Console.ResetColor();
            }
        }

        public void TestQueueHash()
        {
            if(enqueue.Count != 0) { 
                newEnqueue.Add("-"+ enqueue[0],0);
                enqueue.RemoveAt(0);
                PrintList();
            }
            else
            {
                PrintList();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no persons in the enqueue!");
                Console.ResetColor();
            }


        }


        public void PrintList()
        {
            if (newEnqueue.Count != 0)
                foreach (KeyValuePair<string, int> str in newEnqueue)
                {
                    if (str.Value == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{str.Key} ställer sig i kön");
                        Console.ResetColor();

                    }
                    else if (str.Value == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"{str.Key} blir expedierad och lämnar kön");
                        Console.ResetColor();
                    }
                }
        }


    }
}
