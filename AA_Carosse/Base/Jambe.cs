
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
    class Jambe : MonRectangleMovable
    {
        #region Donnés membres
        private MonRectangleMovable _tibia, _pied;

        #endregion

        #region Constructeur
        public Jambe(PictureBox hebergeur, int xbras, int ybras, int longueur, int hauteur, Color crayon, Color pot, double angle) : base(hebergeur, xbras, ybras, longueur, hauteur, angle)
        {
            this.Tibia = new MonRectangleMovable(hebergeur, base.CIG.X, base.CIG.Y, longueur, hauteur - 18, crayon, pot, angle);
            this.Pied = new MonRectangleMovable(hebergeur, Tibia.CIG.X, Tibia.CIG.Y, longueur * 2, hauteur / 6, crayon, pot, angle);
            this.Crayon = Color.Black;
            this.Pot = Color.LightBlue;
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

        #region Méthodes
        public new void Afficher2(IntPtr handle)
        {
            base.Afficher2(handle);
            _tibia.Afficher2(handle);
            _pied.Afficher2(handle);
        }
        public override void Bouger(int deplX, int deplY, double diffangle)
        {
            base.Bouger(deplX, deplY, diffangle);
            _tibia.Bouger(base.CIG.X - _tibia.CSG.X, base.CIG.Y - _tibia.CSG.Y, -diffangle / 3);
            _pied.Bouger(_tibia.CIG.X - _pied.CSG.X, _tibia.CIG.Y - _pied.CSG.Y, -diffangle / 3);
        }
        #endregion
    }
}


