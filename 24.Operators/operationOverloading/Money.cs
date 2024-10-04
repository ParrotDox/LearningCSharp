using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Coin 
    {
        public string name;
        public Coin() => name = "";
        public Coin(string n) => name = n;
    }
    internal class Cash
    {
        private int cash { get; set; }
        private Coin[] coinArr = new Coin[] { };
        public Cash() 
        {
            cash = 0;
        }
        public Cash(int c)
        {
            cash = c;
        }
        public Cash(int c, Coin[] ca) 
        {
            cash = c;
            coinArr = ca;
        }
        public Coin this[int index] 
        {
            get 
            {
                return coinArr[index];
            }
            set 
            {
                coinArr[index] = value;
            }
        }

        public static Cash operator ++ (Cash m)
        {
            Cash temp = new Cash(m.cash);
            temp.cash += 10;
            return temp;
        }
        public static bool operator == (Cash m1, Cash m2) 
        {
            if (m1.cash == m2.cash) return true;
            else return false;
        }
        public static bool operator != (Cash m1, Cash m2)
        {
            if (m1.cash != m2.cash) return true;
            else return false;
        }
        //Неявное преобразование implicit явное explicit
        public static implicit operator double(Cash m) 
        {
            return m.cash;
        }
        public static explicit operator int(Cash m) 
        {
            return m.cash;
        }
        public void Print() 
        {
            Console.WriteLine($"Cash is {cash}");
            Console.WriteLine($"Coins are");
            for(int i = 0; i < coinArr.Length; ++i) 
            {
                Console.WriteLine($"{i} Coin: {coinArr[i].name}");
            }
        }
    }
}
