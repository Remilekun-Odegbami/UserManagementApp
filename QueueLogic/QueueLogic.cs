using System;
using QueueLogic.Commons;


namespace QueueLogic
{
    public class QueueLogic
    {
        public Queue UserInfo (string firstName, string lastName, string email, int age, long phoneNumber, string favouriteArtist, string favouriteFood )
        {
        Queue queue = new Queue
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Age = age,
            PhoneNumber = phoneNumber,
            FavouriteArtist = favouriteArtist,
            FavouriteFood = favouriteFood,
            Result = "Hello " + firstName + " " + lastName + "." + " Your email adress is " + email + " and you are " + age + " years old. " + " Your phone number is " + phoneNumber + ", your favourite artist is " + favouriteArtist + " and your favourite food is " + favouriteFood + "." 
        };
        
        Helpers.UserInput(Console.ReadLine());
        QueueStorage.QueueHistory.Add(queue);
        return queue;         
        }
    }
}
