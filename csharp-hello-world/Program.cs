using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using csharp_lib_hello_world;

namespace csharp_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Phrase hello = new Phrase();
            hello.sayPhrase();
        }
    }
}
