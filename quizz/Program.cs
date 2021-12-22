using System;
using System.Collections.Generic;

namespace quizz
{
    class Program
    {
        static void Main(string[] args)
        {
            QR question1 = new QR("Dans la série de jeu Super Mario, Quel est le nom de famille de Mario ?",
                new Dictionary<int, string> { 
                    { 1, "Mario" },
                    { 2, "Shroom" },
                    { 3, "Star" }, 
                    { 4, "Bros" }}, 
                new List<string>{"Mario"});

            QR question2 = new QR("Comment s'appelle les héros de la série Megaman X ?",
                new Dictionary<int, string> {
                    { 1, "Zero" },
                    { 2, "X" },
                    { 3, "Megaman" },
                    { 4, "Bass" }},
                new List<string> { "X", "Zero" });

            QR question3 = new QR("Lequel de ses héros est un robot ?",
                new Dictionary<int, string> {
                    { 1, "Astroboy" },
                    { 2, "Kirby" },
                    { 3, "Flipper" },
                    { 4, "Franky" }}, 
                new List<string> { "Astroboy"});

            QR question4 = new QR("Qui est le boss du célèbre jeu Final Fantasy 7 ?", 
                new Dictionary<int, string> {
                    { 1, "Séphiroth" },
                    { 2, "Leon" },
                    { 3, "Cloud" },
                    { 4, "Ansem" }}, 
                new List<string> { "Séphiroth" });

            QR question5 = new QR("Qui sont les héros du jeu Kingdom Hearts ?", 
                new Dictionary<int, string> {
                    { 1, "Pampa" },
                    { 2, "Dingo" },
                    { 3, "Sora" },
                    { 4, "Donald" }}, 
                new List<string> { "Dingo", "Sora", "Donald" });

            QR question6 = new QR("Quels est le premier objectif de Jackie Chan dans le dessin animé du même nom ?", 
                new Dictionary<int, string> {
                    { 1, "Récupérer les 12 talismans" },
                    { 2, "Récupérer les masque de Oni" },
                    { 3, "Sceller la fratrie de Shendou" },
                    { 4, "Sauver la vipère" }}, 
                new List<string> { "Récupérer les 12 talismans" });

            QR question7 = new QR("Qui est l'esprit principal d'Asakura Yoh dans Shaman King ?",
                new Dictionary<int, string> {
                    { 1, "Amidamaru" },
                    { 2, "Bason" },
                    { 3, "Tokageroh" },
                    { 4, "Spirit of Fire" }}, 
                new List<string> { "Amidamaru" });

            QR question8 = new QR("Quel est la technique la plus puissante de Naruto dans le manga du même nom ?",
                new Dictionary<int, string> {
                    { 1, "Le rasengan planétaire" },
                    { 2, "L'Orbe des démon à queues" },
                    { 3, "le Sexy Jutsu" },
                    { 4, "Le pet foireux" }}, 
                new List<string> { "L'Orbe des démon à queues" });

            QR question9 = new QR("Quels sont les ancients noms des cyborgs C17 et C18 dans le manga Dragon Ball ?",
                new Dictionary<int, string> {
                    { 1, "Tomtom et Nana" },
                    { 2, "Lapis et Lazuli" },
                    { 3, "Pierre et Pierrete" },
                    { 4, "Goku et Gohan" }}, 
                new List<string> { "Lapis et Lazuli" });

            QR question10 = new QR("Qui est-ce qui va rentrer a 19h en étant bien claqué ?",
                new Dictionary<int, string> {
                    { 1, "Khenjy" },
                    { 2, "Kenji" },
                    { 3, "Kenjy" },
                    { 4, "Kendjy" }}, 
                new List<string> { "Khenjy" });

            List<QR> qcm = new List<QR>
            {
                question1,
                question2,
                question3,
                question4,
                question5,
                question6,
                question7,
                question8,
                question9,
                question10
            };

            Quizz quizz = new Quizz(qcm , 0);
            int choice = 5;
            List<int> choices = new List<int>();

            Console.WriteLine("Bienvenue dans un quizz spéciale culture Geek, nous commençons tout de suite !");
            Console.WriteLine("Il peut y avoir une ou plusieurs réponses, réfléchissez bien !\n");

            while (true)
            {
                foreach(QR question in quizz.qcm)
                {
                    question.printQR();
                    Console.WriteLine("Entrez le numéro de la réponse:");

                    while(choices.Count != 4)
                    {
                        try
                        {
                            Console.WriteLine("Pour arrêter la saisie, tapez 0:");
                            choice = int.Parse(Console.ReadLine());

                            if(choice > 4)
                            {
                                Console.WriteLine("Ceci n'est pas une reponse. Rechoisissez");
                            }
                            else if (choice == 0)
                            {
                                break;
                            }
                            else
                            {
                                if (choices.Contains(choice))
                                {
                                    Console.WriteLine("Vous avez deja choisi cette réponse. Rechoisissez");
                                }
                                else
                                {
                                    choices.Add(choice);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ceci n'est pas une reponse. Rechoisissez");
                        }
                    }
                    

                    quizz.AddScore(question.VerifyAnswers(choices));
                    choices.Clear();
                    Console.WriteLine("\n");
                }
                break;
            }

            if(quizz.score > 5)
            {
                Console.Write("Vous avez eut " + quizz.score + " sur 10 !", Console.BackgroundColor = ConsoleColor.DarkGreen);
                Console.ResetColor();
            }
            else
            {
                Console.Write("Vous avez eut " + quizz.score + " sur 10...", Console.BackgroundColor = ConsoleColor.DarkRed);
                Console.ResetColor();
            }
            

        }
    }
}
