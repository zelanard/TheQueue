using System;

namespace TheQueue.View
{
    /// <summary>
    /// Contorls the display.
    /// </summary>
    internal static class Display
    {
        /// <summary>
        /// Output the app header.
        /// </summary>
        public static void Header()
        {
            Console.WriteLine("::::::::::: :::    ::: ::::::::::       ::::::::  :::    ::: :::::::::: :::    ::: :::::::::: ");
            Console.WriteLine("    :+:     :+:    :+: :+:             :+:    :+: :+:    :+: :+:        :+:    :+: :+:        ");
            Console.WriteLine("    +:+     +:+    +:+ +:+             +:+    +:+ +:+    +:+ +:+        +:+    +:+ +:+        ");
            Console.WriteLine("    +#+     +#++:++#++ +#++:++#        +#+    +:+ +#+    +:+ +#++:++#   +#+    +:+ +#++:++#   ");
            Console.WriteLine("    +#+     +#+    +#+ +#+             +#+  # +#+ +#+    +#+ +#+        +#+    +#+ +#+        ");
            Console.WriteLine("    #+#     #+#    #+# #+#             #+#   +#+  #+#    #+# #+#        #+#    #+# #+#        ");
            Console.WriteLine("    ###     ###    ### ##########       ###### ### ########  ##########  ########  ########## ");
            Console.WriteLine();
        }

        /// <summary>
        /// Display the menu
        /// </summary>
        public static void ShowMenu()
        {
            Header();
            Console.WriteLine("=============================================================================================");
            Console.WriteLine("                                  H1 Queue Operations Menu");
            Console.WriteLine("=============================================================================================");
            Console.WriteLine("1. Add item");
            Console.WriteLine("2. Delete item");
            Console.WriteLine("3. Show the number of items");
            Console.WriteLine("4. Show min and max items");
            Console.WriteLine("5. Find an item");
            Console.WriteLine("6. Print all items");
            Console.WriteLine("7. Exit");
            Console.WriteLine();
        }
        /// <summary>
        /// Prompt user for input.
        /// </summary>
        public static int GetInput()
        {
            Console.WriteLine("Enter the index of your choice:");
            while (true)
            {

                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        return 1;
                    case ConsoleKey.D2:
                        return 2;
                    case ConsoleKey.D3:
                        return 3;
                    case ConsoleKey.D4:
                        return 4;
                    case ConsoleKey.D5:
                        return 5;
                    case ConsoleKey.D6:
                        return 6;
                    case ConsoleKey.D7:
                        return 7;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// prompt the user for a queue index.
        /// </summary>
        /// <returns>int</returns>
        public static int QueueIndex()
        {
            Console.WriteLine("Which Queue number are you searching for?");
            while (true)
            {
                try
                {
                    return Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("NaN: PLease enter a number, which mustbe an index in the queue!");
                }
            }
        }

        /// <summary>
        /// input number.
        /// </summary>
        /// <returns>string</returns>
        public static string GetName()
        {
            Console.WriteLine("Please wirte the Patients Name");
            return (Console.ReadLine());
        }

        /// <summary>
        /// prints a text to the console.
        /// </summary>
        /// <param name="text"></param>
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }

        /// <summary>
        /// await for the user to press any key.
        /// </summary>
        internal static void Await()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
