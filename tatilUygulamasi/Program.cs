
bool devam = true;  //döngü için oluşturmuş olduğum parametre
while (devam)//kullanıcı başka bir tatil planlıyorsa aşağıdaki koşulların edebilmesi için bir döngü oluşturdum.
{
    int fiyat = 0; //fiyatı bir değişkende tuttum.
    Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu seçin:");
    Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL)");
    Console.WriteLine("2 - Marmaris (Paket başlangıç fiyatı 3000 TL)");
    Console.WriteLine("3 - Çeşme (Paket başlangıç fiyatı 5000 TL)");

    string lokasyon = Console.ReadLine().ToLower();
    if (lokasyon == "bodrum") // lokasyon bodruma eşit olduğu durumda bodrum için bilgi verecek.

    {
        fiyat = 4000;
        Console.WriteLine("Bodrum paketini seçtiniz. Muhteşem plajları ile ünlüdür.");
    }

    else if (lokasyon == "marmaris") // lokasyon marmarise eşit olduğu durumda marmaris için bilgi verecek.
    {
        fiyat = 3000;
        Console.WriteLine("Marmaris paketini seçtiniz.Marinası ,kalesi ve koyları ile ünlüdür.");
    }

    else if (lokasyon == "çeşme")// lokasyon çeşmeye eşit olduğu durumda çeşme için bilgi verecek.
    {
        fiyat = 5000;
        Console.WriteLine("Çeşme paketini seçtiniz.Berrak suları ile ünlüdür.");
    }
    else
    {
        Console.WriteLine("Hatalı bir lokasyon girdiniz. Lütfen 'Bodrum', 'Marmaris' veya 'Çeşme' yazın.");
        continue; // hatalı bir giriş yaptığında lokasyon koşulunu başa döndürür.

    }


    Console.WriteLine("Kaç kişi için tatil planlamak istersiniz ?");
    int kisiSayisi = Convert.ToInt32(Console.ReadLine());
    if (kisiSayisi <= 0)
    {
        Console.WriteLine("Hatalı kişi sayısı girdiniz.Lütfen geçerli bir sayı giriniz.");
    }


    int ulasimTutar = 0; //
    Console.WriteLine("Lütfen ulaşım şeklinizi seçin:");
    Console.WriteLine("1 - Kara yolu (Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)");
    Console.WriteLine("2 - Hava yolu (Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
    string ulasim = Console.ReadLine();
    if (ulasim == "1")
    {
        ulasimTutar = 1500;
    }
    else if (ulasim == "2")
    {
        ulasimTutar = 4000;
    }
    else
    {
        Console.WriteLine(" Hatalı ulaşım seçeneği girdiniz.Lütfen '1'veya '2' giriniz.");
        continue;// hatalı bir giriş yaptığında ulaşım koşulunu başa döndürür.
    }

    int toplamUlasim = ulasimTutar * kisiSayisi;
    int toplamFiyat = fiyat * kisiSayisi + toplamUlasim;


    Console.WriteLine($"Seçtiğiniz lokasyon: {lokasyon}, Kişi sayısı: {kisiSayisi}, Ulaşım türü: {(ulasim == "1" ? "Kara yolu" : "Hava yolu")}");
    Console.WriteLine($"Toplam tatil maliyetiniz: {toplamFiyat} TL");
    Console.WriteLine("Başka bir tatil planlamak ister misiniz? (Evet için 'e', Hayır için 'h' yazın)");
    string tekrar = Console.ReadLine().ToLower(); // başka bir tatil planının olup olmadığını sormak için tanımladım.

    if (tekrar != "e")
    {
        devam = false;
        Console.WriteLine("İyi günler dileriz!");
    }

}


