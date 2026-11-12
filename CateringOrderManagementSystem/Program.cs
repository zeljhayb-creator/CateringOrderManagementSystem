//zj
using System;

namespace CateringOrderManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Catering Order Management System");

            Console.WriteLine("Enter 1 - for Catering Account");
            Console.WriteLine("Enter 2 - for Customer Order");
            Console.WriteLine("Enter x - to exit");

            Console.Write("User Input: ");

            string CateringAcc = "Zeljhay001";
            string checkLogin = Console.ReadLine();

            
            string eventType = "";
            string eventDate = "";
            string numberOfGuests = "";
            string foodOrder = "";
            string quantity = "";
            string orderStatus = "Pending";

            bool orderSubmitted = false;

            while (checkLogin != "x")
            {

                if (checkLogin == "1")
                {
                    Console.Write("Enter Catering Account: ");
                    string CateringInput = Console.ReadLine();

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

                                if (orderSubmitted)
                                {
                                    Console.WriteLine("\nCustomer Name: " + customerName);
                                    Console.WriteLine("Event Type: " + eventType);
                                    Console.WriteLine("Event Date: " + eventDate);
                                    Console.WriteLine("Number of Guests: " + numberOfGuests);
                                    Console.WriteLine("Food Order: " + foodOrder);
                                    Console.WriteLine("Quantity: " + quantity);
                                    Console.WriteLine("Order Status: " + orderStatus);
                                }
                                else
                                {
                                    Console.WriteLine("There are no customer orders yet.");
                                }

                                break;

                            case 2:

                                if (orderSubmitted)
                                {
                                    orderStatus = "Accepted";
                                    Console.WriteLine("\nCustomer order has been accepted!");
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
                    eventType = Console.ReadLine();

                    Console.Write("Enter event date: ");
                    eventDate = Console.ReadLine();

                    Console.Write("Enter number of guests: ");
                    numberOfGuests = Console.ReadLine();

                    Console.WriteLine("\nAvailable Food Menu");
                    Console.WriteLine("1 - Chicken");
                    Console.WriteLine("2 - Pork");
                    Console.WriteLine("3 - Beef");
                    Console.WriteLine("4 - Fish");

                    Console.Write("Choose your food: ");
                    string foodChoice = Console.ReadLine();

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
                        quantity = Console.ReadLine();

                        orderSubmitted = true;
                        orderStatus = "Pending";

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
                checkLogin = Console.ReadLine();
            }

            Console.WriteLine("Thank you for using Catering Order Management System!");
        }
    }
}
