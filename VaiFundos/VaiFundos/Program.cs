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
            Cliente a = new Cliente("jefferson");
            
            FundosEmDolar fundo_dolar1 = new FundosEmDolar("Fundos USA", "FSA");
            FundosEmDolar fundo_dolar2 = new FundosEmDolar("Cambio USA", "CSA");
            FundosEmReal fundo_real1 = new FundosEmReal("Fundo Deposito Interbancario", "DI");
            FundosEmReal fundo_real2 = new FundosEmReal("Atmos Master", "FIA");

            fundo_dolar1.Aplicar(201.3,a);
        }
    }
}
