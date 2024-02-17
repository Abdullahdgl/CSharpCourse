internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //Add();
        //Add();
        //Add();
        //var result =Add2(20);

        //int number1 = 20;
        //int number1;
        //int number2 = 100;
        //var result2 = Add3(out number1 , number2);

        //Console.WriteLine(result2);
        //Console.WriteLine(number1);
        //Console.WriteLine(Multiply(2, 4));
        //Console.WriteLine(Multiply(2, 4, 5));0
        //Console.WriteLine(Add4(1,2,3,4,5,6));


        Console.ReadLine();
    }

    #region Neden Metot kullanıyoruz.
    //static void Add()
    //{
    //    Console.WriteLine("Added!!!");
    //}

    #endregion

    #region Parametreli metotlarla çalışmak.
    //static int Add2(int number1, int number2)
    //{

    //    var result = number1 + number2;
    //    return result;

    //}
    #endregion

    #region Default Parametreli Metotlar
    //Default değer daima ilki olmamlı parametrelerde son degerden başlanmalı
    //static int Add2(int number1, int number2=30)
    //{

    //    var result = number1 + number2;
    //    return result;

    //}

    #endregion
    #region Ref Keyword'ü ile çalışmak.
    //static int Add3(out int number1, int number2)
    //{
    //    number1 = 30;
    //    return number1 + number2;
    //}

    #endregion

    #region Metot Overloading

    //static int Multiply(int number1, int number2)
    //{
    //    return number1 * number2;

    //}
    //static int Multiply(int number1, int number2, int number3)
    //{
    //    return number1 * number2 * number3;

    //}
    #endregion
    #region Params Keywordü
    //metodumuza aynı tiple istediğimiz kadar parametre gönderebiliriz.

    //static int Add4(params int[] numbers)
    //{
    //    return numbers.Sum();
    //}


    #endregion
  


}








