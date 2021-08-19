using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AA_Carosse
{
    class CuisseCloseCurve : MonRectangleMovable
    {
        //Cuisse close curve ressemble au rectangle movable juste que celle-ci est close curve

        #region Donnée membres 
        MonRectangleMovable _cuisse;
        #endregion

        #region Constructeur
        public CuisseCloseCurve(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg, longueur, hauteur)
        {
            this.Cuisse = new MonRectangleMovable(hebergeur, xsg, ysg, longueur * 8, hauteur / 4);
        }
        #endregion

        #region Accesseurs
        public MonRectangleMovable Cuisse
        {
            get { return _cuisse; }
            set { _cuisse = value; }
        }

        #endregion

        #region Methodes
        public void BougerCuisse(int deplX, int deplY, double ch)
        {
            //Ici je prend la hauteur de la jambe la base ainsi que le pourcent de l'angle
            //Attention : Faut prendre le milieu du rectangle pour faire la forme close curve

            base.Bouger(deplX, deplY, ch);
            this._cuisse.X = base.MI.X;
            this._cuisse.Y = base.MI.Y;
            this._cuisse.X -= this._cuisse.MS.X - MI.X;
            this._cuisse.Y -= this._cuisse.MS.Y - MI.Y;
            this._cuisse.Bouger(0, 0, 0);
        }
        public void CacherCuisse(IntPtr handle)
        {
            base.Cacher(handle);
            this._cuisse.CacherCarre(handle);
        }
        public void AfficherCuisse(IntPtr handle)
        {
            base.Afficher(handle);
            this._cuisse.AfficherCarre(handle);
        }

        #region Modification pour le scintillement 
        public void AfficherCuisse(Graphics gr)
        {
            base.Afficher(gr);
            this._cuisse.AfficherCarre(gr);
        }
        public void CacherCuisse(Graphics gr)
        {
            base.Cacher(gr);
            this._cuisse.CacherCarre(gr);
        }
        #endregion

        #endregion
    }
}
