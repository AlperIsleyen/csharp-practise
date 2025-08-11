namespace Inheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Customer { FirstName = "Alper", LastName = "İşleyen", Id = 1, CustomerNumber = "C123" },
                new Student { FirstName = "Ayşe", LastName = "Demir", Id = 2, StudentNumber = "S456" },
                new Person { FirstName = "Mehmet", LastName = "Yılmaz", Id = 3 }
            };

            foreach (var person in persons)
            {
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Id: {person.Id}");
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }

    class Customer : Person
    {
        public string? CustomerNumber { get; set; }
    }

    class Student : Person
    {
        public string? StudentNumber { get; set; }
    }
}