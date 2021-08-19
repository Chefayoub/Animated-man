
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;


namespace AA_Carosse
{
    class Bras : MonRectangleMovable
    {
        
        #region Données Membre
        private MonRectangleMovable  _avantbras, _main;
        #endregion

        #region Constructeurs
        public Bras(PictureBox hebergeur, int xbras, int ybras, int longueur, int hauteur, Color crayon, Color pot, double angle) : base(hebergeur, xbras, ybras, longueur, hauteur, angle)
        {
            this._avantbras = new MonRectangleMovable(hebergeur, base.CIG.X, base.CIG.Y, longueur, hauteur - 15, crayon, pot, angle);
            this._main = new MonRectangleMovable(hebergeur, _avantbras.CIG.X, _avantbras.CIG.Y, longueur, hauteur / 4, crayon, pot, angle);
            this.Crayon = Color.Black;
            this.Pot = Color.OliveDrab;

        }
        #endregion

        #region Accesseurs
        public MonRectangleMovable AvantBras
        {
            get { return _avantbras; }
            set { _avantbras = value; }
        }

        public MonRectangleMovable Main
        {
            get { return _main; }
            set { _main = value; }
        }

        #endregion

        #region Méthodes
        public new void Afficher2(IntPtr handle)
        {
            base.Afficher2(handle);
            _avantbras.Afficher2(handle);
            _main.Afficher2(handle);
        }
        public override void Bouger(int deplX, int deplY, double diffangle)
        {
            base.Bouger(deplX, deplY, diffangle);
            _avantbras.Bouger(base.CIG.X - _avantbras.CSG.X, base.CIG.Y - _avantbras.CSG.Y, diffangle * 2);
            _main.Bouger(_avantbras.CIG.X - _main.CSG.X, _avantbras.CIG.Y - _main.CSG.Y, diffangle * 2);
        }
        #endregion

    }
}
