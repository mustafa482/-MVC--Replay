﻿//A01.

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


int kubtil, hecm;

Console.WriteLine("Kub til: ");
kubtil = Convert.ToInt32(Console.ReadLine());

hecm = (int)Math.Pow(kubtil, 3);
Console.WriteLine(hecm);