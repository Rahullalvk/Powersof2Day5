using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    internal class Power
    {
        public static void Displaypower()  
        {
            long pow;
            Console.WriteLine("Enter the number upto which u want powers of 2");
            int n = Convert.ToInt32(Console.ReadLine());    
            for (int i = 1;i <= n; i++) 
            {
                pow = (long)Math.Pow(2, i);
                Console.WriteLine(pow);
            }
        }
    }
}
