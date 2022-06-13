using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi daxil edin:");
            string countStr = Console.ReadLine();
            int count = Convert.ToInt32(countStr);

            var milks = new Milk[count];
            foreach (var item in milks)
            {
                Console.WriteLine("Milk productinin adini daxil edin:");
                string name = Console.ReadLine();

                Console.WriteLine("Milk productinin qiymetin daxil edin:");
                string priceStr = Console.ReadLine();
                double price = Convert.ToInt32(priceStr);

                Console.WriteLine("Milk productinin yagliliq faizini daxil edin:");
                string fatPercentageStr = Console.ReadLine();
                double fatPercent = Convert.ToInt32(fatPercentageStr);
            }

            
        }
    }
}
