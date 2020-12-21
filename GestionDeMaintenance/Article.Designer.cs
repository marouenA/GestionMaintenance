namespace GestionDeMaintenance
{
    partial class Article
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Article));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.code = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.designation = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.prixHt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tva = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.prixTtc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.quantite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.quantiteMin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.categorie = new System.Windows.Forms.ComboBox();
            this.majoration = new System.Windows.Forms.ComboBox();
            this.uniteDeMesure = new System.Windows.Forms.ComboBox();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1269, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // code
            // 
            this.code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.code.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.code.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.code.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.code.ForeColor = System.Drawing.Color.White;
            this.code.HintForeColor = System.Drawing.Color.Empty;
            this.code.HintText = "";
            this.code.isPassword = false;
            this.code.LineFocusedColor = System.Drawing.Color.White;
            this.code.LineIdleColor = System.Drawing.Color.Gray;
            this.code.LineMouseHoverColor = System.Drawing.Color.White;
            this.code.LineThickness = 3;
            this.code.Location = new System.Drawing.Point(25, 92);
            this.code.Margin = new System.Windows.Forms.Padding(4);
            this.code.MaxLength = 32767;
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(160, 33);
            this.code.TabIndex = 3;
            this.code.Text = "Code";
            this.code.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(143, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Articles";
            // 
            // designation
            // 
            this.designation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.designation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.designation.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.designation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.designation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.designation.ForeColor = System.Drawing.Color.White;
            this.designation.HintForeColor = System.Drawing.Color.Empty;
            this.designation.HintText = "";
            this.designation.isPassword = false;
            this.designation.LineFocusedColor = System.Drawing.Color.White;
            this.designation.LineIdleColor = System.Drawing.Color.Gray;
            this.designation.LineMouseHoverColor = System.Drawing.Color.White;
            this.designation.LineThickness = 3;
            this.designation.Location = new System.Drawing.Point(229, 92);
            this.designation.Margin = new System.Windows.Forms.Padding(4);
            this.designation.MaxLength = 32767;
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(131, 33);
            this.designation.TabIndex = 5;
            this.designation.Text = "Designiaton";
            this.designation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // prixHt
            // 
            this.prixHt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.prixHt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.prixHt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.prixHt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prixHt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.prixHt.ForeColor = System.Drawing.Color.White;
            this.prixHt.HintForeColor = System.Drawing.Color.Empty;
            this.prixHt.HintText = "";
            this.prixHt.isPassword = false;
            this.prixHt.LineFocusedColor = System.Drawing.Color.White;
            this.prixHt.LineIdleColor = System.Drawing.Color.Gray;
            this.prixHt.LineMouseHoverColor = System.Drawing.Color.White;
            this.prixHt.LineThickness = 3;
            this.prixHt.Location = new System.Drawing.Point(25, 145);
            this.prixHt.Margin = new System.Windows.Forms.Padding(4);
            this.prixHt.MaxLength = 32767;
            this.prixHt.Name = "prixHt";
            this.prixHt.Size = new System.Drawing.Size(160, 33);
            this.prixHt.TabIndex = 6;
            this.prixHt.Text = "Prix HT";
            this.prixHt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tva
            // 
            this.tva.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tva.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tva.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tva.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tva.ForeColor = System.Drawing.Color.White;
            this.tva.HintForeColor = System.Drawing.Color.Empty;
            this.tva.HintText = "";
            this.tva.isPassword = false;
            this.tva.LineFocusedColor = System.Drawing.Color.White;
            this.tva.LineIdleColor = System.Drawing.Color.Gray;
            this.tva.LineMouseHoverColor = System.Drawing.Color.White;
            this.tva.LineThickness = 3;
            this.tva.Location = new System.Drawing.Point(229, 145);
            this.tva.Margin = new System.Windows.Forms.Padding(4);
            this.tva.MaxLength = 32767;
            this.tva.Name = "tva";
            this.tva.Size = new System.Drawing.Size(131, 33);
            this.tva.TabIndex = 7;
            this.tva.Text = "TVA";
            this.tva.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tva.OnValueChanged += new System.EventHandler(this.Tva_OnValueChanged);
            // 
            // prixTtc
            // 
            this.prixTtc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.prixTtc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.prixTtc.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.prixTtc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prixTtc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.prixTtc.ForeColor = System.Drawing.Color.White;
            this.prixTtc.HintForeColor = System.Drawing.Color.Empty;
            this.prixTtc.HintText = "";
            this.prixTtc.isPassword = false;
            this.prixTtc.LineFocusedColor = System.Drawing.Color.White;
            this.prixTtc.LineIdleColor = System.Drawing.Color.Gray;
            this.prixTtc.LineMouseHoverColor = System.Drawing.Color.White;
            this.prixTtc.LineThickness = 3;
            this.prixTtc.Location = new System.Drawing.Point(229, 217);
            this.prixTtc.Margin = new System.Windows.Forms.Padding(4);
            this.prixTtc.MaxLength = 32767;
            this.prixTtc.Name = "prixTtc";
            this.prixTtc.Size = new System.Drawing.Size(131, 33);
            this.prixTtc.TabIndex = 8;
            this.prixTtc.Text = "Prix TTC";
            this.prixTtc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // quantite
            // 
            this.quantite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.quantite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.quantite.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.quantite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantite.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.quantite.ForeColor = System.Drawing.Color.White;
            this.quantite.HintForeColor = System.Drawing.Color.Empty;
            this.quantite.HintText = "";
            this.quantite.isPassword = false;
            this.quantite.LineFocusedColor = System.Drawing.Color.White;
            this.quantite.LineIdleColor = System.Drawing.Color.Gray;
            this.quantite.LineMouseHoverColor = System.Drawing.Color.White;
            this.quantite.LineThickness = 3;
            this.quantite.Location = new System.Drawing.Point(25, 291);
            this.quantite.Margin = new System.Windows.Forms.Padding(4);
            this.quantite.MaxLength = 32767;
            this.quantite.Name = "quantite";
            this.quantite.Size = new System.Drawing.Size(160, 33);
            this.quantite.TabIndex = 9;
            this.quantite.Text = "Qte";
            this.quantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // quantiteMin
            // 
            this.quantiteMin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.quantiteMin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.quantiteMin.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.quantiteMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantiteMin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.quantiteMin.ForeColor = System.Drawing.Color.White;
            this.quantiteMin.HintForeColor = System.Drawing.Color.Empty;
            this.quantiteMin.HintText = "";
            this.quantiteMin.isPassword = false;
            this.quantiteMin.LineFocusedColor = System.Drawing.Color.White;
            this.quantiteMin.LineIdleColor = System.Drawing.Color.Gray;
            this.quantiteMin.LineMouseHoverColor = System.Drawing.Color.White;
            this.quantiteMin.LineThickness = 3;
            this.quantiteMin.Location = new System.Drawing.Point(229, 291);
            this.quantiteMin.Margin = new System.Windows.Forms.Padding(4);
            this.quantiteMin.MaxLength = 32767;
            this.quantiteMin.Name = "quantiteMin";
            this.quantiteMin.Size = new System.Drawing.Size(131, 33);
            this.quantiteMin.TabIndex = 10;
            this.quantiteMin.Text = "Qte Minimale";
            this.quantiteMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.quantiteMin.OnValueChanged += new System.EventHandler(this.BunifuMaterialTextbox6_OnValueChanged);
            // 
            // categorie
            // 
            this.categorie.FormattingEnabled = true;
            this.categorie.Items.AddRange(new object[] {
            "Piéce de rechange",
            "Lubrifiant",
            "Consommable",
            "Divers",
            "Catégorie"});
            this.categorie.Location = new System.Drawing.Point(25, 365);
            this.categorie.Name = "categorie";
            this.categorie.Size = new System.Drawing.Size(160, 21);
            this.categorie.TabIndex = 12;
            // 
            // majoration
            // 
            this.majoration.FormattingEnabled = true;
            this.majoration.Items.AddRange(new object[] {
            "Majoration",
            "Oui",
            "Non"});
            this.majoration.Location = new System.Drawing.Point(25, 229);
            this.majoration.Name = "majoration";
            this.majoration.Size = new System.Drawing.Size(160, 21);
            this.majoration.TabIndex = 13;
            this.majoration.SelectedIndexChanged += new System.EventHandler(this.Majoration_SelectedIndexChanged);
            // 
            // uniteDeMesure
            // 
            this.uniteDeMesure.FormattingEnabled = true;
            this.uniteDeMesure.Items.AddRange(new object[] {
            "Unité de mesure",
            "Kg",
            "L",
            "Piéces"});
            this.uniteDeMesure.Location = new System.Drawing.Point(229, 365);
            this.uniteDeMesure.Name = "uniteDeMesure";
            this.uniteDeMesure.Size = new System.Drawing.Size(131, 21);
            this.uniteDeMesure.TabIndex = 14;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Ajouter";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleBorderRadius = 20;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(54, 423);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 20;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 20;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton1.OnPressedState = stateProperties2;
            this.bunifuButton1.Size = new System.Drawing.Size(131, 45);
            this.bunifuButton1.TabIndex = 15;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.BunifuButton1_Click);
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.AllowToggling = false;
            this.bunifuButton2.AnimationSpeed = 200;
            this.bunifuButton2.AutoGenerateColors = false;
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.ButtonText = "Modifier";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.ColorContrastOnClick = 45;
            this.bunifuButton2.ColorContrastOnHover = 45;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges2;
            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton2.IconMarginLeft = 11;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.IdleBorderRadius = 20;
            this.bunifuButton2.IdleBorderThickness = 1;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.IndicateFocus = false;
            this.bunifuButton2.Location = new System.Drawing.Point(209, 423);
            this.bunifuButton2.Name = "bunifuButton2";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 20;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.bunifuButton2.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 20;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.bunifuButton2.OnPressedState = stateProperties4;
            this.bunifuButton2.Size = new System.Drawing.Size(128, 45);
            this.bunifuButton2.TabIndex = 16;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            this.bunifuButton2.Click += new System.EventHandler(this.BunifuButton2_Click);
            // 
            // bunifuButton3
            // 
            this.bunifuButton3.AllowToggling = false;
            this.bunifuButton3.AnimationSpeed = 200;
            this.bunifuButton3.AutoGenerateColors = false;
            this.bunifuButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton3.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton3.BackgroundImage")));
            this.bunifuButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.ButtonText = "Supprimer";
            this.bunifuButton3.ButtonTextMarginLeft = 0;
            this.bunifuButton3.ColorContrastOnClick = 45;
            this.bunifuButton3.ColorContrastOnHover = 45;
            this.bunifuButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButton3.CustomizableEdges = borderEdges3;
            this.bunifuButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton3.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton3.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton3.IconMarginLeft = 11;
            this.bunifuButton3.IconPadding = 10;
            this.bunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton3.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton3.IdleBorderRadius = 20;
            this.bunifuButton3.IdleBorderThickness = 1;
            this.bunifuButton3.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton3.IdleIconLeftImage = null;
            this.bunifuButton3.IdleIconRightImage = null;
            this.bunifuButton3.IndicateFocus = false;
            this.bunifuButton3.Location = new System.Drawing.Point(209, 491);
            this.bunifuButton3.Name = "bunifuButton3";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.BorderRadius = 20;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.bunifuButton3.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 20;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.bunifuButton3.OnPressedState = stateProperties6;
            this.bunifuButton3.Size = new System.Drawing.Size(128, 45);
            this.bunifuButton3.TabIndex = 17;
            this.bunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton3.TextMarginLeft = 0;
            this.bunifuButton3.UseDefaultRadiusAndThickness = true;
            this.bunifuButton3.Click += new System.EventHandler(this.BunifuButton3_Click);
            // 
            // bunifuButton4
            // 
            this.bunifuButton4.AllowToggling = false;
            this.bunifuButton4.AnimationSpeed = 200;
            this.bunifuButton4.AutoGenerateColors = false;
            this.bunifuButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton4.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton4.BackgroundImage")));
            this.bunifuButton4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.ButtonText = "Acceuil";
            this.bunifuButton4.ButtonTextMarginLeft = 0;
            this.bunifuButton4.ColorContrastOnClick = 45;
            this.bunifuButton4.ColorContrastOnHover = 45;
            this.bunifuButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.bunifuButton4.CustomizableEdges = borderEdges4;
            this.bunifuButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton4.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton4.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton4.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton4.IconMarginLeft = 11;
            this.bunifuButton4.IconPadding = 10;
            this.bunifuButton4.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton4.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton4.IdleBorderRadius = 20;
            this.bunifuButton4.IdleBorderThickness = 1;
            this.bunifuButton4.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton4.IdleIconLeftImage = null;
            this.bunifuButton4.IdleIconRightImage = null;
            this.bunifuButton4.IndicateFocus = false;
            this.bunifuButton4.Location = new System.Drawing.Point(57, 491);
            this.bunifuButton4.Name = "bunifuButton4";
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.BorderRadius = 20;
            stateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties7.BorderThickness = 1;
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.ForeColor = System.Drawing.Color.White;
            stateProperties7.IconLeftImage = null;
            stateProperties7.IconRightImage = null;
            this.bunifuButton4.onHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.BorderRadius = 20;
            stateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties8.BorderThickness = 1;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.IconLeftImage = null;
            stateProperties8.IconRightImage = null;
            this.bunifuButton4.OnPressedState = stateProperties8;
            this.bunifuButton4.Size = new System.Drawing.Size(128, 45);
            this.bunifuButton4.TabIndex = 19;
            this.bunifuButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton4.TextMarginLeft = 0;
            this.bunifuButton4.UseDefaultRadiusAndThickness = true;
            this.bunifuButton4.Click += new System.EventHandler(this.BunifuButton4_Click);
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(378, 32);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(909, 514);
            this.bunifuDataGridView1.TabIndex = 20;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BunifuDataGridView1_CellContentClick);
            // 
            // Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1299, 567);
            this.Controls.Add(this.bunifuDataGridView1);
            this.Controls.Add(this.bunifuButton4);
            this.Controls.Add(this.bunifuButton3);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.uniteDeMesure);
            this.Controls.Add(this.majoration);
            this.Controls.Add(this.categorie);
            this.Controls.Add(this.quantiteMin);
            this.Controls.Add(this.quantite);
            this.Controls.Add(this.prixTtc);
            this.Controls.Add(this.tva);
            this.Controls.Add(this.prixHt);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Article";
            this.Text = "Article";
            this.Load += new System.EventHandler(this.Article_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox code;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox designation;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prixHt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tva;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prixTtc;
        private Bunifu.Framework.UI.BunifuMaterialTextbox quantite;
        private Bunifu.Framework.UI.BunifuMaterialTextbox quantiteMin;
        private System.Windows.Forms.ComboBox categorie;
        private System.Windows.Forms.ComboBox majoration;
        private System.Windows.Forms.ComboBox uniteDeMesure;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton4;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
    }
}