using System;

namespace CSharpSeven.RefReturn
{
    public class Omg
    {
        //Nicht nachmachen !!!
        public void Demo()
        {
            var a = 2;
            var b = 5;

            Max(ref a, ref b) += 1;

            Console.WriteLine($"a stays 2: {a}; b is now 6: {b}");
        }

        private ref int Max(ref int a, ref int b)
        {
            if (a > b)
                return ref a;
            return ref b;
        }
    }
}
