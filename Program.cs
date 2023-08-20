using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace mutlak_kare_alma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n tane sayı giriniz(aralarında boşluk bırakarak sayıları giriniz: )");
            string[] nums = Console.ReadLine().Split(' ');
            int smaller67 = 0;
            int larger67 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (int.Parse(nums[i]) < 67)
                {
                    smaller67 += (67 - int.Parse(nums[i]));
                }
                else
                {
                    larger67 += (int)Math.Pow(Math.Abs(67 - int.Parse(nums[i])), 2);
                }

            }
            Console.Write("{0} {1}", smaller67, larger67);
        }
    }
}
