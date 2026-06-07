using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Store
    {
        private Item[] items;
        private int count;
        private DBConnection db;

        public Store()
        {
            this.items = new Item[0];
            this.count = 0;
            this.db = new DBConnection();
        }
        public int DeleteKnightFromDB(int code)
        {
            return db.DeleteItemFronDB(code);
        }
        public int AddItem(Item item)
        {
            return db.AddItemToDB(item);
        }
        public override string ToString()
        {
            string data = db.ReadItemsTable();

            if (string.IsNullOrWhiteSpace(data))
            {
                return "No Items";
            }

            return data.TrimEnd();
        }
    }
}
