using System;
using System.Collections.Generic;
using System.IO;

namespace Quiz
{
    class Program
    {
        /*     public static void RecuperationFichier(Question question)
             {

             }*/
        public static void Init()
        {
            string saisie;
            try
            {
                Debut:
                Console.WriteLine("Veuillez saisir un ok pour commencer ou saisissez un code pour ajouter une question");
                saisie = Console.ReadLine();
                if(saisie == "ok") 
                {
                    List<Question> questions = new List<Question>()
                    {
                        new Question("1 Lequel de ces pays est situé en Europe?\nFrance\tInde\tLiechtenstein", "France Liechtenstein"),
                        new Question("2 Lequel de ces monuments est situé en Italie?\nColisée\tTour eiffel\tArc de triomphe", "Colisée"),
                        new Question("En quelle année la France a gagné une coupe du monde?\n1984\t1998\t2018","1998 2018"),
                        new Question("4 Laquelle de ces capitales est située en Asie?\nTripoli\t\tErevan\tSéoul", "Séoul"),
                        new Question("5 Quelle est la capitale du Canada?\nOttawa\tToronto\tVancouver", "Ottawa"),
                        new Question("6 Quelle est la capitale de la Nouvelle Zélande\nWellington\tAuckland\tNassau", "Wellington"),
                        new Question("7 Dans quel pays s'est déroulé la Coupe du Monde 2018?\nBrésil\tQatar\tRussie", "Russie"),
                        new Question("8 Quelle capitale ne se situe pas dans l'hémisphère nord?\nBogota\tCanberra\tBerlin", "Canberra"),
                        new Question("9 Combien d'états possèdent les États-unis?\n50\t51\t52", "50"),
                        new Question("10 Combien fait 1 x 2 x 3 x 4 x 5 x 6 = ???", "720"),
                    };
                    AskQuestion(questions);
                }else if(saisie == "mmagassa")
                {
                    if (AddQuestionFile() == true)
                        goto Debut;
                }

            }
            catch(Exception)
            {
                Console.WriteLine("Erreur de saisie");
            }
            /*
            AskQuestion(questions);*/
        }

        public static bool AddQuestionFile()
        {
            bool ajout = false;
            string questionuser, proposition, reponseUser, chaine;
            Console.WriteLine("Ecrivez dans un premier temps la question...");
            questionuser = Console.ReadLine();
            Console.WriteLine("suivie des propositions de réponse...");
            proposition = Console.ReadLine();
            Console.WriteLine("et de la ou les réponses possibles (Si plusieurs réponses possibles, les séparer par une virgule");
            reponseUser = Console.ReadLine();

            chaine = questionuser+"#"+proposition+"#"+reponseUser;
            StreamWriter sw = new StreamWriter("questions.txt");
            sw.WriteLine(chaine);
            sw.Flush();
            sw.Close();
            Console.WriteLine("La question a été ajoutée");
            ajout = true;
            return ajout;
        
        }




        public static void AskQuestion(List<Question> questionList)
        {
            string[] multipleChoice;
            int score = 0;
            string userAnswer;
            bool isValid = false; // Vaudra true si la réponse est bonne

            foreach (var nb in questionList)
            {
                Console.WriteLine(nb.Intitule);
                userAnswer = Console.ReadLine();

                multipleChoice = nb.Reponse.Split(" ");

                foreach(var choice in multipleChoice)
                {
                    if(choice == userAnswer)// Si la saisie correspond à au moins une réponse possible
                        isValid = true; 
                }
                if (isValid)
                {
                    //Bonne réponse donc coloration en vert
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bonne réponse\n");
                    score++;
                    Console.ForegroundColor = ConsoleColor.White;
                    isValid = false; // On remet isValid a false sinon toutes les réponses seront bonnes
                }
                else
                {
                    //Bonne réponse donc coloration en rouge
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Mauvaise réponse\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            AffichageScore(score, questionList.Count);
        }


        public static void AffichageScore(int score, int nbQuestions)
        {
            Console.WriteLine($"Vous avez eu bon à {score} questions sur {nbQuestions}");
        }


        static void Main(string[] args)
        {
            Init();

            // Variables
            /*
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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bonne réponse\n");
                    scoreuser += 1;
                }
                else
                {
                    if (nb.Value.Contains(" "))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Faux. Les réponses étaient {nb.Value}\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Faux. La réponse était {nb.Value}\n");
                    }
                }
            }

            //Fin du quiz et affichage du score
            Console.WriteLine("Récapitulatif du quiz");
            Console.WriteLine($"{user}, votre score est de {scoreuser} sur {question.Count}");
        */
        }


    }
}

