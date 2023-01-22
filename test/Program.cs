using System;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;


namespace Method
{
    public class program
    {

        static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            method(number);


        }



        static void method(int number)

        {

            if (number % 7 == 0)
            { number = number; }


            while (number % 7 != 0 && number % 7 > 3)
            { number++; }

            while (number % 7 != 0 && number % 7 <= 3)
            { number--; }

            


            Console.WriteLine(number);

        }












        //static void Main() 
        //{

        //int number=Convert.ToInt32(Console.ReadLine());
        //int sum = 0;
        //Sumofelements(number, sum);
        //}

        //static void Sumofelements (int number, int sum)
        //{

        //    for (int i = 0; i <= number; i++)
        //    {
        //        sum += i;
        //    }



        //    Console.WriteLine(sum);
        //}












        //static void Main()
        //{
        //    string firstword = Console.ReadLine();
        //    string secondword = Console.ReadLine();
        //    Longer(firstword, secondword);

        //}


        //static void Longer(string firstword, string secondword)
        //{

        //    if (firstword.Length > secondword.Length)
        //    {
        //        Console.WriteLine($"{firstword} - uzundur");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{secondword} - uzundur");
        //    }

        //}



    }
}

















