using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kethua
{
    internal class UngratuatedStudent : Student
    {
        public long Tuition { get; set; }
        public int UnpaySubject { get; set; }
        public int CompletedSubject { get; set; }
        public UngratuatedStudent(string id, string name, string addr, double cgrade, double engGrade, double mathgrade, string major, long amount, int unpay, int completed) : base(id, name, addr, cgrade, engGrade, mathgrade, major)
        {
            Tuition = amount;
            UnpaySubject = unpay;
            CompletedSubject = completed;
        }
    }
}
