using System.Security.Cryptography;
using System.Text;

namespace BlazorServerAuthenticationAndAuthorization.Authentication
{
    public class UserAccountService
    {
        string pass1 = "admin";

        private List<UserAccount> _users;
        
        public UserAccountService()
        {
           
            _users = new List<UserAccount>
            {
                new UserAccount{ UserName = "admin",Password =pass1 }
               
            };
        }
        
        public UserAccount? GetByUserName(string userName)
        {
            return _users.FirstOrDefault(x => x.UserName == userName);
        }
    }
 
}
