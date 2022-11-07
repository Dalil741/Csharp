using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHeritage
{
    public abstract class Diffusion
    {
        protected String titre;
        protected int annee;

        public Diffusion(String titre, int annee)
        {
            this.titre = titre;
            this.annee = annee;
        }

        public String getTitre()
        {
            return this.titre;
        }

        public int getAnnee()
        {
            return this.annee;
        }

        public abstract String getInfo();
    }

    public class Film : Diffusion
    {
        private int recette;

        public Film(String titre, int annee, int recette) : base(titre, annee)
        {
            this.recette = recette;
        }

        public override string getInfo()
        {
            return base.annee + " " + base.titre + " (recette = " + this.recette + ")";
        }

        public int getRecette() { return this.recette; }
    }

    public class Serie : Diffusion
    {
        private int nbEpisodes;

        public Serie(String titre, int annee, int nbEpisodes) : base(titre, annee)
        {
            this.nbEpisodes = nbEpisodes;
        }

        public override string getInfo()
        {
            return base.annee + " " + base.titre + " (recette = " + this.nbEpisodes + ")";
        }

        public int getNbEpisodes() { return this.nbEpisodes; }
    }
}S