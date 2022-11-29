//Logic yaxud function dediyimiz strukturlarin rahat istifade edilmesini ve basqa metodlar arasinda rahat istifade edilmesini heyata kecirir.
//Delegatelerin daha besitlesidirilmis formasi.Ferqi var.Expression tree var.RunTime da kod yaratmak veaya ferqli tipde kodlar ortaya cixarmaq istesek.


public class Lambda
{
    static void Main()
    {
        ReqemMuqayiseEden muqayiseEden = new ReqemMuqayiseEden();
        Console.WriteLine(muqayiseEden.Muqayise(1, 2, (a, b) => a < b));
        Console.WriteLine(muqayiseEden.Muqayise(1, 2, delegate (int a, int b) { return a == b; }));

    }
}
public class ReqemMuqayiseEden
{
    public bool Muqayise(int a, int b, Func<int, int, bool> muqayise)
    {
        return muqayise(a, b);
    }
}












//var sayiMuqayise = new SayiMuqayise();
//Console.WriteLine(sayiMuqayise.SayiMuqayisesi(2, 3, new Karsilastirma()));

//public class SayiMuqayise
//{
//    public bool SayiMuqayisesi(int a,int b,IKarsilastirma karsilastirma)
//    {
//        return karsilastirma.Karsilastir(a, b);
//    }
//}



//public interface IKarsilastirma
//{
//    bool Karsilastir(int a, int b);
//}    

//public class Karsilastirma:IKarsilastirma
//{
//    public bool Karsilastir(int a,int b)
//    {
//        return a == b;
//    }
//}
