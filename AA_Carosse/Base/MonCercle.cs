using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AA_Carosse
{
    class MonCercle : MonPoint
    {
        #region Données membres
        private Color _pot = Color.Chocolate;
        private bool _remplir = true;
        private int _rayon = 1;
        #endregion

        #region Constructeur
        public MonCercle(PictureBox hebergeur, int xc, int yc, int rayon) : base(hebergeur, xc, yc)
        {
            Rayon = rayon;
        }
        public MonCercle(PictureBox hebergeur, int xc, int yc, int rayon, Color pot) : base(hebergeur, xc, yc)
        {
            Rayon = rayon;
            Pot = pot;
        }
        public MonCercle(PictureBox hebergeur, int xc, int yc, int rayon, Color crayon, Color pot) : base(hebergeur, xc, yc, crayon)
        {
            Rayon = rayon;
            Pot = pot;
        }
        #endregion

        #region Accesseurs
        public Color Pot
        {
            get { return _pot; }
            set
            {
                try { _pot = value; }
                catch { }
            }
        }
        public bool Remplir
        {
            get { return _remplir; }
            set { _remplir = value; }
        }

        public int Rayon
        {
            get { return _rayon; }
            set
            {
                if (value <= 0) { _rayon = 1; }
                else { _rayon = value; }
            }
        }


        #endregion

        #region Méthodes

        #region Pour le sans close curve
        public override void Afficher2(IntPtr handle)
        {

            if (this.Visible)
            {
                //MessageBox.Show("Affiche cercle");
                Graphics gr = Graphics.FromHwnd(handle);
                if (this.Remplir)
                {
                    //on dessine le cercle (le point de référence de la classe MonPoint est au centre du cercle, il faut
                    //lui retirer le rayon 2*this.Rayon est la largeur et la hauteur
                    gr.FillEllipse(new SolidBrush(this.Pot), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
                }
                gr.DrawEllipse(new Pen(this.Crayon), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
            }

        }
        public void Afficher2(Graphics gr)
        {
            if (this.Visible)
            {
                if (this.Remplir) gr.FillEllipse(new SolidBrush(this.Pot), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
                gr.DrawEllipse(new Pen(this.Crayon), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
            }
        }
        #endregion

        public override void Afficher(IntPtr handle)
        {

            if (this.Visible)
            {
                //MessageBox.Show("Affiche cercle");
                Graphics gr = Graphics.FromHwnd(handle);
                if (this.Remplir)
                {
                    //on dessine le cercle (le point de référence de la classe MonPoint est au centre du cercle, il faut
                    //lui retirer le rayon 2*this.Rayon est la largeur et la hauteur
                    gr.FillEllipse(new SolidBrush(this.Pot), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
                }
                gr.DrawEllipse(new Pen(this.Crayon), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
            }

        }

        #region Modification contre le scintillement
        public void Afficher(Graphics gr)
        {
            if (this.Visible)
            {
                if (this.Remplir) gr.FillEllipse(new SolidBrush(this.Pot), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
                gr.DrawEllipse(new Pen(this.Crayon), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
            }
        }
        #endregion

        public override void Cacher(IntPtr handle)
        {
            Graphics gr = Graphics.FromHwnd(handle);
            gr.FillEllipse(new SolidBrush(this.Fond), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
            gr.DrawEllipse(new Pen(this.Fond), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
        }


        #endregion
    }
}
