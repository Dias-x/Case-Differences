class Program
{
    static void Main(string[] args)
    {
        //Aufgabe 1
        //Datenvariablien zuweisen
        double körpergewicht;
        double körpergrösse;
        double bmiergebnis;

        //Abfrage und Benutzer eingabe
        Console.Write($"Gebe dein Gewicht ein: ");
        körpergewicht = double.Parse(Console.ReadLine());
        Console.Write($"Gebe deine Grösse ein: ");
        körpergrösse = double.Parse(Console.ReadLine());

        bmiergebnis = körpergewicht / (körpergrösse * körpergrösse);

        //Fallunterschied If Else

        if (bmiergebnis <= 18.4)
        {
            Console.WriteLine($"Dein BMI-Wert ist: {bmiergebnis} sie sind Untergewichtig");
        }
        else if (bmiergebnis >= 18.4 && bmiergebnis <= 24.9)
        {
            Console.WriteLine($"Dein BMI-Wert ist: {bmiergebnis} sie sind Normalgewicht");
        }
        else if (bmiergebnis >= 25 && bmiergebnis <= 29.9)
        {
            Console.WriteLine($"Dein BMI-Wert ist: {bmiergebnis} sie sind Übergewichtig");
        }
        else if (bmiergebnis >= 30 && bmiergebnis <= 34.9)
        {
            Console.WriteLine($"Dein BMI-Wert ist: {bmiergebnis} sie sind Adipositas Grad 1");
        }
        else if (bmiergebnis >= 35 && bmiergebnis <= 39.9)
        {
            Console.WriteLine($"Dein BMI-Wert ist: {bmiergebnis} sie sind Adipositas Grad 2");
        }
        else if (bmiergebnis >= 40)
        {
            Console.WriteLine($"Dein BMI-Wert ist: {bmiergebnis} sie sind Adipositas Grad 3");
        }
        else
        {
            Console.WriteLine($"Ungültige Angabe");
        }
        
        
        //Aufgabe 2
        //Datenvariablen zuweisen
        /*int geburtsjahr;
        
        
        //Benutzer eingabe und If/Else auswerten
        Console.Write($"Geburtsjahr ein: ");
        geburtsjahr = int.Parse(Console.ReadLine());

        //True
        if (Schaltjahr(geburtsjahr))
        {
            Console.WriteLine(geburtsjahr + " Schaltjahr");
        }
        //False
        else
        {
            Console.WriteLine(geburtsjahr + " Kein Schaltjahr");
        }*/
        
        
        //Aufgabe 3
        //Datenvariablen zuweisen
        /*int zahl1;
        int zahl2;
        string Operator;
        double ergebnis;

        //Eingabe des Benutzers
        Console.Write($"Geben sie eine Zahl: ");
        zahl1 = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Geben sie ein Operator ( + | - | x | : ): ");
        Operator = Console.ReadLine();
        Console.Write($"Geben sie eine Zahl: ");
        zahl2 = Convert.ToInt32(Console.ReadLine());

        //Switch hinzufügen
        switch (Operator)
        {
            case "+":
                ergebnis = zahl1 + zahl2;
                Console.WriteLine($"{zahl1} + {zahl2} = {ergebnis}");
                break;
            case "-":
                ergebnis = zahl1 - zahl2;
                Console.WriteLine($"{zahl1} - {zahl2} = {ergebnis}");
                break;
            case "x":
                ergebnis = zahl1 * zahl2;
                Console.WriteLine($"{zahl1} * {zahl2} = {ergebnis}");
                break; 
            case ":":
                ergebnis = zahl1 / zahl2;
                Console.WriteLine($"{zahl1} : {zahl2} = {ergebnis}");
                break;
            default:
                Console.WriteLine($"Ungültige Eingabe");
                break;
        }*/

    }
    //Gehört zu Aufgabe2
    //Methode mit True/False rückgabewert (Modulo-Operator verwenden)
    /*static bool Schaltjahr(int geburtsjahr)
    {
        return (geburtsjahr % 4 == 0 && geburtsjahr % 100 != 0) || (geburtsjahr % 400 == 0);
    }*/
}