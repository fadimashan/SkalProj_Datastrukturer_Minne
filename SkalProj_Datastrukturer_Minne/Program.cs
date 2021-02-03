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
            Extra extra = new Extra();
            while (true)
            {
                Console.Clear();
                ("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                 + "\n1. Examine a List"
                 + "\n2. Examine a Queue"
                 + "\n3. Examine a Stack"
                 + "\n4. CheckParanthesis"
                 + "\n5. Fibonacci sequence (Övning 5: Rekursion)"
                 + "\n6. To print even numbers"
                 + "\n7. Fibonacci sequence (Övning 6: Iteration)"
                 + "\n8. To print even numbers (Övning 6: Iteration)"
                 + "\n0. Exit the application").PrintLine();
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    ("Please enter some input!").PrintLine();
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
                        CheckParanthesisResult();
                        break;
                    case '5':
                        extra.Fibonaccisekvensen();                  
                        break;
                    case '6':
                        extra.RecursiveEven();
                        break;
                    case '7':
                        extra.Fibonaccisekvensen2();
                        break;
                    case '8':
                        extra.RecursiveEven2();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        ("Please enter some valid input (0, 1, 2, 3, 4)").PrintLine();
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
            Console.Clear();
            List<string> theList = new List<string>();
            string inputName;
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
                ("\n+/- with the word you wanna add to the list. press 0 to close this menu").PrintLine();
                char fiestChar = ' ';
                string rest = "";
                string removeWord = "";
                String[] strlist = null;

                try
                {
                    inputName = Console.ReadLine();
                    fiestChar = inputName[0];
                    rest = inputName.Substring(1);
                    var trimmed = Regex.Replace(inputName, @"\s+", " ");
                    Char[] seperator = { '+', '-', ' ' };
                    strlist = trimmed.Split(seperator,StringSplitOptions.None);

                    removeWord = inputName.Substring(1);
                    removeWord = Regex.Replace(removeWord, " ", "");

                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    ("Please enter some input!").PrintLine();
                }

                switch (fiestChar)
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
                            (str + " ").PrintLine();
                        }
                        ($"\nList Count is: {theList.Count}").PrintLine();
                        ($"List Capacity is: {theList.Capacity}").PrintLine();

                        break;
                    case '-':

                        if (theList.Count == 0)
                        {
                            "This is an empty list!".PrintLine();

                        }
                        else if (theList.Contains(removeWord))
                        {
                            theList.Remove(removeWord);
                            $"\nThere is {theList.Count} persones still in the queue, names: ".PrintLine();


                            foreach (String str in theList)
                            {
                                (str + " ").PrintLine();
                            }
                        }
                        else
                        {
                            ("\nThis word not found in the list"
                            +"\nHere you can find what in this list:").PrintLine();
                            foreach (String str in theList)
                            {
                                (str + " ").PrintLine();
                            }
                        }
                        break;
                    case '0':
                        exaineListLoop = false;
                        break;
                    default:
                        ("\nUse +/- with the word you want to add to the list.\n0. Return to the main menu").PrintLine();
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
                ("\n1. Add new person to the queue"
                + "\n2. Expedited the first person in the waiting list queue"
                + "\n3. Add person to the Stack queue"
                + "\n4. Expedited the last person in the wait Stack list queue"
                + "\n0. Return to the main menu").PrintLine();
                char input = ' ';
                try
                {
                    input = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    ("Please enter some input!").PrintLine();
                }

                switch (input)
                {

                    case '1':
                        Console.Clear();
                        ("Add a new person to the queue").PrintLine();
                        var newPer = Console.ReadLine();
                        q.AddPer(newPer);
                        ("ICA öppnar och kön till kassan är tom").PrintLine();
                        q.PrintList();
                        break;
                    case '2':
                        Console.Clear();
                        ("Remove The first person from from the queue"
                        + "\n\nICA öppnar och kön till kassan är tom").PrintLine();
                        q.TestQueue();
                        break;

                    case '3':
                        ("Add a new person to the queue").PrintLine();
                        var newPerToPush = Console.ReadLine();
                        queueStack.Push(newPerToPush);
                        foreach (String str in queueStack)
                        {
                            str.PrintLine();
                        }
                        break;

                    case '4':
                        queueStack.Pop();
                        foreach (String str in queueStack)
                        {
                            str.PrintLine();
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
                ("\n1. Push person to the Stack queue"
                + "\n2. Pop person in the wait Stack list queue"
                + "\n3. Reserve the names in the Stack list"
                + "\n0. Return to the main menu").PrintLine();
                char input = ' ';
                try
                {
                    input = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    ("Please enter some input!").PrintLine();
                }

                switch (input)
                {

                    case '1':
                        Console.Clear();
                        ("Push a new person to the queue").PrintLine();
                        var newPerToPush = Console.ReadLine();
                        queueStack.Push(newPerToPush);
                        Console.Clear();
                        foreach (String str in queueStack)
                        {
                            str.PrintLine();
                        }

                        break;
                    case '2':
                        Console.Clear();
                        if (queueStack.Count != 0)
                        {
                            queueStack.Pop();
                            foreach (String str in queueStack)
                            {
                                str.PrintLine();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                           "The queue is empty".PrintLine();
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
                                yourString.PrintLine();
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            ("The list is empty").PrintLine();
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

        

        static void CheckParanthesisResult()
        {
           Console.Clear();
           bool exit = true;
            do
            {
                ("Enter text to check or 0 to return the the main menu").PrintLine();
                var str2 = Console.ReadLine();
                if (str2 != "0")
                {
                    var correct = CheckParanthesisImp(str2);
                    if (correct)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        ("Parentheses are correct!").PrintLine();
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        ("Parentheses are incorrect!").PrintLine();
                        Console.ResetColor();
                    }
                }
                else
                {
                    exit = false;
                }
            } while (exit);
        }
        static bool CheckParanthesisImp(string str)
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            str.Print();

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

