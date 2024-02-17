// See https://aka.ms/new-console-template for more information
//ANA TREAD olduğu için main fonksiyonunu yazmaya gerek yok gereksiz bellek tüketimi olmaması için!

using Classes;

Console.WriteLine("Hello, World!");
CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.Id = 1;
customer.FirstName = "Abdullah";
customer.LastName = "Dağlı";
customer.City = "Malataya";

Customer customer2 = new Customer
{
    Id=2,City="BURSA",FirstName="A FirstName", LastName="A LastName" 
};

Console.WriteLine(customer2.FirstName);
