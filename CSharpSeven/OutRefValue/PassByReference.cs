using System;

namespace CSharpSeven.OutRefValue
{
    public class PassByReference
    {
        public void Demo()
        {
            int a = 1;
            ManipulatePassedByRef(ref a);
            Console.WriteLine("a is now 2: {0}", a);
        }

        void ManipulatePassedByRef(ref int a)
        {
            a = 2;
        }
    }
}
