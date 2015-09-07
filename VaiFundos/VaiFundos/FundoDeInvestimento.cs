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
        protected string sigla;
        protected List<Aplicacao> aplicacoes;

        public FundoDeInvestimento(string nome,string sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
        }
        

        public void resgate()
        {


        }
        public void Aplicar(Aplicacao nova,int cod)
        {
            this.aplicacoes.Add(nova);
        }
    }
    


}
