public class Termometro
 {
    private double temperatura;
    public Termometro()
    {
        temperatura = 0.0;
    }
    public double Temperatura
    {
        get
        {
            return temperatura;
        }
    }
    public void Aumentar(double t)
    {
        temperatura += t;
    }
    public void Diminuir(double t)
    {
        temperatura -= t;
    }
 }

  public class TermometroEletrico : Termometro, IEstadoBinario
 {
    private bool ligado = false;
    public void Ligar()
    {
        ligado = true;
    }
    public void Desligar()
    {
        ligado = false;
    }
    public EstadoBinario Estado
    {
        get
        {
            if (ligado) return EstadoBinario.Ligado;
            else return EstadoBinario.Desligado;
        }
    }
 }