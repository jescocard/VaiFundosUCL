using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Aplicacao
    {
        private double valorAplicacao = 0;
        private DateTime dataAplicacao;
        private Cliente cliente = new Cliente();
        private double rendimento  = 0;

        public double getValorAplicacao()
        {
            return this.valorAplicacao;
        }
        public void setValorAplicacao(double valor)
        {
            this.valorAplicacao = valor;
        }
        public DateTime getDataAplicacao()
        {
            return this.dataAplicacao;
        }
        public void setDataAplicao(DateTime d)
        {
            this.dataAplicacao = d;
        }
        public Cliente getCliente()
        {
            return this.cliente;
        }
        public void setCliente(Cliente c)
        {
            this.cliente = c;
        }
        public double getRendimento()
        {
            return this.rendimento;
        }
        public void setRendimento(double r)
        {
            this.rendimento = r;
        }
    }
   
}
