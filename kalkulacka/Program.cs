// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vitejte v náše kalkulačce");
string pokracovat = "ano";
while (pokracovat == "ano")
{
    Console.WriteLine("Zadejte první číslo");
    float a = float.Parse(Console.ReadLine());
    Console.WriteLine("Zadejte druhé číslo");
    float b = float.Parse(Console.ReadLine());
    Console.WriteLine("Zvolte si operaci");
    Console.WriteLine("1 - nasobení");
    Console.WriteLine("2 - dělení");
    Console.WriteLine("3 - sčitání");
    Console.WriteLine("4 - odčitání");
    int operace = int.Parse(Console.ReadLine());
    float vysledek = 0;
    switch (operace);
    { 
     case 1:
            vysledek = a * b;
        break;
     case 2 : 
            vysledek = a / b;
        break;
     case 3 :
            vysledek = a + b;
        break;
     case 4 : 
            vysledek = a - b;
        break;
    }
    if ((operace > 0) && (operace < 5))
        Console.WriteLine("Výsledek: {0}", vysledek);
    else
        Console.WriteLine("Vybraly jste si špatnou operací");
    Console.WriteLine("Přejete si zadat dálší příklad? [ano/ne]");
    pokracovat = Console.ReadLine();
    Console.WriteLine("Děkují za použití tohoto programu, aplikace ukončite libovolnou klavesou");

    Console.ReadKey();
