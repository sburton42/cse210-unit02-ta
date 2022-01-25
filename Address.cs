using System;

namespace Cse210_Unit02_Ta
{
    public class Address
    {
        // public List<int> _dice = new List<int>();

        public string _street;
        public string _city;
        public string _state;

        public Address()
        {
            _street = "Unknown";
            _city = "[city]";
            _state = "NA";
        }

        public void DisplayMailingLabel(bool isSeparateLine)
        {
            Console.WriteLine(_street);

            if (isSeparateLine)
            {
                Console.WriteLine(_city);
                Console.WriteLine(_state);
            }
            else
            {
                Console.WriteLine($"{_city}, {_state}");

            }
        }

        public void PromptUserForData()
        {
            Console.WriteLine("What is your state? ");
            string userState = Console.ReadLine();

            if (userState == "Idaho")
            {
                _state = "ID";
            }

            Console.WriteLine("What is your street? ");
            _street = Console.ReadLine();
        }
    }
}
