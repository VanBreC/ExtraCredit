using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Extra_Credit_1
{
    public class CreateFile
    {
        public static void Main()
        {
            FileStream file = new FileStream("WriteCustomerRecords.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            int idNumber;
            string Name;
            double Balance;
            int x;

            for (x = 0; x < 1; ++x)
            {

                Console.WriteLine("Please enter your ID number");
                idNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter your name");
                Name = Console.ReadLine();

                Console.WriteLine("Please enter your balance");
                Balance = Convert.ToDouble(Console.ReadLine());
                writer.WriteLine("Your id number is {0}, Your name is {1}, and your Balance is {2}", idNumber, Name, Balance);
            }
            writer.Close();
            file.Close();
        }
    }
    // public class ReadNameFile
    // {
    //       public static void Main()
    //     {
    //       FileStream file = new FileStream("ReadCustomerRecords.txt", FileMode.Open, FileAccess.Read);
    // }
    // }
}
