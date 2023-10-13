namespace LambdaPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Student data and display data\n2.Students with age between 12 to 18\n3.Student data of total marks" +
                " \n4.Student records in each address\n5.Data of first three student\n6.Student Search by name\n7.Exit");
            Data data = new Data();
            bool loopAgain = true;
            while (loopAgain)
            {
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        data.AddContact(1, "Shreyas", "9673215173", "Sangli", 18, 99);
                        data.AddContact(2, "Shubham", "9673215173", "Miraj", 15, 100);
                        data.AddContact(3, "Atharv", "9673215173", "Pune", 16, 98);
                        data.AddContact(4, "Kalyan", "9673215173", "Vita", 18, 89);
                        Console.WriteLine("_____________");
                        break;
                    case 2:
                        data.Age();
                        break;
                    case 3:
                        data.TotalMark();
                        Console.WriteLine("_____________");
                        break;
                    case 4:
                        data.StudentByAddress();
                        Console.WriteLine("______________");
                        break;
                    case 5:
                        data.FirstThreeStudent();
                        Console.WriteLine("_____________");
                        break;
                    case 6:
                        data.SearchByName("Kalyan");
                        Console.WriteLine("______________");
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    case 8:
                        loopAgain = false;
                        break;
                }
            }
        }
    }
}