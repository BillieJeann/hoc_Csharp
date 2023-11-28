using KeThua.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua.Employee
{
    class Director : Employee
    {
        public string DirectorPosition { get; set; }
        public int Onboardate { get; set; }
        public long ResponsibleWage { get; set; }
        public long MonthlyRevenue { get; set; }
        private double _bonuspercent;
        public double Bonuspercent
        {
            get => _bonuspercent;
            set
            {
                if (value < 0)
                {
                    _bonuspercent = 0;
                }
                if (value > 100)
                {
                    _bonuspercent = 1;
                }
                else
                {
                    _bonuspercent = value / 100;
                }
            }
        }
        public Director(string id) : base(id)
        {
            Id = id;
        }
        public Director(string posdescribe, int onboarddate, long monthlyrevenue, double bonuspercent)
        {
            DirectorPosition = posdescribe;
            Onboardate = onboarddate;
            ResponsibleWage = (long)(WageAmount * 1.5);
            MonthlyRevenue = monthlyrevenue;
            Bonuspercent = bonuspercent;
        }
        public override void CalSalary()
        {
            long bonusrevenue = (long)(MonthlyRevenue * Bonuspercent);
            long bonusdiligence = (long)(WageAmount * 0.2);
            if (WorkDay >= 22)
            {
                Salary = (WageAmount * WorkDay / 22) + bonusdiligence + bonusrevenue + ResponsibleWage;
            }
            else
            {
                Salary = (WageAmount * WorkDay / 22) + bonusrevenue + ResponsibleWage;

            }
        }
    }
}
