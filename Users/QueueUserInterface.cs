using System;
using QueueLogic.Commons;
// using UserFileManagement;
// using MyQueue;

namespace Users
{
    public class QueueUserInterface
    {
            private static string firstName;
            private static string lastName;
            private static string email;
            private static string age;
            private static long phoneNumber;
            private static string favouriteArtist;
            private static string favouriteFood;

     public static void Display()
            {
                bool shouldRun = true;
                while (shouldRun)
                {
                    System.Console.WriteLine("Hello, welcome to Remilekun's user management app.");

                    System.Console.WriteLine("Enter: ");
                    System.Console.WriteLine("1 to Add User");
                    System.Console.WriteLine("2 to Save Changes");
                    System.Console.WriteLine("3 to Remove User");
                    System.Console.WriteLine("4 to Display Users");
                    System.Console.WriteLine("5 to clear the screen");
                    System.Console.WriteLine("0 to Exit");

                    var consoleInput = Helpers.IsValidInput(Console.ReadLine());
                    if(consoleInput == -1)
                    {
                        System.Console.WriteLine("Please enter a valid input");
                        Console.Clear();
                    }
                    else
                    {
                        switch (consoleInput)
                        {
                            case 1:
                            try{
                                System.Console.WriteLine("What is your first name?");
                                firstName= Console.ReadLine();
                                System.Console.WriteLine("What is your last name?");
                                lastName = Console.ReadLine();
                                System.Console.WriteLine("What is your email address?");
                                email= Console.ReadLine();
                                System.Console.WriteLine("How old are you?");
                                age = Console.ReadLine();
                                System.Console.WriteLine("What is your phone number?");
                                phoneNumber= long.Parse(Console.ReadLine());
                                System.Console.WriteLine("Who is your favourite artist?");
                                favouriteArtist= Console.ReadLine();
                                System.Console.WriteLine("What is your favourite food?");
                                favouriteFood= Console.ReadLine();
                            }
                            catch(FormatException)
                            {
                                throw new FormatException("Email is not valid");
                                System.Console.ReadKey();
                                System.Console.Clear();
                            }
                            catch (System.Exception e)
                            {                                
                                throw new Exception(e.Message);
                                System.Console.ReadKey();
                                System.Console.Clear();
                            }
                            break;
                        case 2:
                                FileManagement.FileStuff();
                                System.Console.ReadKey();
                                System.Console.Clear();
                            break;
                        case 3:
                                Queue.Dequeue1(user.value);
                                System.Console.ReadKey();
                                System.Console.Clear();
                            break;
                        case 4:
                                Queue.Print();
                                System.Console.ReadKey();
                                System.Console.Clear();
                            break;
                        case 5:
                                System.Console.Clear();
                                break;
                        case 0:
                                shouldRun = false;
                                break;
                        default:
                                System.Console.Clear();
                                break;

                        }
                    }
                }
            }

    }
}