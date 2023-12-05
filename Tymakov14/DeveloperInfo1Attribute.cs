using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov14
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class DeveloperInfo1Attribute: Attribute
    {
        public string Name { get; }
        public string Date { get; }
        public DeveloperInfo1Attribute(string name, string date)
        {
            Name = name;
            Date = date;
        }
    }
    
}
