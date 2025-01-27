namespace cS1
{
    internal class Program
    {

        static void Main()
        {
            var brands = new List<Brand>()
            {
                new Brand{ID = 1, Name = "Công ty AAA"},
                new Brand{ID = 2, Name = "Công ty BBB"},
                new Brand{ID = 4, Name = "Công ty CCC"},
            };

            var products = new List<Product>()
            {
                new (1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new (2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new (3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new (4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new (5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new (6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new (7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };

        }
    }
}