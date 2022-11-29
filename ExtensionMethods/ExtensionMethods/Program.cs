

string x = "98";
int y = 10;
Console.WriteLine(x.TamEdedeCevir() + y);





static class Extensions
{
    public static int TamEdedeCevir(this object obj)
    {
        return Convert.ToInt32(obj);
    }
}






//char[] dizi = "Salam".KarakterleriCevir();
//foreach (var item in dizi)
//{
//    Console.WriteLine(item);
//}


//static class Extensions
//{
//    public static char[] KarakterleriCevir(this string text)
//    {
//        char[] chars = new char[text.Length];
//        for (int i = 0; i < chars.Length; i++)
//        {
//            chars[i] = text[i];
//        }
//        return chars;
//    }
//}