using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static public void Main(string[] args)
        {
        Atleta atleta = new Atleta() { Nome = "Mario", Sport = "Calcio" };
        Dipendente dipendente = new Dipendente() { Nome = "Luca", Ruolo = "Ingegnere" };
        Animale animale = new Animale() { Nome = "Buddy", Specie = "Cane" };
        Veicolo veicolo = new Veicolo() { Marca = "Fiat", Modello = "500" };

        Console.WriteLine(atleta);
        Console.WriteLine(dipendente);
        Console.WriteLine(animale);
        Console.WriteLine(veicolo);

        Console.Read();
    }
}
}
public class Atleta
{
    public string Nome { get; set; }
    public string Sport { get; set; }

    public override string ToString()
    {
        return $"Atleta: {Nome}, Sport: {Sport}";
    }
}

public class Dipendente
{
    public string Nome { get; set; }
    public string Ruolo { get; set; }

    public override string ToString()
    {
        return $"Dipendente: {Nome}, Ruolo: {Ruolo}";
    }
}

public class Animale
{
    public string Nome { get; set; }
    public string Specie { get; set; }

    public override string ToString()
    {
        return $"Animale: {Nome}, Specie: {Specie}";
    }
}

public class Veicolo
{
    public string Marca { get; set; }
    public string Modello { get; set; }

    public override string ToString()
    {
        return $"Veicolo: {Marca} {Modello}";
    }
}
