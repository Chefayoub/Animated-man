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
    class BrasCloseCurve : MonRectangleMovable
    {
        #region Données Membres
        private MonRectangleMovable _avantBras;
        private MonRectangleMovable _main;

        #endregion

        #region Constructeur
        public BrasCloseCurve(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg, longueur, hauteur)
        {
            this._avantBras = new MonRectangleMovable(hebergeur, xsg, ysg + hauteur, longueur, hauteur);
            this.Main = new MonRectangleMovable(hebergeur, xsg, ysg + 10 * hauteur, longueur, hauteur / 3);

            this._avantBras.Pot = Color.Gray;
            this._main.Pot = Color.Yellow;
        }

        #endregion

        #region Accesseur 
        public MonRectangleMovable Main
        {
            get { return _main; }
            set { _main = value; }
        }
        public MonRectangleMovable AvantBras
        {
            get { return _avantBras; }
            set { _avantBras = value; }
        }
        #endregion

        #region Methodes
        public void Bouger(int deplX, int deplY, double bh, double bb)
        {
            //Positionner le bras sur le milieu

            base.Bouger(deplX, deplY, bh);
            this._avantBras.X = base.MI.X;
            this._avantBras.Y = base.MI.Y;
            this._avantBras.X -= this._avantBras.MS.X - MI.X;
            this._avantBras.Y -= this._avantBras.MS.Y - MI.Y;
            this._avantBras.Bouger(0, 0, bb);

            this._main.X = _avantBras.X;
            this._main.Y = _avantBras.Y;
            this._main.X -= this._main.MS.X - _avantBras.MI.X;
            this._main.Y -= this._main.MS.Y - _avantBras.MI.Y;
            this._main.Bouger(0, 0, bb);


        }
        public new void Cacher(IntPtr handle)
        {
            base.Cacher(handle);
            this._avantBras.Cacher(handle);
            this._main.Cacher(handle);
        }
        public new void Afficher(IntPtr handle)
        {
            base.Afficher(handle);
            this._avantBras.Afficher(handle);
            this._main.Afficher(handle);
        }
        public new void Cacher(Graphics gr)
        {
            base.Cacher(gr);
            this._avantBras.Cacher(gr);
            this._main.Cacher(gr);
        }
        #region Modification pour le scintillement 
        public new void Afficher(Graphics gr)
        {
            base.Afficher(gr);
            this._avantBras.Afficher(gr);
            this._main.Afficher(gr);
        }
        #endregion

        #endregion
    }
}
