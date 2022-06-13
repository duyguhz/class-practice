using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Human[] humans = new Human[]
            {
                new Human(15,"Hikmet"),
                new Human(55,"Abbasov"),
                new Human(45,"Duygu","Hesenzade")
            };

            
            Console.WriteLine("Axtaris deyerini daxil edin:");
             string text = Console.ReadLine();



            foreach (var item in humans)
            {
                if (item.Name.Contains(text))
                {
                    Console.WriteLine($"{item.Name} {item.Surname}-{item.Age}");
                }
            }






        }
    }
}
