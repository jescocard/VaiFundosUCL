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
        public List<Aplicacao> aplicacoes = new List<Aplicacao>();

        public FundoDeInvestimento(string nome,string sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
        }
        

        public void resgate()
        {


        }
        public void Aplicar(double valor,Cliente c)
        {
            Aplicacao nova = new Aplicacao();
            nova.cliente = c;
            nova.valorAplicacao = valor;
            nova.dataAplicacao = DateTime.Now;
            nova.rendimento = 0;
            this.aplicacoes.Add(nova);
        }
        public void relatorioCliente(int codigo)
        {
            foreach (Aplicacao item in aplicacoes)
            {
                if(item.cliente.getCod() == codigo) { 
}
            }
        }
    }
    


}
