using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMatematica
{
    class Jogador
    {
        private string nome;
        private int pontuacao;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Pontuacao
        {
            get
            {
                return pontuacao;
            }

            set
            {
                pontuacao = value;
            }
        }
    }
}
