using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tituloEleitor
{
    public class ClsTitulo
    {
        public static Boolean ValidaTitulo(string titulo)
        {
            int [] n = { 2,3,4,5,6,7,8,9 };
            int[] vetorTitulo = titulo.Select(c => (int)char.GetNumericValue(c)).ToArray();
            int apoio, resultado = 0, digVerificador1, digVerificador2;
            int apoio2, resultado2 = 0;
            string digVerificador = "";
            for (int i = 0; i < 8; i++)
            {
                apoio = vetorTitulo[i]*n[i];
                resultado += apoio;
            }
            digVerificador1 = resultado%11;
            
            for (int i = 8; i < 11; i++)
            {
                apoio2 = vetorTitulo[i] * (i - 1);
                resultado2 += apoio2;
            }
            digVerificador2 = resultado % 11;

            digVerificador = ("" + digVerificador1) + ("" + digVerificador2);

            if(vetorTitulo[8] == digVerificador1 && vetorTitulo[9] == digVerificador2)
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
