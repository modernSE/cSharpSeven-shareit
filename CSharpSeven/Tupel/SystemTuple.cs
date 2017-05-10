using System;

namespace CSharpSeven.Tupel
{
    class SystemTuple
    {
        void Demo()
        {
            Tuple<int, int> point = GetPoint();
            int x = point.Item1;
            int y = point.Item2;
        }

        private static Tuple<int, int> GetPoint()
        {
            var y = 1;
            var x = 2;
            return new Tuple<int, int>(y, x);
        }
    }
}
