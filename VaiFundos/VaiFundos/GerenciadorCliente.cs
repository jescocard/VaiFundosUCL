using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class GerenciadorCliente : Cliente
    {
        protected List<Cliente> Clientes = new List<Cliente>();
       

       

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
                Console.WriteLine("Nome: {0}, Codigo: {1}", s.getnome(), s.getCod());
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
        public void relatorioCliente(Cliente c)
        {

            Aplicacao aux;
            foreach (Aplicacao item in c.getTodasAplicacoes())
            {

                aux = new Aplicacao();
                aux = item;

               
               
                    Console.WriteLine("O Cliente: {0} , possui o seguinte investimento R$: {1} na data: {2}", aux.getCliente().getnome(), aux.getValorAplicacao(), aux.getDataAplicacao());
               
            }

        }


    }
}
