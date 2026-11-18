using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Rifa_Sorteio.Services
{
    internal class RifaService
    {
        public static int[] sortear()
        {
            Random random = new Random();
            int[] numerosSorteados = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numerosSorteados[i] = random.Next(0, 3000);
            }
            return numerosSorteados;
        }

        public static bool verificar(int[] numerosSorteados, int[] numerosPremiados)
        {
            foreach (int numero in numerosSorteados)
            {
                if (Array.Exists(numerosPremiados, n => n == numero))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
