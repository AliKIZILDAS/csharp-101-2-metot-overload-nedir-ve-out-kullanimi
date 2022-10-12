using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out paremetreler
            string sayi="999";

            bool sonuc=int.TryParse(sayi,out int Outref);
            if(sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(sonuc);
            }
            else
                Console.WriteLine("Başarısız");
                        
            Metotlar instance=new Metotlar();
            instance.Topla(4,5,out int toplaSonucu);
            Console.WriteLine(toplaSonucu);
            //Metot aşırı yükleme~Overloading
            int ifade=999;
            Console.WriteLine(ifade);

        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam=a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

    }

}
