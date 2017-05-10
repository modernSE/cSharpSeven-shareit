using System;

namespace CSharpSeven.ExpressionBodiedMembers
{
    class LocalFunctions
    {
        // C# 7.0
        void NewDemo()
        {
            LocalDemo();

            void LocalDemo()
            {
                Console.WriteLine("Nested method in a method");
            }
        }

        // C# 7.0
        void ExpressionBodiesDemo()
        {
            LocalDemo();

            void LocalDemo() => Console.WriteLine("Nested method in a method");
        }

        // C# 6.0
        void FuncDemo()
        {
            Action localDemo = () => Console.WriteLine("Nested action in a func");

            localDemo.Invoke();
        }
    }
}
