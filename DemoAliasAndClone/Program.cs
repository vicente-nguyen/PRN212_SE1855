using DemoAliasAndClone;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Student s1 = new Student();
s1.Id = 1;
s1.Name = "Tran Thi Teo";

Student s2 = new Student();
s2.Id = 2;
s2.Name = "Nguyen Van Tun";
//Lúc này trên thanh ram sẽ cấp phát 2 ô nhớ
//cho s1 và s2 quản lý 
//=>s1 đổi giá trị không liên quan đến s2 vì s1 và s2 đang quản lý 2 ô nhớ khác nhau
s1 = s2;
//về bản chất nó hoạt động như sau:
//s1 trỏ tới vùng ô nhớ mà s2 đang quản lý chứ không phải s1 bằng s2 có 2 tình huống xảy ra     
//(1) ô nhớ bên s2 giừo sẽ có thêm s1 quản lý =>alias (>= 2 đối tượng quản lý)
//chỉ cần 1 đối tươngj đổi thì các đối tượng khác đều bị đổi
s2.Name= "Nguyen Van A";
Console.WriteLine("s2doi ten, vay s1 co gia tri la gi?");
Console.WriteLine(s1.Name);
//(2) ô nhớ lúc trước s1 đang quản lý, giờ sẽ không còn đối tượng nào quản lý nữa
//thì lúc này HDH tự động thu hồi ô nhớ : Automatic Garbage  Collection
//tức là lúc này ta không thể truy xuất đề lấy lai giá trị s1 có id=1, name=tèo 
