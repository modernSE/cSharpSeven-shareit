using System;

namespace CSharpSeven
{
    class Discard
    {
        void Demo(string something)
        {
            if (int.TryParse(something, out _))
            {
                Console.WriteLine("Yes, its a number!");
            }

            (int x, _) = GetPoint();
            
        }

        private (int x, int y) GetPoint()
        {
            return (20, 0);
        }
    }
}
