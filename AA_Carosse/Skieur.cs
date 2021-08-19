using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Math;
using System.Threading;

namespace AA_Carosse
{
    class Skieur : MonRectangle
    {
        #region Données membres
        private MonCercle _tete;
        private BrasCloseCurve _brasGauche, _brasDroite;
        private JambeSkieurCloseCurve _jambeGauche, _jambeDroite;
        private Decor _decorArr;
        private MonRectangleMovable _batonGauche, _batonDroite;



        #endregion

        #region Constructeurs
        public Skieur(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, int LongueurDecor, int HauteurDecor) : base(hebergeur, xsg, ysg, longueur, hauteur)
        {
            //Le decor
            this.DecorArr = new Decor(hebergeur, 0, HauteurDecor, LongueurDecor, 80, Color.White, Color.White);
            /*hebergeur, 0, 256, 1350, 100, Color.White, Color.White);//Les memes que la classe decor*/




            //Les parties du skieur
            this.Tete = new MonCercle(hebergeur, xsg + longueur / 2, ysg - longueur * 3 / 4, longueur / 2);
            this.MainGauche = new BrasCloseCurve(hebergeur, base.MS.X, ysg, longueur / 3, hauteur / 3);
            this.MainDroite = new BrasCloseCurve(hebergeur, base.MS.X, ysg, longueur / 3, Hauteur / 3);
            this.JambeGauche = new JambeSkieurCloseCurve(hebergeur, base.MI.X, ysg + hauteur, longueur / 2, hauteur / 2);
            this.JambeDroite = new JambeSkieurCloseCurve(hebergeur, base.MI.X, ysg + hauteur, longueur / 2, hauteur / 2);



            //Les Batons du skieur
            this.BatonGauche = new MonRectangleMovable(hebergeur, this.MainDroite.Main.CID.X, this.MainDroite.Main.CID.Y, (int)(hauteur * 1.8), longueur / 5, Color.Blue);
            this.BatonDroite = new MonRectangleMovable(hebergeur, this.MainDroite.Main.CID.X, this.MainDroite.Main.CID.Y, (int)(hauteur * 1.8), longueur / 5, Color.Blue);
        }
        #endregion

        #region Accesseurs
        public MonRectangleMovable BatonGauche
        {
            get { return _batonGauche; }
            set { _batonGauche = value; }
        }
        public MonRectangleMovable BatonDroite
        {
            get { return _batonDroite; }
            set { _batonDroite = value; }
        }
        public Decor DecorArr
        {
            get { return _decorArr; }
            set { _decorArr = value; }
        }
        public MonCercle Tete
        {
            get { return _tete; }
            set { _tete = value; }
        }
        public JambeSkieurCloseCurve JambeGauche
        {
            get { return _jambeGauche; }
            set { _jambeGauche = value; }
        }

        public JambeSkieurCloseCurve JambeDroite
        {
            get { return _jambeDroite; }
            set { _jambeDroite = value; }
        }

        public BrasCloseCurve MainGauche
        {
            get { return _brasGauche; }
            set { _brasGauche = value; }
        }

        public BrasCloseCurve MainDroite
        {
            get { return _brasDroite; }
            set { _brasDroite = value; }
        }
        #endregion

        #region Méthodes


         
        // Le deplacement du skieur ce fait ici
        public void Deplacement(IntPtr handle)
        {
            // Données pour placer les differents membres
            int i = 0;
            int j = 8;


            //Le cacher permet d'enlever la repetion du bonhomme
            //Donc on affiche ensuite on cache et on fait le mouvement



            // Le skieur se met en place


            //Ici ce fait le placement des batons
            //9a les bloques au meme endroit durant toutes l'animation
            Afficher(handle);
            Thread.Sleep(130);
            //Cacher(handle);
            Bouger(80, -10, 0, 1.5708, 0, 1.5708, 0, 0, 0, 0, 0, 0);
            this.BatonDroite.Bouger(0, 0, 2 * 1.5708);
            this.BatonGauche.Bouger(0, 0, 2 * 1.5708);
            Afficher(handle);


            //---------------------------------

            //                          1        2             3           4           5           6           7           8           9           10          11          12
            // public void Bouger(int deplX, int deplY, double bgh, double bgb, double bdh, double bdb, double jgh, double jgb, double jdh, double jdb, double apg, double apd)
            //                                            (--Bras gauche --)       (-- Bras droite --)      (--Jambe gauche --)      (--Jambe droite--)    (Angle %  JambeGauche et Jambe--) 


            //1...Premier coup d'acceleration : VERS LE haut----------------------
            for (i = 0; i < j; i++)
            {
                Afficher(handle);
                Thread.Sleep(130);
                Cacher(handle);
                Bouger(2, 1-2, 2.0944 / j, 0.523599 / j, 2.0944 / j, 0.523599 / j, 0.523599 / j, -1.0472 / j, 0.523599 / j, -1.0472 / j, 0, 0);
                DecorArr.BougerArr(-3, 0);
                Afficher(handle);
            }

            //1...Premier coup d'acceleration : VERS LE bas
            for (i = 0; i < j; i++)
            {
                Afficher(handle);
                Thread.Sleep(130);
                //Cacher(handle);
                Bouger(1, 1-3, -1.5708 / j, -1.5708 / j, -1.5708 / j, -1.5708 / j,  0, 0, 0, 0, 0, 0);
                DecorArr.BougerArr(-3, 0);
                Afficher(handle);
            }
            //------------------------------------------------------------------------------------------------------


            //                          1        2             3           4           5           6           7           8           9           10          11          12
            // public void Bouger(int deplX, int deplY, double bgh, double bgb, double bdh, double bdb, double jgh, double jgb, double jdh, double jdb, double apg, double apd)
            //                                            (--Bras gauche --)       (-- Bras droite --)      (--Jambe gauche --)      (--Jambe droite--)    (Angle %  JambeGauche et Jambe--) 

            
            //2...Premier coup d'acceleration : VERS LE haut---------------
            for (i = 0; i < j; i++)
            {
                Afficher(handle);
                Thread.Sleep(130);
                Cacher(handle);
                Bouger(0, 0, 0.523599 / j, 2.0944 / j, 0.523599 / j, 2.0944 / j, 0, 0, 0, 0, 0, 0);
                DecorArr.BougerArr(-3, 0);
                Afficher(handle);
            }

            //2...Premier coup d'acceleration : VERS LE bas
            for (i = 0; i < j; i++)
            {
                Afficher(handle);
                Thread.Sleep(130);
                //Cacher(handle);
                Bouger(0, 0, -0.523599 / j, -2.0944 / j, -0.523599 / j, -2.0944 / j, 0, 0, 0, 0, 0, 0);
                DecorArr.BougerArr(-3, 0);
                Afficher(handle);
            }
            //--------------------------------------------------------------




            //3...Premier coup d'acceleration : VERS LE haut----------------------
            for (i = 0; i < j; i++)
            {
                Afficher(handle);
                Thread.Sleep(130);
                //Cacher(handle);
                Bouger(0, 0, -0.523599 * 2 / j, -0 / j, -0.523599 * 2 / j, -0 / j, +0.523599 / j, 0, +0.523599 / j, 0, 0, 0);
                DecorArr.BougerArr(-3, 0);
                Afficher(handle);
            }

            //3...Premier coup d'acceleration : VERS LE bas et baton reste vers le derriere
            for (i = 0; i < j; i++)
            {
                Afficher(handle);
                Thread.Sleep(130);
                Cacher(handle);
                Bouger(0, 0);
                Afficher(handle);

            }
            //--------------------------------------------------------------


            

            //Le moment ou les obstacles sont envoyer
            //Deplacement du skieur a ce moment

            //redescend vers le bas et esquive le 1er obstacle
            for (i = 0; i < 16; i++)
            {
                Afficher(handle);
                Thread.Sleep(130);
                //Cacher(handle);
                Bouger(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                DecorArr.BougerObstacle1((int)(-1500 / 16), 0);
                DecorArr.BougerArr(-3, 0);
                Afficher(handle);
            }

            //remonte vers le haut et esquive le 2e obstacle
            for (i = 0; i < 16; i++)
            {
                Afficher(handle);
                Thread.Sleep(130);
                Cacher(handle);
                Bouger(2, -3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                DecorArr.BougerObstacle2((int)(-1500 / 16), 0);
                DecorArr.BougerArr(-3, 0);
                Afficher(handle);
            }


            //redescend vers le bas et esquive le 3 obstacle et continue à  avancer
            for (i = 0; i < 8; i++)
            {
                Afficher(handle);
                Thread.Sleep(130);
                //Cacher(handle);
                DecorArr.BougerObstacle3((int)(-3000 / 16), 0);
                DecorArr.BougerArr(-3, 0);
                Bouger(2, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                Afficher(handle);
            }

            // reviens en position normal
            for (i = 0; i < 8; i++)
            {
                Afficher(handle);
                Thread.Sleep(130);
                Cacher(handle);
                DecorArr.BougerObstacle4((int)(-2800 / 16), 0);
                DecorArr.BougerArr(-3, 0);
                Bouger(2, -2,0.523599 / j, 1.0472 / j, 0.523599 / j, 1.0472 / j,-1.0472 / j, +1.0472 / j, -1.0472 / j, +1.0472 / j, 0, 0);
                Afficher(handle);
            }

        }
        



        //                        1        2           3           4           5           6           7           8           9           10          11          12
        public void Bouger(int deplX, int deplY, double bgh, double bgb, double bdh, double bdb, double jgh, double jgb, double jdh, double jdb, double apg, double apd)
        {//                                       (--Bras gauche --)       (-- Bras droite --)      (--Jambe gauche --)      (--Jambe droite--)   (Angle %  JambeGauche et Jambe--)  
         //Chaque fois je prend la hauteur et la base de chaqueDroite
         //Pour les jambe j'ai ajouter le % de l'angle pour le plit

            base.Bouger(deplX, deplY);
            this.Tete.Bouger(deplX, deplY);

            this.JambeDroite.Bouger(deplX, deplY, jdh, jdb, apd);
            this.JambeGauche.Bouger(deplX, deplY, jgh, jgb, apg);

            this.MainGauche.Bouger(deplX, deplY, bgh, bgb);
            this.MainDroite.Bouger(deplX, deplY, bdh, bdb);

            this.BatonGauche.X = MainGauche.Main.X;
            this.BatonGauche.Y = MainGauche.Main.Y;
            this.BatonGauche.Bouger(deplX, deplY, bgb);

            this.BatonDroite.X = MainDroite.Main.X;
            this.BatonDroite.Y = MainDroite.Main.Y;
            this.BatonDroite.Bouger(deplX, deplY, bdb);

        }

        public new void Cacher(IntPtr handle)
        {
            this.DecorArr.Cacher(handle);
            base.Cacher(handle);

            this.Tete.Cacher(handle);
            this.MainGauche.Cacher(handle);
            this.MainDroite.Cacher(handle);
            this.JambeGauche.Cacher(handle);
            this.JambeDroite.Cacher(handle);
            this.BatonGauche.CacherCarre(handle);
            this.BatonDroite.CacherCarre(handle);
        }
        public new void Cacher(Graphics gr)
        {
            this.DecorArr.Cacher(gr);
            base.Cacher(gr);
            this.Tete.Cacher(gr);
            this.MainGauche.Cacher(gr);
            this.MainDroite.Cacher(gr);
            this.JambeGauche.Cacher(gr);
            this.JambeDroite.Cacher(gr);
            this.BatonGauche.CacherCarre(gr);
            this.BatonDroite.CacherCarre(gr);
        }

        public new void Afficher(IntPtr handle)
        {
            //D'abord afficher le fond apres le skieur
            this.DecorArr.Afficher(handle);

            this.Tete.Afficher(handle);
            this.MainGauche.Afficher(handle);

            this.JambeGauche.Afficher(handle);

            this.BatonGauche.AfficherCarre(handle);

            base.Afficher(handle);
            this.BatonDroite.AfficherCarre(handle);
            this.JambeDroite.Afficher(handle);
            this.MainDroite.Afficher(handle);
        }

        #region Modification contre le scintillement
        public new void Afficher(Graphics gr)
        {
            this.DecorArr.Afficher(gr);
            base.Afficher(gr);
            this.Tete.Afficher(gr);
            this.MainGauche.Afficher(gr);

            this.JambeGauche.Afficher(gr);

            this.BatonGauche.AfficherCarre(gr);

            base.Afficher(gr);
            this.JambeDroite.Afficher(gr);
            this.BatonDroite.AfficherCarre(gr);
            this.MainDroite.Afficher(gr);

        }
        #endregion

        #endregion




    }
}