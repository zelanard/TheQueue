using System;
using TheQueue.Model;
using TheQueue.View;

namespace TheQueue.Controller
{
    /// <summary>
    /// Controls the app.
    /// </summary>
    internal static class Control
    {
        /// <summary>
        /// Open the Farmacy
        /// </summary>
        public static void Open()
        {
            Pharmacy pharmacy = new Pharmacy();
            while (true)
            {
                Console.Clear();
                Display.ShowMenu();
                switch ((InputOption)Display.GetInput())
                {
                    case InputOption.AddItem:
                        Display.Print(pharmacy.EnqueuePatient(Display.GetName()));
                        Display.Await();
                        break;

                    case InputOption.DeleteItem:
                        Display.Print(pharmacy.DequeuePatient());
                        Display.Await();
                        break;
                    
                    case InputOption.ShowTheNumberOfItems:
                        Display.Print(pharmacy.NumberOfItems());
                        Display.Await();
                        break;
                    
                    case InputOption.ShowMinAndMaxItems:
                        Display.Print(pharmacy.MinMax());
                        Display.Await();
                        break;
                    
                    case InputOption.FindAnItem:
                        Display.Print(pharmacy.FindPatient(Display.QueueIndex()));
                        Display.Await();
                        break;
                    
                    case InputOption.PrintAllItems:
                        Display.Print(pharmacy.PatientsToString());
                        Display.Await();
                        break;
                    
                    case InputOption.Exit:
                        Environment.Exit(0);
                        return;
                }
            }
        }
        enum InputOption
        {
            AddItem = 1,
            DeleteItem,
            ShowTheNumberOfItems,
            ShowMinAndMaxItems,
            FindAnItem,
            PrintAllItems,
            Exit
        }
    }
}
