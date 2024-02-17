// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Person[] persons = new Person[3]{
    new Customer{FirstName = "Abdullah"}, new Student{FirstName = "Derin"}, new Person{FirstName="Salih"}
};
foreach (var item in persons)
{
    Console.WriteLine(item.FirstName);
}

Console.ReadLine();



class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }


}

class Customer : Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Departmant { get; set; }
}