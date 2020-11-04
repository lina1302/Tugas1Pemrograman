using System;

namespace tugas1
{
    public class Kelinci : Hewan
    {
        //constructor

        public Kelinci()
        {

        }
        // property
        int umur;
        string jenis;
        string makanan;

        //function

        public void melompat()
        {
            Console.WriteLine("melompat");
        }

        public string makan()
        {
            return "makan";
        }
    }
}