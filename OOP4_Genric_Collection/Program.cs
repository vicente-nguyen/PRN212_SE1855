using OOP2;

Console.OutputEncoding = System.Text.Encoding.UTF8;

/*
su dung generic lisy de quan ly nhan su
thuc hien day du tinh nang CRUD
C->Create --> them moi nhan su
R->read/retrieve --> doc:truy van, tim kiem, sap xep
U->Update --> Chinh sua du lieu
D->Delete --> Xoa du lieu
 */
//Cau1: C (Create)
//Dung List de tao 5 employee, trong do 4 employeee la chinh thuc va 1 employee la thoi vu
List<Employee> employees = new List<Employee>();
FulltimeEmployee e1 = new FulltimeEmployee();
e1.Id = 1;
e1.Name = "Name1";
e1.IdCard = "Card1";
e1.Birthday = new DateTime(1990, 1, 1);
employees.Add(e1);

FulltimeEmployee e2 = new FulltimeEmployee();
e2.Id = 2;
e2.Name = "Name2";
e2.IdCard = "Card2";
e2.Birthday = new DateTime(1992, 2, 2);
employees.Add(e2);

FulltimeEmployee e3 = new FulltimeEmployee();
e3.Id = 3;
e3.Name = "Name3";
e3.IdCard = "Card3";
e3.Birthday = new DateTime(1994, 3, 3);
employees.Add(e3);

FulltimeEmployee e4 = new FulltimeEmployee();
e4.Id = 4;
e4.Name = "Name4";
e4.IdCard = "Card4";
e4.Birthday = new DateTime(1996, 4, 4);
employees.Add(e4);

ParttimeEmployee e5 = new ParttimeEmployee();
e5.Id = 5;
e5.Name = "Name5";
e5.IdCard = "Card5";
e5.Birthday = new DateTime(2000, 5, 5);
e5.workingHour = 5;
employees.Add(e5);

//cau2 R->XUAT TOAN BO NHAN SU
//Cach xuat 1:
Console.WriteLine("-----------------------------------------DS nhan su cach1---------------------------------------");
employees.ForEach(e => Console.WriteLine(e));
Console.WriteLine("-----------------------------------------DS nhan su cach2---------------------------------------");
foreach (var e in employees)
    Console.WriteLine(e);

//cau3 R->loc ra nhan su chinh thuc va tinh tong luong
List<FulltimeEmployee> fe_list = employees.OfType<FulltimeEmployee>().ToList();
Console.WriteLine("-----------------------------------------DS nhan su chinh thuc cach 1---------------------------------------");
fe_list.ForEach(e => Console.WriteLine(e));
//cach thong thuong
List<FulltimeEmployee> fe_list2 = new List<FulltimeEmployee>();
foreach (var e in employees)
{
    if (e is FulltimeEmployee)
    {
        fe_list2.Add(e as FulltimeEmployee);
    }
}
Console.WriteLine("-----------------------------------------DS nhan su chinh thuc cach 2---------------------------------------");
fe_list.ForEach(e => Console.WriteLine(e));

//Tong luong
double sum_salary=fe_list2.Sum(e=>e.calSalary());
Console.WriteLine("Tong luong = "+sum_salary);

//cau4 R-->sap xep nhan su theo ngay thang nam sinh
for (int i = 0; i < employees.Count; i++)
{
    for (int j = i+1; j < employees.Count; j++)
    {
        Employee ei = employees[i];
        Employee ej = employees[j];
        if (ei.Birthday > ej.Birthday)
        {
            employees[i] = ej;
            employees[j] = ei;
        }
    }
}
Console.WriteLine("-------------------DS nhan su sau khi sap xep-----------------------------------");
employees.ForEach(e => Console.WriteLine(e));

//cau5 xoa nhan su co id la 1
employees.RemoveAll(e => e.Id == 1);
Console.WriteLine("-------------------DS nhan su sau khi xoa nhan su Id = 1-----------------------------------");
employees.ForEach(e => Console.WriteLine(e));

//cau6 update thong tin cua nhan su co id = 2
var employeeToUpdate = employees.FirstOrDefault(e => e.Id == 2);
if (employeeToUpdate != null)
{
    employeeToUpdate.Name = "Updated Name";
    employeeToUpdate.IdCard = "Updated Card";
    employeeToUpdate.Birthday = new DateTime(2005, 6, 30);
}
else
{
    Console.WriteLine("Khong tim thay nhan su co Id = 2");
}
Console.WriteLine("-------------------DS nhan su sau khi update-----------------------------------");
employees.ForEach(e => Console.WriteLine(e));