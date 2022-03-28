namespace MangaReader
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Panel();
            this.bunifuButton5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnUploadManga = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnMenu = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnUploadChapter = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnList = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnNew = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.MenuTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.btnBack);
            this.header.Controls.Add(this.btnClose);
            this.header.Controls.Add(this.label1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1110, 40);
            this.header.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MangaReader.Properties.Resources.Webp_net_resizeimage;
            this.pictureBox2.Location = new System.Drawing.Point(478, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.ActiveImage = null;
            this.btnBack.AllowAnimations = true;
            this.btnBack.AllowBuffering = false;
            this.btnBack.AllowToggling = false;
            this.btnBack.AllowZooming = true;
            this.btnBack.AllowZoomingOnFocus = false;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBack.ErrorImage")));
            this.btnBack.FadeWhenInactive = false;
            this.btnBack.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnBack.Image = global::MangaReader.Properties.Resources.back_64px;
            this.btnBack.ImageActive = null;
            this.btnBack.ImageLocation = null;
            this.btnBack.ImageMargin = 5;
            this.btnBack.ImageSize = new System.Drawing.Size(33, 29);
            this.btnBack.ImageZoomSize = new System.Drawing.Size(38, 34);
            this.btnBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBack.InitialImage")));
            this.btnBack.Location = new System.Drawing.Point(12, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Rotation = 0;
            this.btnBack.ShowActiveImage = true;
            this.btnBack.ShowCursorChanges = true;
            this.btnBack.ShowImageBorders = true;
            this.btnBack.ShowSizeMarkers = false;
            this.btnBack.Size = new System.Drawing.Size(38, 34);
            this.btnBack.TabIndex = 2;
            this.btnBack.ToolTipText = "";
            this.btnBack.WaitOnLoad = false;
            this.btnBack.Zoom = 5;
            this.btnBack.ZoomSpeed = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = true;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = global::MangaReader.Properties.Resources.close_window_26px;
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 5;
            this.btnClose.ImageSize = new System.Drawing.Size(22, 22);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(27, 27);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(1071, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(27, 27);
            this.btnClose.TabIndex = 2;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 5;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(522, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hero Manga";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Menu.Controls.Add(this.bunifuButton5);
            this.Menu.Controls.Add(this.btnUploadManga);
            this.Menu.Controls.Add(this.btnMenu);
            this.Menu.Controls.Add(this.btnUploadChapter);
            this.Menu.Controls.Add(this.pictureBox1);
            this.Menu.Controls.Add(this.btnList);
            this.Menu.Controls.Add(this.btnNew);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 40);
            this.Menu.MaximumSize = new System.Drawing.Size(240, 704);
            this.Menu.MinimumSize = new System.Drawing.Size(50, 704);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(50, 704);
            this.Menu.TabIndex = 1;
            // 
            // bunifuButton5
            // 
            this.bunifuButton5.AllowAnimations = true;
            this.bunifuButton5.AllowMouseEffects = true;
            this.bunifuButton5.AllowToggling = false;
            this.bunifuButton5.AnimationSpeed = 200;
            this.bunifuButton5.AutoGenerateColors = false;
            this.bunifuButton5.AutoRoundBorders = false;
            this.bunifuButton5.AutoSizeLeftIcon = true;
            this.bunifuButton5.AutoSizeRightIcon = true;
            this.bunifuButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton5.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(27)))));
            this.bunifuButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton5.BackgroundImage")));
            this.bunifuButton5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.ButtonText = "Settings";
            this.bunifuButton5.ButtonTextMarginLeft = 0;
            this.bunifuButton5.ColorContrastOnClick = 45;
            this.bunifuButton5.ColorContrastOnHover = 45;
            this.bunifuButton5.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton5.CustomizableEdges = borderEdges1;
            this.bunifuButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton5.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton5.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton5.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton5.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton5.ForeColor = System.Drawing.Color.White;
            this.bunifuButton5.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton5.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton5.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton5.IconMarginLeft = 11;
            this.bunifuButton5.IconPadding = 10;
            this.bunifuButton5.IconRightAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton5.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton5.IconRightPadding = new System.Windows.Forms.Padding(12, 3, 7, 3);
            this.bunifuButton5.IconSize = 25;
            this.bunifuButton5.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(27)))));
            this.bunifuButton5.IdleBorderRadius = 1;
            this.bunifuButton5.IdleBorderThickness = 1;
            this.bunifuButton5.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(27)))));
            this.bunifuButton5.IdleIconLeftImage = global::MangaReader.Properties.Resources.settings_24px;
            this.bunifuButton5.IdleIconRightImage = global::MangaReader.Properties.Resources.settings_24px;
            this.bunifuButton5.IndicateFocus = false;
            this.bunifuButton5.Location = new System.Drawing.Point(-3, 662);
            this.bunifuButton5.Name = "bunifuButton5";
            this.bunifuButton5.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton5.OnDisabledState.BorderRadius = 1;
            this.bunifuButton5.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.OnDisabledState.BorderThickness = 1;
            this.bunifuButton5.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton5.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton5.OnDisabledState.IconLeftImage = null;
            this.bunifuButton5.OnDisabledState.IconRightImage = null;
            this.bunifuButton5.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.bunifuButton5.onHoverState.BorderRadius = 1;
            this.bunifuButton5.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.onHoverState.BorderThickness = 1;
            this.bunifuButton5.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.bunifuButton5.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton5.onHoverState.IconLeftImage = null;
            this.bunifuButton5.onHoverState.IconRightImage = null;
            this.bunifuButton5.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(27)))));
            this.bunifuButton5.OnIdleState.BorderRadius = 1;
            this.bunifuButton5.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.OnIdleState.BorderThickness = 1;
            this.bunifuButton5.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(27)))));
            this.bunifuButton5.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton5.OnIdleState.IconLeftImage = global::MangaReader.Properties.Resources.settings_24px;
            this.bunifuButton5.OnIdleState.IconRightImage = global::MangaReader.Properties.Resources.settings_24px;
            this.bunifuButton5.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.bunifuButton5.OnPressedState.BorderRadius = 1;
            this.bunifuButton5.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.OnPressedState.BorderThickness = 1;
            this.bunifuButton5.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.bunifuButton5.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton5.OnPressedState.IconLeftImage = null;
            this.bunifuButton5.OnPressedState.IconRightImage = null;
            this.bunifuButton5.Size = new System.Drawing.Size(243, 39);
            this.bunifuButton5.TabIndex = 2;
            this.bunifuButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton5.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton5.TextMarginLeft = 0;
            this.bunifuButton5.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton5.UseDefaultRadiusAndThickness = true;
            // 
            // btnUploadManga
            // 
            this.btnUploadManga.AllowAnimations = true;
            this.btnUploadManga.AllowMouseEffects = true;
            this.btnUploadManga.AllowToggling = false;
            this.btnUploadManga.AnimationSpeed = 200;
            this.btnUploadManga.AutoGenerateColors = false;
            this.btnUploadManga.AutoRoundBorders = false;
            this.btnUploadManga.AutoSizeLeftIcon = true;
            this.btnUploadManga.AutoSizeRightIcon = true;
            this.btnUploadManga.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadManga.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnUploadManga.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploadManga.BackgroundImage")));
            this.btnUploadManga.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUploadManga.ButtonText = "Add New Manga";
            this.btnUploadManga.ButtonTextMarginLeft = 0;
            this.btnUploadManga.ColorContrastOnClick = 45;
            this.btnUploadManga.ColorContrastOnHover = 45;
            this.btnUploadManga.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnUploadManga.CustomizableEdges = borderEdges2;
            this.btnUploadManga.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUploadManga.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUploadManga.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUploadManga.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUploadManga.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnUploadManga.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUploadManga.ForeColor = System.Drawing.Color.White;
            this.btnUploadManga.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadManga.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnUploadManga.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnUploadManga.IconMarginLeft = 11;
            this.btnUploadManga.IconPadding = 10;
            this.btnUploadManga.IconRightAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadManga.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnUploadManga.IconRightPadding = new System.Windows.Forms.Padding(12, 3, 7, 3);
            this.btnUploadManga.IconSize = 25;
            this.btnUploadManga.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnUploadManga.IdleBorderRadius = 1;
            this.btnUploadManga.IdleBorderThickness = 1;
            this.btnUploadManga.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnUploadManga.IdleIconLeftImage = global::MangaReader.Properties.Resources.upload_to_cloud_30px;
            this.btnUploadManga.IdleIconRightImage = global::MangaReader.Properties.Resources.upload_to_cloud_30px;
            this.btnUploadManga.IndicateFocus = false;
            this.btnUploadManga.Location = new System.Drawing.Point(3, 314);
            this.btnUploadManga.Name = "btnUploadManga";
            this.btnUploadManga.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUploadManga.OnDisabledState.BorderRadius = 1;
            this.btnUploadManga.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUploadManga.OnDisabledState.BorderThickness = 1;
            this.btnUploadManga.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUploadManga.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUploadManga.OnDisabledState.IconLeftImage = null;
            this.btnUploadManga.OnDisabledState.IconRightImage = null;
            this.btnUploadManga.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnUploadManga.onHoverState.BorderRadius = 1;
            this.btnUploadManga.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUploadManga.onHoverState.BorderThickness = 1;
            this.btnUploadManga.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnUploadManga.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnUploadManga.onHoverState.IconLeftImage = null;
            this.btnUploadManga.onHoverState.IconRightImage = null;
            this.btnUploadManga.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnUploadManga.OnIdleState.BorderRadius = 1;
            this.btnUploadManga.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUploadManga.OnIdleState.BorderThickness = 1;
            this.btnUploadManga.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnUploadManga.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnUploadManga.OnIdleState.IconLeftImage = global::MangaReader.Properties.Resources.upload_to_cloud_30px;
            this.btnUploadManga.OnIdleState.IconRightImage = global::MangaReader.Properties.Resources.upload_to_cloud_30px;
            this.btnUploadManga.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnUploadManga.OnPressedState.BorderRadius = 1;
            this.btnUploadManga.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUploadManga.OnPressedState.BorderThickness = 1;
            this.btnUploadManga.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnUploadManga.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnUploadManga.OnPressedState.IconLeftImage = null;
            this.btnUploadManga.OnPressedState.IconRightImage = null;
            this.btnUploadManga.Size = new System.Drawing.Size(240, 39);
            this.btnUploadManga.TabIndex = 2;
            this.btnUploadManga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUploadManga.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUploadManga.TextMarginLeft = 0;
            this.btnUploadManga.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnUploadManga.UseDefaultRadiusAndThickness = true;
            this.btnUploadManga.Click += new System.EventHandler(this.btnUpl_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.ActiveImage = null;
            this.btnMenu.AllowAnimations = true;
            this.btnMenu.AllowBuffering = false;
            this.btnMenu.AllowToggling = false;
            this.btnMenu.AllowZooming = true;
            this.btnMenu.AllowZoomingOnFocus = false;
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMenu.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.ErrorImage")));
            this.btnMenu.FadeWhenInactive = false;
            this.btnMenu.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMenu.Image = global::MangaReader.Properties.Resources.menu_rounded_48px;
            this.btnMenu.ImageActive = null;
            this.btnMenu.ImageLocation = null;
            this.btnMenu.ImageMargin = 5;
            this.btnMenu.ImageSize = new System.Drawing.Size(29, 29);
            this.btnMenu.ImageZoomSize = new System.Drawing.Size(34, 34);
            this.btnMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.InitialImage")));
            this.btnMenu.Location = new System.Drawing.Point(0, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Rotation = 0;
            this.btnMenu.ShowActiveImage = true;
            this.btnMenu.ShowCursorChanges = true;
            this.btnMenu.ShowImageBorders = true;
            this.btnMenu.ShowSizeMarkers = false;
            this.btnMenu.Size = new System.Drawing.Size(34, 34);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.ToolTipText = "";
            this.btnMenu.WaitOnLoad = false;
            this.btnMenu.Zoom = 5;
            this.btnMenu.ZoomSpeed = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnUploadChapter
            // 
            this.btnUploadChapter.AllowAnimations = true;
            this.btnUploadChapter.AllowMouseEffects = true;
            this.btnUploadChapter.AllowToggling = false;
            this.btnUploadChapter.AnimationSpeed = 200;
            this.btnUploadChapter.AutoGenerateColors = false;
            this.btnUploadChapter.AutoRoundBorders = false;
            this.btnUploadChapter.AutoSizeLeftIcon = true;
            this.btnUploadChapter.AutoSizeRightIcon = true;
            this.btnUploadChapter.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadChapter.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnUploadChapter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploadChapter.BackgroundImage")));
            this.btnUploadChapter.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUploadChapter.ButtonText = "Add New Chapter";
            this.btnUploadChapter.ButtonTextMarginLeft = 0;
            this.btnUploadChapter.ColorContrastOnClick = 45;
            this.btnUploadChapter.ColorContrastOnHover = 45;
            this.btnUploadChapter.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnUploadChapter.CustomizableEdges = borderEdges3;
            this.btnUploadChapter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUploadChapter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUploadChapter.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUploadChapter.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUploadChapter.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnUploadChapter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUploadChapter.ForeColor = System.Drawing.Color.White;
            this.btnUploadChapter.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadChapter.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnUploadChapter.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnUploadChapter.IconMarginLeft = 11;
            this.btnUploadChapter.IconPadding = 10;
            this.btnUploadChapter.IconRightAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadChapter.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnUploadChapter.IconRightPadding = new System.Windows.Forms.Padding(12, 3, 7, 3);
            this.btnUploadChapter.IconSize = 25;
            this.btnUploadChapter.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnUploadChapter.IdleBorderRadius = 1;
            this.btnUploadChapter.IdleBorderThickness = 1;
            this.btnUploadChapter.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnUploadChapter.IdleIconLeftImage = global::MangaReader.Properties.Resources.new_24px;
            this.btnUploadChapter.IdleIconRightImage = global::MangaReader.Properties.Resources.new_24px;
            this.btnUploadChapter.IndicateFocus = false;
            this.btnUploadChapter.Location = new System.Drawing.Point(0, 269);
            this.btnUploadChapter.Name = "btnUploadChapter";
            this.btnUploadChapter.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUploadChapter.OnDisabledState.BorderRadius = 1;
            this.btnUploadChapter.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUploadChapter.OnDisabledState.BorderThickness = 1;
            this.btnUploadChapter.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUploadChapter.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUploadChapter.OnDisabledState.IconLeftImage = null;
            this.btnUploadChapter.OnDisabledState.IconRightImage = null;
            this.btnUploadChapter.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnUploadChapter.onHoverState.BorderRadius = 1;
            this.btnUploadChapter.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUploadChapter.onHoverState.BorderThickness = 1;
            this.btnUploadChapter.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnUploadChapter.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnUploadChapter.onHoverState.IconLeftImage = null;
            this.btnUploadChapter.onHoverState.IconRightImage = null;
            this.btnUploadChapter.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnUploadChapter.OnIdleState.BorderRadius = 1;
            this.btnUploadChapter.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUploadChapter.OnIdleState.BorderThickness = 1;
            this.btnUploadChapter.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnUploadChapter.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnUploadChapter.OnIdleState.IconLeftImage = global::MangaReader.Properties.Resources.new_24px;
            this.btnUploadChapter.OnIdleState.IconRightImage = global::MangaReader.Properties.Resources.new_24px;
            this.btnUploadChapter.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnUploadChapter.OnPressedState.BorderRadius = 1;
            this.btnUploadChapter.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUploadChapter.OnPressedState.BorderThickness = 1;
            this.btnUploadChapter.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnUploadChapter.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnUploadChapter.OnPressedState.IconLeftImage = null;
            this.btnUploadChapter.OnPressedState.IconRightImage = null;
            this.btnUploadChapter.Size = new System.Drawing.Size(243, 39);
            this.btnUploadChapter.TabIndex = 2;
            this.btnUploadChapter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUploadChapter.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUploadChapter.TextMarginLeft = 0;
            this.btnUploadChapter.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnUploadChapter.UseDefaultRadiusAndThickness = true;
            this.btnUploadChapter.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MangaReader.Properties.Resources.screenshot_2022_02_22_211300;
            this.pictureBox1.Location = new System.Drawing.Point(36, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnList
            // 
            this.btnList.AllowAnimations = true;
            this.btnList.AllowMouseEffects = true;
            this.btnList.AllowToggling = false;
            this.btnList.AnimationSpeed = 200;
            this.btnList.AutoGenerateColors = false;
            this.btnList.AutoRoundBorders = false;
            this.btnList.AutoSizeLeftIcon = true;
            this.btnList.AutoSizeRightIcon = true;
            this.btnList.BackColor = System.Drawing.Color.Transparent;
            this.btnList.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnList.BackgroundImage")));
            this.btnList.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnList.ButtonText = "Manga List";
            this.btnList.ButtonTextMarginLeft = 0;
            this.btnList.ColorContrastOnClick = 45;
            this.btnList.ColorContrastOnHover = 45;
            this.btnList.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnList.CustomizableEdges = borderEdges4;
            this.btnList.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnList.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnList.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnList.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnList.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnList.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnList.IconMarginLeft = 11;
            this.btnList.IconPadding = 10;
            this.btnList.IconRightAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnList.IconRightPadding = new System.Windows.Forms.Padding(12, 3, 7, 3);
            this.btnList.IconSize = 25;
            this.btnList.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnList.IdleBorderRadius = 1;
            this.btnList.IdleBorderThickness = 1;
            this.btnList.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnList.IdleIconLeftImage = global::MangaReader.Properties.Resources.list_80px;
            this.btnList.IdleIconRightImage = global::MangaReader.Properties.Resources.list_80px;
            this.btnList.IndicateFocus = false;
            this.btnList.Location = new System.Drawing.Point(3, 234);
            this.btnList.Name = "btnList";
            this.btnList.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnList.OnDisabledState.BorderRadius = 1;
            this.btnList.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnList.OnDisabledState.BorderThickness = 1;
            this.btnList.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnList.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnList.OnDisabledState.IconLeftImage = null;
            this.btnList.OnDisabledState.IconRightImage = null;
            this.btnList.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnList.onHoverState.BorderRadius = 1;
            this.btnList.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnList.onHoverState.BorderThickness = 1;
            this.btnList.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnList.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnList.onHoverState.IconLeftImage = null;
            this.btnList.onHoverState.IconRightImage = null;
            this.btnList.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnList.OnIdleState.BorderRadius = 1;
            this.btnList.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnList.OnIdleState.BorderThickness = 1;
            this.btnList.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnList.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnList.OnIdleState.IconLeftImage = global::MangaReader.Properties.Resources.list_80px;
            this.btnList.OnIdleState.IconRightImage = global::MangaReader.Properties.Resources.list_80px;
            this.btnList.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnList.OnPressedState.BorderRadius = 1;
            this.btnList.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnList.OnPressedState.BorderThickness = 1;
            this.btnList.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnList.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnList.OnPressedState.IconLeftImage = null;
            this.btnList.OnPressedState.IconRightImage = null;
            this.btnList.Size = new System.Drawing.Size(243, 39);
            this.btnList.TabIndex = 2;
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnList.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnList.TextMarginLeft = 0;
            this.btnList.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnList.UseDefaultRadiusAndThickness = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnNew
            // 
            this.btnNew.AllowAnimations = true;
            this.btnNew.AllowMouseEffects = true;
            this.btnNew.AllowToggling = false;
            this.btnNew.AnimationSpeed = 200;
            this.btnNew.AutoGenerateColors = false;
            this.btnNew.AutoRoundBorders = false;
            this.btnNew.AutoSizeLeftIcon = true;
            this.btnNew.AutoSizeRightIcon = true;
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNew.ButtonText = "New Chapters";
            this.btnNew.ButtonTextMarginLeft = 0;
            this.btnNew.ColorContrastOnClick = 45;
            this.btnNew.ColorContrastOnHover = 45;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnNew.CustomizableEdges = borderEdges5;
            this.btnNew.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNew.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNew.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNew.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNew.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNew.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNew.IconMarginLeft = 11;
            this.btnNew.IconPadding = 10;
            this.btnNew.IconRightAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNew.IconRightPadding = new System.Windows.Forms.Padding(12, 3, 7, 3);
            this.btnNew.IconSize = 25;
            this.btnNew.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnNew.IdleBorderRadius = 1;
            this.btnNew.IdleBorderThickness = 1;
            this.btnNew.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnNew.IdleIconLeftImage = global::MangaReader.Properties.Resources.box_important_24px;
            this.btnNew.IdleIconRightImage = global::MangaReader.Properties.Resources.box_important_24px;
            this.btnNew.IndicateFocus = false;
            this.btnNew.Location = new System.Drawing.Point(0, 179);
            this.btnNew.Name = "btnNew";
            this.btnNew.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNew.OnDisabledState.BorderRadius = 1;
            this.btnNew.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNew.OnDisabledState.BorderThickness = 1;
            this.btnNew.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNew.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNew.OnDisabledState.IconLeftImage = null;
            this.btnNew.OnDisabledState.IconRightImage = null;
            this.btnNew.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnNew.onHoverState.BorderRadius = 1;
            this.btnNew.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNew.onHoverState.BorderThickness = 1;
            this.btnNew.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnNew.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNew.onHoverState.IconLeftImage = null;
            this.btnNew.onHoverState.IconRightImage = null;
            this.btnNew.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnNew.OnIdleState.BorderRadius = 1;
            this.btnNew.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNew.OnIdleState.BorderThickness = 1;
            this.btnNew.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnNew.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNew.OnIdleState.IconLeftImage = global::MangaReader.Properties.Resources.box_important_24px;
            this.btnNew.OnIdleState.IconRightImage = global::MangaReader.Properties.Resources.box_important_24px;
            this.btnNew.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnNew.OnPressedState.BorderRadius = 1;
            this.btnNew.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNew.OnPressedState.BorderThickness = 1;
            this.btnNew.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnNew.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNew.OnPressedState.IconLeftImage = null;
            this.btnNew.OnPressedState.IconRightImage = null;
            this.btnNew.Size = new System.Drawing.Size(243, 39);
            this.btnNew.TabIndex = 2;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNew.TextMarginLeft = 0;
            this.btnNew.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNew.UseDefaultRadiusAndThickness = true;
            // 
            // MenuTimer
            // 
            this.MenuTimer.Interval = 10;
            this.MenuTimer.Tick += new System.EventHandler(this.MenuTimer_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(50, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1060, 704);
            this.pnlMain.TabIndex = 3;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1110, 744);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel header;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuImageButton btnMenu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUploadManga;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUploadChapter;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnList;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNew;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton5;
        private System.Windows.Forms.Timer MenuTimer;
        private System.Windows.Forms.Panel pnlMain;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuImageButton btnBack;
    }
}

