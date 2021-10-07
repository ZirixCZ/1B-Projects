using System;

namespace prj_trojuhelnik
{
    class Program
    {
        static void Main(string[] args)
        {
            // Promněnné musí být deklarovány zvenčí do,while cyklu, aby se dali použít na více místech v kódu.
            bool checker1, checker2, checker3;
            double strana1, strana2, strana3;
            // Všechen kód běží v jednom while true cyklu. tímto způsobem uživatel nebude nucen program zavírat a znovu otevírat pro další použití.
            while (true)
            {
                // Opakuj kód v do{}, dokud bude podmínka pravdivá
                do
                {
                    Console.WriteLine("\nNapiste tri cisla, prosim.");
                    checker1 = double.TryParse(Console.ReadLine(), out strana1); // Bere si promněnné jako string a konvertuje je do typu double. Toto celé je kontrolováno boolem (Kontroluje, zda je TryParse validní, tedy jestli uživatel zadal číslo).
                    checker2 = double.TryParse(Console.ReadLine(), out strana2);
                    checker3 = double.TryParse(Console.ReadLine(), out strana3);
                } while (!checker1 || !checker2 || !checker3); // Jestli uživatel nezadal číslo u jednoho, či více promněnných, do,while cykl bude pravdivý a tak se bude opakovat do té doby, dokud uživatel zadá čísla. (a podmínka bude lživá).
            

            // Zjistí, zda je součet dvou stran vždy větší, než strana třetí. tímto způsobem si ověříme, jestli uživatel zapsal validní velikosti stran trojúhelníku a má smysl v programu pokračovat.
            if (strana1 + strana3 > strana2 && strana1 + strana2 > strana3 && strana2 + strana3 > strana1)
                {
                    Console.WriteLine("{0}, {1}, {2} jsou stranami trojuhelniku.", strana1, strana2, strana3);
                    // Jestli se všechny délky stran rovnají, je to trojúhelník rovnostranný. jestli (a = b = c)
                    if (strana1 == strana2 && strana2 == strana3)
                        Console.WriteLine("trojuhelnik je rovnostranny");
                    // Jestli alespoň dvě zadané strany jsou stejně dlouhé, jedná se o trojúhelník rovnoramenný. jestli (a = b, nebo b = c)
                    else if (strana1 == strana2 || strana2 == strana3 || strana1 == strana3)
                        Console.WriteLine("trojuhelnik je rovnoramenny");
                    // Vytvoříme si pole double o velikosti 3 (počínaje od 0 do 3) poté do každého volného místa (od nuly do tří) přidám inviduální stranu.
                    double[] arrDouble = new double[3];
                    arrDouble[0] = strana1*strana1;
                    arrDouble[1] = strana2*strana2;
                    arrDouble[2] = strana3*strana3;
                    // Použiji metodu Array.Sort, která v mém případě využívá "Insertion Sort" algortimus pro seřazení čísel v poli od nejmenšího po největší. více informací pod kódem v *insertion sort
                    Array.Sort(arrDouble);
                    
                    // Pythagorova veta = jednoZMensichCisel + jednoZMensichCisel = NejvetsiCislo (vše na druhou). na pozici 2 (na poslední pozici) máme díky array.sort logicky největší číslo a tak ho dosadíme doprava.
                    if (arrDouble[0] + arrDouble[1] == arrDouble[2])
                        Console.WriteLine("trojuhelnik je pravouhly");
                }
                // pokud uživatel zadá nevalidní velikosti stran a tedy se o trojúhelník nejedná,
                // program se ukončuje (v tomto případě začíná od začátku, jelikož celý kód běží ve while true cyklu)
                else
                    Console.WriteLine("zadane delky stran nemohou byti delkami stran trojuhelniku..");
            }
        }
    }
}

// to, který algorithmus array.sort použije záleží na velikosti danného pole. 
// pro pole s velikostí menší, než 16, se použije mnou zmiňovaný insertion sort. Jde o algorithmus, který si vezme číslo v poli "n" a číslo v poli "n+1" a porovná, které je větší. větší posune doprava. (n plus 1).
// Poté se také používá QuickSort a HeapSort.