using System;

namespace tugas1
{
    class tugas
    {
        static void Main(string[] args)
        {
             int angka = 0;

            Console.WriteLine("Masukan angka");
            string inputan = Console.ReadLine();

            int.TryParse(inputan, out angka);

            //angka = angka < angka;
            
            for (int i = 0; i < angka; i++)
            {
                Console.WriteLine("angka= " + i + ", kuadrat=" + Math.Pow(i, 2));
            }

            Kelinci one = new Kelinci();
            Kelinci two = new Kelinci();
            Kelinci three = new Kelinci();
            Kelinci four = new Kelinci();
            one.melompat();
            Console.WriteLine(one.makan());
            one.bernafas();

            IndukBetina five = new IndukBetina();
            Console.WriteLine(five.makan());
            five.melahirkan();
        }
    }
}
