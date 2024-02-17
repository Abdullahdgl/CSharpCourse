// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
IWorker[] workers = new IWorker[3]
    { 
    new Worker(),
    new Manager(),
    new Robot()
    };

foreach (var worker in workers)
{
    worker.Work();
}

IEat[] eats = new IEat[2] { 
new Worker(),
new Manager()
};

foreach (var item in eats)
{
    item.Eat();
}
interface IWorker
{
    void Work();
   
}

interface IEat
{
    void Eat();
}
interface ISalery
{

    void GetSalery();
}
class Manager : IWorker, IEat, ISalery
{
    public void Eat()
    {
        Console.WriteLine("Yemek Satti.");
    }

    public void GetSalery()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        Console.WriteLine("Çalışma Satti.");
    }
}

class Worker : IWorker, IEat, ISalery
{
    public void Eat()
    {
        Console.WriteLine("Yemek Satti.");
    }

    public void GetSalery()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        Console.WriteLine("Çalışma Satti.");
    }
}

class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Çalışma Satti.");
    }
}