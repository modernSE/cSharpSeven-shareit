namespace CSharpSeven.ExpressionBodiedMembers
{
    class Methods
    {
        //C# 5.0
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        //C# 6.0
        public bool IsOdd(int number) => number % 2 != 0;
    }
}
