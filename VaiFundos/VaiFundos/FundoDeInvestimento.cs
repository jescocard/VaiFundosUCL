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

        public FundoDeInvestimento(string nome, string sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
        }


        public void resgate()
        {


        }
        public void Aplicar(double valor, int codCliente)
        {
            GerenciadorCliente gerenciador = new GerenciadorCliente();
            Aplicacao nova = new Aplicacao();
            nova.setCliente(gerenciador.buscaCliente(codCliente)); 
            nova.setValorAplicacao(valor);
            nova.setDataAplicao(DateTime.Now);
            nova.setRendimento(0);
            this.aplicacoes.Add(nova);
        }
        public void relatorioCliente(int codigo)
        {
            Aplicacao aux;
            foreach (Aplicacao item in this.aplicacoes)
            {

                aux = new Aplicacao();
                aux = item;
                if (aux.getCliente().getCod().Equals(codigo))
                {
                    Console.WriteLine("O Cliente: {0} , possui o seguinte investimento R$: {1} na data: {2}",aux.getCliente().getnome(),aux.getValorAplicacao(),aux.getDataAplicacao());
                }
            }
            
        }
    }



}
