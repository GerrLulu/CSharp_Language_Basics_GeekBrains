using System.Text;
using System.Xml.Serialization;

namespace Students
{
    class Student
    {
        public string firstName;
        public string secondName;
        public string university;
        public string faculty;
        public string department;
        public int age;
        public int course;
        public int group;
        public string city;

        public Student(string firstName, string secondName, string university, string faculty, string department,
            int age, int course, int group, string city)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.age = age;
            this.course = course;
            this.group = group;
            this.city = city;
        }
    }


    public class Program
    {
        static int SortAgeCourse(Student student1, Student student2)
        {
            if (student1.age > student2.age)
                return 1;
            if (student1.age < student2.age)
                return -1;
            if (student1.course > student2.course)
                return 1;
            if (student1.course < student2.course)
                return -1;
            return 0;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(@"Задание 5.
                **Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).");
            Console.ReadLine();
            Console.Clear();

            List<Student> students = new List<Student>();

            Console.WriteLine("Введите названия файла CSV.");
            string nameFileCSV = Console.ReadLine();
            nameFileCSV = nameFileCSV + ".csv";
            StreamReader sr = new StreamReader("..\\..\\" + nameFileCSV, Encoding.GetEncoding(1251));

            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');

                    students.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]),
                        int.Parse(s[7]), s[8]));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!\nДля выхода из программы нажмите кнопку 'ESC'.");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                        return;
                }
            }
            sr.Close();
            students.Sort(new Comparison<Student>(SortAgeCourse));

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            Console.WriteLine("Введите названия файла XML.");
            string nameFileXML = Console.ReadLine();
            var stream = new FileStream("..\\..\\" + nameFileXML, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(stream, students);
            stream.Close();
        }
    }
}