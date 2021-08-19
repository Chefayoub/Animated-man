using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace AA_Carosse
{
    class MonRectangle : MonPoint
    {
        #region Données membres
        private Color _pot = Color.DarkSlateGray;
        private bool _remplir = true;
        private int _longueur = 1;
        private int _hauteur = 1;
        #endregion

        #region Constructeurs

        public MonRectangle(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg)
        {
            Longueur = longueur;
            Hauteur = hauteur;
        }
        //Pour les trangles Montagnes et neiges
        public MonRectangle(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, Color pot) : base(hebergeur, xsg, ysg)
        {
            Longueur = longueur;
            Hauteur = hauteur;
            Pot = pot;
        }
        public MonRectangle(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, Color crayon, Color pot) : base(hebergeur, xsg, ysg, crayon)
        {
            Longueur = longueur;
            Hauteur = hauteur;
            Pot = pot;
        }
        #endregion

        #region Accesseurs
        public int Longueur
        {
            get { return this._longueur; }
            set
            {
                if (value <= 0) this._longueur = 1;
                else this._longueur = value;
            }
        }
        public int Hauteur
        {
            get { return this._hauteur; }
            set
            {
                if (value <= 0) this._hauteur = 1;
                else this._hauteur = value;
            }
        }
        public bool Remplir
        {
            get { return this._remplir; }
            set
            {
                this._remplir = value;
            }
        }
        public Color Pot
        {
            get { return this._pot; }
            set
            {
                try { this._pot = value; }
                catch { }
            }
        }

        // modification accesseur, je rajoute les points sans les mouvements pour la classe rectangle
        public Point CSG
        {
            get { return new Point(X, Y); }
        }
        public Point CIG
        {
            get { return new Point((int)X, (int)(Y + Hauteur)); }
        }
        public Point CSD
        {
            get { return new Point((int)(Longueur + X), (int)Y); }
        }
        public Point CID
        {
            get { return new Point((int)(X + Longueur), (int)(Y + Hauteur)); }
        }

        //Close corve
        public Point MS
        {
            get { return new Point((int)((CSD.X + CSG.X) / 2), (int)((CSG.Y + CSD.Y) / 2)); }
        }
        public Point MI
        {
            get { return new Point((int)((CID.X + CIG.X) / 2), (int)((CID.Y + CIG.Y) / 2)); }
        }
        #endregion

        #region Méthodes

        #region Rectangle normal
        //Rectangle normal-------------------------------------------------------------------
        public override void Afficher2(IntPtr handle)
        {
            if (this.Visible)
            {
                Graphics gr = Graphics.FromHwnd(handle);
                if (this.Remplir)
                {
                    gr.FillRectangle(new SolidBrush(this.Pot), this.X, this.Y, this.Longueur, this.Hauteur);
                }
                gr.DrawRectangle(new Pen(this.Crayon), this.X, this.Y, this.Longueur, this.Hauteur);

            }
        }
        #region Modification contre le scintillement
        public virtual void Afficher2(Graphics gr)
        {
            if (this.Visible)
            {
                if (this.Remplir) gr.FillRectangle(new SolidBrush(this.Pot), this.X, this.Y, this.Longueur, this.Hauteur);
                gr.DrawRectangle(new Pen(this.Crayon), this.X, this.Y, this.Longueur, this.Hauteur);
            }
        }
        #endregion
        public override void Cacher2(IntPtr handle)
        {
            Graphics gr = Graphics.FromHwnd(handle);
            if (this.Remplir)
            {
                gr.FillRectangle(new SolidBrush(this.Fond), this.X, this.Y, this.Longueur, this.Hauteur);
            }
            gr.DrawRectangle(new Pen(this.Fond), this.X, this.Y, this.Longueur, this.Hauteur);
        }
        //---------------------------------------------------------------------------------
        #endregion



        //------------Deuxieme affiche pour tous ce qui est Close Curve---------------------------------------------------------------------
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

        #region Modification pour le scintillement 
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

        #region DECOR LES OBSTACLES
        //--Decor obstacle avec polygon pour le carré
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

        #region Modification pour le scintillement des obstacles
        public void AfficherCarre(Graphics gr)
        {
            Point[] pt = new Point[4];
            pt[0] = CSG;
            pt[1] = CSD;
            pt[2] = CID;
            pt[3] = CIG;
            //Alpha += 1;
            if (this.Visible)
            {
                if (this.Remplir)
                {
                    gr.FillPolygon(new SolidBrush(this.Pot), pt);
                    gr.DrawPolygon(new Pen(this.Crayon), pt);
                }
            }
        }
        #endregion

        //--Decor obstacle
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

        #region DECOR MONTAGNE
        //-----Decor Montagne : j'ai fait que trois points pour aficher un triangles
        public void AfficherTriangle(IntPtr handle)
        {
            if (this.Visible)
            {
                Graphics gr = Graphics.FromHwnd(handle);
                Point[] pt = new Point[3];

                pt[1] = CID;
                pt[2] = CIG;
                pt[0] = MS;

                if (this.Remplir)
                {
                    gr.FillPolygon(new SolidBrush(this.Pot), pt);
                    gr.DrawPolygon(new Pen(this.Crayon), pt);
                }
            }
        }

        #region Modification pour le scintillement triangle
        public void AfficherTriangle(Graphics gr)
        {
            Point[] pt = new Point[3];

            pt[1] = CID;
            pt[2] = CIG;
            pt[0] = MS;


            if (this.Visible)
            {
                if (this.Remplir)
                {
                    gr.FillPolygon(new SolidBrush(this.Pot), pt);
                    gr.DrawPolygon(new Pen(this.Crayon), pt);
                }
            }
        }
        #endregion

        //-----Decor Montagne
        public void CacherTriangle(IntPtr handle)
        {
            Graphics gr = Graphics.FromHwnd(handle);
            Point[] pt = new Point[3];

            pt[1] = CID;
            pt[2] = CIG;
            pt[0] = MS;

            if (this.Remplir)
            {
                gr.FillPolygon(new SolidBrush(this.Fond), pt);
                gr.DrawPolygon(new Pen(this.Fond), pt);
            }
        }
        public void CacherTriangle(Graphics gr)
        {
            Point[] pt = new Point[3];

            pt[1] = CID;
            pt[2] = CIG;
            pt[0] = MS;

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
