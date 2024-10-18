using System;

class ContaBancaria
{
    private double Saldo;
    private double ValorInserito;

    public ContaBancaria()
    {
        Saldo = 0; 
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"O seu saldo é R$:{Saldo}");
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();
        Console.Clear();
    }
    
    public void Saque(double valorSaque)
    {
        if (valorSaque < 0 && valorSaque < Saldo)
        {
            Saldo -= ValorInserito;

            Console.WriteLine($"\nSaque de R${ValorInserito} executado com Sucesso!");
            Console.WriteLine($"Seu novo saldo é R$:{Saldo}\n");
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"Valor Inválido! O saque deve ser maior que zero e menor que o seu Saldo: {Saldo}!");
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
            Console.Clear();
        }
    }
    public void Deposito(double valorDeposito)
    {
        Saldo += valorDeposito; 

        Console.WriteLine($"\nDepósito executado com Sucesso!");
        Console.WriteLine($"Seu novo saldo é R$:{Saldo}\n");
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();
        Console.Clear();
    }
}
