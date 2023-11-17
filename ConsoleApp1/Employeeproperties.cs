using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclass.Emp
{
    internal partial class Employee
    {
        private static int EmpIndex = 1000;
        private string _id;
        public string Id
        {
            get => _id;
            set
            {
                if (value == null)
                {
                    _id = "EMP" + EmpIndex++;
                }
                else
                {
                    _id = "EMP" + value;
                }
            }
        }
        public string FullName { get; set; }
        public long PhoneNumber { get; set; }
        public string Position { get; set; }
        public long GroundPay = 7000000;
        private long _salary;
        public long Salary
        {
            get => _salary;
            set
            {
                int max = 10000000;
                if (value > max)
                {
                    _salary = max;
                }
                else if (value < 0)
                {
                    _salary = 0;
                }
                else
                {
                    _salary = value;
                }
            }
        }
        public int WorkDay { get; set; }
        public Employee(string id)
        {
            Id = id;
        }

        public Employee(string id, string fullName, long phoneNumb, string pos, long salary, int workday) : this(id)
        {
            FullName = fullName;
            PhoneNumber = phoneNumb;
            Position = pos;
            Salary = salary;
            WorkDay = workday;

        }
        public partial void CheckIn(string id);
        public partial void CheckOut(string id);
        public partial void Working(string id);
        public partial void SalCount();
    }
    partial class Employee
    {
        public partial void CheckIn(string id)
        {
            Console.WriteLine($"{id} đã check in lúc 7h30");
        }
        public partial void CheckOut(string id)
        {
            Console.WriteLine($"{id} đã check out lúc 17h30");
        }
        public partial void Working(string id)
        {
            Console.WriteLine($"{id} đang làm việc");
        }
        public partial void SalCount()
        {
            double bonus = GroundPay * 20 / 100;
            if (WorkDay >= 22)
            {
                Salary = (long)(GroundPay * WorkDay / 22 + bonus);
            }
            else
            {
                Salary = GroundPay * WorkDay / 22;
            }
        }
    }
}
