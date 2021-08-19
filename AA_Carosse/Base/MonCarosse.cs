using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AA_Carosse
{
    class MonCarosse : MonRectangle
    {
        #region Données membres

        private MonCercle _roueG, _roueD;
        private MonRectangle _porte, _fenD, _fenG, _poignee;

        #endregion

        #region Constructeurs
        public MonCarosse(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg, longueur, hauteur)
        {
            this.RoueG = new MonCercle(hebergeur, xsg, ysg + hauteur, hauteur / 2, Color.Brown, Color.Brown);
            this.RoueD = new MonCercle(hebergeur, xsg + longueur, ysg + hauteur, hauteur / 2, Color.Brown, Color.Brown);
            this.FenG = new MonRectangle(hebergeur, longueur / 10 + xsg, hauteur / 6 + ysg, longueur / 5, hauteur / 3);
            this.FenD = new MonRectangle(hebergeur, xsg + longueur - 3 * longueur / 10, hauteur / 6 + ysg, longueur / 5, hauteur / 3);
            this.Porte = new MonRectangle(hebergeur, xsg + longueur / 2 - 2 * longueur / 15, ysg + hauteur - 3 * hauteur / 4 - 1, 4 * longueur / 15, 3 * hauteur / 4);
            this.Poignee = new MonRectangle(hebergeur, xsg + longueur / 2 + longueur / 30, hauteur / 2 + ysg, longueur / 15, hauteur / 15);
            this.Crayon = Color.Red;
            this.Pot = Color.Gold;
            this.FenG.Pot = this._fenD.Pot = Color.Navy;
            this.Porte.Pot = Color.Red;
            this.Poignee.Pot = this._poignee.Crayon = Color.Yellow;
        }
        #endregion

        #region Accesseurs
        public MonCercle RoueD
        {
            get { return _roueD; }
            set { _roueD = value; }
        }

        public MonCercle RoueG
        {
            get { return _roueG; }
            set { _roueG = value; }
        }

        public MonRectangle Poignee
        {
            get { return _poignee; }
            set { _poignee = value; }
        }

        public MonRectangle FenG
        {
            get { return _fenG; }
            set { _fenG = value; }
        }

        public MonRectangle FenD
        {
            get { return _fenD; }
            set { _fenD = value; }
        }

        public MonRectangle Porte
        {
            get { return _porte; }
            set { _porte = value; }
        }
        #endregion

        #region Méthodes
        public new void Bouger(int deplX, int deplY)
        {
            base.Bouger(deplX, deplY);
            this._roueG.Bouger(deplX, deplY);
            this._roueD.Bouger(deplX, deplY);
            this._fenG.Bouger(deplX, deplY);
            this._fenD.Bouger(deplX, deplY);
            this._porte.Bouger(deplX, deplY);
            this._poignee.Bouger(deplX, deplY);
        }

        public new void Afficher(IntPtr handle)
        {
            base.Afficher(handle);
            this._roueG.Afficher(handle);
            this._roueD.Afficher(handle);
            this._fenG.Afficher(handle);
            this._fenD.Afficher(handle);
            this._porte.Afficher(handle);
            this._poignee.Afficher(handle);
        }

        #region Modification contre le scintillement
        public new void Afficher(Graphics gr)
        {
            base.Afficher(gr);
            this._roueG.Afficher(gr);
            this._roueD.Afficher(gr);
            this._fenG.Afficher(gr);
            this._fenD.Afficher(gr);
            this._porte.Afficher(gr);
            this._poignee.Afficher(gr);
        }
        #endregion

        public new void Cacher(IntPtr handle)
        {
            base.Cacher(handle);
            this._roueG.Cacher(handle);
            this._roueD.Cacher(handle);
            this._fenG.Cacher(handle);
            this._fenD.Cacher(handle);
            this._porte.Cacher(handle);
            this._poignee.Cacher(handle);
        }


        #endregion
    }
}
