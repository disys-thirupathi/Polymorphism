/*uag System;
namespace Studytonight
{
    public class Interest
    {
        public double MyBank(double amount, double rate)
        {
            return amount + (amount * rate);
        }
        public double MyBank(double amount, double rate, string holdertype)
        {
            return amount + (amount * rate) + 5000;
        }
    }
    public class Bank_Interest
    {
        public static void Main(string[] args)
        {
            Interest obj = new Interest();

            double final = obj.MyBank(50000, 0.1);
            Console.WriteLine("Normal interest " + final);

            final = obj.MyBank(50000, 0.5, "Express");
            Console.WriteLine("Express interest  " + final);

        }
    }
}*/
using System;
	class interest
    {
		public double total;
		public interest(int cost, double rate)
        {
			total = cost + (rate * rate);
			
        }
		public static interest operator -(interest b)
        {
			b.total = -b.total;
        Console.WriteLine("Interest amount " + b.total);
    }
    }
	class Class1
	{
		public static void Main()
        {
			interest i = new interest(50000, 0.5);
			i = -i;
			
        }
	}
