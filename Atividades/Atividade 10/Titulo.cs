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
            if (titulo.Length != 10)
            {
                return false; 
            }

            int[] n = { 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] vetorTitulo = titulo.Select(c => (int)char.GetNumericValue(c)).ToArray();
            int apoio, resultado = 0;

            for (int i = 0; i < 8; i++)
            {
                apoio = vetorTitulo[i] * n[i];
                resultado += apoio;
            }
            int digVerificador1 = resultado % 11;

            int resultado2 = 0;
            for (int i = 8; i < 10; i++)
            {
                apoio = vetorTitulo[i] * (i + 1); 
                resultado2 += apoio;
            }
            int digVerificador2 = resultado2 % 11;

            if (vetorTitulo[8] == digVerificador1 && vetorTitulo[9] == digVerificador2)
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

