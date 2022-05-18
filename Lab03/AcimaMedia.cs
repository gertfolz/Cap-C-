public class media
{

    public static List<double> ListaAcimaMedia(List<double> minhaLista)
    {
        List<double> acimaMedia = new List<double>();
        double average = 0;
        double sum = 0;

        for (int i = 0; i<minhaLista.Count; i++)
        {
            sum += minhaLista[i];
        }
        average = sum/minhaLista.Count;
        for (int i = 0; i<minhaLista.Count; i++)
        {
            if(minhaLista[i] > average)
                acimaMedia.Add(minhaLista[i]);
        }
        return acimaMedia;
    }

    public static int TotalAcimaMedia(List<double> minhaLista)
    {
        int elements = 0; 
        double average = 0;
        double sum = 0;

        for (int i = 0; i<minhaLista.Count; i++)
        {
            sum += minhaLista[i];
        }
        average = sum/minhaLista.Count;
        for (int i = 0; i<minhaLista.Count; i++)
        {
            if(minhaLista[i] > average)
                elements++;
        }
        return elements;
    }

}