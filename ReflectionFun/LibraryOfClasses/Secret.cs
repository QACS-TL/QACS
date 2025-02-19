using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

//[assembly: InternalsVisibleTo("ReflectionFun")]
namespace LibraryOfClasses
{
    internal class Secret
    {
        private string secretMessage = "This is private!";

        private string HiddenMethod()
        {
            return "This is the Hidden Method's private message!";
        }
    }
}
