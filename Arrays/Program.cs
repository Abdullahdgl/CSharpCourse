internal class Program
{
    private static void Main(string[] args)
    {
        string[] students = new string[3] { "Engin 2", "Derin  2", "Salih 2" };
        string[] students2 = {"Engin 2","Derin  2","Salih 2" };

        foreach (var student in students2) 
        {
            Console.WriteLine(student);
        }
        string[,] regions = new string[5, 3]{
        {"İstanbul","İzmit","Balıkesir" },
        {"Ankara","Konya","Kırıkkale"}, 
        {"Antalya","Adana","Mersin" }, 
        {"Rize","Trabzon","Samsun" }, 
        {"İzmir","Muğla","Manisa" }
        
        };
        for(int i = 0; i < regions.GetUpperBound(0); i++)
        {
            for(int j = 0; j < regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i,j]);
            }
            Console.WriteLine("****");
        }


        Console.ReadLine();
        

    }



}