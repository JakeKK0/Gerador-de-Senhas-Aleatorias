using System;

namespace GeradorDeSenhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerador de Senhas");
            Console.WriteLine("Quantos caracteres a senha deve ter?");
            int tamanho = int.Parse(Console.ReadLine());
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()";
            Random random = new Random();
            char[] senha = new char[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                senha[i] = caracteres[random.Next(caracteres.Length)];
            }

            Console.WriteLine("Senha gerada: " + new string(senha));
            Console.WriteLine("Aproveite!!!");
            Console.WriteLine("Pau nas do job");
        }
    }
}