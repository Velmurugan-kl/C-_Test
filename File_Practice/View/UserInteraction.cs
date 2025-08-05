using File_Practice.Helper;
using File_Practice.Model;
namespace File_Practice.View
{
    internal class UserInteraction
    {
        public static void SignUp()
        {
            string Name;
            string UserName;
            string UserPassword;
            int TeacherID;

            do
            {
                Console.WriteLine("Enter your Name");
                Name = Console.ReadLine();
                if (!InputValidator.IsValidName(Name))
                {
                    Console.WriteLine("Enter a valid name");
                    continue;
                }
                break;

            } while (true);

            do
            {
                Console.WriteLine("Enter the userName");
                UserName = Console.ReadLine();
                if (!InputValidator.IsValidUserName(UserName))
                {
                    Console.WriteLine("Enter the valid user name");
                    continue;
                }
                break;
            } while (true);

            do
            {
                Console.WriteLine("Enter the Password");
                UserPassword = Console.ReadLine();
                if (InputValidator.IsValidPassword(UserPassword))
                {
                    Console.WriteLine("Enter the valid password");
                    continue;
                }
                break;
            } while (true);

            do
            {
                Console.WriteLine("Enter your ID");
                TeacherID = int.Parse(Console.ReadLine());
                break;
            } while (true);

            TeachersLogin Tl = new TeachersLogin(UserName, UserPassword, TeacherID);
            Teachers teacher = new Teachers(TeacherID, Name);
        }
    }
}
