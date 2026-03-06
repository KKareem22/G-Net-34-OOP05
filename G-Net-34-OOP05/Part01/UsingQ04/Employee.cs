using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP05.Part01.UsingQ04
{
    internal class Employee
    {
        public string Title { get; set; }
        public DepartMent Dept { get; set; }
        public override string ToString() => $"Title : {Title} ,DepartMent : {Dept}";
        public Employee ShallowCopy() => (Employee)this.MemberwiseClone();


    }
}
