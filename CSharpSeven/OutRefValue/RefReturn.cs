using System;

namespace CSharpSeven.OutRefValue
{
    public class RefReturn
    {
        public void Demo()
        {
            int a = 1;
            ref int b = ref a;
            b = 2;
            ref int c = ref ReturnByReference(ref a);
            Console.WriteLine("all vars show 3: {0}, {1} and {2}", a, b, c);
        }

        private ref int ReturnByReference(ref int x)
        {
            x = 3;
            return ref x;
        }
    }
}
