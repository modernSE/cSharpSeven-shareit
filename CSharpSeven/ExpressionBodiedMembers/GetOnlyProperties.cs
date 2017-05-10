namespace CSharpSeven
{
    class GetOnlyProperties
    {
        public string ChristianName { get; set; }
        public string LastName { get; set; }

        //C# 5.0
        public string FullName
        {
            get { return ChristianName + " " + LastName; }
        }

        //C# 6.0
        public string CoolName => ChristianName + " " + LastName;
    }
}
