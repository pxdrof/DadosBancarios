namespace ContaBancaria;

class Program
{
    static void Main(string[] args){
        
        Console.Write("Entre o número da conta: ");
        int conta = int.Parse(Console.ReadLine());
        Console.Write("Entre o titular da conta: ");
        string titular = Console.ReadLine();
        Dados  dados = new Dados(conta, titular);
        
        Console.Write("Hávera depósito inicial(s/n)? ");
        string escolha = Console.ReadLine();
        if (escolha != "n")
        {
            Console.Write("Entre o valor de depósito inicial: ");
            double saldo = double.Parse(Console.ReadLine());
            dados = new Dados(conta, titular, saldo);
            dados.AdicionarSaldo(saldo);
            Console.WriteLine("\nDados da Conta: ");
            Console.WriteLine(dados);
            
        } else {
            Console.WriteLine("\nDados da Conta: ");
            Console.WriteLine(dados);
        }
        
        Console.Write("Entre um valor para depósito: ");
        double deposito = double.Parse(Console.ReadLine());
        dados.AdicionarSaldo(deposito);
        Console.WriteLine("Dados da Conta Atualizado: ");
        Console.WriteLine(dados);
        
        Console.Write("Entre um valor para saque: ");
        double saque = double.Parse(Console.ReadLine());
        dados.SacarSaldo(saque);
        Console.WriteLine("Dados da Conta Atualizado: ");
        Console.WriteLine(dados);
    }
}