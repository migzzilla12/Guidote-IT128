using Microsoft.Extensions.Configuration;
using VideoGameStore.Database;
using VideoGameStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameStore.Data
{
    public class SqlData : ISqlData
    {
        private ISqlDataAccess _db;
        private const string connectionStringName = "SqlDb";

        public SqlData(ISqlDataAccess db)
        {
            _db = db;
        }
        public void AddItem(Item item)
        {
            _db.SaveData("dbo.spItem_add", new
            {item.Name,item.UnitPrice,item.Code,item.Brand,item.DateOrdered
            }, connectionStringName, true);
        }

        public void Register(Users user)
        {
            _db.SaveData("dbo.spUsers_register", new{ user.Username,user.Password}, connectionStringName, true);
        }
        public List<ItemList> ListItems()
        {
            return _db.LoadData<ItemList, dynamic>("dbo.spItem_list", new { }, connectionStringName, true).ToList();
        }
        public ItemList GetItems(int id)
        {
            return _db.LoadData<ItemList, dynamic>("dbo.spItem_get", new { id }, connectionStringName, true).FirstOrDefault();
        }
        public void deleteItem(int id)
        {
            _db.SaveData("dbo.spItem_delete", new { id }, connectionStringName, true);
        }

        public void updateItem(int id, Item item)
        {
            _db.SaveData("dbo.spItem_update", new { id, item.Name, item.Code, item.Brand, item.UnitPrice }, connectionStringName, true);
        }
    }
}
