using System;

namespace Homework_05_Classes
{

    #region Task7
    //Task 7
    //Create a class Dog
    //Add properties: Name, race, color
    //The dog needs to have:
    //Eat method that returns message: The dog is now eating
    //Play method returning a message : The dog is now playing
    //ChaseTail method that returns a message: Dog is now chasing its tail.
    //The user needs to create the dog object by inputs and then given an option to choose one of the actions mentioned above.
    public class Dog
    {   
        public string dogName;
        public string dogRace;
        public string dogColor;

        public void DogIsEating()
        {
            Console.WriteLine("The Dog Is Eating");
        }

        public void DogIsPlaying()
        {
            Console.WriteLine("The dog is now playing");
        }

        public void DogisChasingItsTail()
        {
            Console.WriteLine("The Dog is now chasing its tail.");
        }
        #endregion
        class Program
    {
            #region Task8
            //Task 8
            //Create a class Human
            //Add properties: FirstName, LastName, Age
            //Create a method called GetPersonStats that returns the full name of the human as well as their age
            //Create an object human by asking the user to fill the required information
            //Call the GetPersonStats method and print the result in the console after the object is created
            
                public class Human
            {
                public string FirstName;
                public string LastName;
                public int Age;

                public void GetPersonStats()
                {
                    Console.WriteLine($"{FirstName} {LastName} is {Age} years old");
                }
            }

            #endregion

            static void Main(string[] args)
            {
                #region Task7p2
                //Dog dogOne = new Dog();
                //Console.WriteLine("Type Your Dog's Name: ");
                //dogOne.dogName = Console.ReadLine();



                //Console.WriteLine("Type Your Dog's Color: ");
                //dogOne.dogColor = Console.ReadLine();



                //Console.WriteLine("Type Your Dog's Race: ");
                //dogOne.dogRace = Console.ReadLine();

                //Console.WriteLine("What does your dog enjoy doing the most?");
                //Console.WriteLine("1: Eat?");
                //Console.WriteLine("2: Play?");
                //Console.WriteLine("3: Chase It's Tail?");

                //string dogFavAction = Convert.ToString(Console.ReadLine());

                //switch (dogFavAction)
                //{
                //    case "1":
                //        dogOne.DogIsEating();
                //        break;
                //    case "2":
                //        dogOne.DogIsPlaying();
                //        break;
                //    case "3":
                //        dogOne.DogisChasingItsTail();
                //        break;
                //    default:
                //        Console.WriteLine("You did not choose any action!");
                //        break;
                //}
                //Ne se snajdov tuka kako koga go printam dole izborot na korisnikot da mi go dade i methodot sto go bira pogore. Mi go dava samo kako broj.
                //Console.WriteLine($"{dogOne.dogName} is a {dogOne.dogRace} and it's {dogOne.dogColor} ! It loves to {dogFavAction}");
                //Console.ReadLine();

                #endregion
                #region Task8p2
                //Human newHuman = new Human();
                //Console.WriteLine("What is your first name?");
                //newHuman.FirstName = Console.ReadLine();

                //Console.WriteLine("What is your Last name?");
                //newHuman.LastName = Console.ReadLine();

                //Console.WriteLine("How Old Are You?");
                //newHuman.Age = Convert.ToInt32(Console.ReadLine());

                //newHuman.GetPersonStats();
                #endregion


            }

        }
        
    }
}
