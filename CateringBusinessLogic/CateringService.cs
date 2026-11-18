using System.Collections.Generic;
using CateringDataLogic;

namespace CateringBusinessLogic
{
    public class CateringService
    {
        private readonly ICateringRepository repository;

        public CateringService(ICateringRepository repository)
        {
            this.repository = repository;
        }

        public void SubmitOrder(CateringOrder order)
        {
            order.OrderStatus = "Pending";

            repository.SaveOrder(order);
        }

        public List<CateringOrder> GetOrders()
        {
            return repository.GetOrders();
        }

        public bool AcceptOrder(int orderId)
        {
            List<CateringOrder> orders = repository.GetOrders();

            CateringOrder? order = orders.Find(o => o.OrderId == orderId);

            if (order == null)
            {
                return false;
            }

            order.OrderStatus = "Accepted";

            repository.UpdateOrder(order);

            return true;
        }
    }
}