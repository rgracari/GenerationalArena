using GenerationalArena;
using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Arena<string> arena = new Arena<string>();
            Console.WriteLine(arena);

            GenerationalIndex rafou = arena.Add("Rafou");
            GenerationalIndex math = arena.Add("Mathieu");
            Console.WriteLine(rafou);
            Console.WriteLine(math);

            Console.WriteLine(arena);
        }
    }
}
