using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("输入一个正整数：");
            int i = Convert.ToInt32(System.Console.ReadLine());
            Factors n = new Factors(i);
            n.FindTheFactors();
        }
    }

    class Factors
    {
        private int n;
        private string output;
        public Factors(int n)
        {
            this.n = n;
            output = n + " = ";
        }
        public void FindTheFactors()
        {
            int i = 2;
            int count = n;
            while (1 != count)
            {

                while (count % i != 0)
                {
                    i++;
                }
                count = count / i;
                if (count == 1)
                {
                    output += i;

                }
                else
                {
                    output += i + " * ";
                }
                i = 2;
            }
            System.Console.WriteLine(output);
        }
    }
}