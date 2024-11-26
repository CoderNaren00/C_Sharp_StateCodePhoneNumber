using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_StateCodePhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Displaying Messages
            Console.WriteLine("Enter Your PhoneNumber :");
            //Getting number from user
            long PhoneNumber = Convert.ToInt64(Console.ReadLine());

            //Concatination of PhoneNumber
            Console.Write("Phone Number is" + PhoneNumber);
        }
    }
}
