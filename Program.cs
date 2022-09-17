using System;
using System.Collections;

namespace koleksiyonlar_soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            ArrayList minNums = new ArrayList();
            ArrayList maxNums = new ArrayList();
            int minSum=0;
            int maxSum=0;

            Console.WriteLine("Lütfen 20 adet sayı giriniz: ");
            for(int i=0;i<20;i++)
            {
                Console.Write("{0}. sayıyı giriniz: ",i+1);
                int num = Convert.ToInt32(Console.ReadLine());
                arr.Add(num);
            }
            arr.Sort();

            minNums.Add(arr[0]);
            minNums.Add(arr[1]);
            minNums.Add(arr[2]);
            maxNums.Add(arr[arr.Count-1]);
            maxNums.Add(arr[arr.Count-2]);
            maxNums.Add(arr[arr.Count-3]);

            foreach (var num in minNums)
            {
                minSum+=Convert.ToInt32(num);
            }
            foreach (var num in maxNums)
            {
                maxSum+=Convert.ToInt32(num);
            }

            Console.WriteLine("*****En küçük 3 tane sayı ve ortalamaları*****");
            
            Console.Write("En küçük üç sayı: ");
            foreach (var num in minNums)
            {
                Console.Write(num+" ");
            }
             Console.WriteLine();
            Console.WriteLine("Ortalama: "+minSum/3);
            
            Console.WriteLine("****En büyük 3 tane sayı ve ortalamaları*****");

            Console.Write("En büyük üç sayı: ");
             foreach (var num in maxNums)
            {
                Console.Write(num+" ");
            }
             Console.WriteLine();
            Console.WriteLine("Ortalama: "+maxSum/3);

            Console.WriteLine("Ortalamaların Toplamı: "+((minSum/3)+(maxSum/3)));

        }
    }
}
