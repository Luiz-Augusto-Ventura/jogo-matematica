using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMatematica
{
    class Ranking
    {
        private Jogador[] pontuacao;
        
        public Ranking(List<Jogador> L)
        {
            pontuacao = new Jogador[L.Count];
            for (int i = 0; i < pontuacao.Length; i++)
            {
                pontuacao[i] = L[i];
            }
        }

        public Jogador[] Ordena()
        {
            int c, j, nk;
            Jogador k;
            c = 0;
            nk = pontuacao.Length - 1;
            while (c < pontuacao.Length)
            {
                j = 0;
                while (j < nk)
                {
                    if (pontuacao[j].Pontuacao < pontuacao[j+1].Pontuacao)
                    {
                        k = pontuacao[j];
                        pontuacao[j] = pontuacao[j + 1];
                        pontuacao[j + 1] = k;
                    }
                    j++;
                }
                nk--;
                c++;
            }
            return pontuacao;
        }
    }
}
