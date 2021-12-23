using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Quiz
{
    public class Question
    {
        //Attributs de la classe Question

        private string _intitule;
        public string Intitule { get => _intitule; set => _intitule = value; }

        private string _reponse;
        public string Reponse { get => _reponse; set => _reponse = value; }

        private string _userAnswer;
        public string UserAnswer { get => _userAnswer; set => _userAnswer = value; }


        //Constructeur avec arguments
        public Question(string sentence, string answer)
        {
            this._intitule = sentence;
            this._reponse = answer;
        }

        //Constructeur sans arguments
        public Question() { }


        //public void AjoutQuestions()
        //{
        //    _intitule.Add("1 Lequel de ces pays est situé en Europe?", "\nFrance\t\tSingapour\tLiechtenstein");
        //    _intitule.Add("2 Lequel de ces monuments est situé en Italie?", "\nColisée\t\tTour Eiffel\tArc de triomphe");
        //    _intitule.Add("3 En quelle année la France a gagné une coupe du monde de football?", "\n1984\t1998\t2018");
        //    _intitule.Add("4 Laquelle de ces capitales est située en Asie?", "\nTripoli\t\tErevan\tSéoul");
        //}

        //Affichage des questions

        public void ShowQuestions(Dictionary<string, string> quest)
        {
            /*    foreach (var nb in quest)
                {
                    Console.WriteLine($"{this.Intitule}\n{this.Reponse}");
                    this.UserAnswer = Console.ReadLine();
                    if (this.Reponse.Contains(UserAnswer))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Bonne réponse");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Mauvaise réponse, il fallait répondre {this.Reponse}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }*/

        }

        /*    public void CompareResponse(string userAnswer)
            {
                if (userAnswer == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Green;  //Passage du texte en vert pour la bonne reponse
                    Console.WriteLine("Bonne réponse");
                    this._score++;
                    Console.ForegroundColor = ConsoleColor.White; //On remet la console en blanc pour éviter de colorer la question suivante
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;  //Passage du texte en rouge pour la mauvaise réponse
                    Console.WriteLine("Mauvaise réponse\nIl fallait répondre : ");
                    Console.ForegroundColor = ConsoleColor.White; //On remet la console en blanc pour éviter de colorer la question suivante
                }
            }*/

    }
}
