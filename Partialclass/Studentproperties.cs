using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclass.Student
{
    partial class Studentproperties
    {
        private static int idindex = 1000;
        private string _id;
        public string Id
        {
            get => _id;
            set
            {
                if(value == null)
                {
                    _id = "ST" + idindex++;
                }
                else
                {
                    _id = value;
                }
            }
        }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public double Gpa { get; set; }
        public string Major { get; set; }
        public Studentproperties(string id)
        {
            Id = id;
        }
        public Studentproperties(string id , string firstName , string midName , string lastName , string addr , double gpa , string major) : this(id)
        {
            FirstName = firstName;
            MiddleName = midName;
            LastName = lastName;
            Address = addr;
            Gpa = gpa;
            Major = major;
        }
    }
}
