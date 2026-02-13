using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace HWapp01
{
    struct Info
    {
        /// <summary>
        /// Имена и Фамилии учеников
        /// </summary>
        public string FIO;
        /// <summary>
        /// Средняя оценка
        /// </summary>
        public double mark;
    }


    /// <summary>
    /// Статический класс для обработки текста
    /// </summary>
    static class Message
    {
        /// <summary>
        /// Mетоды для очистки текста от лишних символов
        /// </summary>
        /// <param name="letter">Заданное сообщение</param>
        /// <returns></returns>
        private static string[] CliningLetter(string letter)
        {
            letter = Regex.Replace(letter, "[-.?!)(,:;]", "");
            string[] ltr = Regex.Split(letter, "[ ]");
            int count = 0;
            bool[] indexToDelet = new bool[ltr.Length];

            for (int i = 0; i < ltr.Length; i++)
            {
                if (ltr[i] == "")
                {
                    indexToDelet[i] = true;
                    count++;
                }
                else
                    indexToDelet[i] = false;
            }

            string[] newLtr = new string[ltr.Length - count];

            for (int i = 0, j = 0; i < ltr.Length; i++)
            {
                if (indexToDelet[i] == false)
                {
                    newLtr[j] = ltr[i];
                    j++;
                }
            }
            
            return ltr;
        }

        /// <summary>
        /// Mетоды для вывода только тех слов сообщения, которые содержат не более n букв.
        /// </summary>
        /// <param name="letter">Заданное сообщение</param>
        /// <param name="numWrd">Кол-во букв</param>
        /// <returns></returns>
        public static string DeletWordNum(string letter, int numWrd)
        {
            string[] ltr = CliningLetter(letter);
            string letterBack = "";

            for (int i = 0; i < ltr.Length; i++)
            {
                if (ltr[i].Length <= numWrd)
                    letterBack = letterBack + $"{ltr[i]} ";
            }

            return letterBack;
        }

        /// <summary>
        /// Метод, который удаляет из сообщения все слова, которые заканчиваются на заданный символ
        /// </summary>
        /// <param name="letter">Заданное сообщение</param>
        /// <param name="symb">Заданный символ</param>
        /// <returns></returns>
        public static string DeletWordSymbol(string letter, char symb)
        {
            string[] ltr = CliningLetter(letter);
            string letterBack = "";

            for (int i = 0; i < ltr.Length; i++)
            {
                if (symb != ltr[i][ltr[i].Length - 1])
                    letterBack = letterBack + $"{ltr[i]} ";
            }
                
            return letterBack;
        }

        /// <summary>
        /// Метод по нахождению, самого длинного слово сообщения
        /// </summary>
        /// <param name="letter">Заданное сообщение</param>
        /// <returns></returns>
        public static string LongWord(string letter)
        {
            string[] ltr = CliningLetter(letter);
            string max = "";

            for (int i = 0; i < ltr.Length; i++)
            {
                if (ltr[i].Length > max.Length)
                    max = ltr[i];
            }
                
            return max;
        }

        /// <summary>
        /// Метод для формирования строки с помощью StringBuilder из самых длинных слов сообщения.
        /// </summary>
        /// <param name="letter">Заданное сообщение</param>
        /// <returns></returns>
        public static string LongWords(string letter)
        {
            string[] ltr = CliningLetter(letter);
            StringBuilder res = new StringBuilder();
            string result = "";
            int max = LongWord(letter).Length;

            foreach(string word in ltr)
            {
                if (word.Length == max)
                    result = res.Append(word + " ").ToString();
            }

            return result;
        }
    }


    class Program
    {
        private static Regex _checkLogin = new Regex(@"^[a-zA-z][a-zA-z+0-9]{1,9}");

        /// <summary>
        /// Метод определенния корректности введенного логина
        /// </summary>
        /// <param name="login">Логин</param>
        /// <returns></returns>
        static bool CheckLogin(string login)
        {
            char[] lgn = login.ToCharArray();
            int numSymbol;

            if (lgn.Length >= 2 && lgn.Length <= 10)
            {
                if (Char.IsDigit(lgn[0]) == false)
                {
                    for (int i = 0; i < lgn.Length; i++)
                    {
                        numSymbol = lgn[i];
                        if ((numSymbol >= 65 && numSymbol <= 90) || (numSymbol >= 97 && numSymbol <= 122))
                            return true;
                    }
                }
            }
                
            return false;
        }

        /// <summary>
        /// Метод определенния корректности введенного логина с использованием регулярных выражений
        /// </summary>
        /// <param name="login">Логин</param>
        /// <returns></returns>
        static bool CheckLoginRegular(string login)
        {
            if (_checkLogin.IsMatch(login) == true)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Метод, который определяет является ли одна строка перестановкой другой
        /// </summary>
        /// <param name="line1">Первая строка</param>
        /// <param name="line2">Вторая строка</param>
        /// <returns></returns>
        static bool Comparison(string line1, string line2)
        {
            int[] letter = new int[256];
            char[] l1 = line1.ToCharArray();

            if (line1.Length != line2.Length)
                return false;

            foreach (char c in l1)
                letter[c]++;

            for(int j = 0; j < line2.Length; j++)
            {
                int c = (int)line2[j];
                if (--letter[c] < 0)
                    return false;
            }
            return true;

            /*line1 = new string(line1.Distinct().ToArray()); //Убираем повторяющиеся символы
            line2 = new string(line2.Distinct().ToArray());
            int count = 0;
            for (int i = 0; i < line1.Length; i++)
                for (int j = 0; j < line2.Length; j++)
                    if (line1[i] == line2[j])
                        count++;
            if (line1.Length == count && line2.Length == count)
                return true;
            else
                return false;*/
        }

        static void Sort (ref Info[] info)
        {
            for (int i = 0; i < info.Length; i++)
            {
                for (int j = 0; j < info.Length - i - 1; j++)
                {
                    if (info[j].mark > info[j + 1].mark)
                    {
                        Info n = info[j + 1];
                        info[j + 1] = info[j];
                        info[j] = n;
                    }
                }
            }
        }

        private static int GetNumeral()
        {
            {
                while (true)
                    if (!int.TryParse(Console.ReadLine(), out int x))
                        Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: ");
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
                Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10
                символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
                а) без использования регулярных выражений;
                б) **с использованием регулярных выражений.");
            Console.ReadLine();
            Console.Clear();

            bool flag = false;
            Console.WriteLine(@"К логину есть несколько требований: строка должна быть от 2 до 10 символов,
                содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первым символом.");

            while(flag == false)
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                if (CheckLoginRegular(login) == true && (CheckLogin(login) == true))
                {
                    Console.WriteLine("Вы ввели корректный логин.");
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректный логин. Попробуйте еще раз.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Task02
            Console.WriteLine(@"Задание 2.
                Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
                а) Вывести только те слова сообщения, которые содержат не более n букв.
                б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
                в) Найти самое длинное слово сообщения.
                г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.");
            Console.ReadLine();
            Console.Clear();
            
            Console.Write("Введите текст сообщение: ");
            string letter = Console.ReadLine();

            Console.Write("Введите кол-во букв, которые необходимо для вывода: ");
            int numWrd = GetNumeral();

            Console.WriteLine($"Вывод слов сообщения, которые содержат не более {numWrd} букв: " +
                $"{Message.DeletWordNum(letter, numWrd)}");
            Console.ReadLine();

            Console.Write("Введите символ в конце слова из-за которого будут удалены слова: ");
            char lastSymb = char.Parse(Console.ReadLine());

            Console.WriteLine($"Вывод слова сообщения, которые не заканчиваются на символ {lastSymb}: " +
                $"{Message.DeletWordSymbol(letter, lastSymb)}");
            Console.ReadLine();

            Console.WriteLine($"Самое длинное слово сообщения: {Message.LongWord(letter)}");
            Console.ReadLine();

            Console.WriteLine($"Строка из самых длинных слов сообщения: {Message.LongWords(letter)}");
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Task03
            Console.WriteLine(@"Задание 3.
                Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
                Например: badc являются перестановкой abcd.");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Введите текст первой строки: ");
            string line01 = Console.ReadLine();

            Console.Write("Введите текст второй строки: ");
            string line02 = Console.ReadLine();
            
            if(Comparison(line01, line02) == true)
                Console.WriteLine("Строки являются перестановкой друг друга.");
            else
                Console.WriteLine("Строки не являются перестановкой друг друга.");

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Task04
            Console.WriteLine(@"Задание 4.
                Задача ЕГЭ.
                На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.
                В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая
                из следующих N строк имеет следующий формат:

                <Фамилия> <Имя> <оценки>,

                где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем
                из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе.
                <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки:

                Иванов Петр 4 5 3

                Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена
                трёх худших по среднему баллу учеников. Если среди остальных есть ученики, набравшие тот же средний балл, что
                и один из трёх худших, следует вывести и их фамилии и имена.");
            Console.ReadLine();
            Console.Clear();

            int n = 3; //кол-во выводимых учеников с одинаковыми средними балами
            
            Console.Write("Введите название файла со списком: ");
            string fileName = Console.ReadLine();

            Info[] info = new Info[90]; //100 - 10 = 90;

            StreamReader streamReader = new StreamReader("..\\..\\" + fileName);
            int N = int.Parse(streamReader.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] s = streamReader.ReadLine().Split(' ');
                info[i].FIO = s[0] + " " + s[1];
                info[i].mark = (double.Parse(s[2]) + double.Parse(s[3]) + double.Parse(s[4])) / 3;
            }
            streamReader.Close();

            Sort(ref info);

            Info prev = info[0];

            String result = String.Format("{0,-20} {1,-10}\n\n", "Ученик", "Средний балл");

            for (int j = 0; j < n; j++)
            {
                if (j > 0)
                {
                    if (prev.mark == info[j].mark)
                        n++;
                    prev = info[j];
                }

                result += String.Format("{0,-20} {1,-10:F2}\n", info[j].FIO, info[j].mark);
            }

            Console.WriteLine($"\n{result}");

            Console.ReadLine();
            Console.Clear();
            #endregion
        }
    }
}