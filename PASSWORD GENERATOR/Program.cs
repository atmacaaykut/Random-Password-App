using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();                //[48-57]  [65-90]

            string metin = "";

            char karakter='a';

            Console.Write("Please enter a number: ");
            int number = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                int hs = r.Next(1, 3);
                if (hs==1)
                {
                    karakter = Convert.ToChar(r.Next(65, 91));
                    metin += karakter;
                }
                else if (hs==2)
                {
                    karakter = Convert.ToChar(r.Next(48, 58));
                    metin += karakter;
                }
                
            }
            Console.Write(metin);
            
        }

       
    }
}
