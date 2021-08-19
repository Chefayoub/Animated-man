using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

using System.IO;

namespace AA_Carosse
{
    public partial class EcranAccueil : Form
    {
        private MonPoint pointTest;
        private MonCercle cercleTest;
        private MonRectangle rectangleTest;
        private MonCarosse carosseTest;
        private MonBonhomme bonhommeTest;
        private MonRectangleMovable rectMovtest;
        private Bras brasTest;
        private Jambe jambeTest;
        private MonPerso perso;
        #region Modification contre le scintillement
        private BufferedGraphics bufferG = null;
        private Graphics g;
        #endregion
        private JambeCloseCurve jambeCCTest;
        private CuisseCloseCurve cuisseTest;
        private BrasCloseCurve brasCCTest;
        private JambeSkieurCloseCurve jambeSkieurTest;
        private Skieur skieurTest;
        private Decor decorTest;

        private SoundPlayer son1;
        private SoundPlayer son2;





        public EcranAccueil()
        {
            InitializeComponent();
            #region Modification contre le scintillement
            // Modification contre le scintillement - Creation d'une mémoire tampon graphique
            bufferG = BufferedGraphicsManager.Current.Allocate(TV.CreateGraphics(), TV.DisplayRectangle);
            g = bufferG.Graphics;
            #endregion

            //Pour les Son
            son1 = new SoundPlayer("Bruit_de_Fond40.wav");
            son2 = new SoundPlayer("Bravos_Fin.wav");

            // Code permettant d'utiliser le double buffering
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }



        #region POINT
        //////////////// ICI IL Y A LE CODE DU //////////////////////////////////////////////////////////////////////
        //////////////////////// POINT ////////////////////////////////////////////////////////////////////
        private void btnCreationPoint_Click_1(object sender, EventArgs e)
        {
            this.pointTest = new MonPoint(this.TV, 10, 20, Color.Black);
            this.pointTest.Afficher(this.TV.Handle);
            btnDeplacerPoint.Enabled = true;
            btnCacherPoint.Enabled = true;
            Text = Text + "- Création Point " + this.TV.Handle.ToString();
        }

        private void btnDeplacerPoint_Click_1(object sender, EventArgs e)
        {
            this.pointTest.Bouger(20, 10);
            TV.Refresh();
            this.pointTest.Afficher(this.TV.Handle);
        }

        private void btnCacherPoint_Click_1(object sender, EventArgs e)
        {
            this.pointTest.Cacher(this.TV.Handle);
        }
        #endregion

        #region CERCLE
        /////////////////// ICI IL Y A LE CODE DU /////////////////////////////////////////////////////////////////////////
        /////////////////////////// CERCLE /////////////////////////////////////////////////////////////////
        private void btnCreationCercle_Click_1(object sender, EventArgs e)
        {
            this.cercleTest = new MonCercle(this.TV, 50, 285, 50, Color.Black, Color.GreenYellow);
            this.cercleTest.Afficher(this.TV.Handle);
            Text = Text + " - Creation Cercle : " + this.TV.Handle.ToString();
            btnDeplacerCercle.Enabled = true;
            btnTickCercle.Enabled = true;
            btnTickStopCercle.Enabled = true;
            btnCacherCercle.Enabled = true;
        }

        private void btnDeplacerCercle_Click_1(object sender, EventArgs e)
        {
            this.cercleTest.Cacher(this.TV.Handle);
            this.cercleTest.Bouger(20, 0);
            TV.Refresh();
            this.cercleTest.Afficher(this.TV.Handle);
        }

        private void btnCacherCercle_Click_1(object sender, EventArgs e)
        {
            this.cercleTest.Cacher(this.TV.Handle);
            TV.Refresh();
        }

        private void btnTickCercle_Click_1(object sender, EventArgs e)
        {
            this.TimerImage.Start();
        }

        private void btnTickStopCercle_Click_1(object sender, EventArgs e)
        {
            this.TimerImage.Stop();
        }

        private void timerImage_Tick(object sender, EventArgs e)
        {
            if (this.cercleTest.X + this.cercleTest.Y >= this.TV.Width)
            {
                this.TimerImage.Stop();
                this.btnStopTickCarosse.Enabled = false;
            }
            else
            {
                //g.Clear(TV.BackColor);
                //this.carosseTest.Cacher(this.TV.Handle);
                //this.carosseTest.Bouger(7, 0);
                //this.carosseTest.Afficher(this.TV.Handle);
                #region Modification contre le scintillement
                g.Clear(TV.BackColor);
                this.cercleTest.Afficher(g);
                this.cercleTest.Bouger(7, 0);
                bufferG.Render();
                #endregion
            }

        }
        #endregion

        #region RECTANGLE
        ////////////////// ICI IL Y A LE CODE DU /////////////////////////////////////////////////////////////////////////
        ////////////////////////// RECTANGLE //////////////////////////////////////////////////////////////////
        private void btnCreationRectangle_Click_1(object sender, EventArgs e)
        {
            this.rectangleTest = new MonRectangle(this.TV, 300, 150, 400, 50, Color.Black, Color.LightBlue);
            this.rectangleTest.Afficher2(this.TV.Handle);
            btnDeplacerRectangle.Enabled = true;
            btnCacherRectangle.Enabled = true;
            btnTickRectangle.Enabled = true;
            btnStopTrickRectangle.Enabled = true;
        }

        private void btnDeplacerRectangle_Click_1(object sender, EventArgs e)
        {
            this.rectangleTest.Cacher(this.TV.Handle);
            this.rectangleTest.Bouger(10, 0);
            TV.Refresh();
            this.rectangleTest.Afficher(this.TV.Handle);
        }

        private void btnCacherRectangle_Click_1(object sender, EventArgs e)
        {
            this.rectangleTest.Cacher(this.TV.Handle);
            TV.Refresh();
        }

        private void btnTickRectangle_Click_1(object sender, EventArgs e)
        {
            this.TimerRectangle.Start();
        }

        private void btnStopTrickRectangle_Click_1(object sender, EventArgs e)
        {
            this.TimerRectangle.Stop();
        }
        private void timerRectangle_Tick(object sender, EventArgs e)
        {

            if (this.rectangleTest.X + this.rectangleTest.Longueur >= this.TV.Width)
            {
                this.TimerImage.Stop();
                this.btnStopTickCarosse.Enabled = false;
            }
            else
            {
                //g.Clear(TV.BackColor);
                //this.rectangleTest.Cacher(this.TV.Handle);
                //this.rectangleTest.Bouger(10, 0);
                //this.rectangleTest.Afficher(this.TV.Handle);
                #region Modification contre le scintillement
                g.Clear(TV.BackColor);
                this.rectangleTest.Afficher(g);
                this.rectangleTest.Bouger(10, 0);
                bufferG.Render();
                #endregion
            }
            /*
            this.rectangleTest.Cacher(this.TV.Handle);
            this.rectangleTest.Bouger(20, 0);
            TV.Refresh();
            this.rectangleTest.Afficher(this.TV.Handle);*/
        }
        #endregion

        #region CAROSSE
        ///////////////////// ICI IL Y A LE CODE DU ///////////////////////////////////////////////////////////////////////
        //////////////////////////// CAROSSE ////////////////////////////////////////////////////////////////
        private void btnCreationCarosse_Click_1(object sender, EventArgs e)
        {
            this.carosseTest = new MonCarosse(this.TV, 15, 200, 150, 60); 
            this.carosseTest.Afficher(this.TV.Handle);

            btnBougerCarosse.Enabled = true;
            btnCacherCarosse.Enabled = true;
            btnStopTickCarosse.Enabled = true;
            btnTickCarosse.Enabled = true;
        }

        private void btnBougerCarosse_Click_1(object sender, EventArgs e)
        {
            this.carosseTest.Cacher(this.TV.Handle);
            this.carosseTest.Bouger(10, 0);
            TV.Refresh();
            this.carosseTest.Afficher(this.TV.Handle);
        }

        private void btnTickCarosse_Click_1(object sender, EventArgs e)
        {
            this.TimerCarosse.Start();
        }

        private void btnStopTickCarosse_Click_1(object sender, EventArgs e)
        {
            this.TimerCarosse.Stop();
        }

        private void btnCacherCarosse_Click_1(object sender, EventArgs e)
        {
            this.carosseTest.Cacher(this.TV.Handle);
            TV.Refresh();
        }
        private void timerCarosse_Tick_1(object sender, EventArgs e)
        {
            
            if (this.carosseTest.X + this.carosseTest.Longueur >= this.TV.Width)
            {
                this.TimerImage.Stop();
                this.btnStopTickCarosse.Enabled = false;
            }
            else
            {

                #region Modification contre le scintillement
                g.Clear(TV.BackColor);
                this.carosseTest.Afficher(g);
                this.carosseTest.Bouger(7, 0);
                bufferG.Render();
                #endregion
                /*
                this.carosseTest.Cacher(this.TV.Handle);
                this.carosseTest.Bouger(7, 0);
                TV.Refresh();
                this.carosseTest.Afficher(this.TV.Handle);*/
            }

        }
        #endregion

        #region BONHOMME
        ////////////////////// ICI IL Y A LE CODE DU //////////////////////////////////////////////////////////////////////
        /////////////////////////////// BONHOMME /////////////////////////////////////////////////////////////
        private void btnCreationBonhomme_Click_1(object sender, EventArgs e)
        {
            this.bonhommeTest = new MonBonhomme(this.TV, 50, 50, 35, 80);
            this.bonhommeTest.Afficher2(this.TV.Handle);
            this.btnCacherBonhomme.Enabled = true;
            this.btnDeplacerBonhomme.Enabled = true;
            this.btnTickBonhomme.Enabled = true;
            this.btnStopTickBonhomme.Enabled = true;
        }

        private void btnDeplacerBonhomme_Click_1(object sender, EventArgs e)
        {
            this.bonhommeTest.Cacher2(this.TV.Handle);
            this.bonhommeTest.Bouger(20, 0);
            TV.Refresh();
            this.bonhommeTest.Afficher2(this.TV.Handle);
        }

        private void btnTickBonhomme_Click_1(object sender, EventArgs e)
        {
            this.TimerBonhomme.Start();
        }

        private void btnStopTickBonhomme_Click_1(object sender, EventArgs e)
        {
            this.TimerBonhomme.Stop();
        }

        private void btnCacherBonhomme_Click_1(object sender, EventArgs e)
        {
            this.bonhommeTest.Cacher(this.TV.Handle);
            TV.Refresh();
        }
        private void timerBonhomme_Tick(object sender, EventArgs e)
        {
            
            if (this.bonhommeTest.X + this.bonhommeTest.Hauteur >= this.TV.Width)
            {
                this.TimerImage.Stop();
                this.btnStopTickCarosse.Enabled = false;
            }
            else
            {

                /*#region Modification contre le scintillement
                g.Clear(TV.BackColor);
                this.bonhommeTest.Afficher(g);
                this.bonhommeTest.Bouger(7, 0);
                bufferG.Render();
                #endregion*/
                
                this.bonhommeTest.Cacher2(this.TV.Handle);
                this.bonhommeTest.Bouger(10, 0);
                TV.Refresh();
                this.bonhommeTest.Afficher2(this.TV.Handle);
            }

        }
        #endregion

        #region RESTE
        ///////////////////////////// ICI IL Y A LE CODE ///////////////////////////////////////////////////////////////
        ///////////////////////////////////// RESTE ///////////////////////////////////////////////////////
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            Graphics gr = Graphics.FromHwnd(this.TV.Handle);
            gr.FillRectangle(new SolidBrush(this.TV.BackColor), 0, 0, this.TV.Bounds.Width, this.TV.Bounds.Height);
        }

        private void EcranAccueil_Load(object sender, EventArgs e)
        {

        }

        private void TV_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region RECTANGLE QUI BOUGE
        ///////////////////////////// ICI IL Y A LE CODE DU ///////////////////////////////////////////////////////////////
        ///////////////////////////////////// RECTANGLE QUI BOUGE ///////////////////////////////////////////////////////
        private void btnAfficher_Click(object sender, EventArgs e)
        {
            this.rectMovtest = new MonRectangleMovable(this.TV, 150, 100, 25, 45); 
            //g.Clear(TV.BackColor);
            this.rectMovtest.Afficher(this.TV.Handle);
            //Buffer.Render();
        }

        private void btnTournerRectangle_Click(object sender, EventArgs e)
        {
            //int a = int.Parse(TextBox);
            this.rectMovtest.Bouger(0, 0, Math.PI / 12);
            this.rectMovtest.Bouger(1, 0);
            TV.Refresh();
            this.rectMovtest.Afficher(this.TV.Handle);
            //BufferedGraphics.Render();

        }
        #endregion

        #region BRAS QUI BOUGE
        ///////////////////////////// ICI IL Y A LE CODE DU ///////////////////////////////////////////////////////////////
        ///////////////////////////////////// BRAS QUI BOUGE ///////////////////////////////////////////////////////
        private void btnAfficherBras_Click(object sender, EventArgs e)
        {
            this.brasTest = new Bras(this.TV, 150, 50, 15, 50, Color.Black, Color.DarkGray, 0f);
            this.brasTest.Afficher2(this.TV.Handle);
            btnTournerBras.Enabled = true;
        }

        private void btnTournerBras_Click(object sender, EventArgs e)
        {
            this.brasTest.Bouger(0, 0, Math.PI / 6);
            TV.Refresh();
            this.brasTest.Afficher2(this.TV.Handle);
            //Thread.Sleep(1000);
            //this.brastest.Bouger(0, 0, -Math.PI / 6);
            //TV.Refresh();
            //this.brastest.Afficher(this.TV.Handle);
        }
        #endregion

        #region JAMBE QUI BOUGE
        ///////////////////////////// ICI IL Y A LE CODE DU ///////////////////////////////////////////////////////////////
        ///////////////////////////////////// JAMBE QUI BOUGE ///////////////////////////////////////////////////////
        private void btnAfficherJambe_Click(object sender, EventArgs e)
        {
            this.jambeTest = new Jambe(this.TV, 150, 50, 17, 60, Color.Black, Color.DarkGray, 0f);
            this.jambeTest.Afficher2(this.TV.Handle);
            btnTournerJambe.Enabled = true;
        }

        private void btnTournerJambe_Click(object sender, EventArgs e)
        {
            this.jambeTest.Bouger(0, 0, Math.PI / 6);
            TV.Refresh();
            this.jambeTest.Afficher2(this.TV.Handle);
            //Thread.Sleep(500);
            //this.jambeTest.Bouger(0, 0, -Math.PI / 6);
            //TV.Refresh();
            //this.jambeTest.Afficher(this.TV.Handle);
        }
        #endregion

        #region PERSO QUI BOUGE
        ///////////////////////////// ICI IL Y A LE CODE DU ///////////////////////////////////////////////////////////////
        ///////////////////////////////////// PERSO QUI BOUGE ///////////////////////////////////////////////////////
        private void btnAfficherPerso_Click(object sender, EventArgs e)
        {
            this.perso = new MonPerso(this.TV, 50, 100, 30, 80, 0);
            this.perso.Afficher2(this.TV.Handle);
            //btnBougerPerso.Enabled = true;
            //btnMarcherPerso.Enabled = true;
            //btnStopPerso.Enabled = true;
        }


        private void btnUnPasPerso_Click(object sender, EventArgs e)
        {
            this.perso.Bouger(20, 0, Math.PI / 6);
            
            TV.Refresh();
            this.perso.Afficher2(this.TV.Handle);
            Thread.Sleep(500);
            this.perso.Bouger(20, 0, -Math.PI / 6);
            TV.Refresh();
            this.perso.Afficher2(this.TV.Handle);
        }

        private void TimerPerso_Tick(object sender, EventArgs e)
        {
            this.perso.Bouger(20, 0, Math.PI / 6);
            TV.Refresh();
            this.perso.Afficher2(this.TV.Handle);
            Thread.Sleep(500);

            this.perso.Bouger(20, 0, - Math.PI / 6);
            TV.Refresh();
            this.perso.Afficher2(this.TV.Handle);
            Thread.Sleep(200);
        }

        private void btnMarcherPerso_Click(object sender, EventArgs e)
        {
            TimerPerso.Start();
        }

        private void btnPausePerso_Click(object sender, EventArgs e)
        {
            TimerPerso.Stop();
        }

        #endregion

        #region BRAS, CUISSE ET JAMBE  Close Curve
        ///////////////////////////// ICI IL Y A LE CODE DU ///////////////////////////////////////////////////////////////
        ///////////////////////////////////// Jambe/Bras CloseCurve  ///////////////////////////////////////////////////////

        //---------------Bras----------------------------------------------
        private void btnAfficherBrasCloseCurve_Click(object sender, EventArgs e)
        {
            this.brasCCTest = new BrasCloseCurve(this.TV, 150, 50, 17, 60);
            //TV.Refresh();
            this.brasCCTest.Afficher(this.TV.Handle);
            //btnTournerJambe.Enabled = true;
        }
        private void btnTournerBrasCloseCurve_Click(object sender, EventArgs e)
        {
            this.brasCCTest.Bouger(0, 0, Math.PI / 6, 0);
            TV.Refresh();
            this.brasCCTest.Afficher(this.TV.Handle);
            //Thread.Sleep(500);
            //this.jambeTest.Bouger(0, 0, -Math.PI / 6);
            //TV.Refresh();
            //this.jambeTest.Afficher(this.TV.Handle);
        }
        //---------------Cuisse----------------------------------------------
        private void btnAfficherCuisseCloseCurve_Click(object sender, EventArgs e)
        {
            this.cuisseTest = new CuisseCloseCurve(this.TV, 150, 50, 17, 60);
            //TV.Refresh();
            this.cuisseTest.Afficher(this.TV.Handle);
            //btnTournerJambe.Enabled = true;
        }
        private void btnTournerCuisseCloseCurve_Click(object sender, EventArgs e)
        {
            this.cuisseTest.BougerCuisse(0, 0, Math.PI / 6);
            TV.Refresh();
            this.cuisseTest.Afficher(this.TV.Handle);
            //Thread.Sleep(500);
            //this.jambeTest.Bouger(0, 0, -Math.PI / 6);
            //TV.Refresh();
            //this.jambeTest.Afficher(this.TV.Handle);
        }
        //---------------Jambe----------------------------------------------
        private void btnAfficherJambeCloseCurve_Click(object sender, EventArgs e)
        {
            this.jambeCCTest = new JambeCloseCurve(this.TV, 150, 50, 17, 60);
            //TV.Refresh();
            this.jambeCCTest.Afficher(this.TV.Handle);
            //btnTournerJambeCloseCurve_Click.Enabled = true;
        }
        private void btnTournerJambeCloseCurve_Click(object sender, EventArgs e)
        {

            this.jambeCCTest.Bouger(0, 0, Math.PI / 6, 0, 0);
            

            TV.Refresh();
            this.jambeCCTest.Afficher(this.TV.Handle);
            //Thread.Sleep(500);
            //this.jambeTest.Bouger(0, 0, -Math.PI / 6);
            //TV.Refresh();
            //this.jambeTest.Afficher(this.TV.Handle);
        }
        #endregion

        #region SKIEUR ET JAMBE  DU SKIEUR
        ///////////////////////////// ICI IL Y A LE CODE DU ///////////////////////////////////////////////////////////////
        ///////////////////////////////////// SKIEUR QUI BOUGE ///////////////////////////////////////////////////////
        
        //Skieur
        private void btnAfficheSkieur_Click(object sender, EventArgs e)
        {
            this.skieurTest = new Skieur(this.TV, 80, 200, 25, 60, 1350, 260);   
            this.skieurTest.Afficher(this.TV.Handle);
        }

        private void TimerSkieur_Tick(object sender, EventArgs e)
        {
            
            g.Clear(TV.BackColor);
            //this.skieurTest.Cacher(this.TV.Handle);
            this.skieurTest.Deplacement(this.TV.Handle);
            //this.skieurTest.Afficher(this.TV.Handle);
            this.skieurTest.Afficher(g);
            bufferG.Render();
            TimerSkieur.Stop();
        }

        private void btnBougerSkieur_Click(object sender, EventArgs e)
        {
            TimerSkieur.Start();

        }

        private void btnPauseSkieur_Click(object sender, EventArgs e)
        {
            TimerSkieur.Stop();
        }






        //Jambe du skieur
        private void btnAfficherJambeSkieurCloseCurve_Click(object sender, EventArgs e)
        {
            this.jambeSkieurTest = new JambeSkieurCloseCurve(this.TV, 150, 50, 17, 60);
            //TV.Refresh();
            this.jambeSkieurTest.Afficher(this.TV.Handle);
            //btnTournerJambe.Enabled = true;
        }
        private void btnTournerJambeSkieurCloseCurve_Click(object sender, EventArgs e)
        {
            this.jambeSkieurTest.Bouger(0, 0, Math.PI / 6, 0, 1);
            TV.Refresh();
            this.jambeSkieurTest.Afficher(this.TV.Handle);
            //Thread.Sleep(500);
            //this.jambeTest.Bouger(0, 0, -Math.PI / 6);
            //TV.Refresh();
            //this.jambeTest.Afficher(this.TV.Handle);
        }

        #endregion

        #region DECOR
        ///////////////////////////// ICI IL Y A LE CODE DU ///////////////////////////////////////////////////////////////
        ///////////////////////////////////// DECOR QUI BOUGE ///////////////////////////////////////////////////////
        private void btnAfficherDecor_Click(object sender, EventArgs e)
        {
            this.decorTest = new Decor(this.TV, 0, 256, 1350, 100, Color.White, Color.White);
            this.decorTest.Afficher(this.TV.Handle);
        }
        private void TimerDecor_Tick(object sender, EventArgs e)
        {

            g.Clear(TV.BackColor);
            this.decorTest.BougerArr(-1, 0);
            this.decorTest.BougerObstacle1(-6, 0);
            this.decorTest.BougerObstacle2(-4, 0);
            this.decorTest.BougerObstacle3(-2, 0);
            //TV.Refresh();
            this.decorTest.Afficher(g);
            bufferG.Render();
        }
        private void btnBougerDecor_Click(object sender, EventArgs e)
        {
            TimerDecor.Start();

        }
        private void btnPauseDecor_Click(object sender, EventArgs e)
        {
            TimerDecor.Stop();
        }









        #endregion


        #region Animation avec DU SON

        //Ici je rassemble un peux de la classe skieur et decor
        //ET j'utilise du son pour mon animation
        private void btnTestSon_Click(object sender, EventArgs e) 
        
        {
            this.skieurTest = new Skieur(this.TV, 80, 200, 25, 60, 1350, 260);
            this.skieurTest.Afficher(this.TV.Handle);

            TimerSkieur.Start();

            son1.Play();//Celui-ci ce declanche au debut jusqu'à lignes d'arrivé
            g.Clear(TV.BackColor);
            //this.skieurTest.Cacher(this.TV.Handle);
            this.skieurTest.Deplacement(this.TV.Handle);
            //this.skieurTest.Afficher(this.TV.Handle);
            this.skieurTest.Afficher(g);
            bufferG.Render();
            son2.Play();//Une fois la ligne d'arrivé passé
            TimerSkieur.Stop();
            
        }
        #endregion
    }
}
