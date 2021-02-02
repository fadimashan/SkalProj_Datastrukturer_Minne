using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();

                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        bool exit = true;
                        do
                        {

                            Console.WriteLine("Enter text to check or 0 to return the the main menu");
                            var str = Console.ReadLine();
                            if (str != "0")
                            {
                                var correct = CheckParanthesis(str);
                                if (correct)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Parentheses are correct!");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Parentheses are incorrect!");
                                    Console.ResetColor();
                                }
                            }else
                            {
                                exit = false;
                            }
                        } while (exit);
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {

            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();
            string all;
            bool exaineListLoop = true;
            /* The list capacity increasing when the list count (#itmes) is more than the capacity,
             * So, once the list count is full, the capacity will increase
             * 
             * The list capacity increasing in double size
             * 
             * The list capacity increasing in stable amount (double)
             * 
             * Delete/remove items from a list will not decrease the capacity
             * 
             * Using Arraylist is better when you know how specific number of item you want to add to the array
             */
            do
            {
                Console.WriteLine("\n+/- with the word you wanna add to the list. press 0 to close this menu");
                char input = ' ';
                string rest = "";
                string removeWord = "";
                String[] strlist = null;

                try
                {
                    all = Console.ReadLine();
                    input = all[0];
                    rest = all.Substring(1);
                    rest = Regex.Replace(rest, @"\s+", " ");
                    Char[] seperator = { '+', '-', ' ' };
                    strlist = all.Split(seperator, StringSplitOptions.None);

                    removeWord = all.Substring(1);
                    removeWord = Regex.Replace(removeWord, " ", "");

                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }

                switch (input)
                {
                    case '+':

                        for (int i = 1; i < strlist.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(strlist[i]))
                            {
                                theList.Add(strlist[i]);
                            }
                        };

                        foreach (String str in theList)
                        {
                            Console.Write(str + " ");
                        }
                        Console.WriteLine($"\nList Count is: {theList.Count}");
                        Console.WriteLine($"List Capacity is: {theList.Capacity}");

                        break;
                    case '-':

                        if (theList.Count == 0)
                        {
                            Console.WriteLine("This is an empty list!");

                        }
                        else if (theList.Contains(removeWord))
                        {
                            theList.Remove(removeWord);
                            Console.Write("\nThe new list is: ");


                            foreach (String str in theList)
                            {
                                Console.Write(str + " ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nThis word not found in the list"
                                + "\nHere you can find what in this list:");
                            foreach (String str in theList)
                            {
                                Console.Write(str + " ");
                            }
                        }


                        break;
                    case '0':
                        exaineListLoop = false;
                        break;
                    default:
                        Console.WriteLine("\nUse +/- with the word you want to add to the list.\n0. Return to the main menu");
                        break;

                }

            } while (exaineListLoop);
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Stack<string> queueStack = new Stack<string>();
            Queue q = new Queue();
            bool loop = true;
            do
            {
                Console.WriteLine("\n1. Add new person to the queue"
                    + "\n2. Expedited the first person in the waiting list queue"
                    + "\n3. Add person to the Stack queue"
                    + "\n4. Expedited the last person in the wait Stack list queue"
                    + "\n0. Return to the main menu");
                char input = ' ';
                try
                {
                    input = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }

                switch (input)
                {

                    case '1':
                        Console.Clear();
                        Console.WriteLine("Add a new person to the queue");
                        var newPer = Console.ReadLine();
                        q.AddPer(newPer);
                        Console.WriteLine("ICA öppnar och kön till kassan är tom");
                        q.PrintList();
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("Remove The first person from from the queue"
                            + "\n\nICA öppnar och kön till kassan är tom");
                        q.TestQueue();
                        break;

                    case '3':
                        Console.WriteLine("Add a new person to the queue");
                        var newPerToPush = Console.ReadLine();
                        queueStack.Push(newPerToPush);
                        foreach (String str in queueStack)
                        {
                            Console.WriteLine(str);
                        }

                        break;

                    case '4':
                        queueStack.Pop();
                        foreach (String str in queueStack)
                        {
                            Console.WriteLine(str);
                        }

                        break;
                    case '0':
                        loop = false;
                        break;
                    default:

                        break;
                }

            }
            while (loop);
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            Stack<string> queueStack = new Stack<string>();
            bool loop = true;
            do
            {
                Console.WriteLine("\n1. Push person to the Stack queue"
                    + "\n2. Pop person in the wait Stack list queue"
                    + "\n3. Reserve the names in the Stack list"
                    + "\n0. Return to the main menu");
                char input = ' ';
                try
                {
                    input = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }

                switch (input)
                {

                    case '1':
                        Console.Clear();
                        Console.WriteLine("Push a new person to the queue");
                        var newPerToPush = Console.ReadLine();
                        queueStack.Push(newPerToPush);
                        Console.Clear();
                        foreach (String str in queueStack)
                        {
                            Console.WriteLine(str);
                        }

                        break;
                    case '2':
                        Console.Clear();
                        if (queueStack.Count != 0)
                        {
                            queueStack.Pop();
                            foreach (String str in queueStack)
                            {
                                Console.WriteLine(str);
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The queue is empty");
                            Console.ResetColor();
                        }
                        break;

                    case '3':
                        Console.Clear();
                        if (queueStack.Count != 0)
                        {
                            foreach (String str in queueStack)
                            {
                                char[] arr = str.ToCharArray();
                                Array.Reverse(arr);
                                var yourString = new string(arr);
                                Console.WriteLine(yourString);
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The list is empty");
                            Console.ResetColor();
                        }

                        break;
                    case '0':
                        loop = false;
                        break;
                    default:

                        break;
                }

            }
            while (loop);

        }

        static bool CheckParanthesis(string str)
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
                Stack<char> listOfParanthesis = new Stack<char>();
              
                foreach (Char c in str)
                {
                    switch (c)
                    {
                        case ')':
                            if (listOfParanthesis.Count == 0 || listOfParanthesis.Pop() != '(') return false;
                            break;
                        case ']':
                            if (listOfParanthesis.Count == 0 || listOfParanthesis.Pop() != '[') return false;
                        break;
                        case '}':
                            if (listOfParanthesis.Count == 0 || listOfParanthesis.Pop() != '{') return false;
                        break;
                        case '(': listOfParanthesis.Push(c); break;
                        case '[': listOfParanthesis.Push(c); break;
                        case '{': listOfParanthesis.Push(c); break;
                    }
                }
                if (listOfParanthesis.Count == 0) return true; 
                else return false;
        }

    }
}

