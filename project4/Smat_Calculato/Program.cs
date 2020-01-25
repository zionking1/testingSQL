using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smat_Calculato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A Number");
            double Num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter An Operator:" );
            string Op= Console.ReadLine();

            Console.Write("Enter A Second Number");
            double Num2 = Convert.ToDouble(Console.ReadLine());
            if (Op== "+")
            {
                Console.WriteLine(Num1 + Num2);
            }
            else if(Op =="-")
            {
                Console.WriteLine(Num1 - Num2);
            } 
            else if (Op == "*")
            {
                Console.WriteLine(Num1 * Num2);
            }
            else if (Op== "/")
            {
               Console.WriteLine(Num1/Num2); 
            } else 
            {
                Console.WriteLine("Invalid Operator");
        }
    }
}
