using Common.Models;

namespace GeniusIdiotConsoleApp
{
    public class UserStorage
    {
        public static User GetUser()
        {
            var user = new User();
            var userFullName = QuizIO.GetFullName();

            switch (userFullName.Count)
            {
                case 1: user = new User(userFullName["FirstName"]); break;
                case 2: user = new User(userFullName["LastName"], userFullName["FirstName"]); break;
                case 3: user = new User(userFullName["LastName"], userFullName["FirstName"], userFullName["MiddleName"]); break;
            }

            return user;
        }
    }
}
