using System;
using System.Collections.Generic;
using System.Text;

namespace quizz
{
    class QR
    {
        public string question;
        public Dictionary<int, string> choices;
        public List<string> answers;

        public QR(string question, Dictionary<int, string> choices, List<string> answers)
        {
            this.question = question;
            this.choices = choices;
            this.answers = answers;
        }

        /* Vérifier si les réponses données sont correctes */
        public bool VerifyAnswers(List<int> userChoices)
        {
            bool correct = false;
            int totalCorrect = 0;

            foreach(int uChoice in userChoices)
            {
                foreach(string answer in answers)
                {
                    if (choices[uChoice] == answer)
                    {
                        totalCorrect++;
                        break;
                    }
                }
            }

            if(totalCorrect == answers.Count)
            {
                correct = true;
            }

            return correct;
        }

        /* Affiche la question et ses choix multiples */
        public void printQR()
        {
            Console.WriteLine(question, Console.ForegroundColor = ConsoleColor.Blue);
            foreach(KeyValuePair<int, string> choice in choices)
            {
                Console.WriteLine(choice.Key + " - " + choice.Value, Console.ForegroundColor = ConsoleColor.Yellow);
            }
            Console.ResetColor();
        }
    }
}
