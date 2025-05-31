using System.Runtime.ConstrainedExecution;
using System.Text;
using OOP5_Dictionary;

Console.OutputEncoding = Encoding.UTF8;
Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nuoc ngot";

Product p1 = new Product()
{
    Id = 1,
    Name = "Coca",
    Quantity = 10,
    Price = 15000
};
c1.AddProduct(p1);

Product p2 = new Product()
{
    Id = 2,
    Name = "Monster",
    Quantity = 30,
    Price = 15000
};
c1.AddProduct(p2);

Product p3 = new Product()
{
    Id = 3,
    Name = "Redbull",
    Quantity = 18,
    Price = 5000
};
c1.AddProduct(p3);

Product p4 = new Product()
{
    Id = 4,
    Name = "Pepsi",
    Quantity = 20,
    Price = 80000
};
c1.AddProduct(p4);

Product p5 = new Product()
{
    Id = 5,
    Name = "C2",
    Quantity = 10,
    Price = 9000
};
c1.AddProduct(p5);

Console.WriteLine("---------------------------Toan bo san pham nuoc ngot-----------------------------");
c1.PrintAllProducts();

Dictionary<int, Product> filters = c1.FilterProductsByPrice(10000, 20000);
Console.WriteLine("----------------------cac san pham co gia thu 10000 -> 20 ---------------------------");
foreach (KeyValuePair<int, Product> kvp in filters)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

Dictionary<int, Product> sort_result = c1.SortProductByPrice();
Console.WriteLine("----------------------danh sach cac san pham sau khi sort by price---------------------------");
foreach (KeyValuePair<int, Product> kvp in sort_result)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

Dictionary<int, Product> complex_sort = c1.ComplexSort();
Console.WriteLine("----------------------danh sach cac san pham sau khi complex sort---------------------------");
foreach (KeyValuePair<int, Product> kvp in complex_sort)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

p1.Name = "Xa xi";
p1.Quantity = 20;
p1.Price = 28000;
c1.UpdateProduct(p1);
Console.WriteLine("-------------San pham sau khi chinh sua--------------------");
c1.PrintAllProducts();

int id = 3;
bool ret=c1.RemoveProduct(id);
if(ret)
{
    Console.WriteLine($"Da xoa san pham co id={id}");
}
else
{
    Console.WriteLine($"Khong tim thay san pham co id={id}");
}
Console.WriteLine("-------------San pham sau khi xoa--------------------");
c1.PrintAllProducts();

Category c2 = new Category();
c2.Id = 2;
c2.Name = "Bia";
c2.AddProduct(new Product()
{
    Id = 6,
    Name = "Saigon",
    Quantity = 10,
    Price = 200000
});
c2.AddProduct(new Product()
{
    Id = 7,
    Name = "333",
    Quantity = 15,
    Price = 200000
});
c2.AddProduct(new Product()
{
    Id = 8,
    Name = "Ken",
    Quantity = 7,
    Price = 400000
});
LinkedList<Category> ss = new LinkedList<Category>();
ss.AddLast(c1);
ss.AddLast(c2);

Console.WriteLine("--------------Toan bo du lieu theo danh muc-----------------------");
foreach (Category c in ss)
{
    Console.WriteLine($"--  Danh muc: {c.Name}  --");
    Console.WriteLine("***********************************");
    c.PrintAllProducts();
    Console.WriteLine("***********************************");
}