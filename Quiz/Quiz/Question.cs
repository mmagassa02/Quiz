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


        //Constructeur avec arguments
        public Question(string sentence, string answer)
        {
            this._intitule = sentence;
            this._reponse = answer;
        }

        //Constructeur sans arguments
        public Question() { }

    }
}
