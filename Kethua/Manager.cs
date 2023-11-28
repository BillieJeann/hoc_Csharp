using KeThua.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KeThua.Employee
{
    class Manager : Employee
    {
        public string ManagerPosition { get; set; }
        private double _bonuscoefficient;
        public double BonusCoefficient
        {
            get => _bonuscoefficient;
            set
            {
                if (value <= 0)
                {
                    _bonuscoefficient = 0;
                }
                if (value >= 3)
                {
                    _bonuscoefficient = 0.5;
                }
                if (value == 2)
                {
                    _bonuscoefficient = 0.3;
                }
                if (value == 1)
                {
                    _bonuscoefficient = 0.15;
                }
            }
        }
        public Manager(string id) : base(id)
        {
            Id = id;
        }
        public Manager(string posdescribe, int bonuscoefficient) 
        {
            ManagerPosition = posdescribe;
            BonusCoefficient = bonuscoefficient;          
        }
        public override void CalSalary()
        {
            long bonus = WageAmount * 20 / 100;
            if (WorkDay >= 22)
            {
                Salary = (WageAmount * WorkDay / 22) + bonus;
                Salary += (long)BonusCoefficient * Salary;
            }
            else
            {
                Salary = WageAmount * WorkDay / 22;
                Salary += (long)BonusCoefficient * Salary;
            }
        }
    }
}
