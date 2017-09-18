/* Core Portfolio 3 * */



using System;
using System.Collections.Generic;

namespace CPSC1012_CorePort3
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> AnswerKey = new Dictionary<int, string>();
            AnswerKey.Add(1, "E");
            AnswerKey.Add(2, "D");
            AnswerKey.Add(3, "D");
            AnswerKey.Add(4, "B");
            AnswerKey.Add(5, "A");
            AnswerKey.Add(6, "C");
            AnswerKey.Add(7, "E");
            AnswerKey.Add(8, "B");
            AnswerKey.Add(9, "D");
            AnswerKey.Add(10, "C");
            AnswerKey.Add(11, "D");
            AnswerKey.Add(12, "A");
            AnswerKey.Add(13, "A");
            AnswerKey.Add(14, "D");
            AnswerKey.Add(15, "D");
            AnswerKey.Add(16, "E");
            AnswerKey.Add(17, "A");
            AnswerKey.Add(18, "E");
            AnswerKey.Add(19, "A");
            AnswerKey.Add(20, "D");

            Dictionary<int, string> UserAnswers = new Dictionary<int, string>();

            Console.WriteLine("Welcome to the Auto-Grader.");

            UserAnswers = Operations.EnterAnswers(AnswerKey, UserAnswers);
            List<int> Checked_Answers = Operations.CheckKey(AnswerKey, UserAnswers);
            Checked_Answers.ForEach(Console.WriteLine);

            Operations.PrintResults(Checked_Answers);

        }


    }
}
