using System;
class Program
{
    static void Main()
    {
        int n = 0;
        while (n <= 0)
        {
            System.Console.WriteLine("Kaç kelime gircen");
            string inputn = Console.ReadLine();
            if (int.TryParse(inputn, out n) && n > 0)
            {
                System.Console.WriteLine("Tamam");

            }
            else
            {
                System.Console.WriteLine("Pozitif gir");
            }
        }
        string[] kelimedizisi = new string[n];
        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine("{0}.kelimeyi gir", i + 1);
            kelimedizisi[i] = Console.ReadLine();
        }
        Array.Reverse(kelimedizisi);
        System.Console.WriteLine("EN SEVDİĞİN KELİMELER");
        foreach (var kelime in kelimedizisi)
        {
            System.Console.WriteLine(kelime);
        }





    }
}