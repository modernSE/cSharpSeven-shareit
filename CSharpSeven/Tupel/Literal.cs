using System;

namespace CSharpSeven.Tupel
{
    class Literal
    {
        void Demo()
        {
            var annonymous = ("Klaus", "Peter");
            var named = (ChristianName: "Robert", LastName: "Glaser");
            Console.WriteLine($"FullName1: {annonymous.Item1} {annonymous.Item2}");
            Console.WriteLine($"FullName2: {named.ChristianName} {named.LastName}");
        }
    }
}
