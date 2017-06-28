using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarOpExprDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string donorName = Console.ReadLine();

            Console.WriteLine("What is your address?");
            string donorAddress = Console.ReadLine();

            Console.WriteLine("What is your e-mail?");
            string donorEmail = Console.ReadLine();

            Console.WriteLine("What Fiscal year is it?");
            string fiscalYear = Console.ReadLine();

            Console.WriteLine("What is your donation amount?");
            Console.WriteLine("How many $100 bills?");
            double hundredBill = double.Parse(Console.ReadLine());

            Console.WriteLine("How many $50 bills?");
            double fiftyBill = double.Parse(Console.ReadLine());

            Console.WriteLine("How many $20 bills?");
            double twentyBill = double.Parse(Console.ReadLine());

            Console.WriteLine("How many $10 bills?");
            double tenBill = double.Parse(Console.ReadLine());

            Console.WriteLine("How many $5 bills?");
            double fiveBill = double.Parse(Console.ReadLine());

            Console.WriteLine("How many $1 bills?");
            double oneBill = double.Parse(Console.ReadLine());

            Console.WriteLine("How many quarters?");
            double quarters = double.Parse(Console.ReadLine());

            double hundredValue = 100d;
            double fiftyValue = 50d;
            double twentyValue = 20d;
            double tenValue = 10d;
            double fiveValue = 5d;
            double oneValue = 1d;
            double quarterValue = 0.25d;

            double hundredTotal = hundredValue * hundredBill;
            double fiftyTotal = fiftyValue * fiftyBill;
            double twentyTotal = twentyValue * twentyBill;
            double tenTotal = tenValue * tenBill;
            double fiveTotal = fiveValue * fiveBill;
            double oneTotal = oneValue * oneBill;
            double quartersTotal = quarterValue * quarters;
            double donationTotal = hundredTotal + fiftyTotal + twentyTotal + tenTotal + fiveTotal + oneTotal + quartersTotal;

            Console.WriteLine("Your total donation amount is: $" + donationTotal);
            Console.WriteLine("Please take your receipt. Thank you.");
            Console.WriteLine("Full Name: " + donorName);
            Console.WriteLine("Address: " + donorAddress);
            Console.WriteLine("E-Mail: " + donorEmail);
            Console.WriteLine("Fiscal Year: " + fiscalYear);
            Console.WriteLine("Donation Amount: " + donationTotal);




            //Console.WriteLine("What is the name for your reservation?");
            //string reservationName = Console.ReadLine();

            //Console.WriteLine("How many people are in your party?");
            //int numberOfPeople = int.Parse(Console.ReadLine());

            //Console.WriteLine("Reservation: " + reservationName);

            //double amountEach = 13.53;
            //double totalBill = (numberOfPeople*amountEach);
            //Console.Write("Total Due: $" + totalBill);
            //double totalDue = int.Parse(Console.ReadLine());

            //double moneyAtStart = 29;
            //double moneyAtEnd = 41;
            //double moneyMade = moneyAtEnd - moneyAtStart;

            //Console.WriteLine(moneyMade);




            //int jessicaAge = 23;
            //int samAge = 47;

            //Console.WriteLine(jessicaAge < samAge);


            //int age = 65;
            //string why = "because I said so";
            //char firstInitial = 'L';

            ////Floating point types
            //float floatNumber = 2.164403304897294849383961032f;
            //Console.WriteLine(floatNumber);

            //double doubleNumber = 2.164403304897294849383961032d;
            //Console.WriteLine(doubleNumber);

            //decimal decimalNumber = 2.164403304897294849383961032m;
            //Console.WriteLine(decimalNumber);

            //initializing values
            //string name = "Mike";
            //string birthMonth = "August";
            //int 

            //Console.WriteLine(name);

            //name = "Daniel";
            //Console.WriteLine(name);

            //Console.WriteLine(birthMonth);



        }
    }
}
