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
        public string getInfFundo()
        {
            return string.Format("Nome: {0}, Sigla: {1}",nome,sigla);
        }


        public virtual void resgate(double valor, int codCliente,GerenciadorCliente g)
        {


        }
        public void Aplicar(double valor, int codCliente,GerenciadorCliente a)
        {
            Cliente aux = new Cliente();
            aux = a.buscaCliente(codCliente);
            Aplicacao nova = new Aplicacao();
            nova.setCliente(a.buscaCliente(codCliente)); 
            nova.setValorAplicacao(valor);
            nova.setDataAplicao(DateTime.Now);
            nova.setRendimento(0);
            this.aplicacoes.Add(nova);
            aux.setTodasAplicacoes(nova);
        }
        public void relatorioFundo(){

            Aplicacao aux;
            
            foreach (Aplicacao item in this.aplicacoes)
            {

                aux = new Aplicacao();
                aux = item;
               
                    Console.WriteLine("O Cliente: {0} , possui o seguinte investimento R$: {1} na data: {2}",aux.getCliente().getnome(),aux.getValorAplicacao(),aux.getDataAplicacao());
                
            }
            
        }
        public virtual double calculaRendimento(Aplicacao a)
            
        {
            int anos = 0;
            TimeSpan dif = DateTime.Now.Subtract(a.getDataAplicacao());
            anos = dif.Days / 365;
            if(anos > 1)
            {
               a.setRendimento(a.getValorAplicacao() * 0.05);
            }
            return a.getRendimento();    
        }
        public virtual void TrocarFundo(int codCliente, double valor ,FundoDeInvestimento f,char a)

        {
            foreach (Aplicacao item in aplicacoes)
            {

                if (item.getCliente().getCod() == codCliente && item.getValorAplicacao() == valor)
                {
                    if (a == 'D')
                    {
                        f.aplicacoes.Add(item);
                        aplicacoes.Remove(item);
                        Console.WriteLine("Troca Efetuada Com Sucesso!!!");
                        return;

                    }
                    else if (a == 'R')
                            {
                        item.setValorAplicacao(item.getValorAplicacao() - 10);
                        f.aplicacoes.Add(item);
                        aplicacoes.Remove(item);
                        Console.WriteLine("Troca Efetuada Com Sucesso!!!");
                        return;
                    }
                
                }
            }
        }

    }
}
