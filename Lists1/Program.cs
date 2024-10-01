using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ziyaretçi isimlerini ekleyeceğimiz bir liste oluşturuyoruz.
        List<string> davetliler = new List<string>
        {
            "1 - Bülent Ersoy",
            "2 - Ajda Pekkan",
            "3 - Ebru Gündeş",
            "4 - Hadise",
            "5 - Hande Yener",
            "6 - Tarkan",
            "7 - Funda Arar",
            "8 - Demet Akalın",
        };

        // Başlık
        Console.WriteLine("** DAVETLİLER **");

        // İsimleri yazdırmak için foreach döngüsü kullanıyoruz.
        foreach (var isim in davetliler)
        {
            Console.WriteLine(isim);
        }
    }
}
