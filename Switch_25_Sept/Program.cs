//1.Fråga användaren om ett tal mellan 1 och 50
//2. Utvärdera talet
//a. 11 ska ge svaret ”Talet är 11”
//b. 22 ska ge svaret ”Talet är 22”
//c. 33 ska ge svaret ”Talet är 33”
//d. 44 ska ge svaret ”Talet är 44”
//e. <1 ska ge svaret ”Talet är för litet”
//f. <10 ska ge svaret ”Talet är mindre än 10”
//g. <20 ska ge svaret ”Talet är mindre än 20”
//h. <20 ska ge svaret ”Talet är mindre än 30”
//i. <40 ska ge svaret ”Talet är mindre än 40”
//j. >50 ska ge svaret ”Alldeles för högt tal!”


//Console.WriteLine("Ange ett tal mellan 1 och 50");
//int svar = Convert.ToInt32(Console.ReadLine());

//switch (svar)
//{
//    case 11:
//        Console.WriteLine("Talet är 11");
//        break;
//    case 22:
//        Console.WriteLine("Talet är 22");
//        break;
//    case 33:
//        Console.WriteLine("Talet är 33");
//        break;
//    case 44:
//        Console.WriteLine("Talet är 44");
//        break;
//    case < 1:
//        Console.WriteLine("Talet är för litet");
//        break;
//    case < 10:
//        Console.WriteLine("Talet är mindre än 10");
//        break;
//    case < 20:
//        Console.WriteLine("Talet är mindre än 20");
//        break;
//    case < 30:
//        Console.WriteLine("Talet är mindre än 30");
//        break;
//    case < 40:
//        Console.WriteLine("Talet är mindre än 40");
//        break;
//    case > 50:
//        Console.WriteLine("Alldeles för högt tal");
//        break;
//        default:
//        Console.WriteLine("Heheehe");
//        break;
//}

//1.Skapa en enum med alla månader
//2. Fråga användaren om en månad
//3. Omvandla input texten till en månads-enum
//4.Kör en switch på ditt enum
//5.Skriv ut helg och högtidsdagar för given månad
//6. För tips kolla in: https://www.holidayscalendar.com/categories/weird/


Console.WriteLine("Ange en månad:");
var input = Console.ReadLine();
string firstLetter = input.Substring(0, 1); // Gör så att man kan skriva in månad med liten bokstav utan att den visar default 
string bigLetter = firstLetter.ToUpper(); 
string restLetter = input.Substring(1, input.Length - 1);
string inputCorrect = bigLetter + restLetter;
Enum.TryParse(inputCorrect, out Månader inputEnum);

switch (inputEnum)
{
    case Månader.Januari:
        Console.WriteLine("Dags o jobba nu");
        break;
    case Månader.Februari:
        Console.WriteLine("Månad 2");
        break;
    case Månader.Mars:
        Console.WriteLine("Mars... Jobba på");
        break;
    case Månader.April:
        Console.WriteLine("Snart semester...");
        break;
    case Månader.Maj:
        Console.WriteLine("Tidig semester!");
        break;
    case Månader.Juni:
        Console.WriteLine("JUNI! :D");
        break;
    case Månader.Juli:
        Console.WriteLine("Åka skidor, wiiii");
        break;
    case Månader.Augusti:
        Console.WriteLine("Jobba igen... :(");
        break;
    case Månader.September:
        Console.WriteLine("Löneökning! Kötta på...");
        break;
    case Månader.Oktober:
        Console.WriteLine("Födelsedag. Hurra!");
        break;
    case Månader.Novmber:
        Console.WriteLine("Snart jul!");
        break;
    case Månader.December:
        Console.WriteLine("JULEN E HÄR :D");
        break;
    default:
        Console.WriteLine("Ange en månad!");
        break;
}








Dagar dag = Dagar.Måndag;
switch (dag)
{
    case Dagar.Måndag:
    case Dagar.Tisdag:
        Console.WriteLine("Självstudier");
        break;
    case Dagar.Onsdag:
        Console.WriteLine("Skola");
        break;
    case Dagar.Torsdag:
        Console.WriteLine("Familjen");
        break;
    case Dagar.Fredag:
        Console.WriteLine("Skola");
        break;
    case Dagar.Lördag:
        Console.WriteLine("Kompisar");
        break;
    case Dagar.Söndag:
        Console.WriteLine("Ta det lugnt");
        break;
}


enum Dagar
{
    Måndag, Tisdag, Onsdag, Torsdag, Fredag, Lördag, Söndag
}

enum Månader
{
    Januari = 1, Februari, Mars, April, Maj, Juni, Juli, Augusti, September, Oktober, Novmber, December
}








//namespace Switch
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {


//        }

//        static void SwitchHehe()
//        {

//        }

//    }
//}