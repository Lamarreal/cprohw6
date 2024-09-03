using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cprohw6
{
    static class Shop
    {
        public static Queue<string> Queue = new Queue<string>();

        public static void AddBuyer(string buyerName)
        {
            Queue.Enqueue(buyerName);
        }

        public static void CheckCurentBuyer()
        {
            string B;
            var Success = Queue.TryPeek(out B);
            if (Success)
                Console.WriteLine("{0} now on checkout, {1} more people behind!", B, Queue.Count - 1);
        }

        public static void Checkout()
        {
            string B = Queue.Dequeue();
            Console.WriteLine("{0} was served", B);
            CheckCurentBuyer();
        }
    }
}
