using System;
using System.Linq;


namespace domaci1
{
    internal class Program
    {
        public static void Task1()
        {
            //inputArray = [ 1, 2, 4, 5, 8, 9 ]
            //Result = 14
            int[] array = { 1, 2, 4, 5, 8, 9 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 == 0)
                {
                    sum = array[i] + sum;
                    //zbir += niz[i];
                }
            Console.WriteLine($"The sum of all even numbers is {sum}");
        }

        public static void Task2()
        {
            //string str = "abeceda";
            //char ch = 'a';
            //int freq = str.Count(f => (f == ch));
            //Console.WriteLine(freq);

            string abeceda = "abeceda";
            int counter = 0;
            foreach (char c in abeceda)
            {
                if (c == 'a')
                {
                    counter++;
                }
            }

            int counter1 = 0;
            for (int i = 0; i < abeceda.Length; i++)
            {
                if (abeceda[i] == 'a')
                {
                    counter1++;
                }
            }
            Console.WriteLine(counter);
            Console.WriteLine(counter1);
        }
        public static void CalculateCircumferenceAndArea()
        {
            //r=5
            //result area 78.54
            //result circumference 31.42
            double r = 5;
            double circumference = (2 * r) * Math.PI;
            double area = r * r * Math.PI;
            Console.WriteLine($"Circumference is: {circumference}, Area is: {area}");
        }
        static void Main(string[] args)
        {
            CalculateCircumferenceAndArea();
            Task1();
            Task2();
        }
    }
}
