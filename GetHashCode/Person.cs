using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Person
    {
        public int Birth { get; set; }
        public string Placeofbirth { get; set; }
        public int PassportId { get; set; }
        public string FIO { get; set; }
        public Person(int birth, string placeofbirth, int passportid, string fio)
        {
            Birth = birth;
            Placeofbirth = placeofbirth;
            PassportId = passportid;
            FIO = fio;
        }
        public override int GetHashCode()
        {
            return Birth + PassportId;

        }
        public override string ToString()
        {
            return Placeofbirth + FIO;
        }
       
            }
           
        }
    


