using System;
using System.Collections.Generic;

namespace Demo
{
    public static class Validation
    {
        // -- ListContains() ---------------------------------------------------
        // ---------------------------------------------------------------------
        public static string ListContains(string subject, string response, List<string> list)
        {
            // Checks if user response is contained within a list (or blank),
            // only accepts a response NOT contained within the list.
            while (list.Contains(response) || string.IsNullOrWhiteSpace(response))
            {
                if (string.IsNullOrWhiteSpace(response))
                {
                    Console.WriteLine("Please do not leave this field blank");
                }
                else
                {
                    Console.WriteLine($"Do not enter a {subject} from the list above.");
                }
                response = Console.ReadLine().ToUpper();
            }

            return response;

        }



        // -- Match() ----------------------------------------------------------
        // ---------------------------------------------------------------------
        public static string Match(string subject, List<string> list, string str)
        {
            // Validation for matching user response against a list of strings,
            // only accepts a response that is contained within the list.
            while (!list.Contains(str))
            {
                Console.WriteLine($"Please select a valid {subject} from the list above.");

                str = Console.ReadLine().ToUpper();

            }

            return str;
        }


        // -- Length() ---------------------------------------------------------
        // ---------------------------------------------------------------------
        public static string Length(string subject, int a, int b, string str)
        {
            // Validation for string length.
            int c = str.Length;
            while (c < a || c > b)
            {
                Console.WriteLine($"Your {subject} should be {a}-{b} characters long.");

                str = Console.ReadLine();

                // Update int c
                c = str.Length;
            }
            return str;
        }




        // -- ForString() ------------------------------------------------------
        // ---------------------------------------------------------------------
        public static string ForString(string str)
        {
            // Validation for strings, while left blank, reprompt, recatch
            while (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("Please do not leave this field blank");
                str = Console.ReadLine();
            }

            // Return validated string
            return str;
        }


        // -- ForInt() ------------------------------------------------------
        // ---------------------------------------------------------------------
        public static int ForInt(string str)
        {
            // Validation for integers, while not an integer, reprompt, recatch
            int integer;
            while (!int.TryParse(str, out integer))
            {
                Console.WriteLine("Please only type in integers!");
                str = Console.ReadLine();
            }

            // Return validated int
            return integer;
        }

        // -- IntRange() ------------------------------------------------
        // ---------------------------------------------------------------------
        public static int IntRange(string subject, int a, int b, string str)
        {
            // Validation for integers within an accepted range

            // Validate that inputted string is an int, catch return value.
            int num = ForInt(str);

            // Valdate that the int is between a and b. 
            while (num < a || num > b)
            {
                // Error message
                UI.ChangeForeground($"The {subject} should be between {a} and {b}.\r\n\r\n", ConsoleColor.DarkGray);

                // Recatch resposne
                str = Console.ReadLine();

                // Revalidate that it is an int.
                num = ForInt(str);

            }

            // Return validated int.
            return num;
        }
    }
}
