using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_Constructor
{
    internal class MyPerson
    {
        // MY PERSON
        // Variables 
        public string Name;
        public int Age;
        public string LastName;

        public MyPerson(string aName, int aage, string aLastName)
        {
            Name = aName;
            Age = aage;
            LastName = aLastName;
        }
    }
}
