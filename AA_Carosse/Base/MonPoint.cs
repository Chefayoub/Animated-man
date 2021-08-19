using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AA_Carosse
{
    class MonPoint
    {
        #region Données membres
        private int _x = 0;
        private int _y = 0;
        private bool _visible = true;
        private PictureBox _hebergeur;
        private Color _fond = Color.Red;
        private Color _crayon = Color.Black;
        #endregion

        #region Constructeurs
        public MonPoint()
        {
            this._hebergeur = null;
        }
        public MonPoint(PictureBox hebergeur)
        {
            this._hebergeur = hebergeur;
            this._fond = hebergeur.BackColor;
        }

        public MonPoint(PictureBox hebergeur, int xy) : this(hebergeur)
        { 
            X = Y = xy;
        }
        public MonPoint(PictureBox hebergeur, int x, int y) : this(hebergeur)
        {
            X = x;
            Y = y;
        }

        public MonPoint(PictureBox hebergeur, int xy, Color crayon) : this(hebergeur, xy)
        { Crayon = crayon; }
        public MonPoint(PictureBox hebergeur, int x, int y, Color crayon) : this(hebergeur, x, y)
        {
            Crayon = crayon;
        }
        #endregion

        #region Accesseurs
        public int X
        {
            get { return _x; }
            set
            {
                if (value < 0) { this._x = 0; }
                else if (value > this._hebergeur.Bounds.Size.Width)
                { this._x = this._hebergeur.Bounds.Size.Width; }
                else this._x = value;
            }
        }
        public int Y
        {
            get { return _y; }
            set
            {
                if (value < 0) { this._y = 0; }
                else if (value > this._hebergeur.Bounds.Size.Height)
                { this._y = this._hebergeur.Bounds.Size.Height; }
                else this._y = value;
            }
        }

        public bool Visible
        {
            get { return _visible; }
            set { _visible = value; }
        }
        public Color Fond
        {
            get { return _fond; }
            set
            {
                try { _fond = value; }
                catch { }
            }
        }
        public Color Crayon
        {
            get { return _crayon; }
            set
            {
                try { _crayon = value; }
                catch { }
            }
        }
        public PictureBox Hebergeur
        {
            get { return _hebergeur; }
            set { _hebergeur = value; }
        }


        #endregion

        #region Méthodes
        public void Bouger(int deplX, int deplY)
        {
            X += deplX;
            Y += deplY;
        }

        public virtual void Afficher(IntPtr handle)
        {
            if (this.Visible)
            {
                //MessageBox.Show(handle.ToString());
                Graphics gr = Graphics.FromHwnd(handle);
                gr.FillEllipse(new SolidBrush(Color.DarkGreen), this.X, this.Y, 50, 50);
                gr.DrawEllipse(new Pen(this._crayon, 1), this.X, this.Y, 10, 10);
            }
        }

        public virtual void Cacher(IntPtr handle)
        {
            if (this.Visible)
            {
                Graphics gr = Graphics.FromHwnd(handle);
                gr.FillEllipse(new SolidBrush(this._fond), this.X, this.Y, 10, 10);
                gr.DrawEllipse(new Pen(this._fond, 3), this.X, this.Y, 10, 10);
            }
        }
        public virtual void Cacher(Graphics gr)
        {
            if (this.Visible)
            {
                gr.FillEllipse(new SolidBrush(this._fond), this.X, this.Y, 10, 10);
                gr.DrawEllipse(new Pen(this._fond, 3), this.X, this.Y, 10, 10);
            }
        }


        //----------------------Methode pour les sans close curve------------------------------------
        public virtual void Afficher2(IntPtr handle)
        {
            if (this.Visible)
            {
                //MessageBox.Show(handle.ToString());
                Graphics gr = Graphics.FromHwnd(handle);
                gr.FillEllipse(new SolidBrush(Color.DarkGreen), this.X, this.Y, 10, 10);
                gr.DrawEllipse(new Pen(this._crayon, 1), this.X, this.Y, 10, 10);
            }
        }
        public virtual void Cacher2(IntPtr handle)
        {
            if (this.Visible)
            {
                Graphics gr = Graphics.FromHwnd(handle);
                gr.FillEllipse(new SolidBrush(this._fond), this.X, this.Y, 10, 10);
                gr.DrawEllipse(new Pen(this._fond, 3), this.X, this.Y, 10, 10);
            }
        }
        #endregion

    }
}
