namespace AA_Carosse
{
    partial class EcranAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranAccueil));
            this.TV = new System.Windows.Forms.PictureBox();
            this.btnCreationPoint = new System.Windows.Forms.Button();
            this.btnCreationCercle = new System.Windows.Forms.Button();
            this.btnCreationRectangle = new System.Windows.Forms.Button();
            this.btnCreationCarosse = new System.Windows.Forms.Button();
            this.btnCreationBonhomme = new System.Windows.Forms.Button();
            this.btnDeplacerPoint = new System.Windows.Forms.Button();
            this.btnCacherPoint = new System.Windows.Forms.Button();
            this.btnDeplacerCercle = new System.Windows.Forms.Button();
            this.btnTickCercle = new System.Windows.Forms.Button();
            this.btnTickStopCercle = new System.Windows.Forms.Button();
            this.btnCacherCercle = new System.Windows.Forms.Button();
            this.btnDeplacerRectangle = new System.Windows.Forms.Button();
            this.btnBougerCarosse = new System.Windows.Forms.Button();
            this.btnDeplacerBonhomme = new System.Windows.Forms.Button();
            this.btnTickRectangle = new System.Windows.Forms.Button();
            this.btnTickCarosse = new System.Windows.Forms.Button();
            this.btnTickBonhomme = new System.Windows.Forms.Button();
            this.btnStopTrickRectangle = new System.Windows.Forms.Button();
            this.btnStopTickCarosse = new System.Windows.Forms.Button();
            this.btnStopTickBonhomme = new System.Windows.Forms.Button();
            this.btnCacherRectangle = new System.Windows.Forms.Button();
            this.btnCacherCarosse = new System.Windows.Forms.Button();
            this.btnCacherBonhomme = new System.Windows.Forms.Button();
            this.TimerImage = new System.Windows.Forms.Timer(this.components);
            this.TimerRectangle = new System.Windows.Forms.Timer(this.components);
            this.TimerCarosse = new System.Windows.Forms.Timer(this.components);
            this.TimerBonhomme = new System.Windows.Forms.Timer(this.components);
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnAfficherBras = new System.Windows.Forms.Button();
            this.btnTournerRectangle = new System.Windows.Forms.Button();
            this.btnTournerBras = new System.Windows.Forms.Button();
            this.btnAfficherJambe = new System.Windows.Forms.Button();
            this.btnTournerJambe = new System.Windows.Forms.Button();
            this.btnUnPasPerso = new System.Windows.Forms.Button();
            this.btnMarcherPerso = new System.Windows.Forms.Button();
            this.btnPausePerso = new System.Windows.Forms.Button();
            this.btnAfficherPerso = new System.Windows.Forms.Button();
            this.TimerPerso = new System.Windows.Forms.Timer(this.components);
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnAfficheSkieur = new System.Windows.Forms.Button();
            this.btnAfficherJambeCloseCurve = new System.Windows.Forms.Button();
            this.btnTournerJambeCloseCurve = new System.Windows.Forms.Button();
            this.btnAfficherBrasCloseCurve = new System.Windows.Forms.Button();
            this.btnTournerBrasCloseCurve = new System.Windows.Forms.Button();
            this.btnAfficherCuisseCloseCurve = new System.Windows.Forms.Button();
            this.btnTournerCuisseCloseCurve = new System.Windows.Forms.Button();
            this.btnAfficherJambeSkieurCloseCurve = new System.Windows.Forms.Button();
            this.btnTournerJambeSkieurCloseCurve = new System.Windows.Forms.Button();
            this.btnAfficherDecor = new System.Windows.Forms.Button();
            this.btnBougerDecor = new System.Windows.Forms.Button();
            this.TimerDecor = new System.Windows.Forms.Timer(this.components);
            this.btnPauseDecor = new System.Windows.Forms.Button();
            this.btnBougerSkieur = new System.Windows.Forms.Button();
            this.TimerSkieur = new System.Windows.Forms.Timer(this.components);
            this.btnPauseSkieur = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTestSon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TV
            // 
            this.TV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TV.Cursor = System.Windows.Forms.Cursors.PanSouth;
            resources.ApplyResources(this.TV, "TV");
            this.TV.Name = "TV";
            this.TV.TabStop = false;
            this.TV.Click += new System.EventHandler(this.TV_Click);
            // 
            // btnCreationPoint
            // 
            this.btnCreationPoint.BackColor = System.Drawing.Color.Brown;
            this.btnCreationPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCreationPoint, "btnCreationPoint");
            this.btnCreationPoint.Name = "btnCreationPoint";
            this.btnCreationPoint.UseVisualStyleBackColor = false;
            this.btnCreationPoint.Click += new System.EventHandler(this.btnCreationPoint_Click_1);
            // 
            // btnCreationCercle
            // 
            this.btnCreationCercle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCreationCercle.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCreationCercle, "btnCreationCercle");
            this.btnCreationCercle.Name = "btnCreationCercle";
            this.btnCreationCercle.UseVisualStyleBackColor = false;
            this.btnCreationCercle.Click += new System.EventHandler(this.btnCreationCercle_Click_1);
            // 
            // btnCreationRectangle
            // 
            this.btnCreationRectangle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCreationRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCreationRectangle, "btnCreationRectangle");
            this.btnCreationRectangle.Name = "btnCreationRectangle";
            this.btnCreationRectangle.UseVisualStyleBackColor = false;
            this.btnCreationRectangle.Click += new System.EventHandler(this.btnCreationRectangle_Click_1);
            // 
            // btnCreationCarosse
            // 
            this.btnCreationCarosse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCreationCarosse.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCreationCarosse, "btnCreationCarosse");
            this.btnCreationCarosse.Name = "btnCreationCarosse";
            this.btnCreationCarosse.UseVisualStyleBackColor = false;
            this.btnCreationCarosse.Click += new System.EventHandler(this.btnCreationCarosse_Click_1);
            // 
            // btnCreationBonhomme
            // 
            this.btnCreationBonhomme.BackColor = System.Drawing.Color.Orchid;
            this.btnCreationBonhomme.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCreationBonhomme, "btnCreationBonhomme");
            this.btnCreationBonhomme.Name = "btnCreationBonhomme";
            this.btnCreationBonhomme.UseVisualStyleBackColor = false;
            this.btnCreationBonhomme.Click += new System.EventHandler(this.btnCreationBonhomme_Click_1);
            // 
            // btnDeplacerPoint
            // 
            this.btnDeplacerPoint.BackColor = System.Drawing.Color.Salmon;
            this.btnDeplacerPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnDeplacerPoint, "btnDeplacerPoint");
            this.btnDeplacerPoint.Name = "btnDeplacerPoint";
            this.btnDeplacerPoint.UseVisualStyleBackColor = false;
            this.btnDeplacerPoint.Click += new System.EventHandler(this.btnDeplacerPoint_Click_1);
            // 
            // btnCacherPoint
            // 
            this.btnCacherPoint.BackColor = System.Drawing.Color.Salmon;
            this.btnCacherPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCacherPoint, "btnCacherPoint");
            this.btnCacherPoint.Name = "btnCacherPoint";
            this.btnCacherPoint.UseVisualStyleBackColor = false;
            this.btnCacherPoint.Click += new System.EventHandler(this.btnCacherPoint_Click_1);
            // 
            // btnDeplacerCercle
            // 
            this.btnDeplacerCercle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDeplacerCercle.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnDeplacerCercle, "btnDeplacerCercle");
            this.btnDeplacerCercle.Name = "btnDeplacerCercle";
            this.btnDeplacerCercle.UseVisualStyleBackColor = false;
            this.btnDeplacerCercle.Click += new System.EventHandler(this.btnDeplacerCercle_Click_1);
            // 
            // btnTickCercle
            // 
            this.btnTickCercle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnTickCercle.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTickCercle, "btnTickCercle");
            this.btnTickCercle.Name = "btnTickCercle";
            this.btnTickCercle.UseVisualStyleBackColor = false;
            this.btnTickCercle.Click += new System.EventHandler(this.btnTickCercle_Click_1);
            // 
            // btnTickStopCercle
            // 
            this.btnTickStopCercle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnTickStopCercle.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTickStopCercle, "btnTickStopCercle");
            this.btnTickStopCercle.Name = "btnTickStopCercle";
            this.btnTickStopCercle.UseVisualStyleBackColor = false;
            this.btnTickStopCercle.Click += new System.EventHandler(this.btnTickStopCercle_Click_1);
            // 
            // btnCacherCercle
            // 
            this.btnCacherCercle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCacherCercle.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCacherCercle, "btnCacherCercle");
            this.btnCacherCercle.Name = "btnCacherCercle";
            this.btnCacherCercle.UseVisualStyleBackColor = false;
            this.btnCacherCercle.Click += new System.EventHandler(this.btnCacherCercle_Click_1);
            // 
            // btnDeplacerRectangle
            // 
            this.btnDeplacerRectangle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDeplacerRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnDeplacerRectangle, "btnDeplacerRectangle");
            this.btnDeplacerRectangle.Name = "btnDeplacerRectangle";
            this.btnDeplacerRectangle.UseVisualStyleBackColor = false;
            this.btnDeplacerRectangle.Click += new System.EventHandler(this.btnDeplacerRectangle_Click_1);
            // 
            // btnBougerCarosse
            // 
            this.btnBougerCarosse.BackColor = System.Drawing.Color.Wheat;
            this.btnBougerCarosse.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnBougerCarosse, "btnBougerCarosse");
            this.btnBougerCarosse.Name = "btnBougerCarosse";
            this.btnBougerCarosse.UseVisualStyleBackColor = false;
            this.btnBougerCarosse.Click += new System.EventHandler(this.btnBougerCarosse_Click_1);
            // 
            // btnDeplacerBonhomme
            // 
            this.btnDeplacerBonhomme.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeplacerBonhomme.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnDeplacerBonhomme, "btnDeplacerBonhomme");
            this.btnDeplacerBonhomme.Name = "btnDeplacerBonhomme";
            this.btnDeplacerBonhomme.UseVisualStyleBackColor = false;
            this.btnDeplacerBonhomme.Click += new System.EventHandler(this.btnDeplacerBonhomme_Click_1);
            // 
            // btnTickRectangle
            // 
            this.btnTickRectangle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTickRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTickRectangle, "btnTickRectangle");
            this.btnTickRectangle.Name = "btnTickRectangle";
            this.btnTickRectangle.UseVisualStyleBackColor = false;
            this.btnTickRectangle.Click += new System.EventHandler(this.btnTickRectangle_Click_1);
            // 
            // btnTickCarosse
            // 
            this.btnTickCarosse.BackColor = System.Drawing.Color.Wheat;
            this.btnTickCarosse.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTickCarosse, "btnTickCarosse");
            this.btnTickCarosse.Name = "btnTickCarosse";
            this.btnTickCarosse.UseVisualStyleBackColor = false;
            this.btnTickCarosse.Click += new System.EventHandler(this.btnTickCarosse_Click_1);
            // 
            // btnTickBonhomme
            // 
            this.btnTickBonhomme.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnTickBonhomme.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTickBonhomme, "btnTickBonhomme");
            this.btnTickBonhomme.Name = "btnTickBonhomme";
            this.btnTickBonhomme.UseVisualStyleBackColor = false;
            this.btnTickBonhomme.Click += new System.EventHandler(this.btnTickBonhomme_Click_1);
            // 
            // btnStopTrickRectangle
            // 
            this.btnStopTrickRectangle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnStopTrickRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnStopTrickRectangle, "btnStopTrickRectangle");
            this.btnStopTrickRectangle.Name = "btnStopTrickRectangle";
            this.btnStopTrickRectangle.UseVisualStyleBackColor = false;
            this.btnStopTrickRectangle.Click += new System.EventHandler(this.btnStopTrickRectangle_Click_1);
            // 
            // btnStopTickCarosse
            // 
            this.btnStopTickCarosse.BackColor = System.Drawing.Color.Wheat;
            this.btnStopTickCarosse.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnStopTickCarosse, "btnStopTickCarosse");
            this.btnStopTickCarosse.Name = "btnStopTickCarosse";
            this.btnStopTickCarosse.UseVisualStyleBackColor = false;
            this.btnStopTickCarosse.Click += new System.EventHandler(this.btnStopTickCarosse_Click_1);
            // 
            // btnStopTickBonhomme
            // 
            this.btnStopTickBonhomme.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnStopTickBonhomme.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnStopTickBonhomme, "btnStopTickBonhomme");
            this.btnStopTickBonhomme.Name = "btnStopTickBonhomme";
            this.btnStopTickBonhomme.UseVisualStyleBackColor = false;
            this.btnStopTickBonhomme.Click += new System.EventHandler(this.btnStopTickBonhomme_Click_1);
            // 
            // btnCacherRectangle
            // 
            this.btnCacherRectangle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCacherRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCacherRectangle, "btnCacherRectangle");
            this.btnCacherRectangle.Name = "btnCacherRectangle";
            this.btnCacherRectangle.UseVisualStyleBackColor = false;
            this.btnCacherRectangle.Click += new System.EventHandler(this.btnCacherRectangle_Click_1);
            // 
            // btnCacherCarosse
            // 
            this.btnCacherCarosse.BackColor = System.Drawing.Color.Wheat;
            this.btnCacherCarosse.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCacherCarosse, "btnCacherCarosse");
            this.btnCacherCarosse.Name = "btnCacherCarosse";
            this.btnCacherCarosse.UseVisualStyleBackColor = false;
            this.btnCacherCarosse.Click += new System.EventHandler(this.btnCacherCarosse_Click_1);
            // 
            // btnCacherBonhomme
            // 
            this.btnCacherBonhomme.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnCacherBonhomme.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCacherBonhomme, "btnCacherBonhomme");
            this.btnCacherBonhomme.Name = "btnCacherBonhomme";
            this.btnCacherBonhomme.UseVisualStyleBackColor = false;
            this.btnCacherBonhomme.Click += new System.EventHandler(this.btnCacherBonhomme_Click_1);
            // 
            // TimerImage
            // 
            this.TimerImage.Tick += new System.EventHandler(this.timerImage_Tick);
            // 
            // TimerRectangle
            // 
            this.TimerRectangle.Tick += new System.EventHandler(this.timerRectangle_Tick);
            // 
            // TimerCarosse
            // 
            this.TimerCarosse.Tick += new System.EventHandler(this.timerCarosse_Tick_1);
            // 
            // TimerBonhomme
            // 
            this.TimerBonhomme.Tick += new System.EventHandler(this.timerBonhomme_Tick);
            // 
            // btnAfficher
            // 
            this.btnAfficher.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAfficher.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAfficher, "btnAfficher");
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // btnAfficherBras
            // 
            this.btnAfficherBras.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAfficherBras.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAfficherBras, "btnAfficherBras");
            this.btnAfficherBras.Name = "btnAfficherBras";
            this.btnAfficherBras.UseVisualStyleBackColor = false;
            this.btnAfficherBras.Click += new System.EventHandler(this.btnAfficherBras_Click);
            // 
            // btnTournerRectangle
            // 
            this.btnTournerRectangle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTournerRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTournerRectangle, "btnTournerRectangle");
            this.btnTournerRectangle.Name = "btnTournerRectangle";
            this.btnTournerRectangle.UseVisualStyleBackColor = false;
            this.btnTournerRectangle.Click += new System.EventHandler(this.btnTournerRectangle_Click);
            // 
            // btnTournerBras
            // 
            this.btnTournerBras.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnTournerBras.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTournerBras, "btnTournerBras");
            this.btnTournerBras.Name = "btnTournerBras";
            this.btnTournerBras.UseVisualStyleBackColor = false;
            this.btnTournerBras.Click += new System.EventHandler(this.btnTournerBras_Click);
            // 
            // btnAfficherJambe
            // 
            this.btnAfficherJambe.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnAfficherJambe.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAfficherJambe, "btnAfficherJambe");
            this.btnAfficherJambe.Name = "btnAfficherJambe";
            this.btnAfficherJambe.UseVisualStyleBackColor = false;
            this.btnAfficherJambe.Click += new System.EventHandler(this.btnAfficherJambe_Click);
            // 
            // btnTournerJambe
            // 
            this.btnTournerJambe.BackColor = System.Drawing.Color.Thistle;
            this.btnTournerJambe.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTournerJambe, "btnTournerJambe");
            this.btnTournerJambe.Name = "btnTournerJambe";
            this.btnTournerJambe.UseVisualStyleBackColor = false;
            this.btnTournerJambe.Click += new System.EventHandler(this.btnTournerJambe_Click);
            // 
            // btnUnPasPerso
            // 
            this.btnUnPasPerso.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnUnPasPerso.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnUnPasPerso, "btnUnPasPerso");
            this.btnUnPasPerso.Name = "btnUnPasPerso";
            this.btnUnPasPerso.UseVisualStyleBackColor = false;
            this.btnUnPasPerso.Click += new System.EventHandler(this.btnUnPasPerso_Click);
            // 
            // btnMarcherPerso
            // 
            this.btnMarcherPerso.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnMarcherPerso.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnMarcherPerso, "btnMarcherPerso");
            this.btnMarcherPerso.Name = "btnMarcherPerso";
            this.btnMarcherPerso.UseVisualStyleBackColor = false;
            this.btnMarcherPerso.Click += new System.EventHandler(this.btnMarcherPerso_Click);
            // 
            // btnPausePerso
            // 
            this.btnPausePerso.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnPausePerso.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnPausePerso, "btnPausePerso");
            this.btnPausePerso.Name = "btnPausePerso";
            this.btnPausePerso.UseVisualStyleBackColor = false;
            this.btnPausePerso.Click += new System.EventHandler(this.btnPausePerso_Click);
            // 
            // btnAfficherPerso
            // 
            this.btnAfficherPerso.BackColor = System.Drawing.Color.Yellow;
            this.btnAfficherPerso.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAfficherPerso, "btnAfficherPerso");
            this.btnAfficherPerso.Name = "btnAfficherPerso";
            this.btnAfficherPerso.UseVisualStyleBackColor = false;
            this.btnAfficherPerso.Click += new System.EventHandler(this.btnAfficherPerso_Click);
            // 
            // TimerPerso
            // 
            this.TimerPerso.Tick += new System.EventHandler(this.TimerPerso_Tick);
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.Color.Red;
            this.btnEffacer.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnEffacer, "btnEffacer");
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnAfficheSkieur
            // 
            this.btnAfficheSkieur.BackColor = System.Drawing.Color.Chocolate;
            this.btnAfficheSkieur.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAfficheSkieur, "btnAfficheSkieur");
            this.btnAfficheSkieur.Name = "btnAfficheSkieur";
            this.btnAfficheSkieur.UseVisualStyleBackColor = false;
            this.btnAfficheSkieur.Click += new System.EventHandler(this.btnAfficheSkieur_Click);
            // 
            // btnAfficherJambeCloseCurve
            // 
            this.btnAfficherJambeCloseCurve.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAfficherJambeCloseCurve.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAfficherJambeCloseCurve, "btnAfficherJambeCloseCurve");
            this.btnAfficherJambeCloseCurve.Name = "btnAfficherJambeCloseCurve";
            this.btnAfficherJambeCloseCurve.UseVisualStyleBackColor = false;
            this.btnAfficherJambeCloseCurve.Click += new System.EventHandler(this.btnAfficherJambeCloseCurve_Click);
            // 
            // btnTournerJambeCloseCurve
            // 
            this.btnTournerJambeCloseCurve.BackColor = System.Drawing.Color.Plum;
            this.btnTournerJambeCloseCurve.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTournerJambeCloseCurve, "btnTournerJambeCloseCurve");
            this.btnTournerJambeCloseCurve.Name = "btnTournerJambeCloseCurve";
            this.btnTournerJambeCloseCurve.UseVisualStyleBackColor = false;
            this.btnTournerJambeCloseCurve.Click += new System.EventHandler(this.btnTournerJambeCloseCurve_Click);
            // 
            // btnAfficherBrasCloseCurve
            // 
            this.btnAfficherBrasCloseCurve.BackColor = System.Drawing.Color.Fuchsia;
            this.btnAfficherBrasCloseCurve.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAfficherBrasCloseCurve, "btnAfficherBrasCloseCurve");
            this.btnAfficherBrasCloseCurve.Name = "btnAfficherBrasCloseCurve";
            this.btnAfficherBrasCloseCurve.UseVisualStyleBackColor = false;
            this.btnAfficherBrasCloseCurve.Click += new System.EventHandler(this.btnAfficherBrasCloseCurve_Click);
            // 
            // btnTournerBrasCloseCurve
            // 
            this.btnTournerBrasCloseCurve.BackColor = System.Drawing.Color.Thistle;
            this.btnTournerBrasCloseCurve.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTournerBrasCloseCurve, "btnTournerBrasCloseCurve");
            this.btnTournerBrasCloseCurve.Name = "btnTournerBrasCloseCurve";
            this.btnTournerBrasCloseCurve.UseVisualStyleBackColor = false;
            this.btnTournerBrasCloseCurve.Click += new System.EventHandler(this.btnTournerBrasCloseCurve_Click);
            // 
            // btnAfficherCuisseCloseCurve
            // 
            this.btnAfficherCuisseCloseCurve.BackColor = System.Drawing.Color.HotPink;
            this.btnAfficherCuisseCloseCurve.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAfficherCuisseCloseCurve, "btnAfficherCuisseCloseCurve");
            this.btnAfficherCuisseCloseCurve.Name = "btnAfficherCuisseCloseCurve";
            this.btnAfficherCuisseCloseCurve.UseVisualStyleBackColor = false;
            this.btnAfficherCuisseCloseCurve.Click += new System.EventHandler(this.btnAfficherCuisseCloseCurve_Click);
            // 
            // btnTournerCuisseCloseCurve
            // 
            this.btnTournerCuisseCloseCurve.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnTournerCuisseCloseCurve.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTournerCuisseCloseCurve, "btnTournerCuisseCloseCurve");
            this.btnTournerCuisseCloseCurve.Name = "btnTournerCuisseCloseCurve";
            this.btnTournerCuisseCloseCurve.UseVisualStyleBackColor = false;
            this.btnTournerCuisseCloseCurve.Click += new System.EventHandler(this.btnTournerCuisseCloseCurve_Click);
            // 
            // btnAfficherJambeSkieurCloseCurve
            // 
            this.btnAfficherJambeSkieurCloseCurve.BackColor = System.Drawing.Color.Purple;
            this.btnAfficherJambeSkieurCloseCurve.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAfficherJambeSkieurCloseCurve, "btnAfficherJambeSkieurCloseCurve");
            this.btnAfficherJambeSkieurCloseCurve.Name = "btnAfficherJambeSkieurCloseCurve";
            this.btnAfficherJambeSkieurCloseCurve.UseVisualStyleBackColor = false;
            this.btnAfficherJambeSkieurCloseCurve.Click += new System.EventHandler(this.btnAfficherJambeSkieurCloseCurve_Click);
            // 
            // btnTournerJambeSkieurCloseCurve
            // 
            this.btnTournerJambeSkieurCloseCurve.BackColor = System.Drawing.Color.Thistle;
            this.btnTournerJambeSkieurCloseCurve.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTournerJambeSkieurCloseCurve, "btnTournerJambeSkieurCloseCurve");
            this.btnTournerJambeSkieurCloseCurve.Name = "btnTournerJambeSkieurCloseCurve";
            this.btnTournerJambeSkieurCloseCurve.UseVisualStyleBackColor = false;
            this.btnTournerJambeSkieurCloseCurve.Click += new System.EventHandler(this.btnTournerJambeSkieurCloseCurve_Click);
            // 
            // btnAfficherDecor
            // 
            this.btnAfficherDecor.BackColor = System.Drawing.Color.Gold;
            this.btnAfficherDecor.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAfficherDecor, "btnAfficherDecor");
            this.btnAfficherDecor.Name = "btnAfficherDecor";
            this.btnAfficherDecor.UseVisualStyleBackColor = false;
            this.btnAfficherDecor.Click += new System.EventHandler(this.btnAfficherDecor_Click);
            // 
            // btnBougerDecor
            // 
            this.btnBougerDecor.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBougerDecor.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnBougerDecor, "btnBougerDecor");
            this.btnBougerDecor.Name = "btnBougerDecor";
            this.btnBougerDecor.UseVisualStyleBackColor = false;
            this.btnBougerDecor.Click += new System.EventHandler(this.btnBougerDecor_Click);
            // 
            // TimerDecor
            // 
            this.TimerDecor.Tick += new System.EventHandler(this.TimerDecor_Tick);
            // 
            // btnPauseDecor
            // 
            this.btnPauseDecor.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPauseDecor.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnPauseDecor, "btnPauseDecor");
            this.btnPauseDecor.Name = "btnPauseDecor";
            this.btnPauseDecor.UseVisualStyleBackColor = false;
            this.btnPauseDecor.Click += new System.EventHandler(this.btnPauseDecor_Click);
            // 
            // btnBougerSkieur
            // 
            this.btnBougerSkieur.BackColor = System.Drawing.Color.YellowGreen;
            resources.ApplyResources(this.btnBougerSkieur, "btnBougerSkieur");
            this.btnBougerSkieur.Name = "btnBougerSkieur";
            this.btnBougerSkieur.UseVisualStyleBackColor = false;
            this.btnBougerSkieur.Click += new System.EventHandler(this.btnBougerSkieur_Click);
            // 
            // TimerSkieur
            // 
            this.TimerSkieur.Tick += new System.EventHandler(this.TimerSkieur_Tick);
            // 
            // btnPauseSkieur
            // 
            this.btnPauseSkieur.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPauseSkieur.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnPauseSkieur, "btnPauseSkieur");
            this.btnPauseSkieur.Name = "btnPauseSkieur";
            this.btnPauseSkieur.UseVisualStyleBackColor = false;
            this.btnPauseSkieur.Click += new System.EventHandler(this.btnPauseSkieur_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            resources.ApplyResources(this.checkBox5, "checkBox5");
            this.checkBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // checkBox6
            // 
            resources.ApplyResources(this.checkBox6, "checkBox6");
            this.checkBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Name = "label3";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // btnTestSon
            // 
            this.btnTestSon.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTestSon.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTestSon, "btnTestSon");
            this.btnTestSon.ForeColor = System.Drawing.Color.Navy;
            this.btnTestSon.Name = "btnTestSon";
            this.btnTestSon.UseVisualStyleBackColor = false;
            this.btnTestSon.Click += new System.EventHandler(this.btnTestSon_Click);
            // 
            // EcranAccueil
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.btnTestSon);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnPauseSkieur);
            this.Controls.Add(this.btnBougerSkieur);
            this.Controls.Add(this.btnPauseDecor);
            this.Controls.Add(this.btnBougerDecor);
            this.Controls.Add(this.btnAfficherDecor);
            this.Controls.Add(this.btnTournerJambeSkieurCloseCurve);
            this.Controls.Add(this.btnAfficherJambeSkieurCloseCurve);
            this.Controls.Add(this.btnTournerCuisseCloseCurve);
            this.Controls.Add(this.btnAfficherCuisseCloseCurve);
            this.Controls.Add(this.btnTournerBrasCloseCurve);
            this.Controls.Add(this.btnAfficherBrasCloseCurve);
            this.Controls.Add(this.btnTournerJambeCloseCurve);
            this.Controls.Add(this.btnAfficherJambeCloseCurve);
            this.Controls.Add(this.btnAfficheSkieur);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnAfficherPerso);
            this.Controls.Add(this.btnPausePerso);
            this.Controls.Add(this.btnMarcherPerso);
            this.Controls.Add(this.btnUnPasPerso);
            this.Controls.Add(this.btnTournerJambe);
            this.Controls.Add(this.btnAfficherJambe);
            this.Controls.Add(this.btnTournerBras);
            this.Controls.Add(this.btnTournerRectangle);
            this.Controls.Add(this.btnAfficherBras);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.btnCacherBonhomme);
            this.Controls.Add(this.btnCacherCarosse);
            this.Controls.Add(this.btnCacherRectangle);
            this.Controls.Add(this.btnStopTickBonhomme);
            this.Controls.Add(this.btnStopTickCarosse);
            this.Controls.Add(this.btnStopTrickRectangle);
            this.Controls.Add(this.btnTickBonhomme);
            this.Controls.Add(this.btnTickCarosse);
            this.Controls.Add(this.btnTickRectangle);
            this.Controls.Add(this.btnDeplacerBonhomme);
            this.Controls.Add(this.btnBougerCarosse);
            this.Controls.Add(this.btnDeplacerRectangle);
            this.Controls.Add(this.btnCacherCercle);
            this.Controls.Add(this.btnTickStopCercle);
            this.Controls.Add(this.btnTickCercle);
            this.Controls.Add(this.btnDeplacerCercle);
            this.Controls.Add(this.btnCacherPoint);
            this.Controls.Add(this.btnDeplacerPoint);
            this.Controls.Add(this.btnCreationBonhomme);
            this.Controls.Add(this.btnCreationCarosse);
            this.Controls.Add(this.btnCreationRectangle);
            this.Controls.Add(this.btnCreationCercle);
            this.Controls.Add(this.btnCreationPoint);
            this.Controls.Add(this.TV);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EcranAccueil";
            this.Load += new System.EventHandler(this.EcranAccueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreationPoint;
        private System.Windows.Forms.Button btnCreationCercle;
        private System.Windows.Forms.Button btnCreationRectangle;
        private System.Windows.Forms.Button btnCreationCarosse;
        private System.Windows.Forms.Button btnCreationBonhomme;
        private System.Windows.Forms.Button btnDeplacerPoint;
        private System.Windows.Forms.Button btnCacherPoint;
        private System.Windows.Forms.Button btnDeplacerCercle;
        private System.Windows.Forms.Button btnTickCercle;
        private System.Windows.Forms.Button btnTickStopCercle;
        private System.Windows.Forms.Button btnCacherCercle;
        private System.Windows.Forms.Button btnDeplacerRectangle;
        private System.Windows.Forms.Button btnBougerCarosse;
        private System.Windows.Forms.Button btnDeplacerBonhomme;
        private System.Windows.Forms.Button btnTickRectangle;
        private System.Windows.Forms.Button btnTickCarosse;
        private System.Windows.Forms.Button btnTickBonhomme;
        private System.Windows.Forms.Button btnStopTrickRectangle;
        private System.Windows.Forms.Button btnStopTickCarosse;
        private System.Windows.Forms.Button btnStopTickBonhomme;
        private System.Windows.Forms.Button btnCacherRectangle;
        private System.Windows.Forms.Button btnCacherCarosse;
        private System.Windows.Forms.Button btnCacherBonhomme;
        private System.Windows.Forms.Timer TimerImage;
        private System.Windows.Forms.Timer TimerRectangle;
        private System.Windows.Forms.Timer TimerCarosse;
        private System.Windows.Forms.Timer TimerBonhomme;
        private System.Windows.Forms.PictureBox TV;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Button btnAfficherBras;
        private System.Windows.Forms.Button btnTournerRectangle;
        private System.Windows.Forms.Button btnTournerBras;
        private System.Windows.Forms.Button btnAfficherJambe;
        private System.Windows.Forms.Button btnTournerJambe;
        private System.Windows.Forms.Button btnUnPasPerso;
        private System.Windows.Forms.Button btnMarcherPerso;
        private System.Windows.Forms.Button btnPausePerso;
        private System.Windows.Forms.Button btnAfficherPerso;
        private System.Windows.Forms.Timer TimerPerso;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnAfficheSkieur;
        private System.Windows.Forms.Button btnAfficherJambeCloseCurve;
        private System.Windows.Forms.Button btnTournerJambeCloseCurve;
        private System.Windows.Forms.Button btnAfficherBrasCloseCurve;
        private System.Windows.Forms.Button btnTournerBrasCloseCurve;
        private System.Windows.Forms.Button btnAfficherCuisseCloseCurve;
        private System.Windows.Forms.Button btnTournerCuisseCloseCurve;
        private System.Windows.Forms.Button btnAfficherJambeSkieurCloseCurve;
        private System.Windows.Forms.Button btnTournerJambeSkieurCloseCurve;
        private System.Windows.Forms.Button btnAfficherDecor;
        private System.Windows.Forms.Button btnBougerDecor;
        private System.Windows.Forms.Timer TimerDecor;
        private System.Windows.Forms.Button btnPauseDecor;
        private System.Windows.Forms.Button btnBougerSkieur;
        private System.Windows.Forms.Timer TimerSkieur;
        private System.Windows.Forms.Button btnPauseSkieur;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnTestSon;
    }
}

