class Program
{
    delegate void Duzbucaqli(double x, double y);


    static void Main()
    {
        Duzbucaqli duzbucaq = new Duzbucaqli(perimetr);
        duzbucaq += sahe;

        duzbucaq(5, 8);
        



    }

    

   public static void sahe(double a, double b)
    {
        Console.WriteLine(a*b);
    }

   public static void perimetr(double a, double b)
    {
        Console.WriteLine(2*(a+b));

    }


}



