using System.Text;
using OOP3;

Console.OutputEncoding = Encoding.UTF8;
int n1 = 5;
Console.WriteLine("Tong tu 1 toi 5=" + n1.TongTu1ToiN());
int n2 = 10;
Console.WriteLine("tong tu 1 toi 10=" + n2.TongTu1ToiN());
Console.WriteLine("Tong tu 1 toi 100=" + 100.TongTu1ToiN());
Console.WriteLine("10+20="+10.Cong(20));

int[]arr= new int[8];
arr.TaoMang();
Console.WriteLine("mang truoc khi duoc sap xep:");
arr.XuatMang();
arr.SapXepTangDan();
Console.WriteLine("mang sau khi sap xep:");
arr.XuatMang();
