//zj
using CateringBusinessLogic;
using CateringDataLogic;
namespace CateringOrderManagementSystem
{
    internal class Program
    {
        private static string? customerName;

        static void Main(string[] args)
        {
            ICateringRepository repository = new CateringRepository();
            CateringService cateringService = new CateringService(repository);

            Console.WriteLine("Welcome to Catering Order Management System");

            Console.WriteLine("Enter 1 - for Catering Account");
            Console.WriteLine("Enter 2 - for Customer Order");
            Console.WriteLine("Enter x - to exit");

            Console.Write("User Input: ");

            string CateringAcc = "Zeljhay001";
            string checkLogin = Console.ReadLine() ?? string.Empty;


            string eventType = "";
            string eventDate = "";
            string numberOfGuests = "";
            string foodOrder = "";
            string quantity = "";
            string orderStatus = "Pending";

            

            while (checkLogin != "x")
            {

                if (checkLogin == "1")
                {
                    Console.Write("Enter Catering Account: ");
                    string CateringInput = Console.ReadLine() ?? string.Empty;

                    if (CateringAcc == CateringInput)
                    {
                        Console.WriteLine("Catering Account Login Successful!");

                        Console.WriteLine("Type 1 - to view customer order");
                        Console.WriteLine("Type 2 - to accept customer order");
                        Console.WriteLine("Type 3 - to exit");

                        Console.Write("Enter your option: ");
                        int choice = Convert.ToInt16(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:

                                List<CateringOrder> orders = cateringService.GetOrders();

                                if (orders.Count > 0)
                                {
                                    foreach (CateringOrder order in orders)
                                    {
                                        Console.WriteLine("\nOrder ID: " + order.OrderId);
                                        Console.WriteLine("Customer Name: " + order.CustomerName);
                                        Console.WriteLine("Event Type: " + order.EventType);
                                        Console.WriteLine("Event Date: " + order.EventDate);
                                        Console.WriteLine("Number of Guests: " + order.NumberOfGuests);
                                        Console.WriteLine("Food Order: " + order.FoodOrder);
                                        Console.WriteLine("Quantity: " + order.Quantity);
                                        Console.WriteLine("Order Status: " + order.OrderStatus);
                                        Console.WriteLine("----------------------------");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("There are no customer orders yet.");
                                }

                                break;

                            case 2:

                                List<CateringOrder> ordersToAccept = cateringService.GetOrders();

                                if (ordersToAccept.Count > 0)
                                {
                                    Console.WriteLine("\nCustomer Orders:");

                                    foreach (CateringOrder order in ordersToAccept)
                                    {
                                        Console.WriteLine("Order ID: " + order.OrderId);
                                        Console.WriteLine("Customer Name: " + order.CustomerName);
                                        Console.WriteLine("Order Status: " + order.OrderStatus);
                                        Console.WriteLine("----------------------------");
                                    }

                                    Console.Write("\nEnter Order ID to accept: ");
                                    int orderId = Convert.ToInt32(Console.ReadLine());

                                    bool accepted = cateringService.AcceptOrder(orderId);

                                    if (accepted)
                                    {
                                        Console.WriteLine("Customer order has been accepted!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Order ID.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("There are no customer orders to accept.");
                                }

                                break;

                            case 3:
                                Console.WriteLine("Returning to main menu...");
                                break;

                            default:
                                Console.WriteLine("Incorrect input...");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid catering account.");
                    }
                }

                else if (checkLogin == "2")
                {
                    Console.WriteLine("\nCustomer Catering Order");

                    Console.Write("Enter your name: ");
                    customerName = Console.ReadLine();

                    Console.Write("Enter event type: ");
                    eventType = Console.ReadLine() ?? string.Empty;

                    Console.Write("Enter event date: ");
                    eventDate = Console.ReadLine() ?? string.Empty;

                    Console.Write("Enter number of guests: ");
                    numberOfGuests = Console.ReadLine() ?? string.Empty;

                    Console.WriteLine("\nAvailable Food Menu");
                    Console.WriteLine("1 - Chicken");
                    Console.WriteLine("2 - Pork");
                    Console.WriteLine("3 - Beef");
                    Console.WriteLine("4 - Fish");

                    Console.Write("Choose your food: ");
                    string foodChoice = Console.ReadLine() ?? string.Empty;

                    switch (foodChoice)
                    {
                        case "1":
                            foodOrder = "Chicken";
                            break;

                        case "2":
                            foodOrder = "Pork";
                            break;

                        case "3":
                            foodOrder = "Beef";
                            break;

                        case "4":
                            foodOrder = "Fish";
                            break;

                        default:
                            foodOrder = "Invalid food selection";
                            break;
                    }

                    if (foodOrder != "Invalid food selection")
                    {
                        Console.Write("Enter quantity: ");
                        quantity = Console.ReadLine() ?? string.Empty;

                        CateringOrder order = new CateringOrder
                        {
                            CustomerName = customerName ?? string.Empty,
                            EventType = eventType,
                            EventDate = eventDate,
                            NumberOfGuests = numberOfGuests,
                            FoodOrder = foodOrder,
                            Quantity = quantity
                        };

                        cateringService.SubmitOrder(order);

                        
                        orderStatus = order.OrderStatus;

                        Console.WriteLine("\nOrder submitted successfully!");
                        Console.WriteLine("Thank you for your order, " + customerName + "!");
                        Console.WriteLine("Your order status is: " + orderStatus);
                    }
                    else
                    {
                        Console.WriteLine("Invalid food selection. Please try again.");
                    }
                }

                else
                {
                    Console.WriteLine("Incorrect input...\n");
                }


                Console.WriteLine("\nEnter 1 - for Catering Account");
                Console.WriteLine("Enter 2 - for Customer Order");
                Console.WriteLine("Enter x - to exit");

                Console.Write("User Input: ");
                checkLogin = Console.ReadLine() ?? string.Empty;
            }

            Console.WriteLine("Thank you for using Catering Order Management System!");
        }
    }
}
