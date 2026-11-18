using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CateringDataLogic
{
    public class CateringRepository : ICateringRepository
    {
        private readonly string filePath = "CateringOrders.json";

        public void SaveOrder(CateringOrder order)
        {
            List<CateringOrder> orders = GetOrders();

            if (orders.Count > 0)
            {
                order.OrderId = orders[orders.Count - 1].OrderId + 1;
            }
            else
            {
                order.OrderId = 1;
            }

            orders.Add(order);

            string json = JsonSerializer.Serialize(orders,
                new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(filePath, json);
        }

        public List<CateringOrder> GetOrders()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);

                return JsonSerializer.Deserialize<List<CateringOrder>>(json)
                    ?? new List<CateringOrder>();
            }

            return new List<CateringOrder>();
        }

        public void UpdateOrder(CateringOrder order)
        {
            List<CateringOrder> orders = GetOrders();

            int index = orders.FindIndex(o => o.OrderId == order.OrderId);

            if (index != -1)
            {
                orders[index] = order;

                string json = JsonSerializer.Serialize(orders,
                    new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText(filePath, json);
            }
        }
    }
}