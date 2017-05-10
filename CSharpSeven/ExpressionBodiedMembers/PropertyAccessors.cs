namespace CSharpSeven.ExpressionBodiedMembers
{
    class PropertyAccessors
    {
        public int AutoProperty { get; set; }

        private int backingField;
        public int ManualProperty
        {
            get { return backingField; }
            set { backingField = value; }
        }

        public int ExpressionBodiedProperty
        {
            get => backingField;
            set => backingField = value;
        }
    }
}
