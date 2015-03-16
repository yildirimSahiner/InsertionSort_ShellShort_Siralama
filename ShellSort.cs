using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  
namespace ShellSort
{
    class Program
    {
      static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Kaç elemanlı dizi olsun?");
            int c = int.Parse(Console.ReadLine());
            int[] dizi = new int[c];
            int rastsayi;
            Random rastgele = new Random();
            for (int i = 0; i < c; i++)
            {
                rastsayi = rastgele.Next(1, 500);
                dizi[i] = rastsayi;
            }
            Console.WriteLine(c + " elemanlı dizi üretildi.");
            stopwatch.Start();          
            int j;
            int temporary;
            int gap = array.Length / 2; 
            // Kabuk sıralama,
            while (gap > 0)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    temporary = array[i];
                    j = i;
                    while (j >= gap && array[j - gap] > temporary)
                    {
                        array[j] = array[j - gap];
                        j -= gap;
                    }
                    array[j] = temporary;
                }
                gap = gap / 2;
            }
            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0} saat {1} dakika {2} saniye", ts.Hours, ts.Minutes, ts.Seconds);
            Console.WriteLine("Zaman:" + elapsedTime + "geçti.");
            Console.ReadKey();
        }
    }
}