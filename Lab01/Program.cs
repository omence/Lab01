using System;

namespace Lab01
{
    class Program
    {
        public static int totalCorrect = 0;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Lets play a guessing game about me.");
            QuestionOne();
            QuestionTwo();
            QuestionThree();
            QuestionFour();
            QuestionFive();
            Console.Write(totalCorrect);
        }


        public static string QuestionOne() {
            string correct = "Yes you are correct! Press ENTER for next question";
            string incorrect = "No I was born in CA, press ENTER for next question";
            Console.WriteLine("What state was I born in, CA, FL or WA?");
            string answerOne = Console.ReadLine().ToUpper();
            if (answerOne == "CA")
            {
                totalCorrect++;
                Console.WriteLine(correct);
                Console.ReadLine();
                return correct;
            }
            else Console.WriteLine(incorrect);
            Console.ReadLine();
            return incorrect;
        }

        public static int QuestionTwo()
        {
            Console.WriteLine("How old do you think I am");
            string answerTwo = Console.ReadLine();
            int ansTwo = Convert.ToInt32(answerTwo);
            if (ansTwo == 39)
            {
                totalCorrect++;
                Console.WriteLine("Yes you are correct! Press ENTER for next question");
                Console.ReadLine();
                return ansTwo;
            }
            else Console.WriteLine("No I am 39, press ENTER for next question");
            Console.ReadLine();
            return ansTwo;
        }

        public static bool QuestionThree()
        {
            Console.WriteLine("I have 3 dogs, True or False?");
            string answerThree = Console.ReadLine().ToLower();
            bool ansThree = Convert.ToBoolean(answerThree);
            if (ansThree == true)
            {
                totalCorrect++;
                Console.WriteLine("Yes you are correct! Press ENTER for next question");
                Console.ReadLine();
                return ansThree;
            }
            else Console.WriteLine("No it is true I do have 3 dogs, press ENTER for next question");
            Console.ReadLine();
            return ansThree;
        }

        public static void QuestionFour()
        {
            Console.WriteLine("I have 5 kids, True or False?");
            string answerFour = Console.ReadLine().ToLower();
            bool ansFour = Convert.ToBoolean(answerFour);
            if (ansFour == false)
            {
                totalCorrect++;
                Console.WriteLine("Yes you are correct! Press ENTER for next question");
                //Console.ReadLine();
            }
            else Console.WriteLine("No I actually have 2 kids, press ENTER for next question");
            Console.ReadLine();
        }

        public static int QuestionFive()
        {
            Console.WriteLine("How long do you think I have been married, 5, 10 or 18 years?");
            string answerFive = Console.ReadLine();
            try
            {
                int ansFive = Convert.ToInt32(answerFive);
                if (ansFive == 18)
                {
                    totalCorrect++;
                    Console.WriteLine($"Yes you are correct! Thanks for playing, your score is {totalCorrect}");
                    Console.ReadLine();
                    return ansFive;
                }
                else Console.WriteLine($"No I have been married 18 years. Thanks for playing, your score is {totalCorrect}");
                Console.ReadLine();
                return ansFive;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            finally
            {
                Console.WriteLine("the end");
                Console.ReadLine();

            }
        }
    }
}
