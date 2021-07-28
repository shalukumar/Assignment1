//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment1
//{
    //class Batsman
    //{
    //        public static int Randomvalue()
    //        {
    //            Random r = new Random();
    //            int genRand = r.Next(1, 7);
    //            //Console.WriteLine("Random Number = " + genRand);
    //            return genRand;

    //        }
    //        public static float StrikeRate(int totalruns)
    //        {
    //            return (totalruns / 30);

    //        }
    //        public static void Main()
    //        {
    //            int totalruns = 0;
    //            int ones = 0;
    //            int twos = 0;
    //            int threes = 0;
    //            int fours = 0;
    //            int fives = 0;
    //            int sixes = 0;
    //            //int[] array = new int[30];
    //            List<int> runsList = new List<int>();
    //            for (int i = 0; i < 30; i++)
    //            {
    //                int genRand = Randomvalue();
    //                runsList.Add(genRand);
    //                totalruns = totalruns + genRand;
    //                switch (genRand)
    //                {
    //                    case 1:
    //                        ones = ones + 1;
    //                        break;
    //                    case 2:
    //                        twos = twos + 1;
    //                        break;
    //                    case 3:
    //                        threes = threes + 1;
    //                        break;
    //                    case 4:
    //                        fours = fours + 1;
    //                        break;
    //                    case 5:
    //                        fives = fives + 1;
    //                        break;
    //                    case 6:
    //                        sixes = sixes + 1;
    //                        break;
    //                }


    //            }

    //            // You can convert it back to an array if you would like to
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

