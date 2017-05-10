using CSharpSeven.Deconstruction;
using System;

namespace CSharpSeven.PatternMatching
{
    class Patterns
    {
        void ConstPattern(object o)
        {
            //old
            if (o == null) throw new ArgumentNullException(nameof(o));
            //if (o == 42) Console.WriteLine("Does not compile");
            
            //new
            if (o is null) throw new ArgumentNullException(nameof(o));
            if (o is 42) Console.WriteLine("It's 42!");
        }

        void TypePatterns(object o)
        {
            if(o is MyPoint)
            {
                MyPoint p1 = (MyPoint)o;
                Console.WriteLine("x: {0}, y: {1}", p1.X, p1.Y);
            }

            MyPoint p2 = o as MyPoint;
            if(p2 != null)
            {
                Console.WriteLine("x: {0}, y: {1}", p2.X, p2.Y);
            }

            if(o is MyPoint p3)
            {
                Console.WriteLine("x: {0}, y: {1}", p3.X, p3.Y);
            }
        }
    }
}
