using System;

namespace LeadingZeros_DSJ
{
    class Program
    {
        static void Main(string[] args)
        {
            string i = "00123";
            Console.WriteLine("Please Enter Your Number **00123" );
            i = Console.ReadLine();
            Console.WriteLine("Enter how you want to increase this? ** 00123 X 9 ");
            int qty = 5;
            qty = Convert.ToInt32(Console.ReadLine());
            int num = 0;
            int h = i.Length;
            for (int j = 0; j <= qty; j++)
            {
                num = j + Convert.ToInt32(i);
            }
            string zzeroo = "0";
            string hh = "";
            int p = num.ToString().Length;
            if (p >= h)
            {

                Console.WriteLine(num);
            }
            else
            {
                int re = h - p;
                hh = num.ToString();
                for (int q = 0; q < re; q++)
                {
                    hh = zzeroo + hh;
                }
                Console.WriteLine(hh);
            }
            Console.ReadLine();
        }


    }
}
