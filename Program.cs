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

            int iMenuInput;

            bool bGo = true;

            do
            {
                Console.WriteLine("Select a menu item (Enter 1, 2, 3, or 4)\n" +
                                "1.Stack\n " +
                                "2.Queue\n" +
                                "3.Dictionary\n" +
                                "4.Exit\n\n");
                sMenuInput = Console.ReadLine();

                iMenuInput = Convert.ToInt32(sMenuInput);

                switch (iMenuInput)
                {
                    case 1:

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

                                break;
                        }

                        break;

                    case 2:

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

                                break;
                        }
                        break;

                    case 3:

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

                                break;
                        }

                        break;

                    case 4:
                        bGo = false;
                        Environment.Exit(0);
                        break;
                }

                //Austin doing try catch :-)
                Console.ReadLine();
            } while (bGo);


            
            
        }
    }
}
