using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tituloEleitor
{
    public class ClsTitulo
    {
        public static bool ValidaTitulo(string titulo)
        {
            if (titulo.Length != 12 || !titulo.All(char.IsDigit))
            {
                return false;
            }

            int[] vetorTitulo = titulo.Select(c => (int)char.GetNumericValue(c)).ToArray();

            int[] pesos1 = { 2, 3, 4, 5, 6, 7, 8, 9 };
            int soma1 = 0;

            for (int i = 0; i < 8; i++)
            {
                soma1 += vetorTitulo[i] * pesos1[i];
            }

            int digVerificador1 = soma1 % 11;
            if (digVerificador1 == 10) digVerificador1 = 0;

            int[] pesos2 = { 7, 8, 9 };
            int soma2 = vetorTitulo[8] * 7 + vetorTitulo[9] * 8 + digVerificador1 * 9;
            int digVerificador2 = soma2 % 11;

            if (digVerificador2 == 10) digVerificador2 = 0;
            if (digVerificador2 == 0 && (titulo[8] == '1' || titulo[8] == '2'))
            {
                digVerificador2 = 1;
            }

            return vetorTitulo[10] == digVerificador1 && vetorTitulo[11] == digVerificador2;
        }
    }
}

