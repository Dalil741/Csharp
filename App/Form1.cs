using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestHeritage
{
    public partial class frmDiffusion : Form
    {
        private List<Diffusion> Lesdiffusions = new List<Diffusion>();
        public frmDiffusion()
        {
            InitializeComponent();
        }

        private void MajLstDiffusion()
        {
            lstDiffusion.Items.Clear();
            foreach (Diffusion diffusion in Lesdiffusions)
            {

                lstDiffusion.Items.Add(diffusion.getInfo());
            }
        }

        private void RestrictionAjout()
        {
            lRecette.Visible = rbFilm.Checked;
            tbRecette.Visible = rbFilm.Checked;
            lNbEpisode.Visible = !rbFilm.Checked;
            tbNbEpisode.Visible = !rbFilm.Checked;
        }

        private void rbFilm_CheckedChanged(object sender, EventArgs e)
        {
            RestrictionAjout();
        }

        private void rbSerie_CheckedChanged(object sender, EventArgs e)
        {
            RestrictionAjout();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Diffusion uneDiffusion;
            if (rbFilm.Checked)
            {
                uneDiffusion = new Film(txtTitre.Text, int.Parse(txtAnnee.Text), int.Parse(txtRecette.Text));
            }
            else
            {
                uneDiffusion = new Serie(txtTitre.Text, int.Parse(txtAnnee.Text), int.Parse(txtRecette.Text));
            }
            diffusions.Add(uneDiffusion);
            MajLstDiffusion();
        }
    }
}