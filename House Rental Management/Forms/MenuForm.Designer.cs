namespace House_Rental_Management
{
    partial class MenuForm
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
            Guna.UI.Animation.Animation animation2 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.mainPanel = new Guna.UI.WinForms.GunaShadowPanel();
            this.menuPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnLogOut = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnProprietaire = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCategorie = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnLocataire = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnLocation = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAppartement = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitre = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.gunaControlBox2);
            this.bunifuGradientPanel1.Controls.Add(this.gunaControlBox1);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.gunaTransition1.SetDecoration(this.bunifuGradientPanel1, Guna.UI.Animation.DecorationType.None);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(159)))), ((int)(((byte)(162)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(159)))), ((int)(((byte)(162)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(200, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(984, 32);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaTransition1.SetDecoration(this.gunaControlBox2, Guna.UI.Animation.DecorationType.None);
            this.gunaControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaControlBox2.IconColor = System.Drawing.Color.White;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(901, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(35, 32);
            this.gunaControlBox2.TabIndex = 15;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom;
            this.gunaTransition1.SetDecoration(this.gunaControlBox1, Guna.UI.Animation.DecorationType.None);
            this.gunaControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(936, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(35, 32);
            this.gunaControlBox1.TabIndex = 12;
            // 
            // panel1
            // 
            this.gunaTransition1.SetDecoration(this.panel1, Guna.UI.Animation.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(971, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 32);
            this.panel1.TabIndex = 0;
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Scale;
            this.gunaTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.gunaTransition1.DefaultAnimation = animation2;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mainPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaTransition1.SetDecoration(this.mainPanel, Guna.UI.Animation.DecorationType.None);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 32);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowColor = System.Drawing.Color.Black;
            this.mainPanel.ShadowShift = 0;
            this.mainPanel.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal;
            this.mainPanel.Size = new System.Drawing.Size(984, 628);
            this.mainPanel.TabIndex = 4;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuPanel.BackgroundImage")));
            this.menuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuPanel.BorderRadius = 1;
            this.menuPanel.Controls.Add(this.btnLogOut);
            this.menuPanel.Controls.Add(this.btnProprietaire);
            this.menuPanel.Controls.Add(this.btnCategorie);
            this.menuPanel.Controls.Add(this.btnLocataire);
            this.menuPanel.Controls.Add(this.btnLocation);
            this.menuPanel.Controls.Add(this.btnAppartement);
            this.menuPanel.Controls.Add(this.panel2);
            this.gunaTransition1.SetDecoration(this.menuPanel, Guna.UI.Animation.DecorationType.None);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(159)))), ((int)(((byte)(162)))));
            this.menuPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(159)))), ((int)(((byte)(162)))));
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Quality = 10;
            this.menuPanel.Size = new System.Drawing.Size(200, 660);
            this.menuPanel.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AnimationHoverSpeed = 0.07F;
            this.btnLogOut.AnimationSpeed = 0.03F;
            this.btnLogOut.BaseColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BorderColor = System.Drawing.Color.Black;
            this.btnLogOut.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLogOut.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLogOut.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogOut.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.CheckedImage")));
            this.btnLogOut.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaTransition1.SetDecoration(this.btnLogOut, Guna.UI.Animation.DecorationType.None);
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogOut.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::House_Rental_Management.Properties.Resources.sign_out_100px;
            this.btnLogOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogOut.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLogOut.Location = new System.Drawing.Point(0, 602);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLogOut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogOut.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogOut.OnHoverImage = null;
            this.btnLogOut.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLogOut.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogOut.Size = new System.Drawing.Size(200, 58);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Deconnection";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnProprietaire
            // 
            this.btnProprietaire.AnimationHoverSpeed = 0.07F;
            this.btnProprietaire.AnimationSpeed = 0.03F;
            this.btnProprietaire.BaseColor = System.Drawing.Color.Transparent;
            this.btnProprietaire.BorderColor = System.Drawing.Color.Black;
            this.btnProprietaire.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnProprietaire.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnProprietaire.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnProprietaire.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnProprietaire.CheckedImage = global::House_Rental_Management.Properties.Resources.landlord_100px;
            this.btnProprietaire.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaTransition1.SetDecoration(this.btnProprietaire, Guna.UI.Animation.DecorationType.None);
            this.btnProprietaire.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProprietaire.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProprietaire.FocusedColor = System.Drawing.Color.Empty;
            this.btnProprietaire.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProprietaire.ForeColor = System.Drawing.Color.White;
            this.btnProprietaire.Image = global::House_Rental_Management.Properties.Resources.landlord_100px;
            this.btnProprietaire.ImageSize = new System.Drawing.Size(30, 30);
            this.btnProprietaire.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnProprietaire.Location = new System.Drawing.Point(0, 389);
            this.btnProprietaire.Name = "btnProprietaire";
            this.btnProprietaire.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnProprietaire.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProprietaire.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProprietaire.OnHoverImage = null;
            this.btnProprietaire.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnProprietaire.OnPressedColor = System.Drawing.Color.Black;
            this.btnProprietaire.Size = new System.Drawing.Size(200, 45);
            this.btnProprietaire.TabIndex = 8;
            this.btnProprietaire.Text = "Proprietaire";
            // 
            // btnCategorie
            // 
            this.btnCategorie.AnimationHoverSpeed = 0.07F;
            this.btnCategorie.AnimationSpeed = 0.03F;
            this.btnCategorie.BaseColor = System.Drawing.Color.Transparent;
            this.btnCategorie.BorderColor = System.Drawing.Color.Black;
            this.btnCategorie.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnCategorie.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCategorie.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCategorie.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCategorie.CheckedImage = global::House_Rental_Management.Properties.Resources.category_100px;
            this.btnCategorie.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaTransition1.SetDecoration(this.btnCategorie, Guna.UI.Animation.DecorationType.None);
            this.btnCategorie.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCategorie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorie.FocusedColor = System.Drawing.Color.Empty;
            this.btnCategorie.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorie.ForeColor = System.Drawing.Color.White;
            this.btnCategorie.Image = global::House_Rental_Management.Properties.Resources.category_100px;
            this.btnCategorie.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCategorie.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCategorie.Location = new System.Drawing.Point(0, 343);
            this.btnCategorie.Name = "btnCategorie";
            this.btnCategorie.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCategorie.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCategorie.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCategorie.OnHoverImage = null;
            this.btnCategorie.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCategorie.OnPressedColor = System.Drawing.Color.Black;
            this.btnCategorie.Size = new System.Drawing.Size(200, 46);
            this.btnCategorie.TabIndex = 7;
            this.btnCategorie.Text = "Categorie";
            // 
            // btnLocataire
            // 
            this.btnLocataire.AnimationHoverSpeed = 0.07F;
            this.btnLocataire.AnimationSpeed = 0.03F;
            this.btnLocataire.BaseColor = System.Drawing.Color.Transparent;
            this.btnLocataire.BorderColor = System.Drawing.Color.Black;
            this.btnLocataire.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnLocataire.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLocataire.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLocataire.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLocataire.CheckedImage = global::House_Rental_Management.Properties.Resources.person_at_home_100px;
            this.btnLocataire.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaTransition1.SetDecoration(this.btnLocataire, Guna.UI.Animation.DecorationType.None);
            this.btnLocataire.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLocataire.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocataire.FocusedColor = System.Drawing.Color.Empty;
            this.btnLocataire.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocataire.ForeColor = System.Drawing.Color.White;
            this.btnLocataire.Image = global::House_Rental_Management.Properties.Resources.person_at_home_100px;
            this.btnLocataire.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLocataire.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLocataire.Location = new System.Drawing.Point(0, 297);
            this.btnLocataire.Name = "btnLocataire";
            this.btnLocataire.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLocataire.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLocataire.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLocataire.OnHoverImage = null;
            this.btnLocataire.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLocataire.OnPressedColor = System.Drawing.Color.Black;
            this.btnLocataire.Size = new System.Drawing.Size(200, 46);
            this.btnLocataire.TabIndex = 5;
            this.btnLocataire.Text = "Loactaire";
            // 
            // btnLocation
            // 
            this.btnLocation.AnimationHoverSpeed = 0.07F;
            this.btnLocation.AnimationSpeed = 0.03F;
            this.btnLocation.BaseColor = System.Drawing.Color.Transparent;
            this.btnLocation.BorderColor = System.Drawing.Color.Black;
            this.btnLocation.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnLocation.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLocation.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLocation.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLocation.CheckedImage = global::House_Rental_Management.Properties.Resources.rent_100px;
            this.btnLocation.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaTransition1.SetDecoration(this.btnLocation, Guna.UI.Animation.DecorationType.None);
            this.btnLocation.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocation.FocusedColor = System.Drawing.Color.Empty;
            this.btnLocation.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocation.ForeColor = System.Drawing.Color.White;
            this.btnLocation.Image = global::House_Rental_Management.Properties.Resources.rent_100px;
            this.btnLocation.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLocation.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLocation.Location = new System.Drawing.Point(0, 252);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLocation.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLocation.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLocation.OnHoverImage = null;
            this.btnLocation.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLocation.OnPressedColor = System.Drawing.Color.Black;
            this.btnLocation.Size = new System.Drawing.Size(200, 45);
            this.btnLocation.TabIndex = 4;
            this.btnLocation.Text = "Location";
            // 
            // btnAppartement
            // 
            this.btnAppartement.AnimationHoverSpeed = 0.07F;
            this.btnAppartement.AnimationSpeed = 0.03F;
            this.btnAppartement.BaseColor = System.Drawing.Color.Transparent;
            this.btnAppartement.BorderColor = System.Drawing.Color.Black;
            this.btnAppartement.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnAppartement.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAppartement.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAppartement.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAppartement.CheckedImage = global::House_Rental_Management.Properties.Resources.house_100px;
            this.btnAppartement.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaTransition1.SetDecoration(this.btnAppartement, Guna.UI.Animation.DecorationType.None);
            this.btnAppartement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAppartement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppartement.FocusedColor = System.Drawing.Color.Empty;
            this.btnAppartement.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppartement.ForeColor = System.Drawing.Color.White;
            this.btnAppartement.Image = global::House_Rental_Management.Properties.Resources.house_100px;
            this.btnAppartement.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAppartement.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAppartement.Location = new System.Drawing.Point(0, 207);
            this.btnAppartement.Name = "btnAppartement";
            this.btnAppartement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAppartement.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAppartement.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAppartement.OnHoverImage = null;
            this.btnAppartement.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAppartement.OnPressedColor = System.Drawing.Color.Black;
            this.btnAppartement.Size = new System.Drawing.Size(200, 45);
            this.btnAppartement.TabIndex = 6;
            this.btnAppartement.Text = "Appartement";
            this.btnAppartement.Click += new System.EventHandler(this.btnAppartement_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTitre);
            this.panel2.Controls.Add(this.pictureBox1);
            this.gunaTransition1.SetDecoration(this.panel2, Guna.UI.Animation.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 207);
            this.panel2.TabIndex = 4;
            // 
            // labelTitre
            // 
            this.gunaTransition1.SetDecoration(this.labelTitre, Guna.UI.Animation.DecorationType.None);
            this.labelTitre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitre.Location = new System.Drawing.Point(0, 160);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(200, 47);
            this.labelTitre.TabIndex = 4;
            this.labelTitre.Text = "Location des Maison";
            this.labelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.gunaTransition1.SetDecoration(this.pictureBox1, Guna.UI.Animation.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::House_Rental_Management.Properties.Resources.warehouse_100px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1184, 660);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.menuPanel);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuGradientPanel menuPanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel labelTitre;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private Guna.UI.WinForms.GunaAdvenceButton btnLocataire;
        private Guna.UI.WinForms.GunaAdvenceButton btnLocation;
        private Guna.UI.WinForms.GunaAdvenceButton btnLogOut;
        private Guna.UI.WinForms.GunaAdvenceButton btnProprietaire;
        private Guna.UI.WinForms.GunaAdvenceButton btnCategorie;
        private Guna.UI.WinForms.GunaAdvenceButton btnAppartement;
        private Guna.UI.WinForms.GunaShadowPanel mainPanel;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
    }
}

