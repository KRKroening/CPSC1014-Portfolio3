/* Core Portfolio 3
 * CPSC1012
 * 
 * Kim Kroening
 * */


using System;
using System.Collections.Generic;
using System.Linq;


namespace CPSC1012_CorePort2_KimKroening
{
    public class Operations
    {

        public static Dictionary<int, string> EnterAnswers(Dictionary<int, string> AnswerKey, Dictionary<int, string> UserAnswers)
        {
            int question = 1;
            string answerLetter;

            UserAnswers = new Dictionary<int, string>();

            Console.WriteLine("Enter your answers below: \n\n");
            do
            {
                Console.Write(question + ": ");
                answerLetter = Console.ReadLine().ToUpper();

                if (AnswerKey.ContainsValue(answerLetter)) //Check to see if the Letter entered is a valid answer.(A->E). If not valid asks for input again.
                {
                    UserAnswers[question] = answerLetter; //Adds entry to dictionary (Question number, Answer)
                    question++;                             // To the next question
                }
            } while (UserAnswers.Count < 20);
            return UserAnswers;
        }

        public static List<int> CheckKey(Dictionary<int, string> AnswerKey, Dictionary<int, string> UserAnswers)
        {
            int questionNumber = 1;
            List<int> wrongQuestion = new List<int>();
            wrongQuestion.Add(0);
            List<int> correctQuestion = new List<int>();
            correctQuestion.Add(1);

            while (true)
            {
                if (UserAnswers[questionNumber] == AnswerKey[questionNumber])
                {
                    correctQuestion.Add(questionNumber);
                    questionNumber++;
                }

                else
                {
                    wrongQuestion.Add(questionNumber);
                    questionNumber++;
                }

                if (questionNumber == 21)
                    break;

            }

            wrongQuestion.ForEach(Console.WriteLine);
            if (correctQuestion.Count > 11)
                return correctQuestion;
            else if (wrongQuestion.Count >= 11)
                return wrongQuestion;

            throw new Exception("Something went terribly wrong! ｡゜(｀Д´)゜｡");
        }

        public static void PrintResults(List<int> Checked_Answers)
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Results Calculating.");
            Console.WriteLine(". \n\t . \n\t . \n\t\t .");
            if (Checked_Answers[0] == 0) //Wrong list
            {
                int wrongAnswerTotal = Checked_Answers.Count - 1;
                Console.WriteLine("Your score is " + (20 - wrongAnswerTotal) + "/20. You have failed.");
                Console.WriteLine("Incorrect questions were as follows:");
                Checked_Answers.Remove(0);
                Checked_Answers.ForEach(Console.WriteLine);
            }
            else if (Checked_Answers[0] == 1) //Correct list
            {
                int CorrectAnswerTotal = Checked_Answers.Count - 1;
                Console.WriteLine("Your score is " + CorrectAnswerTotal + "/20. You have passed.");
            }

        }
    }
}
