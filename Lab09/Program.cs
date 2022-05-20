class Program
{
    private static void TrataLimiteSuperior(string msg, double valor)
    {
        Console.WriteLine(($"{msg} Temperatura: {valor}"));
    }
    static void Main(string[] args)
    {
        // inicializa o termometro e mostra seu valor
        TermometroLimite term = new TermometroLimite(5);
        Console.WriteLine(term.ToString());
        // adiciona um tratador ao evento LimiteSuperiorEvent
        term.LimiteSuperiorEvent += new TermometroLimite.MeuDelegate(TrataLimiteSuperior);
        term.TempNormalEvent += new TermometroLimite.MeuDelegate(TrataLimiteSuperior);
        // aumentar a temperatura além do limite
        term.Aumentar(6);
        Console.WriteLine(term.ToString());
        term.Diminuir(3);
        Console.WriteLine(term.ToString());
    }
}

