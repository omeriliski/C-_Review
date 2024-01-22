using C__Basics.Entities;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Product product1 = new Product(1, "TV", 1000);
Product product2 = new Product(2, "Phone", 2000);
Product product3 = new Product(3, "Computer", 3000);

List<Product> products = new List<Product>() { product1, product2, product3 };

app.MapGet("/api/products", () => products);

app.Run();
