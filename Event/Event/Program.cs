class Program
{
    //delegate void Test();


    //static event Test x
    //{
    //    add
    //    {
    //        Console.WriteLine("Added");
    //    }
    //    remove
    //    {
    //        Console.WriteLine("Removed");
    //    }
    //}
    static event EventHandler myEvent;

    static void Main()
    {

        Button btn = new Button() { Height = 40, Width = 15, Text = "Click" };
        ButtonInfo info = new ButtonInfo() { Date = "2022" };

        myEvent += Program_myEvent;

        myEvent(btn, info);


        //x += new Test(Deneme);
        //x += Deneme;
        //x += Deneme;
        //x -= Deneme;

    }

    private static void Program_myEvent(object? sender, EventArgs e)
    {
        Console.WriteLine(((Button)sender).Text);
        Console.WriteLine(((ButtonInfo)e).Date);
    }
    class Button
    {
        public string Text;
        public double Width;
        public double Height;
    }
    class ButtonInfo:EventArgs
    {
        public string Date;
    }



    //static void Deneme()
    //{
    //    Console.WriteLine("Hello");
    //}
}