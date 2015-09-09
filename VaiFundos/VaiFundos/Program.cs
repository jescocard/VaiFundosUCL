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
            
            GerenciadorCliente gerenciador = new GerenciadorCliente();
            gerenciador.cadastrarCliente("jefferson");
            gerenciador.cadastrarCliente("AAAAAA");
            Cliente a = new Cliente();

              FundosEmDolar fundo_dolar1 = new FundosEmDolar("Fundos USA", "FSA");
              FundosEmDolar fundo_dolar2 = new FundosEmDolar("Cambio USA", "CSA");
              FundosEmReal fundo_real1 = new FundosEmReal("Fundo Deposito Interbancario", "DI");
              FundosEmReal fundo_real2 = new FundosEmReal("Atmos Master", "FIA");
              

             fundo_dolar1.Aplicar(201.3, 2,gerenciador);
             fundo_dolar1.Aplicar(201.0, 2,gerenciador);

             fundo_dolar1.relatorioCliente(2);

           // gerenciador.listarClientes();
           // a = gerenciador.buscaCliente(2);

           // Console.WriteLine("{0}: :   {1}",a.getnome(), a.getCod());

            




            Console.ReadKey();

        }
    }
}
