using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Aplicacao
    {
        public float valorAplicacao;
        private DateTime dataAplicacao;
        private Cliente cliente;

        public Aplicacao(float valor, Cliente clt)
        {
            this.valorAplicacao = valor;
            this.cliente = clt;
            this.dataAplicacao = DateTime.Now;
        }
        
    }
   
}
