using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace array_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList dados_cliente = new ArrayList();
            dados_cliente.Add("Bruno Cesar Dias");
            dados_cliente.Add("Candido Mota");
            dados_cliente.Add(23);
            dados_cliente.Add(100);

            int qtd_elementos = dados_cliente.Count;

            for (int i = 0; i < qtd_elementos; i++)
                Console.WriteLine(dados_cliente[i]);

            Console.ReadKey();
        }
    }
}
