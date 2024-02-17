internal class Program
{
    private static void Main(string[] args)
    {
        //Intro();
        string sentence = "My name is Abdullah Dağlı";

        var result = sentence.Length;
        var result2 = sentence.Clone();
        sentence = "My name is Abdullah Dağlı";
       
        bool result3 =sentence.EndsWith("ğ");
        bool result4 = sentence.StartsWith("My name");
        var result5 = sentence.IndexOf("name");
        var result6 = sentence.IndexOf(" ");
        var result7 = sentence.LastIndexOf(" "); // aramaya sondaki bulduğu boşluk karakteri.
        var result8 = sentence.Insert(0, "Hello, ");
        var result9 = sentence.Substring(0, 7);// metni parcalamak için kullanırız.
        var result10 = sentence.ToLower(); //Bütün karakterlerimizi küçük yapar
        var result11 = sentence.ToUpper();//bütün karakterlerimizi büyük yapar
        var result12 = sentence.Replace(" ","_");
        var result13 = sentence.Remove(3, 8);

        Console.WriteLine(result13);


    }

    private static void Intro()
    {
        string city = "Ankara";
        //Console.WriteLine(city[0]);
        foreach (var item in city)
        {
            Console.WriteLine(item);
        }
        string city2 = "İstanbul";
        //string result = city + city2;
        //Console.WriteLine(result);
        Console.WriteLine(String.Format("{0} {1}", city, city2));
    }
}