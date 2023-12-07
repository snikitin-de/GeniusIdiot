using Newtonsoft.Json;

namespace Common.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public User() { }

        public User(string firstName) : this(firstName, string.Empty, string.Empty)
        {
            FirstName = firstName;
        }

        public User(string firstName, string lastName) : this(firstName, lastName, string.Empty)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        [JsonConstructor]
        public User(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }

        public string GetFullName()
        {
            if (string.IsNullOrEmpty(LastName))
            {
                return FirstName;
            }
            else if (string.IsNullOrEmpty(MiddleName))
            {
                return $"{LastName} {FirstName}";
            }
            else
            {
                return $"{LastName} {FirstName} {MiddleName}";
            }
        }
    }
}
