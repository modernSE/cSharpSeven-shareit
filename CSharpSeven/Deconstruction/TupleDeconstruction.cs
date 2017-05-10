using System;

namespace CSharpSeven.Deconstruction
{
    class TupleDeconstruction
    {
        void Demo()
        {
            (int x, int y) = GetPoint();
            Console.WriteLine("x: {0}, y: {1}", x, y);

            int v;
            int z;
            (z, v) = GetPoint();
            Console.WriteLine("z: {0}, v: {1}", z, v);
        }

        private (int X, int Y) GetPoint()
        {
            return (13, 37);
        }
    }
}
