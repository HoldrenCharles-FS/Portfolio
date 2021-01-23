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

            Menu menu = new Menu(_menuTitle, combinedLists);
        }

    }
}
