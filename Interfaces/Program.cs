// See https://aka.ms/new-console-template for more information
using Interfaces;

Console.WriteLine("Hello, World!");

//InterfacesIntro();
//Demo();

ICustomerDal[] customerDals = new ICustomerDal[3]
{ 
    new SqlServerCustomerDal(),
    new OracleCustomerDal(),
    new MySqlCustomerDal()
};
foreach (var customerDal in customerDals)
{
    customerDal.Add();
   

}


    static void InterfacesIntro()
{
    PersonManager personManager = new PersonManager();
    Customer customer = new Customer
    {
        Id = 1,
        FirstName = "Abdullah",
        LastName = "Dağlı",
        Address = "istanbul"

    };

    Student student = new Student
    {
        Id = 1,
        FirstName = "Mehmet",
        LastName = "Dağlı",
        Departman = "Computer Sciences"
    };
    personManager.Add(customer);
    personManager.Add(student);
}

static void Demo()
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(new SqlServerCustomerDal());

    customerManager.Add(new OracleCustomerDal());
}

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }

}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Address { get; set; }
}
class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Address { get; set; }
}
class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Departman { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }



}