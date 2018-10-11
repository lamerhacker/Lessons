using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
   public class Repository
    {
        public List<Supplyer> Supplyers { get; set; }
        public List<Item> Items { get; set; }
        public List<Order> Orders { get; set; }

        public Repository()
        {
            Restore();
        }

        private const string OrdersFileName = "../../Data/orders.json";
        private const string ItemsFileName = "../../Data/items.json";
        private const string SupplyersFileName = "../../Data/supplyers.json";

        private void SaveList<T>(string fileName, List<T> list)
        {
            using (var sw = new StreamWriter(fileName))
            {
                using (var jsonWriter = new JsonTextWriter(sw))
                {
                    jsonWriter.Formatting = Formatting.Indented;
                    var serializer = new JsonSerializer();
                    serializer.Serialize(jsonWriter, list);
                }
            }

        }
        public void Save()
        {
            SaveList(OrdersFileName, Orders);
            SaveList(ItemsFileName, Items);
            SaveList(SupplyersFileName, Supplyers);
        }

        public void SaveOrders()
        {
            SaveList(OrdersFileName, Orders);
        }
        private List<T> RestoreList<T>(string fileName)
        {
            using (var sr = new StreamReader(fileName))
            {
                using (var jsonReader = new JsonTextReader(sr))
                {
                    var serializer = new JsonSerializer();
                    return serializer.Deserialize<List<T>>(jsonReader);
                }
            }

        }

        private void Restore()
        {
            Orders = RestoreList<Order>(OrdersFileName);
            Items = RestoreList<Item>(ItemsFileName);
            Supplyers = RestoreList<Supplyer>(SupplyersFileName);
        }
    }
}
