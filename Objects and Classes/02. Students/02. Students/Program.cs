namespace _02._Students
{
    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] studentDate = command.Split(" ");
                string firstName = studentDate[0];
                string lastName = studentDate[1];
                int age = int.Parse(studentDate[2]);
                string homeTown = studentDate[3];

                Student currentStudent = new Student(
                    firstName,
                    lastName,
                    age,
                     homeTown);

                students.Add(currentStudent);

                command = Console.ReadLine();
            }

            string targetCity = Console.ReadLine();

            List<Student> filteredStudens = students
                .Where((student) => student.HomeTown == targetCity)
                .ToList();

            foreach (Student student in filteredStudens)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

    }
}

