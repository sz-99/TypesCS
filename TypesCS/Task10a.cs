using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TypesCS
{
    internal class Task10a
    {
        public static void takeStudentInfo()
        {


            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your years coding:");
            int userYears = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Are you debugging? ");
            bool isUserDebug = bool.Parse(Console.ReadLine());
            Console.WriteLine("What is your coding affiliation?");
            string userAffiliation = Console.ReadLine();

            //string json = @"{'Name': {userName},
            //            'YearsCoding': {userYears},
            //             'IsDebugging': {isUserDebug},
            //            'CodingAffiliation' : {userAffiliation}
            //               }";

            string json = """{"Name": userName,"YearsCoding": userYears,"IsDebugging": isUserDebug,"CodingAffiliation" : userAffiliation}""";
            Console.WriteLine(json);

            NorthcodersStudent studentOne = JsonSerializer.Deserialize<NorthcodersStudent>(json);
            Console.WriteLine(studentOne);



        }
    }
}
