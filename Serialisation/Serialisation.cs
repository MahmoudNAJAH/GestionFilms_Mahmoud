using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Serialisation
{
    public static class Serialisation
    {
        public static InitPersonnes(List<Personne> personnes)
        {
            Personne p = new Personne
            {
                Nom = "Luc",
                Prenom = "Dupond",
                Date_Naissance = new DateTime(1986, 3, 1)
        };

            //if (questions != null)
            //{
            //    questions[0].Reponses = new List<Reponse>();
            //    questions[0].Reponses.Add(new Reponse
            //    {
            //        EstCorrecte = true,
            //        Id = 1,
            //        Texte = "La réponse D"
            //    });

            //    questions[0].Reponses.Add(new ReponseImage
            //    {
            //        EstCorrecte = false,
            //        Id = 2,
            //        Texte = "La mauvaise réponse",
            //        Image = File.ReadAllBytes(@"C:\Users\Christopher LORENT\Pictures\dawan.png"),
            //        FileName = "dawan.png"
            //    });
            //}

            return p;
        }
    }
}
