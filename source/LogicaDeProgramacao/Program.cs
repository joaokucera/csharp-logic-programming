﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // (INT)
            // inteiro = 10 (número) - INT
            // A variável abaixo vai guardar um número.
            int numero = 10;

            int energia = 90;
            // Concatenando uma string com um inteiro.
            Console.WriteLine("ENERGIA: " + energia);
            
            int magia = 40;
            // Sempre o que é escrito na tela é uma STRING.
            Console.WriteLine("MAGIA (hp): " + magia);

            int soma1 = 100 + 50; // 150
            int soma2 = energia + magia; // 130

            // (BOOL)
            // boolean = bool = true ou false
            bool oPersonagemFoiAtingido = false; // 0
            bool oPersonagemEstaVivo = true; // 1

            oPersonagemFoiAtingido = true;
            energia = energia - 1; // 89
            energia -= 1; // 88
            energia += 1; // 89

            // (FLOAT)
            // inteiro = 10
            // 10,5 - 10.5 ou seja 10...11 flutuante (float)
            float ouro = 10.5f;
            double ouro2 = 10.5d;
            decimal ouro3 = 10.5m;
            float somatorio = 10.5f + 10.5f + 10.5f;
            float somatorio2 = ouro + ouro + ouro;
            float somatorio3 = ouro + (float)ouro2 + (float)ouro3; // CAST (conversão explicita)

            char letra = 'a'; // 97
            string palavra = "nome do jogo";

            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine(); // LER
            Console.WriteLine("Oi, " + nome + "!"); // ESCREVER

            Console.ReadKey();
        }
    }
}
