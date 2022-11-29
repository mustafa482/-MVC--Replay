using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynxonousProgramming
{
    public class TaskString
    {
       public void Main()
        {
            var t = GetGoogleSourceCodeAsync().ContinueWith(task => { Console.WriteLine(task.Result); });//ContinueWith odurki onu yazmiyanda Finished mecbur idiki evvelce ustdeki netice ekrana cixsin.Bele olanda hansi tez islese o ekrana verilir bir mecburiyyet olmur.

            Console.WriteLine("Finished");
            Console.ReadLine();
        }
        async Task<string> GetGoogleSourceCodeAsync()//asyn access modifier kimi return type in qabaginda yazilir awaiti isletmek ucundur.Return typni Task<string> vermek mecbur deyil.async sayesinde Task vermek olur + return yazilmir.
        {
            var httpClient = new HttpClient();
            return await httpClient.GetStringAsync("http://www.google.com");//Gozlemek dir.Geri donderdiyim kodun gozlemesi.Gozlemeden kontrolu yield edir.


        }
       // Task<string> GetGoogleSourceCode()
       //{
       //     var httpClient = new HttpClient();
       //    var t = Task.Run(() =>
       //     {
       //        return httpClient.GetStringAsync("http://www.google.com").Result;

       //     });
       //     return t;
       // }
    }

}
