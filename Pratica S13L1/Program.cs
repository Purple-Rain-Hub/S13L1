using Pratica_S13L1;

Atleta atleta = new()
{
    Nome = "Pippo",
    Cognome = "Longhi",
    Eta = 63,
    Gol = 7
};

Dipendente dipendente = new Dipendente("Salvatore", "Collottola", 4, "Saltimbanco");

Animale animale = new();
animale.Name = "Arbandù";
animale.Species = "Pappagallo";
animale.Age = 7;

Veicolo veicolo = new()
{
    Modello = "Panda 4x4",
    Colore = "Rossa",
    Anno = 1926
};

Console.WriteLine(atleta.Nome);
Console.WriteLine(dipendente.impiego);
Console.WriteLine(animale.Age);
Console.WriteLine(veicolo.Modello);

