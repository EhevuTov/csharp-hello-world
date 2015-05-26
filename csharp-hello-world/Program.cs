// a Hello World program using our own local NuGet package
using System;

// user-defined libraries(our NuGet packaged library in this case)
using csharp_lib_hello_world;

namespace csharp_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            // we instance and use our phrase library contained in our local NuGet package source
            Phrase hello = new Phrase();
            Console.WriteLine(hello.get());
        }
    }
}
