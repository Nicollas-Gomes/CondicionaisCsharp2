using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionaisCsharp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            int urg;
            

            //entrada do usuario
            Console.WriteLine("Digite seu nível de urgência");
            urg = int.Parse(Console.ReadLine());

            if(urg <= 3)
            {
                Console.WriteLine("Seu nível de urgência é BAIXO");
            }
            else if(urg > 3 & urg <= 6)
            {
                Console.WriteLine("Seu nível de urgência é MEDIO");
            }
            else if (urg > 6 & urg <= 9)
            {
                Console.WriteLine("Seu nível de urgência é ALTO");
            }
            else
            {
                Console.WriteLine("Seu nível de urgência é GRAVE");
            }


            Console.ReadLine();
        }
    }
}
