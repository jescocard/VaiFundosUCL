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
            fundo_dolar2.Aplicar(200.0, 2, gerenciador);
            fundo_real2.Aplicar(200.0, 2, gerenciador);
            fundo_real2.Aplicar(2, 1, gerenciador);

            fundo_dolar1.TrocarFundo(2, 201, fundo_real1);
            fundo_real1.relatorioFundo();
            Console.WriteLine("");
            fundo_dolar1.relatorioFundo();
            //fundo_dolar1.relatorioFundo();
            //fundo_dolar1.resgate(201, 2, gerenciador);
            //fundo_real2.resgate(2, 1, gerenciador);
            //fundo_real2.relatorioFundo();
            //fundo_dolar1.relatorioFundo();
            //Console.WriteLine("");
            //erenciador.relatorioCliente(gerenciador.buscaCliente(1));
            
            Console.ReadKey();

        }
    }
}
