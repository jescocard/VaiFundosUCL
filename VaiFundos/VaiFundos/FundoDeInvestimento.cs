using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class FundoDeInvestimento
    {
        protected string nome;
        protected string cod;
        protected List<Aplicacao> aplicacoes;
        

        public void resgate()
        {


        }
        public void Aplicar(Aplicacao nova,int cod)
        {
            this.aplicacoes.Add(nova);
        }
    }
    


}
