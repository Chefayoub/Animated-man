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
    class JambeSkieurCloseCurve : MonRectangleMovable
    {
        #region Données Membres
        private CuisseCloseCurve _cuisse;
        private MonRectangleMovable _pied;          
        #endregion

        #region Constructeur
        
        public JambeSkieurCloseCurve(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg, longueur, hauteur)
        {
            this._cuisse = new CuisseCloseCurve(hebergeur, xsg, ysg + 2 * hauteur, (int)(longueur * 3 / 2), hauteur / 3);
            this._pied = new MonRectangleMovable(hebergeur, xsg, ysg + hauteur, longueur, hauteur);
            this._cuisse.Pot = Color.Yellow;
            this._pied.Pot = Color.Gray;

        }


        #endregion

        #region Accesseurs
        /*
       public MonRectangle Thigh
       {
           get { return _pied; }
           set { _pied = value; }
       }
       public MonRectangle Foot
       {
           get { return _cuisse; }
           set { _cuisse = value; }
       }*/
        #endregion


        #region Methodes
        
        public void Bouger(int deplX, int deplY, double jh, double jb, double jp)
        {
            //Ici je prend la hauteur de la jambe la base ainsi que le pourcent de l'angle
            //Attention : Faut prendre le milieu du rectangle pour faire la forme close curve

            base.Bouger(deplX, deplY, jh);
            this._pied.X = base.MI.X;
            this._pied.Y = base.MI.Y;
            this._pied.X -= this._pied.MS.X - MI.X;
            this._pied.Y -= this._pied.MS.Y - MI.Y;
            this._pied.Bouger(0, 0, jb);

            this._cuisse.X = _pied.X;
            this._cuisse.Y = _pied.Y;
            this._cuisse.X -= this._cuisse.MS.X - this._pied.MI.X;
            this._cuisse.Y -= this._cuisse.MS.Y - this._pied.MI.Y;
            this._cuisse.BougerCuisse(0, 0, jp);
        }

        public new void Cacher(IntPtr handle)
        {
            base.Cacher(handle);
            this._pied.Cacher(handle);
            this._cuisse.CacherCuisse(handle);
        }
        public new void Cacher(Graphics gr)
        {
            base.Cacher(gr);
            this._pied.Cacher(gr);
            this._cuisse.CacherCuisse(gr);
        }
        public new void Afficher(IntPtr handle)
        {
            base.Afficher(handle);
            this._pied.Afficher(handle);
            this._cuisse.AfficherCuisse(handle);
        }
        public new void Afficher(Graphics gr)
        {
            base.Afficher(gr);
            this._pied.Afficher(gr);
            this._cuisse.AfficherCuisse(gr);
        }
        #endregion
    }
}
