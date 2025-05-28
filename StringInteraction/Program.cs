using System.Text;
Console.OutputEncoding = System.Text.Encoding.UTF8;

String ho = "nguyen";
String tenlot = "thi";
String ten = "teo";
String fullname = ho + " " + tenlot + " " + ten;
Console.WriteLine(fullname);

StringBuilder sb = new StringBuilder();
sb.Append(ho);
sb.Append(" ");
sb.Append(tenlot);
sb.Append(" ");
sb.Append(ten);
Console.WriteLine(sb.ToString());

int m;
ham2(ref m);