using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Questao1
{
    static void Main(string[] args)
    {
        const int Indice = 13; 
        int soma = 0; 
        int k = 0;    

        while (k < Indice)
        {
            k += 1;
            soma += k;
        }

        Console.WriteLine("O valor final de soma é: " + soma);
    }
}
