using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication3
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
            Console.WriteLine("Dizideki en büyük sayı : " + InsertionSort(dizi) + " olarak bulundu.");
             stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed; 
            string elapsedTime = String.Format("{0} saat {1} dakika {2} saniye",ts.Hours, ts.Minutes, ts.Seconds);
            Console.WriteLine("Zaman:" + elapsedTime +"geçti.");
            Console.ReadKey();

        }
        
private static string InsertionSort(int[] inputArray)
{ 	
    long j = 0 ;
    long temp = 0 ;
    for (int index = 1; index < inputArray.Length; index++)
    {
        j = index;
        temp = inputArray[index];
        while ((j > 0) && (inputArray[j - 1] > temp))
        {
            inputArray[j] = inputArray[j - 1];
            j = j - 1;
        }
        inputArray[j] = temp;
        }
      }





    }
}
