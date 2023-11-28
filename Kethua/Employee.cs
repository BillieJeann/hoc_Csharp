using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace KeThua.Employee
{
    class Employee
    {
        public static int idindex = 1000;
        private string _id;
        public string Id
        {
            get => _id;
            set
            {
                if (value == null)
                {
                    _id = "EMP" + idindex++;
                }
                else
                {
                    _id = "EMP" + value;
                }
            }
        }
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Position { get; set; }
        public long WageAmount { get; set; }
        public int WorkDay {  get; set; }
        public long Salary { get; set; }
        public void CheckIn() => Console.WriteLine($"Nhân viên{Id} đã check in lúc 7h30");
        public void CheckOut() => Console.WriteLine($"Nhân viên{Id} đã check out lúc 17h30");
        public void Working() => Console.WriteLine($"Nhân viên {Id} đang làm việc");
        public virtual void CalSalary()
        {
            long bonus = WageAmount * 20 / 100;
            if (WorkDay >= 22)
            {
                Salary = WageAmount * WorkDay / 22 + bonus;
            }
            else
            {
                Salary = WageAmount * WorkDay / 22;
            }
        }
        public Employee()
        {
            
        }
        public Employee(string id)
        {
            Id = id;
        }
        public Employee(string id, string fullName,long phonenumb , long basewage, int workday, long salary, string pos) : this(id)
        {                      
            Name = fullName;
            PhoneNumber = phonenumb;         
            WageAmount = basewage;
            Position = pos;
            WorkDay = workday;
            Salary = salary;
        }
        
    }  
}
