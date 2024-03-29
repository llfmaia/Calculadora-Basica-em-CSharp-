﻿
//**   Método principal aonde ocorrerá a execução do programa




using System;
namespace Calculadora_B_sica_em_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int key = 0;
            Word.WriteManual("Olá, seja bem-vindo a minha primeira calculadora hospedada no GitHub!\n");
            while(true){
            double n1=0,n2=0;
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.Blue;
                Word.WriteManual("O que deseja fazer ?\n\n[1] Soma\n[2] Subtração\n[3] Multiplicação\n[4] Divisão\n[5] Sair do Programa\n\n");
                Console.ForegroundColor = ConsoleColor.Magenta;
                key = Word.askUserInt("===>>>");
                if(key == 5)
                    break;
                Console.Clear();
                
                Console.ForegroundColor = ConsoleColor.Magenta;
                n1 = Word.askUserDouble("Digite seu primeiro número: ");
                n2 = Word.askUserDouble("Digite seu segundo número: ");
                Word.WriteManual($"Seus números foram: {n1} e {n2}\n\n");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
               
                for(int i = 0; i <= 3; i++){
                    System.Console.WriteLine("\n" + i);
                    System.Threading.Thread.Sleep(1000);
                }
                Console.Clear();    
                Console.ForegroundColor = ConsoleColor.Green;
                switch (key)
                {
                    case 1:
                        Console.Clear();
                        Word.WriteManual($"O resultado da soma de {n1} e {n2} é igual à {Counts.Plus(n1, n2)}\n");
                        break;
                    case 2:
                        Console.Clear();
                        Word.WriteManual($"O resultado da subtração de {n1} e {n2} é igual à {Counts.Minus(n1, n2)}\n");
                        break;
                    case 3:
                        Console.Clear();
                        Word.WriteManual($"O resultado da multiplicação de {n1} e {n2} é igual à {Counts.Times(n1, n2)}\n");
                        break;
                    case 4:
                        Console.Clear();
                        Word.WriteManual($"O resultado da divisão de {n1} e {n2} é igual à {Counts.Div(n1, n2)}\n");
                        break;
                }
            }

            catch(Exception error)
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
                Word.WriteManual($"VALOR DIGITADO NÃO RECONHECIDO! FAVOR SIGA AS INSTRUÇÕES!\n\n"+error.Message+"\n");
                System.Threading.Thread.Sleep(5000);
                Console.Clear();
            }

            Console.ResetColor();
            }

            Console.Clear();
            Console.ForegroundColor = System.ConsoleColor.Yellow;
            Word.WriteManual($"PROGRAMA FINALIZADO COM SUCESSO! OBRIGADO POR ME USAR!!!!");
            Console.ResetColor();
        }

    }
}
