using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(2000, "Tiraspol", 1, "Vedenchuk Andrew");
            Person person1 = new Person(2000, "Tiraspol", 2, "Shevshenko Vlad");
            Person person2 = new Person(2001, "Tiraspol", 3, "Koval Oleg");
            Person person3 = person;
            var hash1 = person.GetHashCode();
            var hash2 = person1.GetHashCode();
            var hash3 = person2.GetHashCode();
        
            
        
           
        
            

            }

        }
       
        }
    

