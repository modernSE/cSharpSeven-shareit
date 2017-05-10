namespace CSharpSeven.Deconstruction
{
    class CustomDeconstruction
    {
        void Demo()
        {
            (int x, int y) = GetMyPoint();
        }

        private MyPoint GetMyPoint()
        {
            return new MyPoint { X = 2, Y = 3 };
        }

        class MyPoint
        {
            public int X { get; set; }
            public int Y { get; set; }

            public void Deconstruct(out int x, out int y)
            {
                x = X;
                y = Y;
            }
        }
    }
}
