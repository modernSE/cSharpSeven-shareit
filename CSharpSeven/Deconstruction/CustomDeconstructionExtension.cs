namespace CSharpSeven.Deconstruction
{
    class CustomDeconstructionExtension
    {
        void Demo()
        {
            (int x, int y) = GetMyPoint();
        }

        private MyPoint GetMyPoint()
        {
            return new MyPoint { X = 2, Y = 3 };
        }   
    }

    public class MyPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public static class MyPointExtensions
    {
        public static void Deconstruct(this MyPoint point, out int x, out int y)
        {
            x = point.X;
            y = point.Y;
        }
    }
}
