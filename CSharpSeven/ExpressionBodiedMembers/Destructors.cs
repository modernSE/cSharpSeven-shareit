using System;

namespace CSharpSeven.ExpressionBodiedMembers
{
    //C# 6.0
    class OldDestructors
    {
        ~OldDestructors()
        {
            Console.WriteLine("destroyed!");
        }
    }

    //C# 6.0
    class NewDestructors
    {
        ~NewDestructors() => Console.WriteLine("destroyed!");
    }
}
