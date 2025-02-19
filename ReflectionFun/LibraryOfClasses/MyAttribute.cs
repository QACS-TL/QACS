using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfClasses
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MyAttribute : Attribute
    {
        public string Info { get; }
        public MyAttribute(string info) => Info = info;
    }
}
