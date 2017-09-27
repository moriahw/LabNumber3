using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber3
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum;
            bool Continue = true;
            string userCont;

            while (Continue == true)
            {
                Console.WriteLine("Please enter an integer:");
                userNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Number" + "\t" + "Squared" + "\t" + "Cubed");

                for (int i = 1; i <= userNum; i++)
                {
                    Console.WriteLine(i + "\t" + i * i + "\t" + i * i * i);
                }


                Console.WriteLine("Would you like to continue? (Y/N)");
                userCont = Console.ReadLine();

                if (userCont == "N" || userCont == "n")

                    Continue = false;
                else
                    Continue = true;
            }
                    

        }
    }
}
