

for (int i = 0; i < 10; i++)
    new MyClass(i);

Console.WriteLine("***************");


GC.Collect();
Console.Read();

class MyClass 
{
	int number;
	public MyClass(int number)
	{
        this.number = number;
        Console.WriteLine(number +  " Object yarandi");
		
	}

	~MyClass()
	{
		Console.WriteLine(number + " Object silindi");
	}
}
