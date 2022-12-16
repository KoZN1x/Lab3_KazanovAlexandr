using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_KazanovAlexandr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var computer = new Computer(500, "Samsung");
            //Console.WriteLine(computer.ToString());
            //var computer1 = new Computer(1000, "Samsung Gaming Edition", new RAM("DDR4", 16), new HDD("WD Blue", 1, "External"));
            //Console.WriteLine(computer1.ToString());
            var atm = new ATM(10, 10, 10);
            atm.AddMoney(20, 20, 20);
            atm.SuccessOfWithdrawal(790);
            atm.SuccessOfWithdrawal(570);
            atm.Info();

        }
    }
}
