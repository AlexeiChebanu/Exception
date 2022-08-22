using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Exception_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] PhoneBook = 
                { 
                "Alexei Chebanu - 380636188311", 
                "Interesnoe Syschestvo - 380669580534"
            };

            List<string> result = new List<string>();
            Console.Write("Type the user you are looking for: ");

            string answer = Console.ReadLine();
            var regex = new Regex(answer);

            try
            {
                
                foreach (var contact in PhoneBook)
                {
                    MatchCollection match = regex.Matches(contact);
                    int counter = match.Count;
                    if (match.Count > 0)
                        result.Add(contact);
                }
                if (result.Count > 0)
                {
                    Console.WriteLine("Matches:");
                    foreach (var foundUser in result)
                        Console.WriteLine(foundUser);
                }
                else
                {
                    /*for instance. Type "f" to throw the exception*/
                    throw new MyOwnException();
                }
            }
            catch(MyOwnException ex)
            { 
                Console.WriteLine(ex.Message); 
            }
        }
    }
}//checked
