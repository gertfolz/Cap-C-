public class Computador : IEstadoBinario
{    
    private bool ligado;
    public Computador()
    {
        ligado = false;
    }
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