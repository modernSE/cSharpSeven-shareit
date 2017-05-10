using System;

namespace CSharpSeven.OutRefValue
{
    public class PassByValue
    {
        public void Demo()
        {
            int a = 1;
            ManipulatePassedByValue(a);
            Console.WriteLine("a is still 1: {0}", a);
        }

        void ManipulatePassedByValue(int a)
        {
            a = 2;
        }
    }
}
