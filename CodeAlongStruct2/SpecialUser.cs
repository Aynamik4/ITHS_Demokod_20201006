namespace CodeAlongStruct2
{
    struct SpecialUser
    {
        public const string Name = "Anna Andersson";
        public string Location { get; set; }
        public int Age { get; set; }

        public SpecialUser(string location, int age)
        {
            Location = location;
            Age = age;
        }

        //public SpecialUser() // Kompilerar inte!
        //{
        //    Location = "sndk";
        //    Age = 1;
        //}
    }
}
