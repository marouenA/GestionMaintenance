namespace GestionDeMaintenance
{
    partial class Machine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Machine));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges33 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties65 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties66 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges34 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties67 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties68 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges35 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties69 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties70 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges36 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties71 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties72 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.localM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codeM = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.designationM = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.numSerieM = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.etatM = new System.Windows.Forms.ComboBox();
            this.marqueM = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AcquisitionM = new Bunifu.Framework.UI.BunifuDatepicker();
            this.miseEnServiceM = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuButton4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // localM
            // 
            this.localM.FormattingEnabled = true;
            this.localM.Items.AddRange(new object[] {
            "Localisation",
            "Atelier",
            "Labo",
            "Stock"});
            this.localM.Location = new System.Drawing.Point(195, 164);
            this.localM.Name = "localM";
            this.localM.Size = new System.Drawing.Size(160, 21);
            this.localM.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(115, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Machines";
            // 
            // codeM
            // 
            this.codeM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.codeM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.codeM.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.codeM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeM.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.codeM.ForeColor = System.Drawing.Color.White;
            this.codeM.HintForeColor = System.Drawing.Color.Empty;
            this.codeM.HintText = "";
            this.codeM.isPassword = false;
            this.codeM.LineFocusedColor = System.Drawing.Color.White;
            this.codeM.LineIdleColor = System.Drawing.Color.Gray;
            this.codeM.LineMouseHoverColor = System.Drawing.Color.White;
            this.codeM.LineThickness = 3;
            this.codeM.Location = new System.Drawing.Point(14, 91);
            this.codeM.Margin = new System.Windows.Forms.Padding(4);
            this.codeM.MaxLength = 32767;
            this.codeM.Name = "codeM";
            this.codeM.Size = new System.Drawing.Size(160, 33);
            this.codeM.TabIndex = 14;
            this.codeM.Text = "Code";
            this.codeM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.codeM.Enter += new System.EventHandler(this.CodeM_Enter);
            this.codeM.Leave += new System.EventHandler(this.CodeM_Leave);
            // 
            // designationM
            // 
            this.designationM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.designationM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.designationM.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.designationM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.designationM.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.designationM.ForeColor = System.Drawing.Color.White;
            this.designationM.HintForeColor = System.Drawing.Color.Empty;
            this.designationM.HintText = "";
            this.designationM.isPassword = false;
            this.designationM.LineFocusedColor = System.Drawing.Color.White;
            this.designationM.LineIdleColor = System.Drawing.Color.Gray;
            this.designationM.LineMouseHoverColor = System.Drawing.Color.White;
            this.designationM.LineThickness = 3;
            this.designationM.Location = new System.Drawing.Point(195, 91);
            this.designationM.Margin = new System.Windows.Forms.Padding(4);
            this.designationM.MaxLength = 32767;
            this.designationM.Name = "designationM";
            this.designationM.Size = new System.Drawing.Size(160, 33);
            this.designationM.TabIndex = 17;
            this.designationM.Text = "Designation";
            this.designationM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.designationM.Enter += new System.EventHandler(this.DesignationM_Enter);
            this.designationM.Leave += new System.EventHandler(this.DesignationM_Leave);
            // 
            // numSerieM
            // 
            this.numSerieM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.numSerieM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.numSerieM.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.numSerieM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSerieM.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.numSerieM.ForeColor = System.Drawing.Color.White;
            this.numSerieM.HintForeColor = System.Drawing.Color.Empty;
            this.numSerieM.HintText = "";
            this.numSerieM.isPassword = false;
            this.numSerieM.LineFocusedColor = System.Drawing.Color.White;
            this.numSerieM.LineIdleColor = System.Drawing.Color.Gray;
            this.numSerieM.LineMouseHoverColor = System.Drawing.Color.White;
            this.numSerieM.LineThickness = 3;
            this.numSerieM.Location = new System.Drawing.Point(14, 152);
            this.numSerieM.Margin = new System.Windows.Forms.Padding(4);
            this.numSerieM.MaxLength = 32767;
            this.numSerieM.Name = "numSerieM";
            this.numSerieM.Size = new System.Drawing.Size(160, 33);
            this.numSerieM.TabIndex = 18;
            this.numSerieM.Text = "N° Serie";
            this.numSerieM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numSerieM.Enter += new System.EventHandler(this.NumSerieM_Enter);
            this.numSerieM.Leave += new System.EventHandler(this.NumSerieM_Leave);
            // 
            // etatM
            // 
            this.etatM.FormattingEnabled = true;
            this.etatM.Items.AddRange(new object[] {
            "Etat",
            "Neuf",
            "Occasion",
            "En panne"});
            this.etatM.Location = new System.Drawing.Point(195, 239);
            this.etatM.Name = "etatM";
            this.etatM.Size = new System.Drawing.Size(160, 21);
            this.etatM.TabIndex = 19;
            // 
            // marqueM
            // 
            this.marqueM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.marqueM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.marqueM.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.marqueM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.marqueM.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.marqueM.ForeColor = System.Drawing.Color.White;
            this.marqueM.HintForeColor = System.Drawing.Color.Empty;
            this.marqueM.HintText = "";
            this.marqueM.isPassword = false;
            this.marqueM.LineFocusedColor = System.Drawing.Color.White;
            this.marqueM.LineIdleColor = System.Drawing.Color.Gray;
            this.marqueM.LineMouseHoverColor = System.Drawing.Color.White;
            this.marqueM.LineThickness = 3;
            this.marqueM.Location = new System.Drawing.Point(13, 227);
            this.marqueM.Margin = new System.Windows.Forms.Padding(4);
            this.marqueM.MaxLength = 32767;
            this.marqueM.Name = "marqueM";
            this.marqueM.Size = new System.Drawing.Size(160, 33);
            this.marqueM.TabIndex = 20;
            this.marqueM.Text = "Marque";
            this.marqueM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.marqueM.Enter += new System.EventHandler(this.MarqueM_Enter);
            this.marqueM.Leave += new System.EventHandler(this.MarqueM_Leave);
            // 
            // AcquisitionM
            // 
            this.AcquisitionM.BackColor = System.Drawing.Color.White;
            this.AcquisitionM.BorderRadius = 0;
            this.AcquisitionM.ForeColor = System.Drawing.Color.Black;
            this.AcquisitionM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AcquisitionM.FormatCustom = null;
            this.AcquisitionM.Location = new System.Drawing.Point(14, 306);
            this.AcquisitionM.Name = "AcquisitionM";
            this.AcquisitionM.Size = new System.Drawing.Size(160, 36);
            this.AcquisitionM.TabIndex = 21;
            this.AcquisitionM.Value = new System.DateTime(2020, 12, 17, 22, 11, 11, 923);
            // 
            // miseEnServiceM
            // 
            this.miseEnServiceM.BackColor = System.Drawing.Color.White;
            this.miseEnServiceM.BorderRadius = 0;
            this.miseEnServiceM.ForeColor = System.Drawing.Color.Black;
            this.miseEnServiceM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.miseEnServiceM.FormatCustom = null;
            this.miseEnServiceM.Location = new System.Drawing.Point(195, 306);
            this.miseEnServiceM.Name = "miseEnServiceM";
            this.miseEnServiceM.Size = new System.Drawing.Size(160, 36);
            this.miseEnServiceM.TabIndex = 22;
            this.miseEnServiceM.Value = new System.DateTime(2020, 12, 17, 22, 11, 11, 923);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Acquisition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mise en service";
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
            borderEdges33.BottomLeft = true;
            borderEdges33.BottomRight = true;
            borderEdges33.TopLeft = true;
            borderEdges33.TopRight = true;
            this.bunifuButton4.CustomizableEdges = borderEdges33;
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
            this.bunifuButton4.Location = new System.Drawing.Point(46, 459);
            this.bunifuButton4.Name = "bunifuButton4";
            stateProperties65.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties65.BorderRadius = 20;
            stateProperties65.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties65.BorderThickness = 1;
            stateProperties65.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties65.ForeColor = System.Drawing.Color.White;
            stateProperties65.IconLeftImage = null;
            stateProperties65.IconRightImage = null;
            this.bunifuButton4.onHoverState = stateProperties65;
            stateProperties66.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties66.BorderRadius = 20;
            stateProperties66.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties66.BorderThickness = 1;
            stateProperties66.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties66.ForeColor = System.Drawing.Color.White;
            stateProperties66.IconLeftImage = null;
            stateProperties66.IconRightImage = null;
            this.bunifuButton4.OnPressedState = stateProperties66;
            this.bunifuButton4.Size = new System.Drawing.Size(128, 45);
            this.bunifuButton4.TabIndex = 31;
            this.bunifuButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton4.TextMarginLeft = 0;
            this.bunifuButton4.UseDefaultRadiusAndThickness = true;
            this.bunifuButton4.Click += new System.EventHandler(this.BunifuButton4_Click);
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
            borderEdges34.BottomLeft = true;
            borderEdges34.BottomRight = true;
            borderEdges34.TopLeft = true;
            borderEdges34.TopRight = true;
            this.bunifuButton3.CustomizableEdges = borderEdges34;
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
            this.bunifuButton3.Location = new System.Drawing.Point(195, 459);
            this.bunifuButton3.Name = "bunifuButton3";
            stateProperties67.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties67.BorderRadius = 20;
            stateProperties67.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties67.BorderThickness = 1;
            stateProperties67.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties67.ForeColor = System.Drawing.Color.White;
            stateProperties67.IconLeftImage = null;
            stateProperties67.IconRightImage = null;
            this.bunifuButton3.onHoverState = stateProperties67;
            stateProperties68.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties68.BorderRadius = 20;
            stateProperties68.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties68.BorderThickness = 1;
            stateProperties68.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties68.ForeColor = System.Drawing.Color.White;
            stateProperties68.IconLeftImage = null;
            stateProperties68.IconRightImage = null;
            this.bunifuButton3.OnPressedState = stateProperties68;
            this.bunifuButton3.Size = new System.Drawing.Size(128, 45);
            this.bunifuButton3.TabIndex = 30;
            this.bunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton3.TextMarginLeft = 0;
            this.bunifuButton3.UseDefaultRadiusAndThickness = true;
            this.bunifuButton3.Click += new System.EventHandler(this.BunifuButton3_Click);
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
            borderEdges35.BottomLeft = true;
            borderEdges35.BottomRight = true;
            borderEdges35.TopLeft = true;
            borderEdges35.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges35;
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
            this.bunifuButton2.Location = new System.Drawing.Point(195, 379);
            this.bunifuButton2.Name = "bunifuButton2";
            stateProperties69.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties69.BorderRadius = 20;
            stateProperties69.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties69.BorderThickness = 1;
            stateProperties69.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties69.ForeColor = System.Drawing.Color.White;
            stateProperties69.IconLeftImage = null;
            stateProperties69.IconRightImage = null;
            this.bunifuButton2.onHoverState = stateProperties69;
            stateProperties70.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties70.BorderRadius = 20;
            stateProperties70.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties70.BorderThickness = 1;
            stateProperties70.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties70.ForeColor = System.Drawing.Color.White;
            stateProperties70.IconLeftImage = null;
            stateProperties70.IconRightImage = null;
            this.bunifuButton2.OnPressedState = stateProperties70;
            this.bunifuButton2.Size = new System.Drawing.Size(128, 45);
            this.bunifuButton2.TabIndex = 29;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            this.bunifuButton2.Click += new System.EventHandler(this.BunifuButton2_Click);
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
            borderEdges36.BottomLeft = true;
            borderEdges36.BottomRight = true;
            borderEdges36.TopLeft = true;
            borderEdges36.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges36;
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
            this.bunifuButton1.Location = new System.Drawing.Point(43, 379);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties71.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties71.BorderRadius = 20;
            stateProperties71.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties71.BorderThickness = 1;
            stateProperties71.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties71.ForeColor = System.Drawing.Color.White;
            stateProperties71.IconLeftImage = null;
            stateProperties71.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties71;
            stateProperties72.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties72.BorderRadius = 20;
            stateProperties72.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties72.BorderThickness = 1;
            stateProperties72.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties72.ForeColor = System.Drawing.Color.White;
            stateProperties72.IconLeftImage = null;
            stateProperties72.IconRightImage = null;
            this.bunifuButton1.OnPressedState = stateProperties72;
            this.bunifuButton1.Size = new System.Drawing.Size(131, 45);
            this.bunifuButton1.TabIndex = 28;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.BunifuButton1_Click);
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.bunifuDataGridView1.ColumnHeadersHeight = 40;
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
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle27;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(374, 41);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(913, 514);
            this.bunifuDataGridView1.TabIndex = 32;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BunifuDataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1269, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.Label4_Click_1);
            // 
            // Machine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1299, 567);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuDataGridView1);
            this.Controls.Add(this.bunifuButton4);
            this.Controls.Add(this.bunifuButton3);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.miseEnServiceM);
            this.Controls.Add(this.AcquisitionM);
            this.Controls.Add(this.marqueM);
            this.Controls.Add(this.etatM);
            this.Controls.Add(this.numSerieM);
            this.Controls.Add(this.designationM);
            this.Controls.Add(this.localM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeM);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Machine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Machine";
            this.Load += new System.EventHandler(this.Machine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox localM;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox codeM;
        private Bunifu.Framework.UI.BunifuMaterialTextbox designationM;
        private Bunifu.Framework.UI.BunifuMaterialTextbox numSerieM;
        private System.Windows.Forms.ComboBox etatM;
        private Bunifu.Framework.UI.BunifuMaterialTextbox marqueM;
        private Bunifu.Framework.UI.BunifuDatepicker AcquisitionM;
        private Bunifu.Framework.UI.BunifuDatepicker miseEnServiceM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private System.Windows.Forms.Label label4;
    }
}