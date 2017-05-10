using System;

namespace CSharpSeven.OutRefValue
{
    class TryParse
    {
        public void OldskoolOutDemo(string something = "1")
        {
            int i;
            if(int.TryParse(something, out i))
            {
                Console.WriteLine("It is a number!: {0}", i);
            } else
            {
                Console.WriteLine("It is just a string!: {0}", something);
            }
        }

        public void NewOutDemo(string something = "1")
        {
            if (int.TryParse(something, out int i))
            {
                Console.WriteLine("It is a number!: {0}", i);
            }
            else
            {
                Console.WriteLine("It is just a string!: {0}", something);
            }
        }
    }
}
