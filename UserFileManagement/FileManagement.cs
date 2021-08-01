using System;
using System.IO;
using System.Threading.Tasks;
// using QueueLogic;
// using MyQueue;
// using Users;

namespace UserFileManagement
{
    public static class FileManagement
    {
        public static void FileStuff()
        {
            string filePath = @"C:\Users\user\Desktop\Week10\MyQueue\UserFile.txt";
            if(!File.Exists(filePath))
            {
                // this creates a new file if UserFile does not exist. 
               using var createFile = File.CreateText(filePath);
            }
            // this adds the input to the file if the file already exists so the file will not be overridden.
            using(var file =  File.CreateText(filePath))
            {
                file.WriteLine("FirstName,LastName,Email,Age,PhoneNumber,FavouriteArtist,FavouriteFood");
                
            }
             using(StreamReader streamReader = File.OpenText(filePath))
                {
                    var read =  streamReader.ReadToEnd();
                    read = read.TrimEnd();
                var users = read.Split(Environment.NewLine);//Environment.NewLine returns an array
                foreach (var item in users)
                {
                    var user = item.Split(',');
                    System.Console.WriteLine(user[0]);
                    System.Console.WriteLine(user[1]);
                    System.Console.WriteLine(user[2]);
                    System.Console.WriteLine(user[3]);
                    System.Console.WriteLine(user[4]);
                    System.Console.WriteLine(user[5]);
                    System.Console.WriteLine(user[6]);

                    // Queue1 user = new Queue1
                    // {
                    //     FirstName = user[0],
                    //     LastName = user[1],
                    //     Email = user[2],
                    //     Age = user[3],
                    //     PhoneNumber = user[4],
                    //     FavouriteArtist = user[5],
                    //     FavouriteFood = user[6]
                    // };

                    //TRY FirstName = firstName, bring Users(QueueUserInterface) into this.

                    // System.Console.WriteLine(FirstName);



                    // return read; 
                }
            }

        }

    //     public async static Task<string> ReadFileAsync()
    //     {
    //         string filePath = @"C:\Users\user\Desktop\Week10\MyQueue\UserFile.txt";
    //         if(!File.Exists(filePath))
    //         {
    //             // this creates a new file if UserFile does not exist. 
    //            using var createFile = File.CreateText(filePath);
    //         }
    //         // this adds the input to the file if the file already exists so the file will not be overridden.
    //         using(var file =  File.CreateText(filePath))
    //         {
    //             // file.WriteLine("*************************");
    //             file.WriteLine("FirstName,LastName,Email,Age,PhoneNumber,FavouriteArtist,FavouriteFood");
    //             // file.WriteLine("You have been working since morning");
    //             // file.WriteLine("Well done sweetheart :)");
    //         }
    //         using (StreamReader streamReader = File.OpenText(filePath))
    //         {
    //             var read = await streamReader.ReadToEndAsync();
    //                 read = read.TrimEnd();
    //             var users = read.Split(Environment.NewLine);//Environment.NewLine returns an array
    //             foreach (var item in users)
    //             {
    //                 var user = item.Split(',');
    //                 System.Console.WriteLine(user[0]);
    //                 System.Console.WriteLine(user[1]);
    //                 System.Console.WriteLine(user[2]);
    //                 System.Console.WriteLine(user[3]);
    //                 System.Console.WriteLine(user[4]);
    //                 System.Console.WriteLine(user[5]);
    //                 System.Console.WriteLine(user[6]);
    //             return read;
    //         }
    //     }
    // }
    } 
}
    //the using keyword stops the createFile [or file](StreamWriter) from holding on to the file thereby throwing an error. It does the same thing as:
       //createFile.Clear() and
      //file.Dispose();