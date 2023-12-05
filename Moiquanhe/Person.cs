using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moiquanhe
{
    internal class Person
    {
        public string FirsName { get; set; }
        public string _middlename;
        public string MiddleName
        {
            get => _middlename;
            set
            {
                var name = value.Split(' ');
                var mid = "";
                for (int i = 0; i < name.Length; i++)
                {
                    mid += name[i];
                }
                _middlename = mid + " ";
            }
        }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public Person()
        {
            
        }
        public Person(string firstName , string midname,string lastname, string addr, int age)
        {
            FirsName = firstName;
            MiddleName = midname;
            LastName = lastname;    
            Address = addr;
            Age = age;
        }
    }
}
