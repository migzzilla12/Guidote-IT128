using VideoGameStore.Models;

namespace VideoGameStore.Data
{
    public interface ISqlData
    {
        void AddItem(Item item);
        void deleteItem(int id);
        ItemList GetItems(int id);
        List<ItemList> ListItems();
        void Register(Users user);
        void updateItem(int id, Item item);
    }
}