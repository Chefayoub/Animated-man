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
    class MonPerso : MonRectangleMovable
    {
        #region Données Membre
        private MonCercle _tete;
        private Bras _brasG, _brasD;
        private Jambe _jambeG, _jambeD;
        #endregion

        #region Constructeur
        public MonPerso(PictureBox hebergeur, int xsg, int ysg, int lg, int ht, double angle) : base(hebergeur, xsg, ysg, lg, ht, angle)
        {
            this._tete = new MonCercle(hebergeur, xsg + lg / 2, ysg - 15, ht / 5, Color.Maroon, Color.Maroon);
            this._brasD = new Bras(hebergeur, xsg + lg / 4, ysg + lg / 4, 15, 45, Color.Chocolate, Color.Chocolate, 0);
            this._brasG = new Bras(hebergeur, xsg + lg / 4, ysg + lg / 4, 15, 45, Color.Chocolate, Color.Chocolate, 0);
            this._jambeD = new Jambe(hebergeur, xsg + lg / 4, ysg + ht, 15, 60, Color.DarkBlue, Color.DarkBlue, 0);
            this._jambeG = new Jambe(hebergeur, xsg + lg / 4, ysg + ht, 15, 60, Color.DarkBlue, Color.DarkBlue,0);
            this.Crayon = Color.Black;
            this.Pot = Color.White;
        }
        #endregion

        /*
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
        */

        #region Méthodes

        public override void Afficher2(IntPtr handle)
        {
            this._brasG.Afficher2(handle);
            this._jambeG.Afficher2(handle);
            base.Afficher2(handle);
            this._tete.Afficher2(handle);
            this._jambeD.Afficher2(handle);
            this._brasD.Afficher2(handle);

        }

        #region Modification contre le scintillement
        public override void Afficher2(Graphics gr)
        {
            this._brasG.Afficher2(gr);
            this._jambeG.Afficher2(gr);
            base.Afficher2(gr);
            this._tete.Afficher2(gr);
            this._jambeD.Afficher2(gr);
            this._brasD.Afficher2(gr);
        }
        #endregion

        public new void Bouger(int deplX, int deplY, double diffangle)
        {
            base.Bouger(deplX, deplY);
            this._tete.Bouger(deplX, deplY);
            this._brasG.Bouger(deplX, deplY, -diffangle);
            this._brasG.Bouger(deplX, deplY, diffangle);
            this._brasD.Bouger(deplX, deplY, diffangle);
            this._brasD.Bouger(deplX, deplY, -diffangle);
            this._jambeG.Bouger(deplX, deplY, -diffangle);
            this._jambeD.Bouger(deplX, deplY, diffangle);
        }
        #endregion
    }
}
