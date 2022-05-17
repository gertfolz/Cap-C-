    int[] array = new int[5] { 10, 20, 30, 40, 50 };

    foreach (var i in array)
    {
        Console.WriteLine($"Indice = {array.ToList().IndexOf(i)} & Data = {i}");
    }
    Console.WriteLine("\n");

    string[] str = new string[3];
    str[0] = "Um";
    str[1] = "Dois";
    str[2] = "Tres";
    foreach (var s in str)
    {
        Console.WriteLine($"Indice = {str.ToList().IndexOf(s)} & Data = {s}");
    }
    Console.WriteLine("\n");

    DateTime[] dt = new DateTime[2];
    dt[0] = new DateTime(2002, 5, 1);
    dt[1] = new DateTime(2002, 6, 1);
    foreach (var date in dt)
    {
        Console.WriteLine($"Indice = {dt.ToList().IndexOf(date)} & Data = {date.ToLongDateString()}");
    }
    Console.WriteLine("\n");

    // Exercicios
    // Exercicio 1

    int[] arr1 = new int[100];
    int[] arr2 = new int[100];
    
    Random rnd = new Random();

    for (int i = 0; i<arr1.Length; i++)
    {
        arr1[i] = rnd.Next();
    }
    arr2 = arr1;

    for (int i = 0; i<arr1.Length; i++)
    {
        Console.WriteLine($"arr1: {arr1[i]} \t\t arr2: {arr2[i]}");
    }
    Console.WriteLine("\n");
    // Exercicio 2

    int[,] matriz1 = new int[5,5] {
        {1, 2, 3, 4, 5}, 
        {1, 2, 3, 4, 5},
        {1, 2, 3, 4, 5},
        {1, 2, 3, 4, 5},
        {1, 2, 3, 4, 5}};

    int[][] matriz2 = new int[5][] {
        new int[5] {1, 2, 3, 4, 5},
        new int[5] {1, 2, 3, 4, 5},
        new int[5] {1, 2, 3, 4, 5},
        new int[5] {1, 2, 3, 4, 5},
        new int[5] {1, 2, 3, 4, 5}};
    
    for (int i = 0; i<matriz1.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j<matriz1.GetLength(1); j++)
        {
            sum += matriz1[j,i];
        }
        Console.WriteLine($"Soma da coluna{i}={sum}");
    }
    Console.WriteLine("\n");

        for (int i = 0; i<matriz2.Length; i++)
    {
        int sum = 0;
        for (int j = 0; j<matriz2[i].Length; j++)
        {
            sum += matriz2[j][i];
        }
        Console.WriteLine($"Soma da coluna{i}={sum}");
    }
    Console.WriteLine("\n");


