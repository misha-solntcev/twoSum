using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Задача.
 Найти два числа из массива, в сумме равных числу к.
    Решение с помощью перебора всех пар чисел.  */


namespace Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -3, 0, 1, 4, 5 };
            int k = 7;
            int[] res = { 0, 0 };

            for (int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length; j++)
                {                    
                    if (nums[i] + nums[j] == k)
                    {
                        res = new int[] { nums[i], nums[j] };                        
                    }                    
                }

            Console.WriteLine($"[{res[0]}, {res[1]}]");
            
            Console.ReadKey();
            
        }
    }
}
