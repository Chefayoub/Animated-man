using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Math;


namespace AA_Carosse
{
    class JambeCloseCurve : MonRectangleMovable
    {
        #region Données Membres
        private MonRectangleMovable _tibia;
        private MonRectangleMovable _pied;
        #endregion

        #region Constructeur
        public JambeCloseCurve(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg, longueur, hauteur)
        {

            this.Tibia = new MonRectangleMovable(hebergeur, xsg, ysg + hauteur, longueur, hauteur);
            this.Pied = new MonRectangleMovable(hebergeur, xsg, ysg + 2 * hauteur, (int)(longueur * 3 / 2), hauteur / 3);

            //this.Tibia = new MonRectangleMovable(hebergeur, base.CIG.X, base.CIG.Y, longueur, hauteur - 18, crayon, pot, angle);
            //this.Pied = new MonRectangleMovable(hebergeur, Tibia.CIG.X, Tibia.CIG.Y, longueur * 2, hauteur / 6, crayon, pot, angle);

            this.Tibia.Pot = Color.Gray;
            this.Pied.Pot = Color.GreenYellow;
        }

        #endregion
        
        
        #region Accesseurs
        public MonRectangleMovable Tibia
        {
            get { return _tibia; }
            set { _tibia = value; }
        }
        public MonRectangleMovable Pied
        {
            get { return _pied; }
            set { _pied = value; }
        }
        #endregion
        

        #region Methodes
        public void Bouger(int deplX, int deplY, double jh, double jb, double jp)
        {
            //Ici je prend la hauteur de la jambe la base ainsi que le pourcent de l'angle
            //Attention : Faut prendre le milieu du rectangle pour faire la forme close curve

                base.Bouger(deplX, deplY, jh);
                this._tibia.X = base.MI.X;
                this._tibia.Y = base.MI.Y;
                this._tibia.X -= this._tibia.MS.X - MI.X;
                this._tibia.Y -= this._tibia.MS.Y - MI.Y;
                this._tibia.Bouger(0, 0, jb);

                this._pied.X = _tibia.X;
                this._pied.Y = _tibia.Y;
                this._pied.X -= this._pied.MS.X - this._tibia.MI.X;
                this._pied.Y -= this._pied.MS.Y - this._tibia.MI.Y;
                this._pied.Bouger(0, 0, jp);
            
            
        }
        public new void Cacher(IntPtr handle)
        {
            base.Cacher(handle);
            this._tibia.Cacher(handle);
            this._pied.Cacher(handle);
        }
        
        public new void Afficher(IntPtr handle)
        {
            base.Afficher(handle);
            this._tibia.Afficher(handle);
            this._pied.Afficher(handle);
        }

        #region Modification pour le scintillement 
        public new void Afficher(Graphics gr)
        {
            base.Afficher(gr);
            this._tibia.Afficher(gr);
            this._pied.Afficher(gr);
        }
        #endregion

        #endregion
    }
}
