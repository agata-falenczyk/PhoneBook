using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            PhoneBook ksiazka = new PhoneBook(); // deklarowany obiekt PhoneBook o nazwie ksiazka
            while (isRunning)
            {
                Console.WriteLine("Hello! This is PhoneBook.");
                Console.WriteLine("Write number for action: 1 ADDING ENTRY  2 SEARCH  3 DELETE ENTRY  4 END");
                int function = int.Parse(Console.ReadLine());
                if (function == 1)
                {
                    Console.WriteLine("Write Name and Surname");
                    string name = Console.ReadLine();
                    Console.WriteLine("Write Phone Number");
                    string number = Console.ReadLine();
                    ksiazka.addNumber(name, number);
                }
                else if (function == 2)
                {
                    Console.WriteLine("Write Name and Surname");
                    string name = Console.ReadLine();
                    string number = ksiazka.findPhoneNumber(name);
                    Console.WriteLine($"Number for {name} is {number} ");
                }
                else if (function == 3)
                {
                    Console.WriteLine("Write Name and Surname");
                    string name = Console.ReadLine();
                    ksiazka.deleteByName(name);
                }
                else
                {
                    isRunning = false;
                }
                
            }
  
        }
    }
}
