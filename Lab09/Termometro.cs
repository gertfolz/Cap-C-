public class Termometro
 {

    private double valor;
    public Termometro()
    {
        valor = 0.0;
    }
    public double Temperatura
    {
        get { return valor; }
        set { valor = value; }
    }
    virtual public void Aumentar()
    {
        valor += 0.1;
    }
    virtual public void Aumentar(double quantia)
    {
        valor += quantia;
    }
    virtual public void Diminuir()
    {
        valor -= 0.1;
    }
    virtual public void Diminuir(double quantia)
    {
        valor -= quantia;
    }
    override public string ToString()
    {
        return valor.ToString();
    }
}

public class TermometroLimite : Termometro
{
    public delegate void MeuDelegate(string msg, double valor);

    public event MeuDelegate LimiteSuperiorEvent;
    public event MeuDelegate TempNormalEvent;
    private double limiteSuperior;

    private bool disparadoEventoLimiteSuperior;
    public TermometroLimite(double ls)
    {
        limiteSuperior = ls;
        disparadoEventoLimiteSuperior = false;
    }
    public double LimiteSuperior
    {
        get { return limiteSuperior; }
        set { limiteSuperior = value; }
    }
    private void OnLimiteSuperiorEvent()
    {
    // verifica se a temperatura ultrapassou o limite e
    // Verifica se o evento já foi disparado, para não disparar continuamente.
    if ((this.Temperatura > limiteSuperior) && (!disparadoEventoLimiteSuperior))
    // verifica se há tratador
        if (LimiteSuperiorEvent != null)
        {
            LimiteSuperiorEvent("Atenção: temperatura acima do limite!!!", this.Temperatura);
            disparadoEventoLimiteSuperior = true;
        }
    }

    private void OnTempNormalEvent()
    {
        if ((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
        {
             if (TempNormalEvent != null)
            {
                TempNormalEvent("Temperatura voltou ao normal!", this.Temperatura);
                disparadoEventoLimiteSuperior = false;
            }
        }
    }
    public override void Aumentar()
    {
        base.Aumentar();
        OnLimiteSuperiorEvent();
    }
    public override void Aumentar(double quantia)
    {
        base.Aumentar(quantia);
        OnLimiteSuperiorEvent();
    }

    public override void Diminuir()
    {
        base.Diminuir();
        OnTempNormalEvent();
    }
    public override void Diminuir(double quantia)
    {
        base.Diminuir(quantia);
        OnTempNormalEvent();
    }
}