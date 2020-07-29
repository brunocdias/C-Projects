using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tratamentos_erro_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Digite um número: ");

            try
            {
                num = int.Parse(Console.ReadLine());

                for (int i = 0; i < 11; i++)
                    Console.WriteLine(num + " x " + i + " = " + (num * i));
            } catch(Exception erro)
            {
                Console.WriteLine("Você deve digitar um número " + erro.Message);
            }
            finally{
                Console.WriteLine("Digite qualquer tecla para sair.");
                Console.ReadKey();
            }
        }
    }
}
