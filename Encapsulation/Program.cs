using System;
using Encapsulation;

namespace Strings
{
    static class Program
    {
        static void Main(string[] args)
        {
            State state = new State();
            Console.WriteLine(state.publicVar);

            ChildState childState = new ChildState();


        }
    }
}