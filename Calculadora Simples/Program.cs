// See https://aka.ms/new-console-template for more information
					using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Bem Vindo à Calculadora");
        
        double valor1, valor2, calculo = 0;
        Console.WriteLine("Insira o Primeiro valor: ");
        
        string texto = Console.ReadLine();
        if (Double.TryParse(texto, out valor1))
        {
            Console.WriteLine("Insira a operação que deseja fazer (+, -, *, /): ");
            string sinal = Console.ReadLine();
            
            Console.WriteLine("Insira o Segundo valor: ");
            string texto1 = Console.ReadLine();
            
            if (Double.TryParse(texto1, out valor2))
            {
                bool operacaoValida = true;

                switch (sinal)
                {
                    case "+":
                        calculo = valor1 + valor2;
                        Console.WriteLine($"O Resultado da Soma é {calculo}");
                        break;
                    case "-":
                        calculo = valor1 - valor2;
                        Console.WriteLine($"O Resultado da Subtração é {calculo}");
                        break;
                    case "*":
                        calculo = valor1 * valor2;
                        Console.WriteLine($"O Resultado da Multiplicação é {calculo}");
                        break;
                    case "/":
                        if (valor2 != 0)
                        {
                            calculo = valor1 / valor2;
                            Console.WriteLine($"O Resultado da Divisão é {calculo}");
                        }
                        else
                        {
                            operacaoValida = false;
                            Console.WriteLine("Erro: Divisão por zero");
                        }
                        break;
                    default:
                        operacaoValida = false;
                        Console.WriteLine("Operação Inválida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Valor Inválido para o segundo valor");
            }
        }
        else
        {
            Console.WriteLine("Valor Inválido para o primeiro valor");
        }
    }
}
