using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptSandBox

{
    public class ChainingConstructorTest 
    {
        public ChainingConstructorTest(string a) : this(a, "")
        {
            Console.WriteLine("Constructor 1");
        }
        public ChainingConstructorTest(string a, string b) : this(a, b, "")
        {
            Console.WriteLine("Constructor 2");
        }
        public ChainingConstructorTest(string a, string b, string c)
        {
            Console.WriteLine("Constructor 3");
        }

    }
}
