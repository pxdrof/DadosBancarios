using System.Globalization;

namespace ContaBancaria;

class Dados
{
    public int Conta { get; private set; }
    public string Nome { get; set; }
    public double Saldo { get; private set; }
    
    
    public Dados(){
        
    }
    
    public Dados(int conta, string nome) : this(){
        Conta = conta;
        Nome = nome;
    }
    
    public Dados(int conta, string nome, double saldo) : this(conta, nome){
        Saldo = 0;
    }
    
    public void AdicionarSaldo(double deposito){
        Saldo += deposito;
    }
    
    public void SacarSaldo(double saque){
        Saldo -= (saque + 5);
    }
    
    public override string ToString(){
        return
            "Conta: " + Conta
                      + ", Titular: " + Nome
                      + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture) 
                      + "\n";
    }
    
}
    