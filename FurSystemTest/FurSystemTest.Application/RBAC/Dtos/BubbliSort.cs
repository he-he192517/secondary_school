using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Application.RBAC.Dtos
{
    public class BubbleSort
    {
        public static int Fibo(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return Fibo(n - 1) + Fibo(n - 2);
        }

        public static void Main(string[] args)
        {
            int position = 30;
            int result = Fibo(position);
            Console.WriteLine($"斐波那契数列的第 {position} 位数是: {result}");
        }
    }
}
