//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment1
//{
//    class Bank
//    {
//        internal int accno { get; set; }
//        internal int accbalance { get; set; }
//        internal string accpw { get; set; }
//        internal string bankname { get; }

//        internal Bank()
//        {
//            accno = 1;
//            accbalance = 0;
//            accpw = "abc";
//            bankname = "ABC";
//        }
//        internal Bank(int accno, int accbalance, string accpw)
//        {
//            this.accno = accno;
//            this.accbalance = accbalance;
//            this.accpw = accpw;
//            string bankname = "ABC";
//        }
//        internal void showdeets()
//        {
//            Console.WriteLine("ACC NO:{0}", accno);
//            Console.WriteLine("ACC Balance:{0}", accbalance);
//            Console.WriteLine("ACC password:{0}", accpw);
//            Console.WriteLine("Bank:ABC");

//        }

//        public static void Mai()
//        {
//            Bank acc1 = new Bank();
//            acc1.showdeets();
//            Bank acc2 = new Bank(75, 1000, "abbbbbb");
//            acc2.showdeets();
//        }
//    }
//}