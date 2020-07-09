﻿using System;

namespace IMC_Vet
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, cont = 1;
            double altura, peso, resul;
            string Nomes;
            double[] vet;
            string[] nomes;

            
            Console.WriteLine("Digite quantas pessoas quer armazenar:");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            vet = new double[N];
            nomes = new string[N];

            for (int i = 0; i < N; i++)
            {

                Console.WriteLine("Digite seu nome: ");
                Nomes = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite sua altura em Metros(m):");
                altura = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Digite seu peso em Kilogramas(Kg):");
                peso = double.Parse(Console.ReadLine());
                Console.WriteLine();

                resul = (peso) / (Math.Pow(altura, 2));

                if (resul < 16)
                {
                    Console.WriteLine(resul.ToString("F3") + " Magreza estrema");
                    Console.WriteLine();
                }

                if (resul >= 16 && resul < 17)
                {
                    Console.WriteLine(resul.ToString("F3") + " Magreza moderada");
                    Console.WriteLine();
                }

                if (resul >= 17 && resul < 18.5)
                {
                    Console.WriteLine(resul.ToString("F3") + " Magreza moderada");
                    Console.WriteLine();
                }

                if (resul >= 18.25 && resul < 25)
                {
                    Console.WriteLine(resul.ToString("F3") + " Saudável");
                    Console.WriteLine();
                }

                if (resul >= 25 && resul < 30)
                {
                    Console.WriteLine(resul.ToString("F3") + " Sobrepeso");
                    Console.WriteLine();
                }

                if (resul >= 30 && resul < 35)
                {
                    Console.WriteLine(resul.ToString("F3") + " Obesidade Grau I");
                    Console.WriteLine();
                }

                if (resul >= 35 && resul < 40)
                {
                    Console.WriteLine(resul.ToString("F3") + " Obesidade Grau II (severa)");
                    Console.WriteLine();
                }

                if (resul >= 40)
                {
                    Console.WriteLine(resul.ToString("F3") + " Obesidade Grau III (morbida)");
                    Console.WriteLine();
                }

                vet[i] = resul;
                nomes[i] = Nomes;
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(i + " - " + nomes[i]);
     
            }
                Console.WriteLine();

            while (cont == 1)
            {
                int i;

                Console.WriteLine("Digite qual pessoa quer consultar: ");
                i = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine(nomes[i] + " = " + vet[i].ToString("F2"));
                Console.WriteLine();

                Console.WriteLine("Digite 1 para fazer outra consulta ou 0 para encerrar");
                cont = int.Parse(Console.ReadLine());
                Console.WriteLine();

            }


        }
    }
}
