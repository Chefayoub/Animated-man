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
    class Decor : MonRectangle
    {

        #region Données Membres
        private MonRectangle _montagne1, _montagne2, _montagne3, _montagne4, _montagne5, _montagne6;
        private MonRectangle _neige1, _neige2, _neige3, _neige4, _neige5, _neige6;
        private MonCercle _soleil;
        public MonRectangle _obstacle1, _obstacle2, _obstacle3, _obstacle4;
        #endregion

        #region Constructeur 
        public Decor(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, Color crayon, Color pot) : base(hebergeur, xsg, ysg, longueur, hauteur, crayon, pot)
        {
            //Le soleil
            _soleil = new MonCercle(hebergeur, xsg + 1000, ysg - 200, 25, Color.Yellow);// x , y , rayon et couleur
            
            //Les montagnes sont faites avec un trinagles et je refais un autre plus petits pour la neiges
            
            this.Montagne1 = new MonRectangle(hebergeur, 300, ysg - 150, 150, 150, Color.Gray);
            this.Montagne2 = new MonRectangle(hebergeur, 350, ysg - 175, 175, 175, Color.Gray, Color.Gray);

            this.Neige1 = new MonRectangle(hebergeur, 360, ysg - 150, 30, 30, Color.White);// x, y ,longuer , hauteur , couleur
            this.Neige2 = new MonRectangle(hebergeur, 420, ysg - 175, 35, 35, Color.White);

            this.Montagne3 = new MonRectangle(hebergeur, 500, ysg - 200, 200, 200, Color.Gray);
            this.Montagne4 = new MonRectangle(hebergeur, 550, ysg - 225, 225, 225, Color.Gray, Color.Gray);

            this.Neige3 = new MonRectangle(hebergeur, 580, ysg - 200, 40, 40, Color.White);
            this.Neige4 = new MonRectangle(hebergeur, 640, ysg - 225, 45, 45, Color.White);

            this.Montagne5 = new MonRectangle(hebergeur, 800, ysg - 150, 150, 150, Color.Gray);
            this.Montagne6 = new MonRectangle(hebergeur, 850, ysg - 175, 175, 175, Color.Gray, Color.Gray);

            this.Neige5 = new MonRectangle(hebergeur, 860, ysg - 150, 30, 30, Color.White);
            this.Neige6 = new MonRectangle(hebergeur, 920, ysg - 175, 35, 35, Color.White);

            this.Obstacles1 = new MonRectangle(hebergeur, longueur, ysg - 60, 10, 60);
            this.Obstacles2 = new MonRectangle(hebergeur, longueur, ysg - 5, 10, 60);
            this.Obstacles3 = new MonRectangle(hebergeur, longueur, ysg - 60, 10, 60);
            this.Obstacles4 = new MonRectangle(hebergeur, longueur, ysg  + 1, 10, 100);//Lignes d'arrivé
        }
        #endregion

        #region Accesseurs
        public MonRectangle Montagne1
        {
            get { return _montagne1; }
            set { _montagne1 = value; }
        }

        public MonRectangle Montagne2
        {
            get { return _montagne2; }
            set { _montagne2 = value; }
        }
        public MonRectangle Montagne3
        {
            get { return _montagne3; }
            set { _montagne3 = value; }
        }
        public MonRectangle Montagne4
        {
            get { return _montagne4; }
            set { _montagne4 = value; }
        }
        public MonRectangle Montagne5
        {
            get { return _montagne5; }
            set { _montagne5 = value; }
        }
        public MonRectangle Montagne6
        {
            get { return _montagne6; }
            set { _montagne6 = value; }
        }

        public MonRectangle Neige1
        {
            get { return _neige1; }
            set { _neige1 = value; }
        }
        public MonRectangle Neige2
        {
            get { return _neige2; }
            set { _neige2 = value; }
        }
        public MonRectangle Neige3
        {
            get { return _neige3; }
            set { _neige3 = value; }
        }
        public MonRectangle Neige4
        {
            get { return _neige4; }
            set { _neige4 = value; }
        }
        public MonRectangle Neige5
        {
            get { return _neige5; }
            set { _neige5 = value; }
        }
        public MonRectangle Neige6
        {
            get { return _neige6; }
            set { _neige6 = value; }
        }
        public MonRectangle Obstacles1
        {
            get { return _obstacle1; }
            set { _obstacle1 = value; }
        }
        public MonRectangle Obstacles2
        {
            get { return _obstacle2; }
            set { _obstacle2 = value; }
        }
        public MonRectangle Obstacles3
        {
            get { return _obstacle3; }
            set { _obstacle3 = value; }
        }
        public MonRectangle Obstacles4
        {
            get { return _obstacle4; }
            set { _obstacle4 = value; }
        }


        #endregion


        #region Méthode

        public void BougerArr(int deplX, int deplY)
        {
            this._soleil.Bouger(deplX, deplY);
        }

        #region Les OBSTACLES
        //Obstacle 1
        public void BougerObstacle1(int deplX, int deplY)
        {
            this._obstacle1.Bouger(deplX, deplY);
        }

        //Obstacle 2
        public  void BougerObstacle2(int deplX, int deplY)
        {
            this._obstacle2.Bouger(deplX, deplY);
        }

        //Obstacle3
        public  void BougerObstacle3(int deplX, int deplY)
        {
            this._obstacle3.Bouger(deplX, deplY);
        }

        //Obstacle4 : Ligne d'arrivé
        public void BougerObstacle4(int deplX, int deplY)
        {
            this._obstacle4.Bouger(deplX, deplY);
        }
        #endregion

        public new void Cacher(IntPtr handle)
        {
            base.Cacher(handle);
            this._soleil.Cacher(handle);
            this._montagne1.CacherTriangle(handle);
            this._montagne2.CacherTriangle(handle);
            this._neige1.CacherTriangle(handle);
            this._neige2.CacherTriangle(handle);

            this._montagne3.CacherTriangle(handle);
            this._montagne4.CacherTriangle(handle);
            this._neige3.CacherTriangle(handle);
            this._neige4.CacherTriangle(handle);

            this._montagne5.CacherTriangle(handle);
            this._montagne6.CacherTriangle(handle);
            this._neige5.CacherTriangle(handle);
            this._neige6.CacherTriangle(handle);

            this._obstacle1.CacherCarre(handle);
            this._obstacle2.CacherCarre(handle);
            this._obstacle3.CacherCarre(handle);
            this._obstacle4.CacherCarre(handle);
        }

        public new void Cacher(Graphics gr)
        {
            base.Cacher(gr);
            this._soleil.Cacher(gr);
            this._montagne1.CacherTriangle(gr);
            this._montagne2.CacherTriangle(gr);
            this._neige1.CacherTriangle(gr);
            this._neige2.CacherTriangle(gr);

            this._montagne3.CacherTriangle(gr);
            this._montagne4.CacherTriangle(gr);
            this._neige3.CacherTriangle(gr);
            this._neige4.CacherTriangle(gr);

            this._montagne5.CacherTriangle(gr);
            this._montagne6.CacherTriangle(gr);
            this._neige5.CacherTriangle(gr);
            this._neige6.CacherTriangle(gr);

            this._obstacle1.CacherCarre(gr);
            this._obstacle2.CacherCarre(gr);
            this._obstacle3.CacherCarre(gr);
            this._obstacle4.CacherCarre(gr);
        }

        public new void Afficher(IntPtr handle)
        {
            base.AfficherCarre(handle);
            this._soleil.Afficher(handle);
            this._montagne1.AfficherTriangle(handle);
            this._montagne2.AfficherTriangle(handle);
            this._neige1.AfficherTriangle(handle);
            this._neige2.AfficherTriangle(handle);

            this._montagne3.AfficherTriangle(handle);
            this._montagne4.AfficherTriangle(handle);
            this._neige3.AfficherTriangle(handle);
            this._neige4.AfficherTriangle(handle);

            this._montagne5.AfficherTriangle(handle);
            this._montagne6.AfficherTriangle(handle);
            this._neige5.AfficherTriangle(handle);
            this._neige6.AfficherTriangle(handle);

            this._obstacle1.AfficherCarre(handle);
            this._obstacle2.AfficherCarre(handle);
            this._obstacle3.AfficherCarre(handle);
            this._obstacle4.AfficherCarre(handle);

        }

        #region Modification contre le scintillement
        public new void Afficher(Graphics gr)
        {
            base.AfficherCarre(gr);
            this._soleil.Afficher(gr);
            this._montagne1.AfficherTriangle(gr);
            this._montagne2.AfficherTriangle(gr);
            this._neige1.AfficherTriangle(gr);
            this._neige2.AfficherTriangle(gr);

            this._montagne3.AfficherTriangle(gr);
            this._montagne4.AfficherTriangle(gr);
            this._neige3.AfficherTriangle(gr);
            this._neige4.AfficherTriangle(gr);

            this._montagne5.AfficherTriangle(gr);
            this._montagne6.AfficherTriangle(gr);
            this._neige5.AfficherTriangle(gr);
            this._neige6.AfficherTriangle(gr);

            this._obstacle1.AfficherCarre(gr);
            this._obstacle2.AfficherCarre(gr);
            this._obstacle3.AfficherCarre(gr);
            this._obstacle4.AfficherCarre(gr);

        }
        #endregion

        #endregion
    }
}
