
using CateringOrderManagementSystem.CateringDataLogic;
using System.Collections.Generic;

namespace CateringDataLogic
{
    public interface ICateringRepository
    {
        void SaveOrder(CateringOrder order);

        List<CateringOrder> GetOrders();
            
        void UpdateOrder(CateringOrder order);  
    }
}
