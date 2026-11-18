namespace CateringDataLogic
{
    public class CateringOrder
    {
        public int OrderId { get; set; }

        public string CustomerName { get; set; } = string.Empty;
        public string EventType { get; set; } = string.Empty;
        public string EventDate { get; set; } = string.Empty;
        public string NumberOfGuests { get; set; } = string.Empty;
        public string FoodOrder { get; set; } = string.Empty;
        public string Quantity { get; set; } = string.Empty;
        public string OrderStatus { get; set; } = "Pending";
    }
}