using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class FundosEmReal : FundoDeInvestimento
    {
        public FundosEmReal (string nome, string sigla) : base(nome, sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
        }
    }
}
