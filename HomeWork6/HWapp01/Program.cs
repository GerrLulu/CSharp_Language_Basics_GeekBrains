using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HWapp01
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


    /// <summary>
    /// Делегат для решения задачи Task01.
    /// </summary>
    /// <param name="a">Параметр a</param>
    /// <param name="x">Параметр x</param>
    /// <returns></returns>
    public delegate double Fun(double a, double x);
    /// <summary>
    /// Делегат для решения задачи Task02.
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns>Параметр имя файла</returns>
    public delegate double Function(double x);


    class Program
    {
        /// <summary>
        /// Метод принимающий делегат и выводящий результат.
        /// </summary>
        /// <param name="F">Метод с сигнатурой (double, double)</param>
        /// <param name="a">Параметр а</param>
        /// <param name="x">Параметр х</param>
        /// <param name="b">Параметр b</param>
        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("------ A ------- X ------- Y ------");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------------------");
        }

        /// <summary>
        /// Метод возвращает значение функции функции a*x^2
        /// </summary>
        /// <param name="a">Параметр а</param>
        /// <param name="x">Параметр х</param>
        /// <returns></returns>
        public static double MyFunc(double a, double x)
        {
            return a * x * x;
        }

        /// <summary>
        /// Метод возвращает значение функции функции a*sin(x)
        /// </summary>
        /// <param name="a">Параметр а</param>
        /// <param name="x">Параметр х</param>
        /// <returns></returns>
        public static double MyFunc2(double a, double x)
        {
            return a * Math.Sin(x);
        }

        /// <summary>
        /// Метод для сравнения экземпляров
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Медот записи функций двоичным потоком
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="start">Начальное значение</param>
        /// <param name="end">Конечное значение</param>
        /// <param name="step">Шаг</param>
        /// <param name="fun">Делегат функции</param>
        public static void SaveFunc(string fileName, double start, double end, double step, Function fun)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            while (start <= end)
            {
                bw.Write(fun(start));
                start += step;
            }
            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Метод считывания значений из файла и находит минимальное значение
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="min">Минимальное значение</param>
        /// <returns></returns>
        public static double Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                if (d < min)
                    min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        /// <summary>
        /// Метод для вычесления функции
        /// </summary>
        /// <param name="x">Параметр х</param>
        /// <returns></returns>
        public static double MyFun (double x)
        {
            return x * x - 50 * x + 10;
        }

        /// <summary>
        /// Метод для вычесления функции
        /// </summary>
        /// <param name="x">Параметр х</param>
        /// <returns></returns>
        public static double Cos (double x)
        {
            return Math.Cos(x);
        }

        /// <summary>
        /// Метод для вычесления функции
        /// </summary>
        /// <param name="x">Параметр х</param>
        /// <returns></returns>
        public static double Sin (double x)
        {
            return Math.Sin(x);
        }

        /// <summary>
        /// Метод для вычесления функции
        /// </summary>
        /// <param name="x">Параметр х</param>
        /// <returns>Параметр х</returns>
        public static double MyDegree (double x)
        {
            return x * x;
        }

        /// <summary>
        /// Метод проверки ввода
        /// </summary>
        /// <param name="max">Максимальное значение, которое может ввести пользователь</param>
        /// <returns></returns>
        static int GetNum(int max)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int x) || x > max)
                    Console.Write("Неверный ввод (требуется числовое значение от 0 до {0}).\nПожалуйста повторите ввод: ", max);
                else return x;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Задания выполнил студент: Демин Артем.");
            Console.ReadLine();
            Console.Clear();

            #region Task01
            Console.WriteLine(@"Задание 1.
                Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
                Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Введите значение a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите значение b: ");
            double b = double.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine(@"Значение b должно быть больше или равно значению x.");

                Console.Write("Введите значение x: ");
                x = double.Parse(Console.ReadLine());

                Console.Write("Введите значение b: ");
                b = double.Parse(Console.ReadLine());
            }
            while (x > b);

            Console.WriteLine("Таблица функции a*x^2: ");
            Table(MyFunc, a, x, b);

            Console.WriteLine("Таблица функции a*sin(x): ");
            Table(MyFunc2, a, x, b);

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Task02
            Console.WriteLine(@"Задание 2.
                Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
                а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке
                находить минимум. Использовать массив (или список) делегатов, в котором хранятся различные функции.
                б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум
                через параметр (с использованием модификатора out).

                Написать программу сохранения результатов вычисления заданной функции в файл для дальнейшей обработки файла.
                Разбить программу на две функции: одна записывает данные функции в файла на промежутке от a до b с шагом h,
                а другая считывает данные и находит минимум функции.");
            Console.ReadLine();
            Console.Clear();

            List<Function> functions = new List<Function> {new Function(MyFun), new Function(Cos), new Function(Sin), new Function(MyDegree) };
            Console.WriteLine("Выберите функцию для дальнейшей работы.");
            Console.WriteLine("1) f(x)=y^2-50*y+10");
            Console.WriteLine("2) f(x)=Cos(y)");
            Console.WriteLine("3) f(x)=Sin(y)");
            Console.WriteLine("4) f(x)=y^2");
            int userChoose = GetNum(functions.Count);

            Console.Write("Ввидите значение начала отрезка: ");
            double start = double.Parse(Console.ReadLine());
            Console.Write("Ввидите значение конца отрезка отрезка: ");
            double end = double.Parse(Console.ReadLine());

            Console.Write("Задайте величинау шага дискредитирования: ");
            double step = double.Parse(Console.ReadLine());

            Console.Write("Введите имя файла: ");
            string flNm = Console.ReadLine();
            flNm = flNm + ".bin";

            SaveFunc(flNm, start, end, step, functions[userChoose - 1]);
            double min = double.MaxValue;

            Console.WriteLine(Load(flNm, out min));

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Task03
            Console.WriteLine(@"Задание 3.
                Переделать программу Пример использования коллекций для решения следующих задач:
                а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
                б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
                в) отсортировать список по возрасту студента;
                г) *отсортировать список по курсу и возрасту студента;");
            Console.ReadLine();
            Console.Clear();

            int fifthCourse = 0;
            int sixthCourse = 0;

            ArrayList listAge = new ArrayList();

            List<Student> students = new List<Student>();

            StreamReader sr = new StreamReader("..\\..\\students.csv", Encoding.GetEncoding(1251));

            //int N = int.Parse(sr.ReadLine());
            //int[] count = new int[N];
            int[] count = new int[7];

            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');

                    if (int.Parse(s[6]) == 5)
                        fifthCourse++;
                    if (int.Parse(s[6]) == 6)
                        sixthCourse++;

                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20)
                        count[int.Parse(s[6])]++;

                    listAge.Add("Возраст студента: " + int.Parse(s[5]) + "; Студент: " + s[1] + " " + s[0]);

                    students.Add(new Student (s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]),
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
            listAge.Sort();
            students.Sort(new Comparison<Student>(SortAgeCourse));


            Console.WriteLine("Кол-во студентов 5-го курса: {0}", fifthCourse);
            Console.WriteLine("Кол-во студентов 6-го курса: {0}", sixthCourse);

            Console.WriteLine("=======================================================");

            for (int i = 1; i < count.Length; i++)
            {
                if (count[i] > 0)
                    Console.WriteLine($"Курс: {i}; кол-во студентов: {count[i]}");
            }

            Console.WriteLine("=======================================================");

            foreach (object v in listAge)
                Console.WriteLine(v);

            Console.WriteLine("=======================================================");

            foreach (Student f in students)
                Console.WriteLine($"Возраст: {f.age}; курс: {f.course}; студент: {f.secondName} {f.firstName}");

            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}