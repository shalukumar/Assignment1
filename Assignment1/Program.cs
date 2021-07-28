using System;
using System.Collections.Generic;

namespace Assignment1
{

    //    class ElectricityBill
    //    {

    //        internal int bill_id { get; set; }
    //        internal int units { get; set; }
    //        //internal double priceperunit { get; set; }
    //        //internal static double totalamt { get; set; }
    //        internal ElectricityBill(int bill_id, int units, double totalamt)
    //        {
    //            this.bill_id = bill_id;
    //            this.units = units;
    //            //this.totalamt = totalamt;

    //        }

    //        public void BillDetails(double Totalamt)
    //        {
    //            Console.WriteLine("Bill ID: " + bill_id);
    //            Console.WriteLine("units: " + units);
    //            Console.WriteLine("Total Amount: " + Totalamt);

    //        }


    //        static void Main(string[] args)
    //        {
    //            double totalamt;
    //            Console.WriteLine("Enter No of units");
    //            int Units = Convert.ToInt32(Console.ReadLine());
    //            if (Units < 100)
    //            {
    //                double priceperunit = 1.2;
    //                totalamt = Units * priceperunit;
    //                //int case = 1;
    //            }
    //            else if (Units < 301)
    //            {
    //                double priceperunit = 2;
    //                //300 units 
    //                double first100cost = 120;
    //                totalamt = first100cost + ((Units - 100) * priceperunit);
    //                //Console.WriteLine(totalamt);
    //            }
    //            else
    //            {

    //                double priceperunit = 3;
    //                //500 units
    //                double first100cost = 120;
    //                double next200cost = 400;
    //                totalamt = first100cost + next200cost + ((Units - 300) * priceperunit);
    //                //Console.WriteLine(totalamt);
    //            }
    //            Console.WriteLine("Total Amount: " + totalamt);
    //            ElectricityBill bill = new ElectricityBill(1, Units, totalamt);
    //            bill.BillDetails(totalamt);

    //life
    //        }
    //    }
    //}
    //-------------------------------------------------------------

    //class Batsman
    //{
    //    public static int Randomvalue()
    //    {
    //        Random r = new Random();
    //        int genRand = r.Next(1, 7);
    //        //Console.WriteLine("Random Number = " + genRand);
    //        return genRand;

    //    }
    //    public static float StrikeRate(int totalruns)
    //    {
    //        return (totalruns / 30);

    //    }
    //    public static void Main()
        {
    //        int totalruns = 0;
    //        int ones = 0;
    //        int twos = 0;
    //        int threes = 0;
    //        int fours = 0;
    //        int fives = 0;
    //        int sixes = 0;
    //        //int[] array = new int[30];
    //        List<int> runsList = new List<int>();
    //        for (int i = 0; i < 30; i++)
    //        {
    //            int genRand = Randomvalue();
    //            runsList.Add(genRand);
    //            totalruns = totalruns + genRand;
    //            switch (genRand)
    //            {
    //                case 1:
    //                    ones = ones + 1;
    //                    break;
    //                case 2:
    //                    twos = twos + 1;
    //                    break;
    //                case 3:
    //                    threes = threes + 1;
    //                    break;
    //                case 4:
    //                    fours = fours + 1;
    //                    break;
    //                case 5:
    //                    fives = fives + 1;
    //                    break;
    //                case 6:
    //                    sixes = sixes + 1;
    //                    break;
    //            }


    //        }

    // You can convert it back to an array if you would like to
    //            int[] runs = runsList.ToArray();
    //            Console.WriteLine("Runs:");
    //            foreach (var i in runs)
    //            {
    //                Console.Write(i + ",");

    //            }
    //            Console.WriteLine("");
    //            Console.WriteLine("Total Runs: " + totalruns);
    //            Console.WriteLine("ones: " + ones);
    //            Console.WriteLine("twos: " + twos);
    //            Console.WriteLine("threes: " + threes);
    //            Console.WriteLine("fours: " + fours);
    //            Console.WriteLine("fives: " + fives);
    //            Console.WriteLine("sixes: " + sixes);

    //            float strikerate = StrikeRate(totalruns);
    //            Console.WriteLine("Strikerate is:" + strikerate);




    //        }
    //    }
    //}

    //--------------------------------------

    class Bank
    {
        internal int accno { get; set; }
        internal int accbalance { get; set; }
        internal string accpw { get; set; }
        internal string bankname { get; }

        internal Bank()
        {
            accno = 1;
            accbalance = 0;
            accpw = "abc";
            bankname = "ABC";
        }
        internal Bank(int accno, int accbalance, string accpw)
        {
            this.accno = accno;
            this.accbalance = accbalance;
            this.accpw = accpw;
            string bankname = "ABC";
        }
        internal void showdeets()
        {
            Console.WriteLine("ACC NO:{0}", accno);
            Console.WriteLine("ACC Balance:{0}", accbalance);
            Console.WriteLine("ACC password:{0}", accpw);
            Console.WriteLine("Bank:ABC");

        }

        public static void Main()
        {
            Bank acc1 = new Bank();
            acc1.showdeets();
            Bank acc2 = new Bank(75, 1000, "abbbbbb");
            acc2.showdeets();
            
            Console.WriteLine("3rd line");
        }
    }
}
