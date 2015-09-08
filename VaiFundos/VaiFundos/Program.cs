using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorCliente Cadastro = new GerenciadorCliente();
            Cadastro.cadastrarCliente("jefferson");
            Cadastro.cadastrarCliente("Junior");

            Cadastro.listarClientes();

            Console.ReadKey();

        }
    }
}
