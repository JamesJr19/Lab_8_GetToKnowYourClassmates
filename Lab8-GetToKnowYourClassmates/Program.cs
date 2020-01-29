using System;

namespace Lab8_GetToKnowYourClassmates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our C# class. Let's get to know your classmates.");


            //int pickStudent;
            string[][] classmates = new string[5][];
            classmates[0][0] = "1.James";
            classmates[1][0] = "2.Sean";
            classmates[2][0] = "3.Blake";
            classmates[3][0] = "4.Kyle";
            classmates[4][0] = "5.Cam";

            classmates[0] = new string[2] { "Pizza", "Lake Orion" };
            classmates[1] = new string[2] { "Chicken", "Ann Arbor" };
            classmates[2] = new string[2] { "Fries", "Monro" };
            classmates[3] = new string[2] { "Chicken Tenders", "Madison Heights" };
            classmates[4] = new string[2] { "Tacos", "Detroit" };


            for (int i = 0; i < classmates.Length; i++)
            {
                Console.WriteLine(classmates[i][0]);
                for (int j = 0; j < classmates[i].Length; j++)
                {
                    Console.WriteLine(classmates[i][j]);
                }
            }

            Console.WriteLine("Pick a classmate to learn more about them");
        }
    }
}






//            //"James", "Sean", "Blake", "Kyle", "Cam" };

//            string userContinue = "y";
//            while (userContinue != "n")
//            {
//                Console.WriteLine("Pick a student to learn more about them. (Enter a number between 0 and 4)");
//                int userInput = int.Parse(Console.ReadLine());

//                Console.WriteLine(classmates[userInput]);






//                try
//                    {
//                        pickStudent = int.Parse(Console.ReadLine());
//                    }
//                    catch (IndexOutOfRangeException)
//                    {
//                        Console.WriteLine("Number entered is not within valid range.");
//                    }
//                    catch (FormatException)
//                    {
//                        Console.WriteLine("That was not a number.");
//                    }

//                }
//                //Console.WriteLine($"{classmates.");

//                //ask user if they want to try again
//                //Validation to make sure they enter y or n
//                userContinue = "";
//                while (userContinue != "y" && userContinue != "n")
//                {
//                    Console.WriteLine("Would you like to try again? y/n");
//                    userContinue = Console.ReadLine().ToLower();
//                }



//        }
//    }
//}      




//        //validate number input
//        //public static string ValidateNumber(string num1)
//        //{

//        //    int userNumber = GetUserInput()
//        //    while (userNumber >= 1 && userNumber <= 5)
//        //    {

//        //        string userInput = GetUserInput("pick a number between 1 & 20");
//        //        isNumber = int.TryParse(userInput, out userNumber);

//        //    }
//        //    return $"You've selected student {userNumber}";
//        //}






//try
//{
//    checked //specifically for the OverflowException
//    {
//        int number = int.Parse(num1);
//        return number;
//    }
//}
//catch (FormatException)
//{
//    string userInput = GetUserInput("That is not a number.");
//    return ValidateNumber(userInput);
//}
//catch (IndexOutOfRangeException)
//{
//    string userInput = GetUserInput("Please enter a number between 1 and 20.");
//    return ValidateNumber(userInput);


