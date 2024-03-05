using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_05032024._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //entrada
            double r;
            Console.Write("numero:");
            double n1=double.Parse(Console.ReadLine());
            Console.Write("Operação:");
            string op = Console.ReadLine();
            Console.Write("numero:");
            double n2 = double.Parse(Console.ReadLine());

            //processamento e Saída

            if (op == "+")
            {
                r = n1 + n2;
                Console.WriteLine(n1 + "+" + n2 + "=" + r);
            }    
            else if (op == "-")
            {
                r = n1 - n2;
                Console.WriteLine(n1 + "+" + n2 + "=" + r);
            }   
            else if(op == "*")
            {
                 r = n1 * n2;
                Console.WriteLine(n1 + "+" + n2 + "=" + r);
            }
            else if( op == "/")
            {
                r = n1 / n2;
                Console.WriteLine(n1 + "+" + n2 + "=" + r);
            }
            else    
                //Saída de erro
                Console.WriteLine("ERROR.Operação não encontrada");


            //Encerramento

            Console.ReadKey();
        }
    }
}
