using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class GerenciadorCliente : Cliente
    {
        public List<Cliente> Clientes = new List<Cliente>();
        private List<Aplicacao> todasAplicacoes = new List<Aplicacao>();

        public List<Aplicacao> getTodasAplicacoes()
        {
            return this.todasAplicacoes;
        }
        public void setTodasAplicacoes(Aplicacao a)
        {
            this.todasAplicacoes.Add(a);
        }

        public void cadastrarCliente(string n)
        {
            Cliente novo = new Cliente();
            novo.setNome(n);
            novo.setCod(Clientes.Count + 1);

            this.Clientes.Add(novo);
        }
        public void listarClientes()
        {
            foreach (Cliente s in Clientes)
            {
                Console.WriteLine("Nome: {0}, Codigo:{1}", s.getnome(), s.getCod());
            }

        }
        public Cliente buscaCliente(int cod)
        {
            foreach (Cliente item in this.Clientes)
            {
                if(item.getCod() == cod)
                {
                    return item;
                   
                }
               
            }
            return null;

        }
        public void relatorioCliente(int codigo)
        {

            Aplicacao aux;
            foreach (Aplicacao item in this.todasAplicacoes)
            {

                aux = new Aplicacao();
                aux = item;
                if (aux.getCliente().getCod().Equals(codigo))
                {
                    Console.WriteLine("O Cliente: {0} , possui o seguinte investimento R$: {1} na data: {2}", aux.getCliente().getnome(), aux.getValorAplicacao(), aux.getDataAplicacao());
                }
            }

        }


    }
}
