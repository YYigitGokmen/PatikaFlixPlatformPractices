using PatikaflixSeriesPlatformPractice;

public class Program
{

    static void Main(string[] args)
    {

        List<PatikaflixPlatform> patikaflix = new List<PatikaflixPlatform>();

        while (true)
        {

            PatikaflixPlatform newEntry = new PatikaflixPlatform();


            Console.WriteLine("Dizinin adını giriniz");
            newEntry.seriesName = Console.ReadLine();


            Console.WriteLine("Dizinin yapım yılını giriniz");
            newEntry.productionYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dizinin türünü giriniz");
            newEntry.type = Console.ReadLine();


            Console.WriteLine("Dizinin yayınlanmaya başlama yılını giriniz");
            newEntry.startDate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dizinin yönetmenlerini giriniz");
            newEntry.directors = Console.ReadLine();

            Console.WriteLine("Dizinin yayınlandığı ilk platformu giriniz");
            newEntry.firstPlatformPublished= Console.ReadLine();

          patikaflix.Add(newEntry);

            Console.Write("Başka bir dizi eklemek ister misiniz? (evet/hayır): ");
            string continueInput = Console.ReadLine().ToLower();

            if (continueInput != "evet")
            {
                break; 
            }

        }
        // console tablo şeklinde bastırmak istedim ve chatgpt den bu güzel formatı buldum
        Console.WriteLine("\nGirilen Dizi Platformu Bilgileri");

        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("| {0,-30} | {1,-15} | {2,-20} | {3,-15} | {4,-30} | {5,-25} |", "Dizinin adı", "Dizinin yapım yılı","Dizinin Türü", "Başlama yılı", "Dizinin yönetmenleri", "Dizinin yayınlandığı ilk platform");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

        foreach (var enteredSeries in patikaflix)
        {
            Console.WriteLine("| {0,-30} | {1,-15} |   {2,-20} | {3,-15} | {4,-30} | {5,-25} |",

               enteredSeries.seriesName,
                enteredSeries.productionYear,
                enteredSeries.type,
                enteredSeries.startDate,
                enteredSeries.directors,
                enteredSeries.firstPlatformPublished);

        }

        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


        //İlk listenizde bulunan komedi dizilerinden yeni bir liste oluşturunuz.
        //Bu listede yalnızca Dizi Adı / Dizi Türü / Yönetmen bilgileri yer alsın
        //(Yani başka bir class ihtiyacınız doğuyor.)

        List<ComedySerie> comedySeriesList = patikaflix
            .Where(s => s.type.ToLower().Contains("komedi")) 
            .Select(s => new ComedySerie
            {
                seriesName = s.seriesName,
                type = s.type,
                directors = s.directors
            })
            .ToList();

        //Yazımın öncelikle dizi isimleri sonra da yönetmen isimleri baz alınarak sıralanmasına özen gösteriniz.

        var sortedComedySeriesList = comedySeriesList
           .OrderBy(cs => cs.seriesName)
           .ThenBy(cs => cs.directors)
           .ToList();



        Console.WriteLine("\nKomedi Dizileri:");
        Console.WriteLine("-------------------------------------------------------------------------------------------");
        Console.WriteLine("| {0,-30} | {1,-20} | {2,-30} |", "Dizi Adı", "Türü", "Yönetmen");
        Console.WriteLine("-------------------------------------------------------------------------------------------");

        foreach (var comedySeries in sortedComedySeriesList)
        {
            Console.WriteLine("| {0,-30} | {1,-20} | {2,-30} |",
                comedySeries.seriesName,
                comedySeries.type,
                comedySeries.directors);
        }

        Console.WriteLine("-------------------------------------------------------------------------------------------");






    }
}