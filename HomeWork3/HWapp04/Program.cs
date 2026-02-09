using System;

namespace HWapp04
{
    class Fraction
    {
        /// <summary>
        /// Числитель
        /// </summary>
        private int _numerator;
        /// <summary>
        /// Знаменатель
        /// </summary>
        private int _denominator;

        public int Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }
        public int Denominator
        {
            get { return _denominator; }
            set { _denominator = value; }
        }
        public double Decimal
        {
            get { return ((double)_numerator / (double)_denominator); }
        }


        public Fraction()
        {
            Normalization();
        }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new Exception("Знаменатель не может быть равен 0");
            this._numerator = numerator;
            this._denominator = denominator;
            Normalization();
        }


        public Fraction Plus(Fraction other)
        {
            Fraction result = new Fraction(_numerator * other._denominator + other._numerator * _denominator,
                _denominator * other._denominator);
            return result;
        }

        public Fraction Minus(Fraction other)
        {
            Fraction result = new Fraction(_numerator * other._denominator - other._numerator * _denominator,
                _denominator * other._denominator);
            return result;
        }

        public Fraction Multiplication(Fraction other)
        {
            Fraction result = new Fraction(_numerator * other._numerator, _denominator * other._denominator);
            return result;
        }

        public Fraction Division(Fraction other)
        {
            Fraction result = new Fraction(_numerator * other._denominator, _denominator * other._numerator);
            return result;
        }

        private void Normalization()
        {
            var numerator = Math.Abs(_numerator);
            var dennominator = Math.Abs(_denominator);
            int temp;

            while (numerator != 0 && dennominator != 0)
            {
                if (numerator % dennominator > 0)
                {
                    temp = numerator;
                    numerator = dennominator;
                    dennominator = temp % dennominator;
                }
                else
                    break;
            }

            if (numerator != 0 && dennominator != 0)
            {
                _numerator = _numerator / dennominator;
                _denominator = _denominator / dennominator;
            }
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задания выполнил студент: Демин Артем.");

            Console.WriteLine("Задание 3.\n*Описать класс дробей — рациональных чисел, являющихся отношением двух целых" +
                " чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, " +
                "демонстрирующую все разработанные элементы класса.\nДобавить свойства типа int для доступа к числителю" +
                " и знаменателю;\nДобавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;" +
                " **Добавить проверку, чтобы знаменатель не равнялся 0.\nВыбрасывать исключение " +
                "ArgumentException('Знаменатель не может быть равен 0'); ***Добавить упрощение дробей.");
            Console.ReadLine();
            Console.Clear();

            Fraction fraction01 = EnteringValues(1);
            Fraction fraction02 = EnteringValues(2);
            Console.Clear();

            Console.WriteLine($"Сумма дроби {fraction01} и дроби {fraction02} равна: {fraction01.Plus(fraction02)}");
            Console.WriteLine($"\nРазность дроби {fraction01} и дроби {fraction02} равна: " +
                $"{fraction01.Minus(fraction02)}");
            Console.WriteLine($"\nПроизведение дроби {fraction01} на дробь {fraction02} равно: " +
                $"{fraction01.Multiplication(fraction02)}");
            Console.WriteLine($"\nДеление дроби {fraction01} на дробь {fraction02} равно: " +
                $"{fraction01.Division(fraction02)}");
            Console.ReadKey();
            Console.Clear();

            double fr01 = fraction01.Decimal;
            double fr02 = fraction02.Decimal;
            Console.WriteLine($"Десятичное отображение первой дроби: {fr01:F2}; и второй дроби: {fr02:F2}");

            Console.ReadKey();
        }

        static Fraction EnteringValues(int num)
        {
            Fraction fraction = new Fraction();

            Console.Write($"Введите числитель {num}-го дробного числа: ");
            fraction.Numerator = int.Parse(Console.ReadLine());

            Console.Write($"Введите знеаменатель {num}-го дробного числа: ");
            fraction.Denominator = int.Parse(Console.ReadLine());
            if (fraction.Denominator == 0)
                throw new Exception("Знаменатель не может быть равен 0");

            return fraction;
        }
    }
}