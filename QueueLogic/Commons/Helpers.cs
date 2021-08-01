using System;
using System.IO;

namespace QueueLogic.Commons
{
    public class Helpers
    {
        public static int IsValidInput(string data)
        {
            bool isValid = int.TryParse(data, out int value);
            if(!isValid)
                return -1;
            else if (value < 0 || value > 4)
                return -1;
            else 
                return value;
        }

        public static void UserInput(string firstName, string lastName, string email, int age, long phoneNumber, string favouriteArtist, string favouriteFood )
        {   
             Queue newUser = new Queue
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Age = age,
                PhoneNumber = phoneNumber,
                FavouriteArtist = favouriteArtist,
                FavouriteFood = favouriteFood,
        };

        //     try
        //     {
        //         var isValidFirstName = string.Parse(firstName, out string firstValue);
        //         if(!isValidFirstName) 
        //         {
        //             return "Input is invalid, Please enter a valid name";
        //         }

        //         var isValidLastName = string.Parse(lastName, out string secondValue);
        //         if(!isValidLastName) 
        //         {
        //             return "Input is invalid, Please enter a valid name";
        //         }

        //         var isValidEmail = string.Parse(email, out string thirdValue);
        //         if(!isValidEmail) 
        //         {
        //             return "Input is invalid, Please enter a valid email address";
        //         }

        //         var isValidAge = int.TryParse(age, out int fourthValue);
        //         if(!isValidAge) 
        //         {
        //             return "Input is invalid, Please enter a valid number";
        //         }

        //         var isValidPhoneNumber = long.TryParse(phoneNumber, out string fifthValue);
        //         if(!isValidPhoneNumber) 
        //         {
        //             return "Input is invalid, Please enter a valid number";
        //         }
        //         var isValidFavouriteArtist = string.Parse(firstName, out string sixthValue);
        //         if(!isValidFavouriteArtist) 
        //         {
        //             return "Input is invalid, Please enter a valid value";
        //         }
                
        //         var isValidFavouriteFood = string.Parse(firstName, out string seventhValue);
        //         if(!isValidFavouriteFood) 
        //         {
        //             return "Input is invalid, Please enter a valid value";
        //         }
                
        //     }
        //     catch(FormatException)
        //     {
        //         throw new FormatException("Email is not valid");
        //     }
        //     catch (System.Exception e)
        //     {
                
        //         throw new Exception(e.Message);
        //     }
         }

       
    }
}