namespace File_Practice.Model
{
    internal class Students
    {
        public Students(int id, string name, decimal amount, DateTime due, PaymentStatus status, int teacherID)
        {
            Id = id;
            Name = name;
            Amount = amount;
            Due = due;
            this.status = status;
            TeacherID = teacherID;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime Due {  get; set; }
        public PaymentStatus status { get; set; }
        public int TeacherID { get; set; }
        public override string ToString()
        {
            return $"{Id},{Name},{Amount},{Due},{status},{TeacherID}";
        }
    }
}
