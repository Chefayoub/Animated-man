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
    class MonRectangleMovable : MonPoint
    {
        #region Données membres
        private Color _Pot = Color.Orange;
        private bool _Remplir = true;
        private int _hauteur = 1;
        private int _longueur = 1;
        private double _angle = 0;
        #endregion

        #region Constructeurs
        public MonRectangleMovable(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg)
        {
            Longueur = longueur;
            Hauteur = hauteur;
        }

        #region Constructeur sans close curve
        //-----Constructeur pour les sans Close Curve---------------------------------------------------
        public MonRectangleMovable(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, double angle) : base(hebergeur, xsg, ysg)
        {
            _longueur = longueur;
            _hauteur = hauteur;
            _angle = angle;
        }
        public MonRectangleMovable(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, Color crayon, Color pot, double angle) : base(hebergeur, xsg, ysg, crayon)
        {
            _longueur = longueur;
            _hauteur = hauteur;
            _Pot = pot;
            _angle = angle;
        }
        //----------------------------------------------------------------------------------------------
        #endregion

        public MonRectangleMovable(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, Color pot) : base(hebergeur, xsg, ysg)
        {
            Longueur = longueur;
            Hauteur = hauteur;
            Pot = pot;
        }

        public MonRectangleMovable(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, Color crayon, Color pot) : base(hebergeur, xsg, ysg)
        {
            Longueur = longueur;
            Hauteur = hauteur;
            Pot = pot;
        }
        #endregion

        #region Accesseurs
        public Color Pot
        {
            get { return _Pot; }
            set
            {
                try { _Pot = value; }
                catch (Exception) { }
            }
        }
        public double Angle
        {
            get { return _angle; }
            set { _angle = value; }
        }
        public bool Remplir
        {
            get { return _Remplir; }
            set { _Remplir = value; }
        }

        public int Longueur
        {
            get { return _longueur; }
            set
            {
                if (value < 0) { _longueur = 1; }
                else { _longueur = value; }
            }
        }

        public int Hauteur
        {
            get { return _hauteur; }
            set
            {
                if (value < 0) { _hauteur = 1; }
                else { _hauteur = value; }
            }
        }


        // Accesseur pour les 4 points du rectangle
        public Point CSG //Coint superieur gauche
        {
            get { return new Point(X, Y); }
        }
        public Point CIG //Coint superieur droite
        {
            get { return new Point((int)(X + Hauteur * Cos(3 * PI / 2 + Angle)), (int)(Y - Hauteur * Sin(3 * PI / 2 + Angle))); }   
        }
        public Point CSD //Coint inferieur gauche
        {
            get { return new Point((int)(X + Longueur * Cos(Angle)), (int)(Y - Longueur * Sin(Angle))); }
        }
        public Point CID //Coint inferieur gauche
        {
            get { return new Point((int)(X + Longueur * Cos(Angle) + Hauteur * Cos((3 * PI / 2) + Angle)), (int)(Y - Longueur * Sin(Angle) - Hauteur * Sin(3 * PI / 2 + Angle))); }
        }


        //Accesseur pour centrer les bras et les jambes (juste 2)
        public Point MS //Milieu superieur
        {
            get { return new Point((int)((CSD.X + CSG.X) / 2), (int)((CSG.Y + CSD.Y) / 2)); }
        }
        public Point MI //Milieu inferieur
        {
            get { return new Point((int)((CID.X + CIG.X) / 2), (int)((CID.Y + CIG.Y) / 2)); }
        }
        #endregion

        #region Méthodes

        #region Méthodes sans close curve
        public override void Afficher2(IntPtr handle)
        {
            if (this.Visible)
            {
                Point[] p = new Point[4];
                p[0] = CSG;
                p[1] = CSD;
                p[2] = CID;
                p[3] = CIG;


                Graphics gr = Graphics.FromHwnd(handle);
                if (this.Remplir)
                {
                    gr.FillPolygon(new SolidBrush(this.Pot), p);
                    gr.DrawPolygon(new Pen(this.Crayon), p);
                }

            }
            //base.Afficher(handle);
        }
        #region Modification contre scentillement
        public virtual void Afficher2(Graphics gr)
        {
            Point[] pt = new Point[4];
            pt[0] = CSG;
            pt[1] = CSD;
            pt[2] = CID;
            pt[3] = CIG;
            if (this.Visible)
            {
                if (this.Remplir)
                {
                    gr.FillClosedCurve(new SolidBrush(this.Pot), pt);
                    gr.DrawClosedCurve(new Pen(this.Crayon), pt);
                }
            }
        }
        #endregion


        public override void Cacher2(IntPtr handle)
        {
            Graphics gr = Graphics.FromHwnd(handle);
            Point[] pt = new Point[4];
            pt[0] = CSG;
            pt[1] = CSD;
            pt[2] = CID;
            pt[3] = CIG;
            //Angle += 1;
            if (this.Remplir)
            {
                gr.FillClosedCurve(new SolidBrush(this.Fond), pt);
                gr.DrawClosedCurve(new Pen(this.Fond), pt);
            }
        }
        #endregion

        /*
        public void Bouger(int deplX, int deplY, double deplA)
        {
            Bouger(deplX, deplY);
            Angle += deplA;
        }*/

        public virtual void Bouger(int deplX, int deplY, double diffangle)
        {
            base.Bouger(deplX, deplY);
            _angle += diffangle;
        }

        public override void Afficher(IntPtr handle)
        {
            if (this.Visible)
            {
                Graphics gr = Graphics.FromHwnd(handle);
                Point[] pt = new Point[4];
                pt[0] = CSG;
                pt[1] = CSD;
                pt[2] = CID;
                pt[3] = CIG;
                if (this.Remplir)
                {
                    gr.FillClosedCurve(new SolidBrush(this.Pot), pt);
                    gr.DrawClosedCurve(new Pen(this.Crayon), pt);
                }
            }
        }

        #region Modification contre scentillement
        public void Afficher(Graphics gr)
        {
            Point[] pt = new Point[4];
            pt[0] = CSG;
            pt[1] = CSD;
            pt[2] = CID;
            pt[3] = CIG;
            if (this.Visible)
            {
                if (this.Remplir)
                {
                    gr.FillClosedCurve(new SolidBrush(this.Pot), pt);
                    gr.DrawClosedCurve(new Pen(this.Crayon), pt);
                }
            }
        }
        #endregion


        public override void Cacher(IntPtr handle)
        {
            Graphics gr = Graphics.FromHwnd(handle);
            Point[] pt = new Point[4];
            pt[0] = CSG;
            pt[1] = CSD;
            pt[2] = CID;
            pt[3] = CIG;

            if (this.Remplir)
            {
                gr.FillClosedCurve(new SolidBrush(this.Fond), pt);
                gr.DrawClosedCurve(new Pen(this.Fond), pt);
            }
        }
        public override void Cacher(Graphics gr)
        {

            Point[] pt = new Point[4];
            pt[0] = CSG;
            pt[1] = CSD;
            pt[2] = CID;
            pt[3] = CIG;

            if (this.Remplir)
            {
                gr.FillClosedCurve(new SolidBrush(this.Fond), pt);
                gr.DrawClosedCurve(new Pen(this.Fond), pt);
            }
        }
        //---------------------------------------------------------------------------------


        #region Carré
        public void AfficherCarre(IntPtr handle)
        {
            if (this.Visible)
            {
                Graphics gr = Graphics.FromHwnd(handle);
                Point[] pt = new Point[4];
                pt[0] = CSG;
                pt[1] = CSD;
                pt[2] = CID;
                pt[3] = CIG;

                if (this.Remplir)
                {
                    gr.FillPolygon(new SolidBrush(this.Pot), pt);
                    gr.DrawPolygon(new Pen(this.Crayon), pt);
                }
            }
        }

        public void AfficherCarre(Graphics gr)
        {
            Point[] pt = new Point[4];
            pt[0] = CSG;
            pt[1] = CSD;
            pt[2] = CID;
            pt[3] = CIG;

            if (this.Visible)
            {
                if (this.Remplir)
                {
                    gr.FillPolygon(new SolidBrush(this.Pot), pt);
                    gr.DrawPolygon(new Pen(this.Crayon), pt);
                }
            }
        }


        public void CacherCarre(IntPtr handle)
        {
            Graphics gr = Graphics.FromHwnd(handle);
            Point[] pt = new Point[4];
            pt[0] = CSG;
            pt[1] = CSD;
            pt[2] = CID;
            pt[3] = CIG;

            if (this.Remplir)
            {
                gr.FillPolygon(new SolidBrush(this.Fond), pt);
                gr.DrawPolygon(new Pen(this.Fond), pt);
            }
        }
        public void CacherCarre(Graphics gr)
        {

            Point[] pt = new Point[4];
            pt[0] = CSG;
            pt[1] = CSD;
            pt[2] = CID;
            pt[3] = CIG;

            if (this.Remplir)
            {
                gr.FillPolygon(new SolidBrush(this.Fond), pt);
                gr.DrawPolygon(new Pen(this.Fond), pt);
            }
        }
        #endregion

        #endregion
    }
}
