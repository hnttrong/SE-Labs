using System.Linq;

namespace DAL
{
    public class UserRepository
    {
        public bool ValidateLogin(string username, string password)
        {
            using (var context = new Lab4DbContext())
            {
                return context.Users.Any(user =>
                    user.Username == username && user.Password == password);
            }
        }
    }
}
