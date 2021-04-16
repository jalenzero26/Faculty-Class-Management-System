using System;

namespace Faculty_Class_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faculty Class Management System \n");
            Console.WriteLine("Please enter your credentials \n");
            string usern;
            string passw;

            Console.WriteLine("Enter Username:");
            usern = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            passw = Console.ReadLine();
            if  (usern == "admin" && passw == "1234")
            {
                Console.WriteLine("Account Verified\n ");
                Console.WriteLine("Welcome " + usern + '\n');
            } 
            else
            {
                Console.WriteLine("Login Failed");

            }

        }
    }
}
