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
            //First task
            var computer = new Computer(500, "Samsung");
            Console.WriteLine(computer.ToString());
            var computer1 = new Computer(1000, "Samsung Gaming Edition", new RAM("DDR4", 16), new HDD("WD Blue", 1, "External"));
            Console.WriteLine(computer1.ToString());

            //Second task
            var atm = new ATM(10, 10, 10);
            atm.AddMoney(20, 20, 20);
            atm.SuccessOfWithdrawal(790);
            atm.SuccessOfWithdrawal(555);
            atm.Info();

            //Third task
            var Alex = new Patient(1);
            var John = new Patient(2);
            var Bob = new Patient(3);
            var Frank = new Patient(4);
            Alex.Healing();
            John.Healing();
            Bob.Healing();
            Frank.Healing();
        }
    }
}
