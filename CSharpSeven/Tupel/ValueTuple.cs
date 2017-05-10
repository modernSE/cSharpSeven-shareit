namespace CSharpSeven.Tupel
{
    public class ValueTuple
    {
        public void DemoBad()
        {
            var point = GetBadPoint();
            int x = point.Item1;
            int y = point.Item2;
        }

        private (int, int) GetBadPoint()
        {
            return (1, 2);
        }

        void DemoGood()
        {
            var point = GetGoodPoint();
            int x = point.X;
            int y = point.Y;
        }

        private (int X, int Y) GetGoodPoint()
        {
            var x = 3;
            var y = 4;
            return (x, y);
        }

        void Weird()
        {
            var point = GetWeirdPoint();
            int x = point.Item1;
            int y = point.Y;
        }

        private (int X, int Y) GetWeirdPoint()
        {
            return (5, 6);
        }
    }
}
