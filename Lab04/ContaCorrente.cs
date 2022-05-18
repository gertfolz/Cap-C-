using System;
class ContaCorrente 
{
    private decimal saldo;
    public string Nome {get; init;}
    public DateTime data {get; init;}
    private int contador = 0;
    private decimal ac = 0M;

    public void Depositar(decimal val)
    {
        saldo = saldo + val;
        ac += saldo;
        contador++;
    }
    
    public void Sacar(decimal val)
    {
        saldo = saldo - val;
        ac += saldo;
        contador++;
    }

    public decimal Media()
    {
        return ac/contador;
    }

    public decimal Saldo
    {
        get { return saldo; }
    }
    public ContaCorrente(decimal saldo, string nome)
    {
        this.saldo = saldo;
        this.Nome = nome;
        this.data =  DateTime.Now;
    }


}
