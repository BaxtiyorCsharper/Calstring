
static void CalstringInfo()
{
    Console.WriteLine("\nCalstring dasturiga xush kelisiz!");
    Console.WriteLine("Siz ikkita son kiritasiz va bitta operator kiritasiz.");
    Console.WriteLine("Kiritilgan son va operatorga qarab dastur natija chiqaradi\n");
    Console.WriteLine("Quyidagi amallardan birini tanlang:");
    Console.WriteLine("1.Oddiy(+ - * /)");
}

CalstringInfo();

Console.Write("2.Murrakkab(Logorifm/darajaga chiqarish)\n(tanlash: 1 / 2)\nJavobingiz:");
int userChoice = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (userChoice == 1)
{
    Console.WriteLine("Siz oddiy amallar bajarishni tanladingiz!");
    Console.WriteLine("Ikkita son kiritng:");
    Console.Write("1-son:");
    decimal son1 = Convert.ToDecimal(Console.ReadLine());
    Console.Write("2-son:");
    decimal son2 = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Operatorni tanlang:");
    Console.Write("1.+  2.-  3.*  4./ \n(tanlash:1/2/3/4)\nJavobingiz:");
    int oddiyOperator = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (oddiyOperator == 1)
    {
        Console.WriteLine("Siz qo'shish operatorini tanladingiz");
        decimal result = son1 + son2;
        Console.WriteLine("natija:" + result);
    }
    else if (oddiyOperator == 2)
    {
        Console.WriteLine("Siz ayrish operatorini tanladingiz");
        decimal result = son1 - son2;
        Console.WriteLine("natija:" + result);
    }
    else if (oddiyOperator == 3)
    {
        Console.WriteLine("Siz ko'paytirish operatorini tanladingiz");
        decimal result = son1 * son2;
        Console.WriteLine("natija:" + result);
    }
    else if (oddiyOperator == 4)
    {
        try
        {

            Console.WriteLine("Siz bo'lish operatorini tanladingiz");
            decimal result = son1 / son2;
            Console.WriteLine("natija:" + result);

        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("0 ga bo'lish mumkin emas!");
        }
        finally
        {
            System.Console.WriteLine("\nDastur tugadi");
        }


    }
    else
    {
        Console.WriteLine("noto'g'ri operator kiritildi");
    }
}
else if (userChoice == 2)
{
    System.Console.WriteLine("Siz murakkab amallar bajarishni tanladingiz!");
    Console.WriteLine("Ikkita son kiritng:");
    Console.Write("1-son:");
    double son1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("2-son:");
    double son2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("");
    Console.WriteLine("Operatorni tanlang:");
    Console.Write("1.Logorifm 2.Darajaga chiqarish\n(tanlash: 1 / 2)\nJavobingiz:");
    int murrakkabOperator = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (murrakkabOperator == 1)
    {
        Console.WriteLine("Siz logorifm operatorini tanladingiz");
        double result = Math.Log(son1, son2);
        Console.WriteLine("natija:" + result);
    }
    else if (murrakkabOperator == 2)
    {
        Console.WriteLine("Siz darajaga oshrish operatorini tanladingiz");
        double result1 = Math.Pow(son1, 2);
        double result2 = Math.Pow(son2, 2);
        Console.WriteLine("Birinchi son natijasi:" + result1);
        Console.WriteLine("Ikkinchi son natijasi:" + result2);

    }
}
else
{
    Console.WriteLine("Kechirasiz ikki operatordan birini tanlang!");

}







