using File_Practice.Model;

namespace File_Practice.FileHandling
{
    internal class FileOperation
    {
        private string _loginCsv = @"C:\Users\velmo\source\repos\File_Practice\File_Practice\FileHandling\Login.csv";
        private string _teachersCsv = @"C:\Users\velmo\source\repos\File_Practice\File_Practice\FileHandling\Teachers.csv";
        private string _studentsCsv = @"C:\Users\velmo\source\repos\File_Practice\File_Practice\FileHandling\Students.csv";

        public void WriteLogin()
        {
            try
            {
                using StreamWriter sw = new StreamWriter(_loginCsv);
                foreach (var item in Records.teachersId)
                {
                    sw.WriteLine(item.ToString());
                }
            }
            catch
            {
                Console.WriteLine("File Error");
            }
        }

        public void ReadLogin()
        {
            try
            {
                using StreamReader sr = new StreamReader(_loginCsv);
                string? line;
                do
                {
                    line = sr.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] data = line.Split(",",3);
                    string UserName = data[0];
                    string Password = data[1];
                    int Id = int.Parse(data[2]);
                    Records.teachersId.Add(new TeachersLogin(
                        UserName,
                        Password,
                        Id));
                } while (line!=null);
            }
            catch
            {
                Console.WriteLine("File error");
            }
        }
        public void WriteTeacher()
        {
            try
            {
                using StreamWriter sw = new StreamWriter(_teachersCsv);
                foreach (var item in Records.teachers)
                {
                    sw.WriteLine(item.ToString());
                }
            }
            catch
            {
                Console.WriteLine("File Error");
            }
        }
        public void ReadTeacher()
        {
            try
            {
                using StreamReader sr = new StreamReader(_teachersCsv);
                string? line;
                do
                {
                    line = sr.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] data = line.Split(",",2);
                    int Id = int.Parse(data[0]);
                    string Name = data[1];
                    Records.teachers.Add(new Teachers(
                        Id,
                        Name));
                } while (line!=null);
            }
            catch
            {
                Console.WriteLine("File Error");
            }
        }
        public void WriteStudent()
        {
            try
            {
                using StreamWriter sw = new StreamWriter(_studentsCsv);
                foreach (var item in Records.students)
                {
                    sw.WriteLine(item.ToString());
                }
            }
            catch
            {
                Console.WriteLine("File Error");
            }
        }
        public void ReadStudent()
        {
            try
            {
                using StreamReader sr = new StreamReader(_studentsCsv);
                string? line;
                do
                {
                    line = sr.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] data = line.Split(",",6);
                    int Id = int.Parse(data[0]);
                    string Name = data[1];
                    decimal Amount = decimal.Parse(data[2]);
                    DateTime Due = DateTime.Parse(data[3]);
                    PaymentStatus status = PaymentStatus.Paid; // should change
                    int TeacherID = int.Parse(data[5]);
                    Records.students.Add(new Students(
                        Id,
                        Name,
                        Amount,
                        Due,
                        status,
                        TeacherID));
                } while (line!=null);
            }
            catch
            {
                Console.WriteLine("File Error");
            }
        }
    }
}
