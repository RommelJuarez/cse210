using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        string frase = "Este es un ejemplo de frase que será ocultada progresivamente";
        
        
        string[] palabras = frase.Split(' ');
        bool[] palabrasOcultas = new bool[palabras.Length];

        Random random = new Random();
        int palabrasRestantes = palabras.Length;

        while (palabrasRestantes > 0)
        {
            Console.Clear();

            
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabrasOcultas[i])
                {
                    Console.Write("_ ");
                }
                else
                {
                    Console.Write(palabras[i] + " ");
                }
            }

            
            Console.WriteLine("\nPresiona Enter para ocultar una palabra...");
            Console.ReadLine();

            
            int indice;
            do
            {
                indice = random.Next(0, palabras.Length);
            } while (palabrasOcultas[indice]);

            
            palabrasOcultas[indice] = true;
            palabrasRestantes--;
        }

       
        Console.Clear();
        Console.WriteLine("Frase completamente oculta.");
    }
}
