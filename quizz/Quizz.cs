using System;
using System.Collections.Generic;
using System.Text;

namespace quizz
{
    class Quizz
    {
        public List<QR> qcm;
        public int score;
        public List<QR> wrongAnswers;

        public Quizz(List<QR> qcm, int score, List<QR> wrongAnswers)
        {
            this.qcm = qcm;
            this.score = score;
            this.wrongAnswers = wrongAnswers;
        }

        /*ajoute 1 au score*/
        public void AddScore()
        {
            score++;
        }

        /* Récupère les réponse mal répondu */
        public void getWrongAnswers(QR question)
        {
            wrongAnswers.Add(question);
        }

        /* Affiche les questions mal répondus avec leurs réponses */
        public void printWrongAnswers()
        {
            if (wrongAnswers.Count == 0)
            {
                return;
            }

            Console.WriteLine("Voici les questions où vous avez eut faux avec leurs réponses.");
            foreach (QR wrong in wrongAnswers)
            {
                wrong.printQR();
                Console.WriteLine("La ou les réponse était: ");
                foreach (string answer in wrong.answers)
                {
                    Console.WriteLine(answer);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
