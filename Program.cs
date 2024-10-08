Console.WriteLine("tervetuloa järjestelmään");
int valintaNro;
for(; ; )
{
    Console.WriteLine("näytä varaukset [1]");
    Console.WriteLine("varaa vuoro [2]");
    Console.WriteLine("Anna palautetta [3]");
    Console.WriteLine("sammuta [0]");
    Console.WriteLine("valitse haluttu toiminnallisuus :");
    string valinta = Console.ReadLine();
    try
    {
        valintaNro = int.Parse(valinta);
    }
    catch (Exception ex) {
                continue;
    }
    switch(valintaNro)
    {
        case 0: Environment.Exit(0); break;
        case 1: nyatavaraukset(); break;
        case 2: varaavuoro(); break;
        case 3: annapalaute(); break;
    }
    
}

void nyatavaraukset() {
    var input = File.ReadAllLines("/Users/macbook/varaus/vataukset.txt");
    foreach (var v in input)
    {
        Console.WriteLine(v);
    }
}
void varaavuoro()
{
    Console.WriteLine("anna vuorosi esim 8.10.2024 8.00-9.00");
    string vuoro = Console.ReadLine();
    List<string> output = new List<string>();
    output.Add(vuoro);

    File.AppendAllLines("/Users/macbook/varaus/vataukset.txt",output);
}

void annapalaute()
{
    Console.WriteLine("anna palautetta oalvelusta");
    Console.ReadLine();
    Console.WriteLine("kiitos palautteestasi");
}