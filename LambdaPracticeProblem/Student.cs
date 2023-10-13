namespace LambdaPracticeProblem
{
    internal class Student
    {
        public int Id;
        public string Name;
        public string PhoneNumber;
        public string Address;
        public int Age;
        public int TotalMarks;

        public Student(int Id, string Name, string PhoneNumber, string Address, int Age, int TotalMarks)
        {
            this.Id = Id;
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Age = Age;
            this.TotalMarks = TotalMarks;
        }
        public override string ToString()
        {
            return $"{Id} {Name} {PhoneNumber} {Address} {Age} {TotalMarks}";
        }
    }
}
