using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneBook
    {
        private List<PhoneBookEntry> phoneBookEntries;



        public PhoneBook()
        {
            phoneBookEntries = new List<PhoneBookEntry>(); // stworzenie pustej listy wpisow w ksiazce - worek pustych wpisów
                                                           // list to jest typ, np. tak jak tablica, tylko bez rozmiaru
        }

        public void burn()
        {
            phoneBookEntries.Clear();
        }
         


        public string findPhoneNumber(string name)
        {
            foreach (PhoneBookEntry entry in phoneBookEntries)
            {
                if (name.Equals(entry.name))
                {
                    return entry.number;
                }
            }
            return null;
        }

        public void addNumber(string name, string phoneNumber)
        {
            PhoneBookEntry entry = new PhoneBookEntry(name, phoneNumber); 
            phoneBookEntries.Add(entry); // dodawanie do listy
        }

        public void deleteByName(string name)
        {
            PhoneBookEntry matchingEntry = null;
            foreach (PhoneBookEntry entry in phoneBookEntries)
            {
                if (name.Equals(entry.name))
                {
                    matchingEntry = entry;
                }
            }
            if (matchingEntry != null)
            {
                phoneBookEntries.Remove(matchingEntry);
            }

        }        
    }
}
