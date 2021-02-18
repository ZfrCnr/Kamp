using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Ali");
            isimler.Add("Ayşe");
            isimler.Add("Fatma");

            Console.WriteLine("Kayıt sayısı: " + isimler.Count);
            Console.WriteLine("----Kayıtlar----");
            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
