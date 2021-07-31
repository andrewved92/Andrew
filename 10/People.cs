using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class People
    {
        public int Birth { get; set; }
        public string Placeofbirth { get; set; }
        public int PassportId { get; set; }
        public string FIO { get; set; }
        

        public People(int birth, string placeofbirth, int passportid, string fio)
        {
            Birth = birth;
            Placeofbirth = placeofbirth;
            PassportId = passportid;
            FIO = fio;
            
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is People))
            {
                return false;
            }
            People result = (People)obj;
            return result.Birth == Birth && result.PassportId == PassportId;
        }
        public static bool operator ==(People one, People two)
        {
            return one.Equals(two);
        }
        public static bool operator !=(People one, People two)
        {
            return !one.Equals(two);
        }
    }

}
