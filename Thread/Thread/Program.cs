//Windows kimi emeliyyat sistemlerinde applaicationlarin islemesi ucun prossesler var.Bunlar applari bir paket halinda təcrid edərlər və applicationarin bir birilərinin memory adreslərini (Ram) işlətməməsi üçün vəya bir birlərinin məlumatlarını çatmamsı üçün (dəyişməmək üçün) həm güvənlik həm idarə həmdə əməliyyat sisteminin realibilty (etibarliliq) baxımından belə prosseslər yaradılıb.
//Bir yerde bir is baslayir ve davam edir.Sonra bir basqa bir thread yaradiriq.Oda baslair ve davam edir.Sizin proccess etmek istediyiniz data əldə edən vəya yaradan isler.
//Thread əməliyyat sisteminden gələn bir şeydir dilə məxsus deyil.Əməliyyat sistemlərinin birdən çox appi eyni vaxta çalıştırmaq üçün belə bir şey yaradılıb.
//Her bir prossese cpu mueyyen zaman ayirir.Bizede ele gelirki eyni vaxta calisir hamisi.Birden cox isin gorulmesi idare edilmesi concurrency adlanir.

Thread t = new Thread(() => {


    //Thread.Sleep(2000);
    Console.WriteLine("Hello World");


    });
t.Start();
t.Join();
Console.WriteLine("Salam");

//Foreground thredaler proccessin qapanmasinin qarsini alarlar.
//Threadler bir birinden asili deyil yeni sira ile olsada kod bir birinde bagimsiz isleyir Burda salam sözü ilk oldu 2 saniyə sonrdada hello world.Eger saniye vermesem onda bizden asili olmuyacaq ve her hansi biri ilk baslaya biler.Eger thread icinde olani one atmaq istesem onda t.Join deyecem.