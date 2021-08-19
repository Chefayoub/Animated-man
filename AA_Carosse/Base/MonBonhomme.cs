using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AA_Carosse
{
    class MonBonhomme : MonRectangle
    {
        #region Données Membres
        private MonCercle _tete;
        private MonRectangle _brasD, _brasG, _jambeD, _jambeG;
        #endregion

        #region Constructeurs
        public MonBonhomme(PictureBox hebergeur, int xsg, int ysg, int lg, int ht) : base(hebergeur, xsg, ysg, lg, ht)
        {
            this.Tete = new MonCercle(hebergeur, xsg + lg / 2, ysg - 15, ht / 5, Color.Maroon, Color.Maroon);
            this.BrasD = new MonRectangle(hebergeur, xsg + lg / 4, ysg + lg / 4, 15, 45, Color.Chocolate, Color.Chocolate);
            this.BrasG = new MonRectangle(hebergeur, xsg + lg / 4, ysg + lg / 4, 15, 45, Color.Chocolate, Color.Chocolate);
            this.JambeD = new MonRectangle(hebergeur, xsg + lg / 4, ysg + ht, 15, 60, Color.DarkBlue, Color.DarkBlue);
            this.JambeG = new MonRectangle(hebergeur, xsg + lg / 4, ysg + ht, 15, 60, Color.DarkBlue, Color.DarkBlue);
            this.Crayon = Color.Black;
            this.Pot = Color.White;
        }
        #endregion

        #region Accesseurs
        public MonCercle Tete
        {
            get { return _tete; }
            set { _tete = value; }
        }

        public MonRectangle BrasD
        {
            get { return _brasD; }
            set { _brasD = value; }
        }

        public MonRectangle BrasG
        {
            get { return _brasG; }
            set { _brasG = value; }
        }

        public MonRectangle JambeD
        {
            get { return _jambeD; }
            set { _jambeD = value; }
        }

        public MonRectangle JambeG
        {
            get { return _jambeG; }
            set { _jambeG = value; }
        }
        #endregion

        #region Méthodes
        public override void Afficher2(IntPtr handle)
        {
            base.Afficher2(handle);
            this._tete.Afficher2(handle);
            this._brasD.Afficher2(handle);
            this._brasG.Afficher2(handle);
            this._jambeD.Afficher2(handle);
            this._jambeG.Afficher2(handle);
        }
        public override void Afficher2(Graphics gr)
        {
            base.Afficher2(gr);
            this._tete.Afficher2(gr);
            this._brasD.Afficher2(gr);
            this._brasG.Afficher2(gr);
            this._jambeD.Afficher2(gr);
            this._jambeG.Afficher2(gr);
        }
        public new void Bouger(int deplX, int deplY)
        {
            base.Bouger(deplX, deplY);
            this._brasG.Bouger(deplX, deplY);
            this._brasD.Bouger(deplX, deplY);
            this._jambeG.Bouger(deplX, deplY);
            this._jambeD.Bouger(deplX, deplY);
            this._tete.Bouger(deplX, deplY);
        }

        #endregion
    }
}
