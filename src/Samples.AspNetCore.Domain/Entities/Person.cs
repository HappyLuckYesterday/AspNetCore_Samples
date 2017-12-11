namespace Samples.AspNetCore.Domain.Entities
{
    public class Person
    {        
        public Person(string firstName,
                     string lastName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public string FirstName { get; set; }
        public string LastName { get; }
    }
}
