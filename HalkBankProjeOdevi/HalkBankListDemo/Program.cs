using HalkBankCore;

namespace HalkBankListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listClass = new HalkBankList();
            listClass.Ekle("Salih");
            listClass.Ekle("Engin");
            listClass.Ekle("Mustafa");
            listClass.Ekle("Ahmet");

            listClass[2] = "Mehmet";

            listClass.Sil(1);

            Console.WriteLine("Eleman Sayısı:{0}", listClass.ElemanSayisi);

            listClass.KosulluSil(kosulFunc);


            foreach (var eleman in listClass)
            {
                Console.WriteLine(eleman);
            }

            listClass.Temizle();

            Console.WriteLine("Eleman Sayısı:{0}", listClass.ElemanSayisi);

            Console.ReadLine();
        }

        public static bool kosulFunc(object iParam)
        {
            var res = ((string)iParam).ToString().ToLower().Contains("m");
            return res;
        }
    }
}