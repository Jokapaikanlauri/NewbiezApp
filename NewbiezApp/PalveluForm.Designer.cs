namespace NewbiezApp
{
    partial class PalveluForm
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
            this.logopb = new System.Windows.Forms.PictureBox();
            this.miniAsiakastiedotpb = new System.Windows.Forms.PictureBox();
            this.miniMokitpb = new System.Windows.Forms.PictureBox();
            this.miniVarauksetpb = new System.Windows.Forms.PictureBox();
            this.miniLaskutuspb = new System.Windows.Forms.PictureBox();
            this.palvelutIDPalvelulbl = new System.Windows.Forms.Label();
            this.alueIDPalvelulbl = new System.Windows.Forms.Label();
            this.nimiPalvelulbl = new System.Windows.Forms.Label();
            this.tyyppiPalvelulbl = new System.Windows.Forms.Label();
            this.kuvausPalvelulbl = new System.Windows.Forms.Label();
            this.hintaPalvelulbl = new System.Windows.Forms.Label();
            this.alvPalvelulbl = new System.Windows.Forms.Label();
            this.kuvausPalvelutb = new System.Windows.Forms.TextBox();
            this.palveluIDPalvelutb = new System.Windows.Forms.TextBox();
            this.nimiPalvelutb = new System.Windows.Forms.TextBox();
            this.tyyppiPalvelutb = new System.Windows.Forms.TextBox();
            this.palveluDgv = new System.Windows.Forms.DataGridView();
            this.palveluIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alueIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyyppiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varauksenPalvelutsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addPalvelubtn = new System.Windows.Forms.Button();
            this.editPalvelubtn = new System.Windows.Forms.Button();
            this.getPalvelubtn = new System.Windows.Forms.Button();
            this.alvPalveluNum = new System.Windows.Forms.NumericUpDown();
            this.hintaPalveluNum = new System.Windows.Forms.NumericUpDown();
            this.palveluAlueCb = new System.Windows.Forms.ComboBox();
            this.refreshPalveluBtn = new System.Windows.Forms.Button();
            this.delPalveluBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniAsiakastiedotpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMokitpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniVarauksetpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniLaskutuspb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alvPalveluNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hintaPalveluNum)).BeginInit();
            this.SuspendLayout();
            // 
            // logopb
            // 
            this.logopb.BackColor = System.Drawing.Color.Transparent;
            this.logopb.BackgroundImage = global::NewbiezApp.Properties.Resources.vnlogo;
            this.logopb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logopb.Location = new System.Drawing.Point(12, 12);
            this.logopb.Name = "logopb";
            this.logopb.Size = new System.Drawing.Size(90, 93);
            this.logopb.TabIndex = 2;
            this.logopb.TabStop = false;
            this.logopb.Click += new System.EventHandler(this.logopb_Click);
            // 
            // miniAsiakastiedotpb
            // 
            this.miniAsiakastiedotpb.BackColor = System.Drawing.Color.Transparent;
            this.miniAsiakastiedotpb.BackgroundImage = global::NewbiezApp.Properties.Resources.icons8_business_group_96_1_;
            this.miniAsiakastiedotpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniAsiakastiedotpb.Location = new System.Drawing.Point(1000, 12);
            this.miniAsiakastiedotpb.Name = "miniAsiakastiedotpb";
            this.miniAsiakastiedotpb.Size = new System.Drawing.Size(68, 69);
            this.miniAsiakastiedotpb.TabIndex = 8;
            this.miniAsiakastiedotpb.TabStop = false;
            this.miniAsiakastiedotpb.Click += new System.EventHandler(this.miniAsiakastiedotpb_Click);
            // 
            // miniMokitpb
            // 
            this.miniMokitpb.BackColor = System.Drawing.Color.Transparent;
            this.miniMokitpb.BackgroundImage = global::NewbiezApp.Properties.Resources.icons8_country_house_96;
            this.miniMokitpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniMokitpb.Location = new System.Drawing.Point(1090, 12);
            this.miniMokitpb.Name = "miniMokitpb";
            this.miniMokitpb.Size = new System.Drawing.Size(72, 69);
            this.miniMokitpb.TabIndex = 9;
            this.miniMokitpb.TabStop = false;
            this.miniMokitpb.Click += new System.EventHandler(this.miniMokitpb_Click);
            // 
            // miniVarauksetpb
            // 
            this.miniVarauksetpb.BackColor = System.Drawing.Color.Transparent;
            this.miniVarauksetpb.BackgroundImage = global::NewbiezApp.Properties.Resources.icons8_briefcase_96;
            this.miniVarauksetpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniVarauksetpb.Location = new System.Drawing.Point(1180, 12);
            this.miniVarauksetpb.Name = "miniVarauksetpb";
            this.miniVarauksetpb.Size = new System.Drawing.Size(73, 69);
            this.miniVarauksetpb.TabIndex = 10;
            this.miniVarauksetpb.TabStop = false;
            this.miniVarauksetpb.Click += new System.EventHandler(this.miniVarauksetpb_Click);
            // 
            // miniLaskutuspb
            // 
            this.miniLaskutuspb.BackColor = System.Drawing.Color.Transparent;
            this.miniLaskutuspb.BackgroundImage = global::NewbiezApp.Properties.Resources.icons8_check_dollar_96_1_;
            this.miniLaskutuspb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniLaskutuspb.Location = new System.Drawing.Point(910, 12);
            this.miniLaskutuspb.Name = "miniLaskutuspb";
            this.miniLaskutuspb.Size = new System.Drawing.Size(70, 69);
            this.miniLaskutuspb.TabIndex = 14;
            this.miniLaskutuspb.TabStop = false;
            this.miniLaskutuspb.Click += new System.EventHandler(this.miniLaskutuspb_Click);
            // 
            // palvelutIDPalvelulbl
            // 
            this.palvelutIDPalvelulbl.AutoSize = true;
            this.palvelutIDPalvelulbl.BackColor = System.Drawing.Color.Transparent;
            this.palvelutIDPalvelulbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.palvelutIDPalvelulbl.Location = new System.Drawing.Point(147, 128);
            this.palvelutIDPalvelulbl.Name = "palvelutIDPalvelulbl";
            this.palvelutIDPalvelulbl.Size = new System.Drawing.Size(59, 15);
            this.palvelutIDPalvelulbl.TabIndex = 15;
            this.palvelutIDPalvelulbl.Text = "Palvelu ID";
            // 
            // alueIDPalvelulbl
            // 
            this.alueIDPalvelulbl.AutoSize = true;
            this.alueIDPalvelulbl.BackColor = System.Drawing.Color.Transparent;
            this.alueIDPalvelulbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.alueIDPalvelulbl.Location = new System.Drawing.Point(147, 164);
            this.alueIDPalvelulbl.Name = "alueIDPalvelulbl";
            this.alueIDPalvelulbl.Size = new System.Drawing.Size(31, 15);
            this.alueIDPalvelulbl.TabIndex = 16;
            this.alueIDPalvelulbl.Text = "Alue";
            // 
            // nimiPalvelulbl
            // 
            this.nimiPalvelulbl.AutoSize = true;
            this.nimiPalvelulbl.BackColor = System.Drawing.Color.Transparent;
            this.nimiPalvelulbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nimiPalvelulbl.Location = new System.Drawing.Point(147, 201);
            this.nimiPalvelulbl.Name = "nimiPalvelulbl";
            this.nimiPalvelulbl.Size = new System.Drawing.Size(33, 15);
            this.nimiPalvelulbl.TabIndex = 17;
            this.nimiPalvelulbl.Text = "Nimi";
            // 
            // tyyppiPalvelulbl
            // 
            this.tyyppiPalvelulbl.AutoSize = true;
            this.tyyppiPalvelulbl.BackColor = System.Drawing.Color.Transparent;
            this.tyyppiPalvelulbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tyyppiPalvelulbl.Location = new System.Drawing.Point(147, 239);
            this.tyyppiPalvelulbl.Name = "tyyppiPalvelulbl";
            this.tyyppiPalvelulbl.Size = new System.Drawing.Size(41, 15);
            this.tyyppiPalvelulbl.TabIndex = 18;
            this.tyyppiPalvelulbl.Text = "Tyyppi";
            // 
            // kuvausPalvelulbl
            // 
            this.kuvausPalvelulbl.AutoSize = true;
            this.kuvausPalvelulbl.BackColor = System.Drawing.Color.Transparent;
            this.kuvausPalvelulbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kuvausPalvelulbl.Location = new System.Drawing.Point(408, 127);
            this.kuvausPalvelulbl.Name = "kuvausPalvelulbl";
            this.kuvausPalvelulbl.Size = new System.Drawing.Size(45, 15);
            this.kuvausPalvelulbl.TabIndex = 19;
            this.kuvausPalvelulbl.Text = "Kuvaus";
            // 
            // hintaPalvelulbl
            // 
            this.hintaPalvelulbl.AutoSize = true;
            this.hintaPalvelulbl.BackColor = System.Drawing.Color.Transparent;
            this.hintaPalvelulbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hintaPalvelulbl.Location = new System.Drawing.Point(911, 169);
            this.hintaPalvelulbl.Name = "hintaPalvelulbl";
            this.hintaPalvelulbl.Size = new System.Drawing.Size(36, 15);
            this.hintaPalvelulbl.TabIndex = 20;
            this.hintaPalvelulbl.Text = "Hinta";
            // 
            // alvPalvelulbl
            // 
            this.alvPalvelulbl.AutoSize = true;
            this.alvPalvelulbl.BackColor = System.Drawing.Color.Transparent;
            this.alvPalvelulbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.alvPalvelulbl.Location = new System.Drawing.Point(928, 128);
            this.alvPalvelulbl.Name = "alvPalvelulbl";
            this.alvPalvelulbl.Size = new System.Drawing.Size(27, 15);
            this.alvPalvelulbl.TabIndex = 21;
            this.alvPalvelulbl.Text = "ALV";
            // 
            // kuvausPalvelutb
            // 
            this.kuvausPalvelutb.Location = new System.Drawing.Point(469, 124);
            this.kuvausPalvelutb.MaxLength = 255;
            this.kuvausPalvelutb.Multiline = true;
            this.kuvausPalvelutb.Name = "kuvausPalvelutb";
            this.kuvausPalvelutb.Size = new System.Drawing.Size(400, 135);
            this.kuvausPalvelutb.TabIndex = 5;
            // 
            // palveluIDPalvelutb
            // 
            this.palveluIDPalvelutb.Location = new System.Drawing.Point(208, 125);
            this.palveluIDPalvelutb.Name = "palveluIDPalvelutb";
            this.palveluIDPalvelutb.Size = new System.Drawing.Size(169, 23);
            this.palveluIDPalvelutb.TabIndex = 1;
            // 
            // nimiPalvelutb
            // 
            this.nimiPalvelutb.Location = new System.Drawing.Point(208, 198);
            this.nimiPalvelutb.MaxLength = 40;
            this.nimiPalvelutb.Name = "nimiPalvelutb";
            this.nimiPalvelutb.Size = new System.Drawing.Size(169, 23);
            this.nimiPalvelutb.TabIndex = 3;
            // 
            // tyyppiPalvelutb
            // 
            this.tyyppiPalvelutb.Location = new System.Drawing.Point(208, 236);
            this.tyyppiPalvelutb.MaxLength = 11;
            this.tyyppiPalvelutb.Name = "tyyppiPalvelutb";
            this.tyyppiPalvelutb.Size = new System.Drawing.Size(169, 23);
            this.tyyppiPalvelutb.TabIndex = 4;
            this.tyyppiPalvelutb.TextChanged += new System.EventHandler(this.tyyppiPalvelutb_TextChanged);
            // 
            // palveluDgv
            // 
            this.palveluDgv.AutoGenerateColumns = false;
            this.palveluDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.palveluDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.palveluDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.palveluDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.palveluIdDataGridViewTextBoxColumn,
            this.nimiDataGridViewTextBoxColumn,
            this.alueIdDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.tyyppiDataGridViewTextBoxColumn,
            this.hintaDataGridViewTextBoxColumn,
            this.alvDataGridViewTextBoxColumn,
            this.varauksenPalvelutsDataGridViewTextBoxColumn});
            this.palveluDgv.DataSource = this.palveluBindingSource;
            this.palveluDgv.Location = new System.Drawing.Point(12, 391);
            this.palveluDgv.Name = "palveluDgv";
            this.palveluDgv.RowTemplate.Height = 25;
            this.palveluDgv.Size = new System.Drawing.Size(1260, 294);
            this.palveluDgv.TabIndex = 32;
            this.palveluDgv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.palveluDgv_MouseDoubleClick);
            // 
            // palveluIdDataGridViewTextBoxColumn
            // 
            this.palveluIdDataGridViewTextBoxColumn.DataPropertyName = "PalveluId";
            this.palveluIdDataGridViewTextBoxColumn.HeaderText = "PalveluId";
            this.palveluIdDataGridViewTextBoxColumn.Name = "palveluIdDataGridViewTextBoxColumn";
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "Nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "Nimi";
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
            // 
            // alueIdDataGridViewTextBoxColumn
            // 
            this.alueIdDataGridViewTextBoxColumn.DataPropertyName = "AlueId";
            this.alueIdDataGridViewTextBoxColumn.HeaderText = "AlueId";
            this.alueIdDataGridViewTextBoxColumn.Name = "alueIdDataGridViewTextBoxColumn";
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "Kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "Kuvaus";
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            // 
            // tyyppiDataGridViewTextBoxColumn
            // 
            this.tyyppiDataGridViewTextBoxColumn.DataPropertyName = "Tyyppi";
            this.tyyppiDataGridViewTextBoxColumn.HeaderText = "Tyyppi";
            this.tyyppiDataGridViewTextBoxColumn.Name = "tyyppiDataGridViewTextBoxColumn";
            // 
            // hintaDataGridViewTextBoxColumn
            // 
            this.hintaDataGridViewTextBoxColumn.DataPropertyName = "Hinta";
            this.hintaDataGridViewTextBoxColumn.HeaderText = "Hinta";
            this.hintaDataGridViewTextBoxColumn.Name = "hintaDataGridViewTextBoxColumn";
            // 
            // alvDataGridViewTextBoxColumn
            // 
            this.alvDataGridViewTextBoxColumn.DataPropertyName = "Alv";
            this.alvDataGridViewTextBoxColumn.HeaderText = "Alv";
            this.alvDataGridViewTextBoxColumn.Name = "alvDataGridViewTextBoxColumn";
            // 
            // varauksenPalvelutsDataGridViewTextBoxColumn
            // 
            this.varauksenPalvelutsDataGridViewTextBoxColumn.DataPropertyName = "VarauksenPalveluts";
            this.varauksenPalvelutsDataGridViewTextBoxColumn.HeaderText = "VarauksenPalvelut";
            this.varauksenPalvelutsDataGridViewTextBoxColumn.Name = "varauksenPalvelutsDataGridViewTextBoxColumn";
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataSource = typeof(NewbiezApp.Classes.Palvelu);
            // 
            // addPalvelubtn
            // 
            this.addPalvelubtn.Location = new System.Drawing.Point(1090, 124);
            this.addPalvelubtn.Name = "addPalvelubtn";
            this.addPalvelubtn.Size = new System.Drawing.Size(75, 23);
            this.addPalvelubtn.TabIndex = 8;
            this.addPalvelubtn.Text = "Lisää";
            this.addPalvelubtn.UseVisualStyleBackColor = true;
            this.addPalvelubtn.Click += new System.EventHandler(this.addPalvelubtn_Click);
            // 
            // editPalvelubtn
            // 
            this.editPalvelubtn.Location = new System.Drawing.Point(1090, 208);
            this.editPalvelubtn.Name = "editPalvelubtn";
            this.editPalvelubtn.Size = new System.Drawing.Size(75, 23);
            this.editPalvelubtn.TabIndex = 10;
            this.editPalvelubtn.Text = "Muokkaa";
            this.editPalvelubtn.UseVisualStyleBackColor = true;
            this.editPalvelubtn.Click += new System.EventHandler(this.editPalvelubtn_Click);
            // 
            // getPalvelubtn
            // 
            this.getPalvelubtn.Location = new System.Drawing.Point(1090, 165);
            this.getPalvelubtn.Name = "getPalvelubtn";
            this.getPalvelubtn.Size = new System.Drawing.Size(75, 23);
            this.getPalvelubtn.TabIndex = 9;
            this.getPalvelubtn.Text = "Hae";
            this.getPalvelubtn.UseVisualStyleBackColor = true;
            this.getPalvelubtn.Click += new System.EventHandler(this.getPalvelubtn_Click);
            // 
            // alvPalveluNum
            // 
            this.alvPalveluNum.DecimalPlaces = 2;
            this.alvPalveluNum.Location = new System.Drawing.Point(961, 124);
            this.alvPalveluNum.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.alvPalveluNum.Name = "alvPalveluNum";
            this.alvPalveluNum.Size = new System.Drawing.Size(120, 23);
            this.alvPalveluNum.TabIndex = 6;
            // 
            // hintaPalveluNum
            // 
            this.hintaPalveluNum.DecimalPlaces = 2;
            this.hintaPalveluNum.Location = new System.Drawing.Point(961, 165);
            this.hintaPalveluNum.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.hintaPalveluNum.Name = "hintaPalveluNum";
            this.hintaPalveluNum.Size = new System.Drawing.Size(120, 23);
            this.hintaPalveluNum.TabIndex = 7;
            // 
            // palveluAlueCb
            // 
            this.palveluAlueCb.FormattingEnabled = true;
            this.palveluAlueCb.Location = new System.Drawing.Point(208, 161);
            this.palveluAlueCb.Name = "palveluAlueCb";
            this.palveluAlueCb.Size = new System.Drawing.Size(169, 23);
            this.palveluAlueCb.TabIndex = 2;
            // 
            // refreshPalveluBtn
            // 
            this.refreshPalveluBtn.Location = new System.Drawing.Point(1090, 253);
            this.refreshPalveluBtn.Name = "refreshPalveluBtn";
            this.refreshPalveluBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshPalveluBtn.TabIndex = 12;
            this.refreshPalveluBtn.Text = "Päivitä";
            this.refreshPalveluBtn.UseVisualStyleBackColor = true;
            this.refreshPalveluBtn.Click += new System.EventHandler(this.refreshPalveluBtn_Click);
            // 
            // delPalveluBtn
            // 
            this.delPalveluBtn.Location = new System.Drawing.Point(1090, 297);
            this.delPalveluBtn.Name = "delPalveluBtn";
            this.delPalveluBtn.Size = new System.Drawing.Size(75, 23);
            this.delPalveluBtn.TabIndex = 33;
            this.delPalveluBtn.Text = "Poista";
            this.delPalveluBtn.UseVisualStyleBackColor = true;
            this.delPalveluBtn.Click += new System.EventHandler(this.delPalveluBtn_Click);
            // 
            // PalveluForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewbiezApp.Properties.Resources.sivutaustat1x;
            this.ClientSize = new System.Drawing.Size(1284, 697);
            this.Controls.Add(this.delPalveluBtn);
            this.Controls.Add(this.refreshPalveluBtn);
            this.Controls.Add(this.palveluAlueCb);
            this.Controls.Add(this.hintaPalveluNum);
            this.Controls.Add(this.alvPalveluNum);
            this.Controls.Add(this.getPalvelubtn);
            this.Controls.Add(this.editPalvelubtn);
            this.Controls.Add(this.addPalvelubtn);
            this.Controls.Add(this.palveluDgv);
            this.Controls.Add(this.tyyppiPalvelutb);
            this.Controls.Add(this.nimiPalvelutb);
            this.Controls.Add(this.palveluIDPalvelutb);
            this.Controls.Add(this.kuvausPalvelutb);
            this.Controls.Add(this.alvPalvelulbl);
            this.Controls.Add(this.hintaPalvelulbl);
            this.Controls.Add(this.kuvausPalvelulbl);
            this.Controls.Add(this.tyyppiPalvelulbl);
            this.Controls.Add(this.nimiPalvelulbl);
            this.Controls.Add(this.alueIDPalvelulbl);
            this.Controls.Add(this.palvelutIDPalvelulbl);
            this.Controls.Add(this.miniLaskutuspb);
            this.Controls.Add(this.miniVarauksetpb);
            this.Controls.Add(this.miniMokitpb);
            this.Controls.Add(this.miniAsiakastiedotpb);
            this.Controls.Add(this.logopb);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 736);
            this.MinimumSize = new System.Drawing.Size(1300, 736);
            this.Name = "PalveluForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palvelut";
            this.Load += new System.EventHandler(this.PalveluForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniAsiakastiedotpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMokitpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniVarauksetpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniLaskutuspb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alvPalveluNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hintaPalveluNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox logopb;
        private PictureBox miniAsiakastiedotpb;
        private PictureBox miniMokitpb;
        private PictureBox miniVarauksetpb;
        private PictureBox miniLaskutuspb;
        private Label palvelutIDPalvelulbl;
        private Label alueIDPalvelulbl;
        private Label nimiPalvelulbl;
        private Label tyyppiPalvelulbl;
        private Label kuvausPalvelulbl;
        private Label hintaPalvelulbl;
        private Label alvPalvelulbl;
        private TextBox kuvausPalvelutb;
        private TextBox palveluIDPalvelutb;
        private TextBox nimiPalvelutb;
        private TextBox tyyppiPalvelutb;
        private DataGridView palveluDgv;
        private Button addPalvelubtn;
        private Button editPalvelubtn;
        private Button getPalvelubtn;
        private BindingSource palveluBindingSource;
        private NumericUpDown alvPalveluNum;
        private NumericUpDown hintaPalveluNum;
        private ComboBox palveluAlueCb;
        private DataGridViewTextBoxColumn palveluIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alueIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tyyppiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hintaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alvDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn varauksenPalvelutsDataGridViewTextBoxColumn;
        private Button refreshPalveluBtn;
        private Button delPalveluBtn;
    }
}