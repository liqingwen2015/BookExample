namespace _08过滤器
{
    internal class Person
    {
        public Person(string name, string gender, string maritalStatus)
        {
            Name = name;
            Gender = gender;
            MaritalStatus = maritalStatus;
        }

        public string Name { get; }

        public string Gender { get; }

        public string MaritalStatus { get; }
    }
}