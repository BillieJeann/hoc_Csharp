using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kethua
{
    internal class Student
    {
        private static int _idindex = 1000;
        private string _id;
        public string Id
        {
            get => _id;
            set
            {
                if (value == null)
                {
                    _id = "ST" + _idindex++;
                }
                else
                {
                    _id = "ST" + value;
                }
            }
        }
        private class FullName
        {
            public string FirstName;
            public string MiddleName;
            public string LastName;
        }
        private FullName _name;
        public string WholeName
        {
            get => $"{_name.FirstName} {_name.MiddleName} {_name.LastName}";
            set
            {
                _name = new FullName();
                var name = value.Split(' ');
                _name.FirstName = name[0];
                _name.LastName = name[name.Length - 1];
                string item = "";
                for (int i = 1; i < name.Length - 1; i++)
                {
                    item += name[i];
                }
                _name.MiddleName = item + " ";
            }
        }
        public string GetLastName => _name.LastName;
        public string GetFirstName => _name.FirstName;
        public string Adress { get; set; }
        private class Grade
        {
            public double C;
            public double Eng;
            public double Math;
        }
        private Grade _grade;
        public double Cgrade
        {
            get => _grade.C;
            set => _grade.C = value;
        }
        public double Enggrade
        {
            get => _grade.Eng;
            set => _grade.Eng = value;
        }
        public double Mathgrade
        {
            get => _grade.Math;
            set => _grade.Math = value;
        }
        public string Major { get; set; }
        public double Gpa;
        public Student()
        {
            
        }
        public Student(string id)
        {
            Id = id;
        }
        public Student(string id, string name, string addr, double cgrade, double engGrade, double mathgrade, string major) : this(id)
        {
            _grade = new Grade(); 
            WholeName = name;
            Adress = addr;
            Cgrade = cgrade;
            Enggrade = engGrade;
            Mathgrade = mathgrade;
            Major = major;
            Gpa = Math.Round((Cgrade + Enggrade + Mathgrade) / 3, 2);
        }
    }
}
