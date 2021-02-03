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

        public void AddPer(string str)
        {
            if (!newEnqueue.ContainsKey(str))
            {
                newEnqueue.Add(str, 1);
                enqueue.Add(str);
            }else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                ("This name is alrady added!").PrintLine();
                Console.ResetColor();
            }
        }

        public void TestQueue()
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
                ("There is no persons in the enqueue!").PrintLine();
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
                        ($"{str.Key} ställer sig i kön").PrintLine();
                        Console.ResetColor();

                    }
                    else if (str.Value == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        ($"{str.Key} blir expedierad och lämnar kön").PrintLine();
                        Console.ResetColor();
                    }
                }
        }


    }
}
