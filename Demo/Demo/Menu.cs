using System;
using System.Collections.Generic;

namespace Demo
{
    public class Menu
    {
        public Menu(string title, List<string> options)
        {
            Display(title, options);
        }

        private static void Display(string title, List<string> options)
        {
            int i = 1;

            UI.Header(title, ConsoleColor.Green);

            foreach (string option in options)
            {
                if (option.StartsWith('-'))
                {
                    if (i > 1) { Console.WriteLine(); }
                    UI.ChangeForeground(option, ConsoleColor.Gray);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"[{i}] {option}");
                    i++;
                }
            }
        }
    }
}
