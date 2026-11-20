using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginService
    {
        private readonly UserRepository _userRepository;

        public LoginService()
        {
            _userRepository = new UserRepository();
        }

        public bool Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            return _userRepository.ValidateLogin(username, password);
        }
    }
}
