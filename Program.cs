using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string sMenuInput;
            string sEntry;

            int iMenuInput;

            Dictionary<string, int> diDictionary = new Dictionary<string, int>();

            bool bGo = true;
            bool bOne = true;
            bool bTwo = true;
            bool bThree = true;

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

                            switch (iMenuInput)
                            {
                                case 1:

                                    break;

                                case 2:

                                    break;

                                case 3:

                                    break;

                                case 4:

                                    break;

                                case 5:

                                    break;

                                case 6:

                                    break;

                                case 7:

                                    bOne = false;

                                    break;
                            }
                        } while (bOne == true);
                            
                        break;

                    case 2:

                        do
                        {
                            //Karli
                            Console.WriteLine("Select a menu item (1, 2, 3, 4, etc)\n" +
                                                "1. Add one time to Queue\n" +
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

                                    break;

                                case 2:

                                    break;

                                case 3:

                                    break;

                                case 4:

                                    break;

                                case 5:

                                    break;

                                case 6:

                                    break;

                                case 7:

                                    bTwo = false;

                                    break;
                            }
                        } while (bTwo == true);
                        
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

                                    if(diDictionary.ContainsKey(sEntry))
                                    {
                                        sw.Stop();
                                        Console.WriteLine(sEntry + " was found after " + sw.ElapsedMilliseconds*1000 + " seconds." );
                                    }

                                    else
                                    {
                                        sw.Stop();
                                        Console.WriteLine("It took " + sw.ElapsedMilliseconds * 1000 + " seconds to search the dictioanry.\n"
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
