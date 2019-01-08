using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Lets play a guessing game about me.");
            QuestionOne();
            QuestionTwo();
            QuestionThree();
            QuestionFour();
            QuestionFive();
            
        }

        public static int ScoreCounter()
        {
            int totalCorrect = 0;
            return totalCorrect ++;
        }

        public static string QuestionOne() {
            string correct = "Yes you are correct!";
            string incorrect = "No I was born in CA, Press ENTER for next question";
            Console.WriteLine("What state was I born in, CA, FL or WA?");
            string answerOne = Console.ReadLine().ToUpper();
            if (answerOne == "CA")
            {
                ScoreCounter();
                Console.WriteLine(correct);
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
                Console.WriteLine("Yes you are correct! Press ENTER for next question");
                return ansTwo;
            }
            else Console.WriteLine("No I am 39, Press ENTER for next question");
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
                Console.WriteLine("Yes you are correct! Press ENTER for next question");
                return ansThree;
            }
            else Console.WriteLine("No it is true I do have 3 dogs, Press ENTER for next question");
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
                Console.WriteLine("Yes you are correct! Press ENTER for next question");
            }
            else Console.WriteLine("No I actually have 2 kids, Press ENTER for next question");
            Console.ReadLine();
        }

        public static void QuestionFive()
        {
            Console.WriteLine("How long do you think I have been married, 5, 10 or 18 years?");
            string answerFive = Console.ReadLine();
            try
            {
                int ansFive = Convert.ToInt32(answerFive);
                if (ansFive == 18)
                {
                    Console.WriteLine("Yes you are correct! Thanks for playing, your score is");
                }
                else Console.WriteLine("No I have been married 18 years. Thanks for playing, your score is");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
