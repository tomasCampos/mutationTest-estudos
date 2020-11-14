using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
{
    public class MediaIntercecao
    {
        public float mediaIntersecao(List<float> m, List<float> n)
        {
            if (!m.Any() || !n.Any())
                return 0;

            var intercecao = new List<float>();
            foreach (var item_m in m)
            {
                foreach (var item_n in n)
                {
                    if (item_m == item_n)
                    {
                        intercecao.Add(item_m);
                        break;
                    }
                }
            }

            if (!intercecao.Any())
                return 0;

            var somaIntercecao = 0f;
            foreach (var numero in intercecao)
            {
                somaIntercecao += numero;
            }

            var resultado = somaIntercecao / intercecao.Count;
            return resultado;
        }
    }
}
