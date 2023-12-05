using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov14
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class DeveloperInfo2Attribute:Attribute
    {
        public string DName { get; }
        public string OName { get; }
        public DeveloperInfo2Attribute(string dName, string oName)
        {
            DName = dName;
            OName = oName;
        }
    }
}
