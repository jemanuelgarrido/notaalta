void matriz ()
{
    String[] nombre = new string[]
    {
        "Anderson","Brandon","Yeimi", "Fatima","vivian"
    };
    foreach (string n in nombre)
    {
        Console.WriteLine("nombre=" + n);
    }
    int[] notas = new int[]
    {
        51,80,96,76,61
    };
    
    static void Main(string[] args)
    {
        // Definir el conjunto de datos con las notas de los alumnos
        Dictionary<string, double> notas = new Dictionary<string, double>();
        notas.Add("Anderson", 51);
        notas.Add("Brandon", 80);
        notas.Add("Yeimi", 96);
        notas.Add("Fatima", 76);
        notas.Add("Vivian", 61);

        var maxNota = notas.Aggregate((l, r) => l.Value > r.Value ? l : r);
        string nombre = maxNota.Key;
        double nota = maxNota.Value;

        
        Console.WriteLine($"La nota más alta es {nota}, obtenida por {nombre}.");
    }


}
matriz();
Console.ReadLine();

