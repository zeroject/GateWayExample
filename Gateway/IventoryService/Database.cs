using domain;

namespace IventoryService
{
    public static class Database
    {
        static List<Iventory> _inventory;

        public static Iventory GetInventory(int id)
        {
            return _inventory.Find(x => x.Id == id);
        }
    }
}
