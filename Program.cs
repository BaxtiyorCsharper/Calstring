Console.WriteLine("Calstring dasturiga xush kelisiz!");
Console.WriteLine("Siz ikkita son kiritasiz va bitta operator kiritasiz.");
Console.WriteLine("Kiritilgan son va operatorga qarab dastur natija chiqaradi.");
Console.WriteLine("Quyidagi amallardan birini tanlang:(tanlash 1 yoki 2)");
Console.WriteLine("1.Oddiy(+ - * /)");
Console.WriteLine("2.Murrakkab(Logorifm/darajaga chiqarish)");
int choice = Convert.ToInt32(Console.ReadLine());
if (choice == 1)
{
    Console.WriteLine("Siz oddiy amallar bajarishni tanladingiz!");
    Console.WriteLine("2ta son va bitta operator kiritng:");
    Console.Write("1-son:");
    decimal son1 =Convert.ToDecimal(Console.ReadLine());
    Console.Write("2-son:");
    decimal son2 =Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("1.+  2.-  3.*  4./ (tanlang:1/2/3/4)");
    int OddiyOperator = Convert.ToInt32(Console.ReadLine());
    if (OddiyOperator == 1)
    {
        Console.WriteLine("Siz qo'shish operatorini tanladingiz");
        decimal result = son1 + son2;
        Console.WriteLine("natija:"+result);
    }
    else if (OddiyOperator == 2)
    {
        Console.WriteLine("Siz ayrish operatorini tanladingiz");
        decimal result = son1 - son2;
        Console.WriteLine("natija:"+result);
    }
    else if (OddiyOperator == 3)
    {
        Console.WriteLine("Siz ko'paytirish operatorini tanladingiz");
        decimal result = son1 * son2;
        Console.WriteLine("natija:"+result);
    }
    else if (OddiyOperator == 4)
    {
        Console.WriteLine("Siz bo'lish operatorini tanladingiz");
        decimal result = son1 / son2;
        Console.WriteLine("natija:"+result);
    }
    else
    {
        Console.WriteLine("noto'g'ri operator kiritildi");
    }
}
else if (choice == 2)
{
    System.Console.WriteLine("Siz murakkab amallar bajarishni tanladingiz!");
    Console.WriteLine("2ta son va bitta operator kiritng:");
    Console.Write("1-son:");
    double son1 =Convert.ToDouble(Console.ReadLine());
    Console.Write("2-son:");
    double son2 =Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("1.Logorifm 2.Darajaga chiqarish (tanlash 1 yoki 2)");
    int MurrakkabOperator = Convert.ToInt32(Console.ReadLine());
    if (MurrakkabOperator == 1)
    {
        Console.WriteLine("Siz logorifm operatorini tanladingiz");
        double result = Math.Log(son1, son2);
        Console.WriteLine("natija:"+result);
    }
    else if (MurrakkabOperator == 2)
    {
        Console.WriteLine("Siz darajaga oshrish operatorini tanladingiz");
        double result1 = Math.Pow(son1, 2);
        double result2 = Math.Pow(son2, 2);
        Console.WriteLine("Birinchi son natijasi:"+result1);
        Console.WriteLine("Ikkinchi son natijasi:"+result2);

    }
}
else
{
    Console.WriteLine("Kechirasiz ikki operatordan birini tanlang!");
    
}







