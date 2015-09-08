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

            Clientes.Add(novo);
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
            foreach (Cliente item in Clientes)
            {
                if(item.getCod() == cod)
                {
                    return item;
                }
               
            }
            return null;

        }


    }
}
