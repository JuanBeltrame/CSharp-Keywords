namespace Class___Practice_01__Library_
{
    public class Person
    {
        public string Name { get;  }
        public int Age { get; }
        public string Address { get; set; }

        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is: {Name}");
        }
    }
}
