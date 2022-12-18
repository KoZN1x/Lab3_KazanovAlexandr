using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_KazanovAlexandr
{
    internal class ATM
    {
        public ushort amountOf20 { get; set; }
        public ushort amountOf50 { get; set; }
        public ushort amountOf100 { get; set; }
        public ATM (ushort amountOf20, ushort amountOf50, ushort amountOf100)
        {
            this.amountOf20 = amountOf20;
            this.amountOf50 = amountOf20;
            this.amountOf100 = amountOf100;
        }
        public void AddMoney(ushort amountOf20, ushort amountOf50, ushort amountOf100)
        {
            this.amountOf20 += amountOf20;
            this.amountOf50 += amountOf50;
            this.amountOf100 += amountOf100;
        }
        private ushort[] MoneySplit(int sum)
        {
            var baknotesOfSum = new ushort[3];
            baknotesOfSum[0] = (ushort)(sum / 100);
            sum %= 100;
            baknotesOfSum[1] = (ushort)(sum / 50);
            sum %= 50;
            baknotesOfSum[2] = (ushort)(sum / 20);
            return baknotesOfSum;
        }
        public bool SuccessOfWithdrawal(int sum)
        {
            ushort[] banknotesOfSum = MoneySplit(sum);
            if ((banknotesOfSum[0] > amountOf100) | (banknotesOfSum[1] > amountOf50) | (banknotesOfSum[2] > amountOf20))
            {
                Console.WriteLine("Error! ATM runs out of banknotes.");
                return false;
            }
            else if (sum < 20)
            {
                Console.WriteLine("Error! Withdrawal amount too small.");
                return false;
            }
            else if (sum % 10 != 0)
            {
                Console.WriteLine("Error! Incorrect value.");
                return false;
            }
            else
            {
                amountOf100 -= banknotesOfSum[0];
                amountOf50 -= banknotesOfSum[1];
                amountOf20 -= banknotesOfSum[2];
                Console.WriteLine($"You are given {banknotesOfSum[0]} of 100$ bills.\nYou are given {banknotesOfSum[1]} of 50$ bills.\nYou are given {banknotesOfSum[2]} of 20$ bills.");
                return true;
            }
        }
        public void Info()
        {
            Console.WriteLine($"There are {amountOf100} of 100$ bills in the ATM.\nThere are {amountOf50} of 50$ bills in the ATM.\nThere are {amountOf20} of 20$ bills in the ATM.");
        }
    }
}
