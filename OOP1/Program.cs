using OOP1;

Console.OutputEncoding = System.Text.Encoding.UTF8;
//tao 1 doi tuong danh muc
Category c1=new Category();
//Gan gia tri cho thuoc tinh
c1.Id = 1;
c1.Name = "Nuoc mam";
//Goi ham xuat du lieu
c1.PrintInfor();

//khoi tao nhan vien

Employee e1=new Employee();
e1.Id = 1; //goi setter Id
e1.Id_card = "00123"; //gei setter property Id_card
e1.Name = "teo";
e1.Email = "teo@gmail.com";
e1.Phone = "0365482281";
//goi ham xuat thong tin
e1.PrintInfor();
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("Id cua e1="+e1.Id);
Console.WriteLine("name cua e1="+ e1.Name);

//Ta cung co the khoi tao doi tuong va cac gia tri cua thuoc tinh nhu sau
Employee e2 = new Employee()
{
    Id = 1,
    Id_card = "123",
    Name = "Name",
    Email = "dads",
    Phone = "11wd1d1",
};
Console.WriteLine("-----------------------------------------E2-------------------------------------");
e2.PrintInfor();

Console.WriteLine("===============================================================");
Employee e3 = new Employee(3, "333", "ba", "3@gmail.com", "033333");
//goi ham xuat thong tin
e3.PrintInfor();
//hoc tu dong goi ham toString() khi doi tuong xuat ra man hinh
Console.WriteLine(e3);

//dung thu constructer mac dinh
Employee e4 = new Employee();
Console.WriteLine(e4);

//tao doi tuong customer
Customer cus1 = new Customer()
{
    Id = "CUS1",
    Name = "Name",
    Address = "Dis",
    Email = "email",
    Phone = "999",
};
cus1.PrintInfor();
cus1.Address = "binh gia vung tau";
cus1.Phone = "0365482281";
Console.WriteLine("thong tin cus sau khi chinh sua");
cus1.PrintInfor();