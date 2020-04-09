using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneBookEntry
    {
        public string name { get; } // akcesory: get zwraca wartość pola, set przypisuje wartość 
        public string number { get; }

        public PhoneBookEntry(string name, string number) //to jest kontruktor
        {
            this.name = name;

            this.number = number;
        }
    }
}
