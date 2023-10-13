namespace LambdaPracticeProblem
{
    internal class Data
    {
        List<Student> contacts;
        public Data()
        {
            contacts = new List<Student>();
        }
        public void AddContact(int Id, string Name, string PhoneNumber, string Address, int Age, int TotalMarks)
        {
            Student details = new Student(Id, Name, PhoneNumber, Address, Age, TotalMarks);
            contacts.Add(details);
            DisplayContacts();
        }

        public void DisplayContacts()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine("Student Id: " + contact.Id);
                Console.WriteLine("Student Name: " + contact.Name);
                Console.WriteLine("Phone Number: " + contact.PhoneNumber);
                Console.WriteLine("Address: " + contact.Address);
                Console.WriteLine("Student Age: " + contact.Age);
                Console.WriteLine("Student Age: " + contact.TotalMarks);
            }
        }
        public void Age()
        {
            var ageFilteredStudents = contacts.Where(x => x.Age >= 12 && x.Age <= 18);
            Console.WriteLine("\nStudents aged between 12 and 18:");
            foreach (var student in ageFilteredStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
        }
        public void TotalMark()
        {
            var sortedStudents = contacts.OrderByDescending(x => x.TotalMarks).ToList();
            Console.WriteLine("\nStudents sorted by TotalMarks (descending order):");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, TotalMarks: {student.TotalMarks}");
            }
        }
        public void StudentByAddress()
        {
            var groupedStudents = contacts.GroupBy(x => x.Address);

            foreach (var group in groupedStudents)
            {
                foreach (var student in group)
                {
                    Console.WriteLine($"Name: {student.Name}");
                }
                Console.WriteLine($"Address: {group.Key}");
                Console.WriteLine();
            }
        }
        public void FirstThreeStudent()
        {
            var firstThreeStudents = contacts.Take(3).ToList();
            Console.WriteLine("\nFirst three students:");
            foreach (var student in firstThreeStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
            }
        }
        public void SearchByName(string userData)
        {

            var searchResult = contacts.FindAll(x => x.Name == userData);
            if (searchResult.Count != 0)
            {
                foreach (var item in searchResult)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("No student found for this name");
            }
        }
    }
}
