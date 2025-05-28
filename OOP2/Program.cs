using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;
FulltimeEmployee obama = new FulltimeEmployee()
{
    Id = 1,
    IdCard = "123",
    Name = "Barac Obama",
    Birthday = new DateTime(1960, 11, 25),
};
Console.WriteLine("thông tin của OBAMA");
Console.WriteLine($"ID={obama.Id}");
Console.WriteLine("Name="+obama.Name);
Console.WriteLine("IDCard="+obama.IdCard);
Console.WriteLine("Năm sinh" + obama.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Mức lương obama nhận được = " + obama.calSalary());

ParttimeEmployee trump = new ParttimeEmployee()
{
    Id = 2,
    Name = "Donald trump",
    IdCard = "123",
    Birthday = new DateTime(2005 / 10 / 05),
    workingHour = 5,
};
Console.WriteLine("thông tin của TRUMP");
Console.WriteLine($"ID={trump.Id}");
Console.WriteLine("Name=" + trump.Name);
Console.WriteLine("IDCard=" + trump.IdCard);
Console.WriteLine("Năm sinh" + trump.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Mức lương obama nhận được = " + trump.calSalary());

Console.WriteLine("------------------------------Su dung toString()-----------------------------------");
Console.WriteLine(obama);
Console.WriteLine(trump);