using System;
namespace Demo
{
    public static class UI
    {
        // -- TitleCase() ------------------------------------------------------
        // ---------------------------------------------------------------------
        public static string TitleCase(string str)
        {
            // Converts passed string into Title case, used for city name

            // Convert to Char Array
            char[] chars = str.ToCharArray();

            // Create a string[] to utilize string functions ToLower() and ToUpper()
            string[] letters = new string[chars.Length];

            // Capatalize first letter
            letters[0] = chars[0].ToString().ToUpper();

            // Lowercase the rest of the letters
            for (int i = 1; i < chars.Length; i++)
            {
                letters[i] = chars[i].ToString().ToLower();
            }

            // Reset the value of the passed string
            str = null;

            // Append the converted letters to str
            foreach (string letter in letters)
            {
                str += letter;
            }

            // Return string
            return str;
        }


        // -- Dasher() ---------------------------------------------------------
        // ---------------------------------------------------------------------
        private static void Dasher(string text)
        {
            // Adds double dashes for as long as the passed texts length
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write("=");
            }
        }

        // -- Header() ---------------------------------------------------------
        // ---------------------------------------------------------------------
        public static void Header(string text, ConsoleColor c)
        {
            // Convert text to Uppercase, add spacing
            text = $"  {text.ToUpper()}  ";
            // Add line 1
            Dasher(text);
            // new line, write title
            ChangeForeground($"\r\n{text}\r\n", c);
            // Add line 2
            Dasher(text);
            // New line
            Console.Write("\r\n");
        }

        // -- Footer() ---------------------------------------------------------
        // ---------------------------------------------------------------------
        public static void Footer(string text)
        {
            // Add 1 line
            Dasher(text);
            // New line, write text
            Console.Write($"\r\n{text}");
        }

        // -- ChangeForeground() -----------------------------------------------
        // ---------------------------------------------------------------------
        public static void ChangeForeground(string text, ConsoleColor color)
        {
            // Changes foreground for passed text

            ConsoleColor currentForeground = Console.ForegroundColor;

            Console.ForegroundColor = color;

            Console.Write(text);

            Console.ForegroundColor = currentForeground;
        }

        // -- ChangeBackground() -----------------------------------------------
        // ---------------------------------------------------------------------
        public static void ChangeBackground(string text, ConsoleColor color)
        {
            ConsoleColor currentBackground = Console.BackgroundColor;

            Console.BackgroundColor = color;

            Console.Write(text);

            Console.BackgroundColor = currentBackground;
        }


    }
}
