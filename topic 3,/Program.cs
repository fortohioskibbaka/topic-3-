using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace topic_3_
{
    internal class Program
    {
        private static object science;

        static void Main(string[] args)
        {
            string coursename;
            string myname;

            double raduis, area;
            raduis = 10;
            coursename = "iam learning a bit of computer science";
            int value;
            value = 299;
            double roomnumber;
            roomnumber = 29;
            Console.WriteLine("the room number is #" + roomnumber);
            Console.WriteLine("the price is #" + value);
            Console.WriteLine("   #" + coursename);
          
            Console.ReadLine();
            myname = "my name is parker hammmond iam graduating in 2026";
            Console.WriteLine(" #" + myname);

            Console.WriteLine("press enter to continue");

            Console.ReadLine();



            area = Math.PI * Math.Pow(raduis, 2);
            
            












        }
    }
}
