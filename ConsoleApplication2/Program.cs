using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using test.name.abc;  // error: type or namespace "test" cannot be found.  
public class testName2 : testName1  // build error here 
{
    public int id;
}

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
