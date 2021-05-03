using System;
using System.Collections.Generic;
using System.Threading;
namespace Faculty_Class_Management_System
{
    class Program
    {
      public static List<string> chosenDays = new List<string>();
        static void Main(string[] args)
        {
            string usern;
            string passw;
            int attempts = 0;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Faculty Class Management System");
            Console.WriteLine("--------------------------------"); ;
            Console.WriteLine("<<Please Enter Your Credentials>> \n");


            //Login
            for (int i = 0; i < 3; attempts++)
            {
                
                Console.WriteLine("[Enter Username]:");
                usern = Console.ReadLine();
                Console.WriteLine("[Enter Password]:");
                passw = Console.ReadLine();


                if (usern == "admin" && passw == "1234")
                {
                    Console.Clear();
                    Console.WriteLine(">>>Account Verified<<<");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("welcome " + usern);
                    Console.WriteLine("--------------------------------");
                    break;
                }
                else
                {
                    Console.WriteLine("\n Login Failed! \n");

                }
                if (attempts >= 3)
                {
                    Console.WriteLine("**Too many logins** \n");
                }


            }
            //Menu
            Console.Title = "Faculty Class Management Menu";
            Console.WriteLine("--------------------------------");
            Console.WriteLine("             MENU               ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("(1) [Create Course Schedule]");
            Console.WriteLine("(2) [Course Student List]");
            Console.WriteLine("(3) [Exit]");

            string load = Console.ReadLine();

            if (load == "1")
            {
                sched();
            }
            else if (load == "2")
            {
                course();
            }
            else if (load == "3")
            {
                Console.WriteLine("Exiting...");
                Environment.Exit(0);
            }
        }

        public static void sched()
        {

            chosenDays.Clear();
            
            //Schedule,'
            Console.WriteLine();
            string prof = "Jalen Carino";
            

            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("          SCHEDULE              ");
            Console.WriteLine("--------------------------------");

                 Console.WriteLine("\n [Course]\n ");
                    Console.WriteLine("For Section");
                          Console.WriteLine("(1) BSIT");
                          Console.WriteLine("(2) DICT");
                            string sect = Console.ReadLine();


            Console.WriteLine("--------------------------------");
            Console.WriteLine("\n [Subjects]\n ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Pick Subjects");
                           Console.WriteLine("(3) Quantitative Method with Modeling and Simulation");
                           Console.WriteLine("(4) Object Oriented Programming");
                             string choice = Console.ReadLine();


            Console.WriteLine("--------------------------------");
            Console.WriteLine("\n [Time] \n");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Format Time [Hours (AM/PM)]");
                        Console.WriteLine("Enter Time");
                        Console.WriteLine("From:");
                            var ftime = Console.ReadLine();
                        Console.WriteLine("To:");
                            var etime = Console.ReadLine();

            


             var listDays = new List<string>
                {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday",
                "Saturday", "Sunday"};

            Console.WriteLine("\n <<LIST OF DAYS>> \n");
            Console.WriteLine(listDays[0]);
            Console.WriteLine(listDays[1]);
            Console.WriteLine(listDays[2]);
            Console.WriteLine(listDays[3]);
            Console.WriteLine(listDays[4]);
            Console.WriteLine(listDays[5]);
            Console.WriteLine(listDays[6]);
            Console.WriteLine();


            Console.WriteLine("Enter Number of Days");
            int NumberofDays = Convert.ToInt32(Console.ReadLine());

            int numDay = 1;
            Console.WriteLine("Choices\n");
            foreach (var day in listDays)
            {
                Console.WriteLine(numDay + " - " + day);
                numDay++;
            }

            
            for (int i = 0; i < NumberofDays; i++)
            {

                Console.WriteLine("Enter your choice:");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                string days = listDays[inputNum - 1];

                chosenDays.Add(days);
            }
            Console.Clear();
                if (choice == "3")
                {
                Console.WriteLine("____ 	   ___ ___ ___ ___   ____  ____       ");
                Console.WriteLine("|    | 	 | |  |  | |  |  |  |    | |   | |   |");
                Console.WriteLine("|__  |	 | |  |  | |  |  |  |    | |___| |___|");
                Console.WriteLine("   | |	 | |     | |     |  |====| | |      |");
                Console.WriteLine("___| |___| |     | |     |  |    | |  |  ___|");

                Console.WriteLine("\n-------------------------");
                        Console.WriteLine("Subject Code: RES00021");
                        Console.WriteLine("Subject     : [Quantitative Method with Modeling and Simulation]");
                        Console.WriteLine("Time        : " + ftime + " - " + etime);
                    
                   
                    foreach(var displayDays in chosenDays)
                    {
                        Console.WriteLine("Day         : " +  displayDays);
                    }

                    Console.WriteLine("Professor   : " + prof);
                    if (sect == "1")
                    {
                        Console.WriteLine("Course      : BSIT");
                    }
                    else
                    {
                        Console.WriteLine("Course      : DICT");
                    }
                    Console.WriteLine("------------------------- \n \n \n \n");
                }

            if (choice == "4")
            {
                Console.WriteLine("____ 	   ___ ___ ___ ___   ____  ____       ");
                Console.WriteLine("|    | 	 | |  |  | |  |  |  |    | |   | |   |");
                Console.WriteLine("|__  |	 | |  |  | |  |  |  |    | |___| |___|");
                Console.WriteLine("   | |	 | |     | |     |  |====| | |      |");
                Console.WriteLine("___| |___| |     | |     |  |    | |  |  ___|");
                Console.WriteLine("\n-------------------------");
                Console.WriteLine("Subject Code: COMP0021");
                Console.WriteLine("Subject: [Object Oriented Programming]");
                Console.WriteLine("Time: " + ftime + " - " + etime);


                foreach (var displayDays in chosenDays)
                {
                    Console.WriteLine("Day: " + displayDays);
                }

                Console.WriteLine("Professor: " + prof);
                if (sect == "1")
                {
                    Console.WriteLine("Course: BSIT");
                }
                else
                {
                    Console.WriteLine("Course: DICT");
                }
                Console.WriteLine("------------------------- \n \n \n \n");
            }


        }

        public static void course()
        {
            

            
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("            COURSE              ");
            Console.WriteLine("--------------------------------");


            for (int i = 0; i < 5; i++)
            {
            Console.WriteLine("(A) BSIT 2-1");
            Console.WriteLine("(B) DICT 2-1");
            string course = Console.ReadLine();

            

                if (course == "a")
            {
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("         BSIT STUDENTS          ");
                Console.WriteLine("--------------------------------");

                var bsit = new List<string>
                {"Anabelle Cox", "Brody Jacobson", "Caspar Neal", "Corrina Blanchard", "Kunal Hogg",
                "Nettie Millington", "Rhydian Mcclain", "Shaquille Eastwood", "Thalia Bowden",
                "Tiffany Jarvis"};

                Console.WriteLine(bsit[0]);
                 Console.WriteLine(bsit[1]);
                  Console.WriteLine(bsit[2]);
                   Console.WriteLine(bsit[3]);
                    Console.WriteLine(bsit[4]);
                     Console.WriteLine(bsit[5]);
                      Console.WriteLine(bsit[6]);
                       Console.WriteLine(bsit[7]);
                        Console.WriteLine(bsit[8]);
                         Console.WriteLine(bsit[9]);

                    Console.WriteLine("\n Press any key to back or ee to exit \n");
                    string loo = Console.ReadLine();

                    if (loo == "ee" ){

                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                    } 


            }

                if (course == "b")
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("         DICT STUDENTS          ");
                    Console.WriteLine("--------------------------------");

                    var bsit = new List<string>
                {"Alessandra Lees", "Amit Aldred", "Axel Cope", "Claudia Mccullough", "Ewen Bowden",
                 "Manveer Gilbert", "Mike Barry", "Piper Lott", "Rachael Mccartney", "Rajan Lowe"};

                    Console.WriteLine(bsit[0]);
                    Console.WriteLine(bsit[1]);
                    Console.WriteLine(bsit[2]);
                    Console.WriteLine(bsit[3]);
                    Console.WriteLine(bsit[4]);
                    Console.WriteLine(bsit[5]);
                    Console.WriteLine(bsit[6]);
                    Console.WriteLine(bsit[7]);
                    Console.WriteLine(bsit[8]);
                    Console.WriteLine(bsit[9]);
                   
                    Console.WriteLine("\n Press any key to back or ee to exit \n");
                    string loo = Console.ReadLine();

                    if (loo == "ee")
                    {

                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                    }

                  }
                }
            }
        }
    }
