namespace CSharpSeven.ExpressionBodiedMembers
{
    //C# 6.0
    class OldConstructors
    {
        readonly bool initialized;
        public OldConstructors()
        {
            initialized = true;
        }
    }

    //C# 6.0
    class NewConstructors
    {
        readonly bool initialized;
        public NewConstructors() => initialized = true;
    }
}
