using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kethua
{
    internal class GratuatedStudent : Student
    {
        public long PayAmount {  get; set; }
        public int GradYear { get; set; }
        public string GradClassification { get; set; }
        public GratuatedStudent(string id, string name, string addr, double cgrade, double engGrade, double mathgrade, string major , long amount , int gradYear , string classification) : base( id,  name,  addr,  cgrade,  engGrade,  mathgrade,  major)
        {
            PayAmount = amount;
            GradYear = gradYear;
            GradClassification = classification;
        }
    }
}
