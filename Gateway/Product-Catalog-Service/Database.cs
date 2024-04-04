using domain;

namespace Product_Catalog_Service
{
    public static class Database
    {
        public static List<product> Products { get; set; }
        public static product GetProduct(int id)
        {
            return Products.Find(x => x.Id == id);
        }

        public static void PopulateProducts() 
        {
            Products = new List<product>();
            Random random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                string[] names = { "Product", "Item", "Good", "Widget", "Gadget", "Thing" };
                string[] descriptions = { "Great product", "Awesome item", "Amazing gadget", "Cool widget", "Fantastic thing" };

                string randomName = names[random.Next(names.Length)] + " " + i;
                string randomDescription = descriptions[random.Next(descriptions.Length)] + " " + i;
                int randomPrice = random.Next(10, 100); // Random price between 10 and 99

                Products.Add(new product { Id = i, Name = randomName, Description = randomDescription, price = randomPrice });
            }
        }
    }
}
