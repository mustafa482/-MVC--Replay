//A01.

//Console.Write("3 reqemli eded daxil edin: ");
//int num = int.Parse(Console.ReadLine());



//while (num / 10 !=0 || num > 0)
//{
//    int qaliq = num % 10;
//    num = (num - qaliq)/10;

//    Console.Write(qaliq + " ");
//}

//A02.

//Console.WriteLine("Iki eded daxil edin: ");

//int num1 = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());

//Console.WriteLine(num1 + " " + num2);

//int num3 = num1;
//num1 = num2;
//num2 = num3;
//Console.WriteLine(num1 + " " + num2);

//A03

//Console.WriteLine("Iki eded daxil edin: ");

//int num1 = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());

//Console.WriteLine(num1 + " " + num2);

//if (num1>num2)
//{
//    Console.WriteLine(num1 + " " + num2);

//}
//else
//{
//    Console.WriteLine(num2 + " " + num1);
//}

//A04

//Console.WriteLine("Bir eded daxil edin: ");

//int num = int.Parse(Console.ReadLine());

//if (num % 2 ==0)
//{
//    Console.WriteLine("Yes");
//}
//else if (num % 2 == 1)
//{
//    Console.WriteLine("No");
//}

//A05

//Console.Write("2 reqemli eded daxil edin: ");
//int num = int.Parse(Console.ReadLine());



//while (num > 0)
//{
//    int qaliq = num % 10;
//    num = (num - qaliq) / 10;

//    Console.Write(qaliq + " ");
//}

//A06

//Console.WriteLine("Ededi daxil edin: ");

//int num = int.Parse(Console.ReadLine());
//int cem =0;
//int hasil = 1;
//int qaliq = 0;
//while (num > 0)
//{
//    qaliq = num % 10;
//    num = (num - qaliq) / 10;

//    cem += qaliq;
//    hasil *= qaliq;



//}
//Console.WriteLine("Cem: " + cem);
//Console.WriteLine("Hasil: " + hasil);

//A07

//Console.WriteLine("Bir eded daxil edin: ");

//int num = int.Parse(Console.ReadLine());
//Console.WriteLine("Ededin tersi: ");


//int tersEded;

//while (num >0)
//{
//    tersEded = num % 10;
//    Console.Write(tersEded);
//    num = (num - tersEded) / 10;
//}

//A08

//Console.WriteLine("Eded daxil edin: ");

//int num = int.Parse(Console.ReadLine());
//int qaliq;
//int yeniEded =100;
//while (yeniEded >9)
//{
//    qaliq = num % 1000;
//    yeniEded = qaliq /100;


//}
//Console.WriteLine(yeniEded);

//A09

//Console.WriteLine("Bir eded daxil edin: ");
//int num = int.Parse(Console.ReadLine());


//int x;
//int max = 0;
//int min = 9;
//int say = 0;
//int cem = 0;
//while (num != 0)
//{
//    x = num % 10;
//    num = (num - num % 10) / 10;



//    if (x <= min)
//    {
//        min = x;
//    }
//    if (x > max)
//    {

//        max = x;
//    }
//    if (x %2 ==1)
//    {
//        Console.Write("Tek reqemleri: " + x);
//    }
//    if (x %2 ==0)
//    {
//        Console.Write("Cut reqemleri: " + x);
//    }
//    cem += x;
//    say++;

//}
//Console.WriteLine("Max eded: {0},Min eded: {1},Reqemlerinin sayi: {2},Reqemleinin cemi: {3}",max,min,say,cem);


//string[] arr = new string[] { " ","Yanvar", "Fevral", "Mart", "Aprel", "May", "Iyun", "Iyul", "Avqust", "Sentyabr", "Oktyabr", "Noyabr", "Dekabr" };
//Console.Write("Ayin sirasini daxil edin: ");
//int a = int.Parse(Console.ReadLine());

//for (int i = 1; i <= 12; i++)
//{
//    Console.WriteLine(arr[i]);
//}
//Console.WriteLine();
//do
//{
//    Console.WriteLine($"{a}-th ay: " + arr[a] + " ayidir"); 2456;245,24,2
//} while (false);


//int kubtil, hecm;

//Console.WriteLine("Kub til: ");
//kubtil = Convert.ToInt32(Console.ReadLine());

//hecm = (int)Math.Pow(kubtil, 3);
//Console.WriteLine(hecm);


//Console.Write("Ekrana bir eded daxil edin: ");
//int num = int.Parse(Console.ReadLine());
//int n = 0;


//while (num >= (double)Math.Pow(2, n))
//{
//	if (num == (double)Math.Pow(2, n))
//	{
//		Console.WriteLine("Bu eded 2nin quvvetidir");

//		break;
//	}
//    n++;

//}
//if (num != (double)Math.Pow(2, n))
//{
//	Console.WriteLine("Bu eded 2nin quvveti deyil");
//}


//Console.WriteLine("Ekrana eded daxil edin: ");
//int num = int.Parse(Console.ReadLine());
//int k,cem = 0;


//while (num !=0)
//{
//    k = num % 10;
//    num = (num - num % 10) / 10;
//    Console.WriteLine(k);
//    cem = cem + k;

//}
//Console.WriteLine(cem);
//Console.ReadLine();

//Console.WriteLine("Birinci eded: ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("ikinci eded: ");
//int b = int.Parse(Console.ReadLine());


//while ((b-1) !=a)
//{
//    b = b - 1;
//	if (b % 2==0)
//	{
//		Console.WriteLine(b);
//	}
//}

//int[] arr = { 100, 20, -30, -40, 50,25 };


//for (int i = 0; i < arr.Length; i++)
//{
//	if (i%2==0)
//	{
//		Console.WriteLine(arr[i]);
//	}
//}

//using System;

//int sum = 0, sum1;
//int[] numbers = { 1, 1, 2, 3, 4, 1, 4, 4 };
//int max = 0;    
//int min = numbers[0];
//int num1 = 0, num2 = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    sum = sum + numbers[i];

//    if (numbers[i] > max)
//    {
//        max = numbers[i];

//    }
//    if (numbers[i] < min)
//    {
//        min = numbers[i];
//    }

//}
//for (int i = 0; i < numbers.Length; i++)
//{
//    // maxlarin sayi
//    if (max == numbers[i])
//    {
//        num1++;
//    }
//    //minlarin sayi
//    if (min == numbers[i])
//    {
//        num2++;
//    }

//}

//sum1 = sum - num1 * max - num2 * min;
//Console.WriteLine("min ve max olmadan digerlerinin cemi:" + sum1);


//public class Program
//{
//  static void Main()
//    {
//        int[] ints = { 1, 2, 3, 4, 5, 6 };
//       reSize(ref ints, 10);
//        Console.WriteLine(ints.Length);

//    }
//    public static void reSize(ref int[] arr,int newSize)
//    {
//        int[] reSizeArr = new int[newSize];
//        for (int i = 0; i < newSize; i++)
//        {
//            if (i<arr.Length)
//            {
//                reSizeArr[i] = arr[i];
//            }
//            else
//            {
//                reSizeArr[i] = 0;
//            }
//        }
//        arr = reSizeArr;
//    }



//}

//string text = "acaabcca";

//char[] charArray = text.ToCharArray();

//for (int i = 0; i < charArray.Length; i++)
//{
//	for (int j = 1; j < charArray.Length; j++)
//	{
//		if (charArray[i] != charArray[j])
//		{
//			Console.Write(charArray[0] + charArray[i]);
//		}
//	}
//}

//using CSharp;

//public class Program
//{
//    static void Main()
//    {
//        Car car = new Car();
//        car.ShowInfo();
//        car.Drive(100);
//    }
//}
//public class Vehicle
//{
//    public string Color = "black";
//    public int Year = 2000;
//}

//public class Car:Vehicle
//{
//    public string Brand;
//    public string Model;
//    public float FuelCapacity = 90;
//    public float FuelFor1Km = 1/10f;
//    public float CurrentFuel;

//    public void ShowInfo()
//    {
        
//        Console.WriteLine();
//        Console.WriteLine();
//        Console.WriteLine();



//    }

//    public void Drive(float km)
//    {
//        CurrentFuel = FuelCapacity - km * FuelFor1Km;
//        Console.WriteLine(CurrentFuel);

//    }
//}


public class CapacityLimitException : Exception
{
	public CapacityLimitException(String message):base(message)
	{

	}
}
public class Employee : IPerson
{
	public string Name => "Mustafa";

	public int age => 20;

	public int id { get; }
	public int Id {
		get { return id; } 
		set { id = Id + 1; } }
	public string ShowInfo()
    {
		return "Name: " + Name + " Yas: " + age;
		
    }

	public Employee(int Id)
	{
		this.Id = Id;
	}
}
public interface IPerson
{
	public string Name { get; }
	public int age { get; }

	public string ShowInfo();
}
