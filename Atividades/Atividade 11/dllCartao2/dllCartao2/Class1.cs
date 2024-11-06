using System;
using System.Linq;

namespace dllCartao2
{
    public class Validacoes
    {
        public static bool ValidaCartao(string numeroCartao)
        {
            int[] vetorCartao = numeroCartao.Select(c => (int)char.GetNumericValue(c)).ToArray();
            int[] pesos = { 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };
            int soma = 0;
            int resultado = 0;
            for (int i = 0; i < vetorCartao.Length; i++)
            {
                resultado = vetorCartao[i] * pesos[i];
                if (resultado > 9)
                {
                    resultado -= 9;
                }
                soma += resultado;
            }

            if (soma % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
