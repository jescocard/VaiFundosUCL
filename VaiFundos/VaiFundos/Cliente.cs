using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Cliente
    {
        private string nome;
        private int cod;
        public List<Aplicacao> todasAplicacoes = new List<Aplicacao>();


        public Cliente()
        {
            nome = null;
            
        }
        public string getnome() { return this.nome; }
        public void setNome(string n) { this.nome = n; }
        public int getCod() { return this.cod; }
        public void setCod(int n) { this.cod = n;}

       
    }
}
