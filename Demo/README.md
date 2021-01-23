# Demo Application
## Features
###Validation Methods
All Validation methods are that are tested are located within the Validation class, with the exception of Number Range and String Length requirement.

- **List\<string> .Contains(response)** – This demo option demonstrates how to validate a user response against a List of options.
- **String Length Requirement** – This demo option demonstrates how to validate a user response within a specific Length.
- **string.IsNullOrWhiteSpace(response)** – This demo option demonstrates validation against user response that is left blank.
- **!int.TryParse(response, out int)** – This demo option demonstrates validation against user response that cannot be parsed into an integer.
- **Number Range** – This demo option demonstrates how to validate a user response within a specific range of integers.

### Formatting Methods
All Formatting methods are that are tested are located within the UI class.

- **Convert Text to Title Case** – This demo option demonstrates a formatting method that converts passed text into Title Case.
- **Create a Header** – This demo option demonstrates a formatting method that converts passed text into a Header.
- **Create a Footer** – This demo option demonstrates a formatting method that converts passed text into a Footer.
- **Change Text Foreground Color** – This demo option demonstrates a formatting method that changes the Foreground color of the passed text.
- **Change Text Background Color** – This demo option will demonstrate a formatting method that changes the Foreground color of the passed text.

##Menu Class
	public class Menu
    {
    	// This is the constructor
        public Menu(string title, List<string> options)
        {
        	// Method call to a private method within class
            Display(title, options);
        }

		// The constructor passes the arguments to the Display()
        private static void Display(string title, List<string> options)
        {
            int i = 1;

            UI.Header(title, ConsoleColor.Green);
            
            // A foreach loop to iterate through the list of options
            foreach (string option in options)
            {
            	// If the option starts with this character, it is a category, it won't be numbered.
                if (option.StartsWith('-'))
                {
                	// Not counting the first category, Add a visual break for every category to be listed.
                    if (i > 1) { Console.WriteLine(); }
                    
                    UI.ChangeForeground(option, ConsoleColor.Gray);
                    Console.WriteLine();
                }
                // Else list a numbered option
                else
                {
                    Console.WriteLine($"[{i}] {option}");
                    i++;
                } 
            }

            Console.WriteLine("\r\n[0] Exit");

            UI.Footer("Please select an option: ");
        }
    }
}