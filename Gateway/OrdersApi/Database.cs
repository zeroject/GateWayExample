using domain;

namespace OrdersApi
{
    public static class Database
    {
        static List<Order> orders = new List<Order>();

        public static Order GetOrder(int id)
        {
            return orders.Find(x => x.Id == id);
        }

        public static void PostOrder(Order order) 
        {
            orders.Add(order);
        }
    }
}
