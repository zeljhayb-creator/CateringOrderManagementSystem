using System;

namespace CateringOrderManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Catering Order Management System");

            Console.WriteLine("Enter 1 - for Catering Account");
            Console.WriteLine("Enter 2 - for Customer Inquiry");
            Console.WriteLine("Enter x - to exit");

            Console.Write("User Input: ");

            string CateringAcc = "Zeljhay001";
            string checkLogin = Console.ReadLine();

            string customerName = "Josh002";
            string customerInquiry = "";
            string inquiryStatus = "pending";

            while (checkLogin != "x")
            {
            
                if (checkLogin == "1")
                {
                    Console.Write("Enter Catering Account: ");
                    string CateringInput = Console.ReadLine();

                    if (CateringAcc == CateringInput)
                    {
                        Console.WriteLine("Catering Account Login Successful!");

                        Console.WriteLine("Type 1 - to view customer inquiry");
                        Console.WriteLine("Type 2 - to exit");

                        Console.Write("Enter your option: ");
                        int choice = Convert.ToInt16(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:

                                if (customerInquiry != "")
                                {
                                    Console.WriteLine("\nCustomer Name: " + customerName);
                                    Console.WriteLine("Customer Inquiry:");
                                    Console.WriteLine(customerInquiry);
                                    Console.WriteLine("Inquiry Status: " + inquiryStatus);
                                }
                                else
                                {
                                    Console.WriteLine("There are no customer inquiries yet.");
                                }

                                break;

                            case 2:
                                Console.WriteLine("Returning to main menu...");
                                break;

                            default:
                                Console.WriteLine("Incorrect input...");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid staff number.");
                    }
                }

                else if (checkLogin == "2")
                {
                    Console.WriteLine("\nCustomer Catering Inquiry");

                    Console.Write("Enter your name: ");
                    customerName = Console.ReadLine();

                    Console.Write("Enter event type: ");
                    string eventType = Console.ReadLine();

                    Console.Write("Enter event date: ");
                    string eventDate = Console.ReadLine();

                    Console.Write("Enter number of guests: ");
                    string numberOfGuests = Console.ReadLine();

                    Console.Write("Enter your catering request: ");
                    string cateringRequest = Console.ReadLine();

                    customerInquiry =
                        "Event Type: " + eventType +
                        "\nEvent Date: " + eventDate +
                        "\nNumber of Guests: " + numberOfGuests +
                        "\nCatering Request: " + cateringRequest;        

                    Console.WriteLine("\nInquiry submitted successfully!");
                    Console.WriteLine("Thank you for your inquiry, " + customerName + "!");
                    Console.WriteLine("Your inquiry status is: " + inquiryStatus);
                }

                else
                {
                    Console.WriteLine("Incorrect input...\n");
                }

       
                Console.WriteLine("Enter 1 - for Catering Account");
                Console.WriteLine("Enter 2 - for Customer Inquiry");
                Console.WriteLine("Enter x - to exit");

                Console.Write("User Input: ");
                checkLogin = Console.ReadLine();
            }

            Console.WriteLine("Thank you for using Catering Order Management System!");
        }
    }
}