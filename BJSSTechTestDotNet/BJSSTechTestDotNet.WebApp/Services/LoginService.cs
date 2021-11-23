using BJSSTechTestDotNet.WebApp.Models;

namespace BJSSTechTestDotNet.WebApp.Services
{
	public class LoginService : ILoginService
    {
        public bool CheckCredentials(User user)
        {
            return user.UserName == "interviewee@bjss.com" && user.Password == "Test123";
        }
    }
}
