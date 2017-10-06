using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresHomework
{
    class Program
    
{
        //WHAT'S UP HOMIES.

            //trial #2
        public static string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + input.Substring(1);
        }

        static void Main(string[] args)
        {
            string sMenuInput;
            string sEntry;

            int iMenuInput;

            Dictionary<string, int> diDictionary = new Dictionary<string, int>();

            Stack<String> sStack1 = new Stack<String>();
            
            Queue<string> sQueue = new Queue<string>();

            bool bGo = true;
            bool bOne = true;
            bool bTwo = true;
            bool bThree = true;
            bool bFound = false;

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            do
            {
                Console.WriteLine("Select a menu item (Enter 1, 2, 3, or 4)\n" +
                                "1.Stack\n" +
                                "2.Queue\n" +
                                "3.Dictionary\n" +
                                "4.Exit\n\n");
                sMenuInput = Console.ReadLine();

                iMenuInput = Convert.ToInt32(sMenuInput);

                switch (iMenuInput)
                {
                    case 1:

                        do
                        {
                            //Julian
                            Console.WriteLine("Select a menu item (Enter 1, 2, 3, 4, etc)\n" +
                                                "1.Add one time to Stack\n" +
                                                "2.Add Huge List of Items to Stack\n" +
                                                "3.Display Stack\n" +
                                                "4.Delete from Stack\n" +
                                                "5.Clear Stack\n" +
                                                "6.Search Stack\n" +
                                                "7.Return to Main Menu\n\n");

                            sMenuInput = Console.ReadLine();

                            iMenuInput = Convert.ToInt32(sMenuInput);
                            Console.WriteLine();

                            switch (iMenuInput)
                            {
                                case 1:
                                    Console.WriteLine("Insert a new string: ");
                                    sEntry = Console.ReadLine();

                                    //Add String to Stack
                                    sStack1.Push(sEntry);

                                    Console.WriteLine(sEntry + " was added to the Stack.");

                                    Console.WriteLine();
                                    break;

                                case 2:
                                    //Clear Stack of Current Contents
                                    sStack1.Clear();

                                    //Add 2000 Entries
                                    for (int i = 1; i < 2001; i++)
                                    {
                                        sEntry = "New Entry " + i;

                                        sStack1.Push(sEntry);
                                    }

                                    Console.WriteLine("A Huge List has been added to the Stack");
                                    Console.WriteLine();
                                    break;

                                case 3:

                                    //Display Stack
                                    Console.WriteLine("Current stack: ");
                                    foreach (String value in sStack1)
                                    {
                                        Console.Write(value + " ");
                                    }

                                    Console.WriteLine("\n");

                                    break;

                                case 4:

                                    //HOW SHOULD DELETING A STACK WORK? :S


                                    Console.WriteLine("Stacks can only delete the top item, are you sure " +
                                        "you are to delete? (Y/N)");
 
                                    sEntry = Console.ReadLine();

                                    sEntry = FirstCharToUpper(sEntry);

                                    if(sEntry.Substring(0) == "Y")
                                    {
                                        sStack1.Pop();
                                        Console.WriteLine("Top item was removed");
                                    }

                                    else if (sEntry.Substring(0) == "N")
                                    {
                                        Console.WriteLine("Top item was not removed");
                                    }

                                    else
                                    {
                                        Console.WriteLine("Response was invalid. Top item was not removed");
                                    }

                                    Console.WriteLine();
                                    
                                    break;

                                case 5:

                                    sStack1.Clear();
                                    Console.WriteLine("The Stack has been cleared\n");

                                    break;

                                case 6:

                                    Console.WriteLine("Which entry do you want to find?");
                                    sEntry = Console.ReadLine();

                                    //Reset the Stopwatch just incase it was previously used
                                    sw.Reset();

                                    //Start stopwatch
                                    sw.Start();

                                    bFound = sStack1.Contains(sEntry);

                                    if (bFound == true)
                                    {
                                        sw.Stop();
                                        Console.WriteLine(sEntry + " was found after " + sw.ElapsedMilliseconds * 1000 + " seconds.");
                                    }
                                    else
                                    {
                                        sw.Stop();
                                        Console.WriteLine("It took " + sw.ElapsedMilliseconds * 1000 + " seconds to search the Stack.\n"
                                            + sEntry + " was not found.");
                                    }

                                    Console.WriteLine();
                                    break;

                                case 7:

                                    bOne = false;
                                    
                                    //It takes too long to break to the main menu, is that okay?

                                    break;
                            }
                        } while (bOne == true);

                        break;

                    case 2:

                        do
                        {
                            //Karli
                            Console.WriteLine("\n\nSelect a menu item (1, 2, 3, 4, etc)\n" +
                                                "1. Add One Item to Queue\n" +
                                                "2.Add Huge List of Items to Queue\n" +
                                                "3.Display Queue\n" +
                                                "4.Delete from Queue\n" +
                                                "5.Clear Queue\n" +
                                                "6.Search Queue\n" +
                                                "7.Return to Main Menu\n\n");

                            sMenuInput = Console.ReadLine();

                            iMenuInput = Convert.ToInt32(sMenuInput);

                            switch (iMenuInput)
                            {
                                case 1:
                                    Console.WriteLine("\nInsert a new string: ");
                                    sEntry = Console.ReadLine();

                                    //Add String to Queue
                                    sQueue.Enqueue(sEntry);

                                    Console.WriteLine("\n" + sEntry + " was added to the Queue.");

                                    Console.WriteLine();
                                    break;

                                case 2:
                                    //Clear Queue
                                    sQueue.Clear();

                                    //Add 2000 Entries
                                    for (int i = 1; i < 2001; i++)
                                    {
                                        sEntry = "New Entry " + i;

                                        sQueue.Enqueue(sEntry);
                                    }

                                    Console.WriteLine("A Huge List has been added to the Queue");
                                    Console.WriteLine();
                                    break;

                                case 3:

                                    //Display Queue
                                    Console.WriteLine("Current queue: ");
                                    foreach (String value in sQueue)
                                    {
                                        Console.Write(value + " ");
                                    }

                                    Console.WriteLine("\n");

                                    break;

                                case 4:

                                    //Delete from queue

                                    Console.WriteLine("Which item would you like to delete? ");

                                    sEntry = Console.ReadLine();
                                    bFound = sQueue.Contains(sEntry);


                                    if (bFound == true)
                                    {
                                        string sQueueHold;

                                        for (int iCount = 0; iCount < sQueue.Count; iCount++)
                                        {
                                            if(sEntry == sQueue.Peek())
                                            {
                                                //remove item in queue
                                                sQueue.Dequeue();
                                                Console.WriteLine("\n\n" + sEntry + " was removed");
                                            }
                                            else
                                            {
                                                //pass first item in list to back of queue so can check the next item in the list
                                                sQueueHold = sQueue.Dequeue();
                                                sQueue.Enqueue(sQueueHold);
                                            }
                                        }                                
                                    }

                                    else
                                    {
                                        //exception handling - need to include menu again
                                        Console.WriteLine("\n\nThat is not an item in the queue. Please enter an item in the queue: ");
                                    }

                                    Console.WriteLine();

                                    break;

                                case 5:

                                    //clear queue
                                    sQueue.Clear();
                                    Console.WriteLine("\n\nThe Queue has been cleared\n");

                                    break;

                                case 6:

                                    Console.WriteLine("Which entry do you want to find?");
                                    sEntry = Console.ReadLine();

                                    //Reset the Stopwatch just incase it was previously used
                                    sw.Reset();

                                    //Start stopwatch
                                    sw.Start();

                                    bFound = sQueue.Contains(sEntry);

                                    if (bFound == true)
                                    {
                                        sw.Stop();
                                        Console.WriteLine(sEntry + " was found after " + sw.ElapsedMilliseconds * 1000 + " seconds.");
                                    }
                                    else
                                    {
                                        sw.Stop();
                                        Console.WriteLine("It took " + sw.ElapsedMilliseconds * 1000 + " seconds to search the Queue.\n"
                                            + sEntry + " was not found.");
                                    }

                                    Console.WriteLine();
                                    break;

                                case 7:

                                    bOne = false;

                                    //It takes too long to break to the main menu, is that okay?

                                    break;
                            }
                        } while (bOne == true);

                        break;

                    case 3:

                        do
                        {
                            //Brittany
                            Console.WriteLine("Select a menu item (1, 2, 3, 4, etc)\n" +
                                                "1.Add one item to Dictionary\n" +
                                                "2.Add Huge List of Items to Dictionary\n" +
                                                "3.Display Dictionary\n" +
                                                "4.Delete from Dictionary\n" +
                                                "5.Clear Dictionary\n" +
                                                "6.Search Dictionary\n" +
                                                "7.Return to Main Menu\n\n");

                            sMenuInput = Console.ReadLine();

                            iMenuInput = Convert.ToInt32(sMenuInput);

                            switch (iMenuInput)
                            {
                                case 1:

                                    Console.WriteLine("Insert a new name: ");
                                    sEntry = Console.ReadLine();

                                    diDictionary.Add(sEntry, 0);

                                    Console.WriteLine(sEntry + " was added to the dictionary.");

                                    break;

                                case 2:

                                    //Clear Dictionary
                                    diDictionary.Clear();

                                    for (int i = 1; i < 2001; i++)
                                    {
                                        sEntry = "New Entry " + i;

                                        diDictionary.Add(sEntry, 0);
                                    }

                                    Console.WriteLine("A Huge List has been added to the dictionary");

                                    break;

                                case 3:

                                    foreach (KeyValuePair<string, int> pair in diDictionary)
                                    {
                                        Console.WriteLine(pair.Key.ToString() + "\t\t" + pair.Value.ToString());
                                    }

                                    break;

                                case 4:

                                    Console.WriteLine("Which entry would you like to delete?");

                                    sEntry = Console.ReadLine();

                                    diDictionary.Remove(sEntry);

                                    Console.WriteLine(sEntry + " has been removed");

                                    break;

                                case 5:

                                    diDictionary.Clear();

                                    Console.WriteLine("The dictionary has been cleared");

                                    break;

                                case 6:

                                    Console.WriteLine("Which entry do you want to find?");
                                    sEntry = Console.ReadLine();

                                    sw.Start();

                                    if (diDictionary.ContainsKey(sEntry))
                                    {
                                        sw.Stop();
                                        Console.WriteLine(sEntry + " was found after " + sw.ElapsedMilliseconds * 1000 + " seconds.");
                                    }

                                    else
                                    {
                                        sw.Stop();
                                        Console.WriteLine("It took " + sw.ElapsedMilliseconds * 1000 + " seconds to search the dictionary.\n"
                                            + sEntry + " was not found.");
                                    }

                                    break;

                                case 7:

                                    bThree = false;

                                    break;
                            }
                        } while (bThree == true);

                        break;

                    case 4:

                        bGo = false;


                        Environment.Exit(0);
                        break;
                }

                //Austin doing try catch :-)
                Console.ReadLine();
            } while (bGo == true);




        }
    }
}
