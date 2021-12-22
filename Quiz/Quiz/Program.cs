﻿using System;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {

 /*       public static int AskQuestion()
        {
            int score;
            return score;
        }*/

        static void Main(string[] args)
        {
            // Variables
            int scoreuser = 0; // Le score de l'utilisateur
            string userAnswer; // La réponse de l'utilisateur
            string user; //Le nom de l'utilisateur

            //Un dictionnaire <string,string> qui contient d'un coté la question avec les propositions et de l'autre coté les réponses pour comparer
            Dictionary<string, string> question = new Dictionary<string, string>();
            question.Add("1 Lequel de ces pays est situé en Europe?\nFrance\t\tSingapour\tLiechtenstein", "France Liechtenstein");
            question.Add("2 Lequel de ces monuments est situé en Italie?\nColisée\t\tTour Eiffel\tArc de triomphe", "Colisée");
            question.Add("3 En quelle année la France a gagné une coupe du monde de football?\n1984\t1998\t2018", "1998 2018");
            question.Add("4 Laquelle de ces capitales est située en Asie?\nTripoli\t\tErevan\tSéoul", "Séoul");
            question.Add("5 Quelle est la capitale du Canada?\nOttawa\tToronto\tVancouver", "Ottawa");
            question.Add("6 Quelle est la capitale de la Nouvelle Zélande\nWellington\tAuckland\tNassau", "Wellington");
            question.Add("7 Dans quel pays s'est déroulé la Coupe du Monde 2018?\nBrésil\tQatar\tRussie", "Russie");
            question.Add("8 Quelle capitale ne se situe pas dans l'hémisphère nord?", "");
            question.Add("9 Combien d'états possèdent les États-unis?\n50\t51\t52", "50");
            question.Add("10 Combien fait 1 x 2 x 3 x 4 x 5 x 6 = ???","720");


            //Saisie données user
            Console.WriteLine("Entrez votre nom d'utilisateur");
            user = Console.ReadLine();

            // Début du quiz
            Console.WriteLine("10 questions: ");
            foreach (var nb in question)
            {
                Console.WriteLine("{0}",nb.Key);
                userAnswer = Console.ReadLine();
                // Les réponses du dictionnaire contiennent la saisie de l'utilisateur
                if (nb.Value.Contains(userAnswer))
                {
                    Console.WriteLine("Bonne réponse\n");
                    scoreuser += 1;
                }
                else
                {
                    if (nb.Value.Contains(" "))
                        Console.WriteLine($"Faux. Les réponses étaient {nb.Value}\n");
                    else
                        Console.WriteLine($"Faux. La réponse était {nb.Value}\n");
                }
            }

            //Fin du quiz et affichage du score
            Console.WriteLine("Récapitulatif du quiz");
            Console.WriteLine($"{user}, vous avez obtenu {scoreuser}/{question.Count}");
        

        }
        
    }
}
