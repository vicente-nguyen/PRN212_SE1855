using OOP2;
using OOP2_ReUse_Ap_Library;

Console.OutputEncoding = System.Text.Encoding.UTF8;
FulltimeEmployee e1 = new FulltimeEmployee();

e1.Id = 1;
e1.Name = "teo";
e1.IdCard = ("123");
e1.Birthday = new DateTime(1990, 12, 25);
Console.WriteLine("thong tin cua TEO:");
Console.WriteLine(e1);
Console.WriteLine("====>age" + e1.TinhTuoi());