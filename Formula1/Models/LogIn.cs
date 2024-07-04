using System.Runtime.CompilerServices;

namespace Formula1.Models
{
    public class SignIn
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class Register : UserInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
