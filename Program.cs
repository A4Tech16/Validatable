using System;


namespace Validatable
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Первая машина\n");

            AddCar addCar = new AddCar("J", "");

            var e = addCar.ValidateCar();

            if (e.Count != 0)
            {
                foreach (var er in e)
                {
                    Console.WriteLine(er);
                }
            }
            else
            {
                Console.WriteLine("Машина прошла проверку");
            }
            Console.WriteLine("\n Следующая машина");

            AddCar addCar2 = new AddCar("McLaren","720Spyder");
            var e1 = addCar2.ValidateCar();
            if (e1.Count != 0)
            {
                foreach (var er in e1)
                {
                    Console.WriteLine(er);
                }
            }
            else
            {
                Console.WriteLine("Машина прошла проверку");
            }
        }
    }
}
