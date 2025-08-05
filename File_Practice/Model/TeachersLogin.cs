namespace File_Practice.Model
{
    internal class TeachersLogin
    {
        public TeachersLogin(string userName, string password, int teacherId)
        {
            UserName = userName;
            Password = password;
            TeacherId = teacherId;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public int TeacherId { get; set; }
        public override string ToString()
        {
            return $"{UserName},{Password},{TeacherId}";
        }
    }
}
