using System;
using System.Collections.Generic;

namespace Demo
{
    public class Demo
    {
        private readonly string _menuTitle = "DEMO APPLICATION";

        private readonly List<string> _categories = new List<string>()
        {
            "- VALIDATION FOR USER INPUT -", "- UI / FORMATTING -"
        };

        private readonly List<string> _validationOptions = new List<string>()
        {
            "List<string> .Contains(response)", "String Length Requirement",
            "string.IsNullOrWhiteSpace(response)", "!int.TryParse(response, out int)",
            "Number Range"
        };

        private readonly List<string> _uiOptions = new List<string>()
        {
            "Convert Text to Title Case", "Create a Header", "Create a Footer",
            "Change Text Foreground Color", "Change Text Background Color"
        };

        public Demo()
        {
            List<string> combinedLists = new List<string>();

            combinedLists.Add(_categories[0]);

            foreach (string validationOption in _validationOptions)
            {
                combinedLists.Add(validationOption);
            }

            combinedLists.Add(_categories[1]);

            foreach (string uiOption in _uiOptions)
            {
                combinedLists.Add(uiOption);
            }

            bool selecting = true;

            while (selecting)
            {
                Console.Clear();

                Menu menu = new Menu(_menuTitle, combinedLists);

                selecting = Selection();
            }
        }

        private bool Selection()
        {
            string response = Console.ReadLine();

            int choice = Validation.IntRange("option", 0, 10, response);

            switch (choice)
            {
                case 0:
                    Exit();
                    return false;
                case 1:
                    ListContains(_validationOptions[0]);
                    return true;
                case 2:
                    Length(_validationOptions[1]);
                    return true;
                case 3:
                    IsNullOrWhiteSpace(_validationOptions[2]);
                    return true;
                case 4:
                    IntTryParse(_validationOptions[3]);
                    return true;
                case 5:
                    IntRange(_validationOptions[4]);
                    return true;
                case 6:
                    TitleCase();
                    return true;
                case 7:
                    Header();
                    return true;
                case 8:
                    Footer();
                    return true;
                case 9:
                    ChangeForeground();
                    return true;
                case 10:
                    ChangeBackground();
                    return true;
            }

            return true;

        }


        private static bool Exit()
        {
            Console.Clear();

            UI.Header("Exitiing...", ConsoleColor.Red);

            Console.WriteLine("\r\nYou may close this window at anytime.");

            Console.WriteLine();

            return false;
        }

        private static void ListContains(string title)
        {
            Console.Clear();

            List<string> states = new List<string>()
            {
                "AK", "AL", "AR", "AS", "AZ", "CA", "CO", "CT", "DC", "DE", "FL",
                "GA", "GU", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA",
                "MD", "ME", "MI", "MN", "MO", "MP", "MS", "MT", "NC", "ND", "NE",
                "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "PR", "RI",
                "SC", "SD", "TN", "TX", "UM", "UT", "VA", "VI", "VT", "WA", "WI",
                "WV", "WY"
            };



            UI.Header(title, ConsoleColor.Green);

            UI.ChangeForeground("\r\nThis demo option will demonstrate how to validate" +
                "a user response against a List of options.\r\n\r\n\r\n", ConsoleColor.Gray);

            // Display states
            for (int i = 0; i < states.Count; i++)
            {
                UI.ChangeForeground(states[i], ConsoleColor.Yellow);
                if (i + 1 != states.Count)
                {
                    UI.ChangeForeground(", ", ConsoleColor.Yellow);
                }
            }

            Console.WriteLine("\r\n");

            UI.Footer("Please type in a state from the list above: ");

            string response = Console.ReadLine();

            response = Validation.Match("state", states, response.ToUpper());

            Console.Clear();

            UI.Header(title, ConsoleColor.Green);

            UI.ChangeForeground("\r\nGood job, now let's do the opposite.\r\n\r\n\r\n", ConsoleColor.Gray);

            // Display states
            for (int i = 0; i < states.Count; i++)
            {
                UI.ChangeForeground(states[i], ConsoleColor.Yellow);
                if (i + 1 != states.Count)
                {
                    UI.ChangeForeground(", ", ConsoleColor.Yellow);
                }
            }

            Console.WriteLine("\r\n");

            UI.Footer("Please type in any response not listed above: ");

            response = Console.ReadLine();

            response = Validation.ListContains("state", response.ToUpper(), states);

            Console.Clear();

            UI.Header(title, ConsoleColor.Green);

            UI.ChangeForeground("\r\nNice! Returning to menu...\r\n", ConsoleColor.Gray);

            Continue();

        }

        private static void Length(string title)
        {
            Console.Clear();

            UI.Header(title, ConsoleColor.Green);

            UI.ChangeForeground("\r\nThis demo option will demonstrate how to validate" +
                " a user response within a specific Length.\r\n\r\n\r\n", ConsoleColor.Gray);

            UI.Footer("Please enter a lower limit (integer): ");

            string response = Console.ReadLine();

            int num = Validation.ForInt(response);

            Console.Clear();

            UI.Header(title, ConsoleColor.Green);

            UI.ChangeForeground($"\r\nLower limit: {num}\r\n\r\n\r\n", ConsoleColor.Gray);

            UI.Footer("Please enter an upper limit (integer): ");

            response = Console.ReadLine();

            int num2 = Validation.ForInt(response);

            while (num2 <= num)
            {
                Console.Clear();

                UI.Header(title, ConsoleColor.Green);

                UI.ChangeForeground($"\r\nThe upper limit should be higher than the lower limit!\r\n\r\n" +
                    $"Lower limit: {num}\r\n\r\n\r\n", ConsoleColor.Gray);

                UI.Footer("Please enter an upper limit (integer): ");

                response = Console.ReadLine();

                num2 = Validation.ForInt(response);
            }

            Console.Clear();

            UI.Header(title, ConsoleColor.Green);

            UI.ChangeForeground($"\r\nLower limit: {num}" +
                $"\r\nUpper limit: {num2}\r\n\r\n\r\n", ConsoleColor.Gray);

            UI.Footer($"Please type in a string with a length between {num} and {num2}: ");

            response = Console.ReadLine();

            response = Validation.Length("string", num, num2, response);

            Console.Clear();

            UI.Header(title, ConsoleColor.Green);

            UI.ChangeForeground("\r\nWell done! Returning to menu...\r\n", ConsoleColor.Gray);

            Continue();


        }

        private static void IsNullOrWhiteSpace(string title)
        {
            Console.Clear();

            UI.Header(title, ConsoleColor.Green);

            UI.ChangeForeground("\r\nThis demo option will demonstrate validation" +
                "against user response that is left blank.\r\n\r\n\r\n", ConsoleColor.Gray);

            UI.Footer("Please enter a response to return to the menu: ");

            string response = Console.ReadLine();

            Validation.ForString(response);

        }

        private static void IntTryParse(string title)
        {
            Console.Clear();

            UI.Header(title, ConsoleColor.Green);

            UI.ChangeForeground("\r\nThis demo option will demonstrate validation" +
                "against user response that cannot be parsed into an integer.\r\n\r\n\r\n", ConsoleColor.Gray);

            UI.Footer("Please enter an integer to return to the menu: ");

            string response = Console.ReadLine();

            Validation.ForInt(response);

        }

        private static void IntRange(string title)
        {
            Console.Clear();

            UI.Header(title, ConsoleColor.Green);

            UI.ChangeForeground("\r\nThis demo option will demonstrate how to validate" +
                " a user response within a specific range of integers.\r\n\r\n\r\n", ConsoleColor.Gray);

            UI.Footer("Please enter a lower limit (integer): ");

            string response = Console.ReadLine();

            int num = Validation.ForInt(response);

            Console.Clear();

            UI.Header(title, ConsoleColor.Green);

            UI.ChangeForeground($"\r\nLower limit: {num}\r\n\r\n\r\n", ConsoleColor.Gray);

            UI.Footer("Please enter an upper limit (integer): ");

            response = Console.ReadLine();

            int num2 = Validation.ForInt(response);

            while (num2 <= num)
            {
                Console.Clear();

                UI.Header(title, ConsoleColor.Green);

                UI.ChangeForeground($"\r\nThe upper limit should be higher than the lower limit!\r\n\r\n" +
                    $"Lower limit: {num}\r\n\r\n\r\n", ConsoleColor.Gray);

                UI.Footer("Please enter an upper limit (integer): ");

                response = Console.ReadLine();

                num2 = Validation.ForInt(response);
            }

            Console.Clear();

            UI.Header(title, ConsoleColor.Green);

            UI.ChangeForeground($"\r\nLower limit: {num}" +
                $"\r\nUpper limit: {num2}\r\n\r\n\r\n", ConsoleColor.Gray);

            UI.Footer($"Please type in a number between {num} and {num2}: ");

            response = Console.ReadLine();

            Validation.IntRange("integer", num, num2, response);

            Console.Clear();

            UI.Header(title, ConsoleColor.Green);

            UI.ChangeForeground("\r\nWell done! Returning to menu...\r\n", ConsoleColor.Gray);

            Continue();
        }

        private static void TitleCase()
        {

        }

        private static void Header()
        {

        }

        private static void Footer()
        {

        }

        private static void ChangeForeground()
        {

        }

        private static void ChangeBackground()
        {

        }

        private static void Continue()
        {
            Console.WriteLine("\r\n(Press Any Key To Continue)");
            Console.ReadKey();
        }
    }
}
