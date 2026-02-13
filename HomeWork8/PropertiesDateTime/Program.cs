using System.Reflection;

namespace PropertiesDateTime
{
    class Program
    {
        static PropertyInfo GetPropertyInfo(object obj, string str)
        {
            return obj.GetType().GetProperty(str);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задания выполнил студент: Демин Артем.");

            Console.WriteLine("Задание 1.\nС помощью рефлексии выведите все свойства структуры DateTime.");
            Console.ReadLine();
            Console.Clear();

            DateTime dateTime = new DateTime();

            Console.WriteLine("Свойство Now: " + GetPropertyInfo(dateTime, "Now"));
            Console.WriteLine("Свойство Today: " + GetPropertyInfo(dateTime, "Today"));
            Console.WriteLine("Свойство UtcNow: " + GetPropertyInfo(dateTime, "UtcNow"));
            Console.WriteLine("Свойство Ticks: " + GetPropertyInfo(dateTime, "Ticks"));
            Console.WriteLine("Свойство Second: " + GetPropertyInfo(dateTime, "Second"));
            Console.WriteLine("Свойство Date: " + GetPropertyInfo(dateTime, "Date"));
            Console.WriteLine("Свойство Nanosecond: " + GetPropertyInfo(dateTime, "Nanosecond"));
            Console.WriteLine("Свойство Month: " + GetPropertyInfo(dateTime, "Month"));
            Console.WriteLine("Свойство Minute: " + GetPropertyInfo(dateTime, "Minute"));
            Console.WriteLine("Свойство Millisecond: " + GetPropertyInfo(dateTime, "Millisecond"));
            Console.WriteLine("Свойство Microsecond: " + GetPropertyInfo(dateTime, "Microsecond"));
            Console.WriteLine("Свойство Kind: " + GetPropertyInfo(dateTime, "Kind"));
            Console.WriteLine("Свойство Hour: " + GetPropertyInfo(dateTime, "Hour"));
            Console.WriteLine("Свойство DayOfYear: " + GetPropertyInfo(dateTime, "DayOfYear"));
            Console.WriteLine("Свойство DayOfWeek: " + GetPropertyInfo(dateTime, "DayOfWeek"));
            Console.WriteLine("Свойство Day: " + GetPropertyInfo(dateTime, "Day"));
            Console.WriteLine("Свойство TimeOfDay: " + GetPropertyInfo(dateTime, "TimeOfDay"));
            Console.WriteLine("Свойство Year: " + GetPropertyInfo(dateTime, "Year"));
            Console.ReadKey();
        }
    }
}