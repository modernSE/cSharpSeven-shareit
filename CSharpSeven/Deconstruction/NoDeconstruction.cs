using System;

namespace CSharpSeven.Deconstruction
{
    class NoDeconstruction
    {
        void Demo()
        {
            var tuple = GetPoint();
            Console.WriteLine("x: {0}, y: {1}", tuple.X, tuple.Y);
        }

        private (int X, int Y) GetPoint()
        {
            return (13, 37);
        }
    }
}
