using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator calculator = new Calculator();
                calculator.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Umumiy xatolik: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nDastur tugadi.");
            }
        }
    }

    class Calculator
    {
        public void Start()
        {
            ShowInfo();

            Console.Write("2.Murakkab (Logarifm/Daraja)\n(tanlash: 1 / 2)\nJavobingiz: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (userChoice == 1)
                SimpleOperations();
            else if (userChoice == 2)
                ComplexOperations();
            else
                Console.WriteLine("Faqat 1 yoki 2 tanlang!");
        }

        private void ShowInfo()
        {
            Console.WriteLine("\nCalstring dasturiga xush kelisiz!");
            Console.WriteLine("1. Oddiy (+ - * /)");
        }

        private void SimpleOperations()
        {
            try
            {
                Console.Write("1-son: ");
                decimal son1 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("2-son: ");
                decimal son2 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("\n1.+  2.-  3.*  4./ \nJavobingiz: ");
                int op = Convert.ToInt32(Console.ReadLine());

                decimal result = 0;

                switch (op)
                {
                    case 1:
                        result = son1 + son2;
                        break;
                    case 2:
                        result = son1 - son2;
                        break;
                    case 3:
                        result = son1 * son2;
                        break;
                    case 4:
                        if (son2 == 0)
                            throw new DivideByZeroException();
                        result = son1 / son2;
                        break;
                    default:
                        Console.WriteLine("Noto‘g‘ri operator!");
                        return;
                }

                Console.WriteLine("Natija: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Son noto‘g‘ri formatda kiritildi!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("0 ga bo‘lish mumkin emas!");
            }
        }

        private void ComplexOperations()
        {
            try
            {
                Console.Write("1-son: ");
                double son1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("2-son: ");
                double son2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\n1.Logarifm  2.Daraja\nJavobingiz: ");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        if (son1 <= 0 || son2 <= 0 || son2 == 1)
                        {
                            Console.WriteLine("Logarifm uchun noto‘g‘ri qiymatlar!");
                            return;
                        }
                        double logResult = Math.Log(son1, son2);
                        Console.WriteLine("Natija: " + logResult);
                        break;

                    case 2:
                        Console.WriteLine("1-son kvadrati: " + Math.Pow(son1, 2));
                        Console.WriteLine("2-son kvadrati: " + Math.Pow(son2, 2));
                        break;

                    default:
                        Console.WriteLine("Noto‘g‘ri operator!");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Son noto‘g‘ri formatda kiritildi!");
            }
        }
    }
}
