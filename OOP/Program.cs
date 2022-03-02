using System;
using System.Linq;


namespace domaci1
{
    internal class Program
    {
        public static void CalculateCircumferenceAndArea()
        {
            //r=5
            //result povrsina 78.54
            //obim 31.42
            double r = 5;
            double obim = (2 * r) * Math.PI;
            double povrsina = r * r * Math.PI;

            Console.WriteLine($"Obim je: {obim}, Povrsina je: {povrsina}");
            Console.WriteLine(povrsina);


        }
        public static void Zadatak1()
        {
            //inputArray = [ 1, 2, 4, 5, 8, 9 ]
            //Result = 14
            int[] niz = { 1, 2, 4, 5, 8, 9 };
            int zbir = 0;
            for (int i = 0; i < niz.Length; i++)
                if (niz[i] % 2 == 0)
                {
                    zbir = niz[i] + zbir;
                    //zbir += niz[i];
                }
            Console.WriteLine($"Zbir svih parnih brojeva je {zbir}");
        }

        public static void Zadatak2()
        {
            string str = "abeceda";
            char ch = 'a';

            int freq = str.Count(f => (f == ch));
            Console.WriteLine(freq);

        }


        static void Main(string[] args)
        {
            CalculateCircumferenceAndArea();
            Zadatak1();
            Zadatak2();
        }
    }
}
