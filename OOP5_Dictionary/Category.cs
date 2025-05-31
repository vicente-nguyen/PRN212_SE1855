using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_Dictionary
{
    public class Category
    {
        public Dictionary<int, Product> Products { get; set; }
        public int Id { get; internal set; }
        public string Name { get; internal set; }

        public Category()
        {
            Products = new Dictionary<int, Product>();
        }
        /*
         * Mọi dữ liệu cần làm đủ CRUD 
         */
        public void AddProduct(Product p)
        {
            if (Products.ContainsKey(p.Id))
            {
                return;//vì mã đã tồn tại 
            }
            else
            {
                Products.Add(p.Id, p);
            }
        }
        //Xem toan bo product cua category
        public void PrintAllProducts()
        {
            foreach (KeyValuePair<int, Product> item in Products)
            {
                Product p=item.Value;
                Console.WriteLine(p);
            }
        }

        //Loc ra cac san pham co gia tu x -> y
        public Dictionary<int, Product> FilterProductsByPrice(double min, double max)
        {
            Dictionary<int, Product> results = new Dictionary<int, Product>();
            results = Products.Where( item => item.Value.Price >= min && item.Value.Price <= max).ToDictionary<int, Product>();
            return results;
        }

        //Sap xep san pham theo don gia tang dan
        public Dictionary<int, Product> SortProductByPrice()
        {
            return Products.OrderBy(item => item.Value.Price).ToDictionary<int, Product>();
        }

        //Sap xep san pham theo don gia tang dan, neu trung thi so luong se giam dan
        public Dictionary<int, Product> ComplexSort()
        {
            return Products.OrderByDescending(item => item.Value.Quantity)
                           .OrderBy(item => item.Value.Price)
                           .ToDictionary<int, Product>();
        }

        //
        public bool UpdateProduct(Product p)
        {
            if(p== null) return false;
            if (Products.ContainsKey(p.Id) == false) return false;
            Products[p.Id] = p;//de lu lieu len o nho hien tai
                               //hoac tham chieu toi o nho khac
            return true;
        }

        public bool RemoveProduct(int id)
        {
            if (Products.ContainsKey(id) == false) return false;
            return Products.Remove(id);
        }
    }
}
