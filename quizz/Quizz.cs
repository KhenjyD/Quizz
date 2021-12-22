using System;
using System.Collections.Generic;
using System.Text;

namespace quizz
{
    class Quizz
    {
        public List<QR> qcm;
        public int score;

        public Quizz(List<QR> qcm, int score)
        {
            this.qcm = qcm;
            this.score = score;
        }

        public void AddScore(bool correct)
        {
            if (correct)
            {
                score++;
            }
        }
    }
}
