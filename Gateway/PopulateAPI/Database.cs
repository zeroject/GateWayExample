using domain;

namespace PopulateAPI
{
    public static class Database
    {
        static Random random = new Random();
        static List<Order> dataOrders = new List<Order>();
        static List<Iventory> dataInv = new List<Iventory>();
        static List<product> dataProducts = new List<product>();

        public static void GenerateProducts(int count)
        {
            List<product> products = new List<product>();
            for (int i = 0; i < count; i++)
            {
                products.Add(new product
                {
                    Id = i + 1,
                    Name = RandomString(8),
                    Description = RandomString(20),
                    price = random.Next(10, 1000)
                });
            }
            dataProducts.AddRange(products);
        }

        public static void GenerateInventory(List<product> products)
        {
            List<Iventory> inventory = new List<Iventory>();
            foreach (var product in products)
            {
                inventory.Add(new Iventory
                {
                    Id = product.Id,
                    product = product,
                    amount = random.Next(1, 100)
                });
            }
            dataInv.AddRange(inventory);
        }

        public static List<Order> GenerateOrders(List<product> products)
        {
            List<Order> orders = new List<Order>();
            for (int i = 0; i < random.Next(100, 1000); i++)
            {
                int productCount = random.Next(1, 5);
                List<product> orderProducts = new List<product>();
                for (int j = 0; j < productCount; j++)
                {
                    orderProducts.Add(products[random.Next(products.Count)]);
                }
                orders.Add(new Order
                {
                    Id = i + 1,
                    Products = orderProducts,
                    TotalPricelist = orderProducts.Sum(p => p.price)
                });
            }
            return orders;
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
