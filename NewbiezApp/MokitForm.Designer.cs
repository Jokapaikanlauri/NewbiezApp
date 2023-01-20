namespace NewbiezApp
{
    partial class MokitForm
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
            this.miniVarauksetpb = new System.Windows.Forms.PictureBox();
            this.miniAsiakastiedotpb = new System.Windows.Forms.PictureBox();
            this.miniLaskutuspb = new System.Windows.Forms.PictureBox();
            this.mokitDgv = new System.Windows.Forms.DataGridView();
            this.mokkiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alueIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteMokitbtn = new System.Windows.Forms.Button();
            this.getMokitbtn = new System.Windows.Forms.Button();
            this.addMokitbtn = new System.Windows.Forms.Button();
            this.osoiteMokitTb = new System.Windows.Forms.TextBox();
            this.mokkinimiTb = new System.Windows.Forms.TextBox();
            this.kuvausMokitTb = new System.Windows.Forms.TextBox();
            this.varusteluMokitTb = new System.Windows.Forms.TextBox();
            this.hlomaaraLbl = new System.Windows.Forms.Label();
            this.kuvausMokitlbl = new System.Windows.Forms.Label();
            this.postinroMokitlbl = new System.Windows.Forms.Label();
            this.osoiteMokitlbl = new System.Windows.Forms.Label();
            this.hintaMokitlbl = new System.Windows.Forms.Label();
            this.mokkinimiLbl = new System.Windows.Forms.Label();
            this.varusteluMokitlbl = new System.Windows.Forms.Label();
            this.aluenimiLbl = new System.Windows.Forms.Label();
            this.editMokitbtn = new System.Windows.Forms.Button();
            this.saveMokitbtn = new System.Windows.Forms.Button();
            this.miniPalvelupb = new System.Windows.Forms.PictureBox();
            this.alueMokitCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.postinroMokitTb = new System.Windows.Forms.TextBox();
            this.toimipaikkaMokitTb = new System.Windows.Forms.TextBox();
            this.hintaMokitnup = new System.Windows.Forms.NumericUpDown();
            this.hloMokitnup = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniVarauksetpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniAsiakastiedotpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniLaskutuspb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokitDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniPalvelupb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hintaMokitnup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hloMokitnup)).BeginInit();
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
            // miniAsiakastiedotpb
            // 
            this.miniAsiakastiedotpb.BackColor = System.Drawing.Color.Transparent;
            this.miniAsiakastiedotpb.BackgroundImage = global::NewbiezApp.Properties.Resources.icons8_business_group_96_1_;
            this.miniAsiakastiedotpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniAsiakastiedotpb.Location = new System.Drawing.Point(1090, 12);
            this.miniAsiakastiedotpb.Name = "miniAsiakastiedotpb";
            this.miniAsiakastiedotpb.Size = new System.Drawing.Size(68, 69);
            this.miniAsiakastiedotpb.TabIndex = 12;
            this.miniAsiakastiedotpb.TabStop = false;
            this.miniAsiakastiedotpb.Click += new System.EventHandler(this.miniAsiakastiedotpb_Click);
            // 
            // miniLaskutuspb
            // 
            this.miniLaskutuspb.BackColor = System.Drawing.Color.Transparent;
            this.miniLaskutuspb.BackgroundImage = global::NewbiezApp.Properties.Resources.icons8_check_dollar_96_1_;
            this.miniLaskutuspb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniLaskutuspb.Location = new System.Drawing.Point(1000, 12);
            this.miniLaskutuspb.Name = "miniLaskutuspb";
            this.miniLaskutuspb.Size = new System.Drawing.Size(70, 69);
            this.miniLaskutuspb.TabIndex = 13;
            this.miniLaskutuspb.TabStop = false;
            this.miniLaskutuspb.Click += new System.EventHandler(this.miniLaskutuspb_Click);
            // 
            // mokitDgv
            // 
            this.mokitDgv.AutoGenerateColumns = false;
            this.mokitDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mokitDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.mokitDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mokitDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.mokitDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mokitDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mokkiIdDataGridViewTextBoxColumn,
            this.alueIdDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.mokkinimiDataGridViewTextBoxColumn,
            this.katuosoiteDataGridViewTextBoxColumn,
            this.hintaDataGridViewTextBoxColumn});
            this.mokitDgv.DataSource = this.mokkiBindingSource;
            this.mokitDgv.Location = new System.Drawing.Point(12, 111);
            this.mokitDgv.Name = "mokitDgv";
            this.mokitDgv.RowTemplate.Height = 25;
            this.mokitDgv.Size = new System.Drawing.Size(655, 574);
            this.mokitDgv.TabIndex = 14;
            this.mokitDgv.DoubleClick += new System.EventHandler(this.mokitDgv_DoubleClick);
            // 
            // mokkiIdDataGridViewTextBoxColumn
            // 
            this.mokkiIdDataGridViewTextBoxColumn.DataPropertyName = "MokkiId";
            this.mokkiIdDataGridViewTextBoxColumn.HeaderText = "MokkiId";
            this.mokkiIdDataGridViewTextBoxColumn.Name = "mokkiIdDataGridViewTextBoxColumn";
            // 
            // alueIdDataGridViewTextBoxColumn
            // 
            this.alueIdDataGridViewTextBoxColumn.DataPropertyName = "AlueId";
            this.alueIdDataGridViewTextBoxColumn.HeaderText = "AlueId";
            this.alueIdDataGridViewTextBoxColumn.Name = "alueIdDataGridViewTextBoxColumn";
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "Postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "Postinro";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            // 
            // mokkinimiDataGridViewTextBoxColumn
            // 
            this.mokkinimiDataGridViewTextBoxColumn.DataPropertyName = "Mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.HeaderText = "Mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.Name = "mokkinimiDataGridViewTextBoxColumn";
            // 
            // katuosoiteDataGridViewTextBoxColumn
            // 
            this.katuosoiteDataGridViewTextBoxColumn.DataPropertyName = "Katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.HeaderText = "Katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.Name = "katuosoiteDataGridViewTextBoxColumn";
            // 
            // hintaDataGridViewTextBoxColumn
            // 
            this.hintaDataGridViewTextBoxColumn.DataPropertyName = "Hinta";
            this.hintaDataGridViewTextBoxColumn.HeaderText = "Hinta";
            this.hintaDataGridViewTextBoxColumn.Name = "hintaDataGridViewTextBoxColumn";
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataSource = typeof(NewbiezApp.Classes.Mokki);
            // 
            // deleteMokitbtn
            // 
            this.deleteMokitbtn.Location = new System.Drawing.Point(1138, 662);
            this.deleteMokitbtn.Name = "deleteMokitbtn";
            this.deleteMokitbtn.Size = new System.Drawing.Size(100, 23);
            this.deleteMokitbtn.TabIndex = 17;
            this.deleteMokitbtn.Text = "Poista";
            this.deleteMokitbtn.UseVisualStyleBackColor = true;
            this.deleteMokitbtn.Click += new System.EventHandler(this.deleteMokitbtn_Click);
            // 
            // getMokitbtn
            // 
            this.getMokitbtn.Location = new System.Drawing.Point(820, 662);
            this.getMokitbtn.Name = "getMokitbtn";
            this.getMokitbtn.Size = new System.Drawing.Size(100, 23);
            this.getMokitbtn.TabIndex = 16;
            this.getMokitbtn.Text = "Hae";
            this.getMokitbtn.UseVisualStyleBackColor = true;
            this.getMokitbtn.Click += new System.EventHandler(this.getMokitbtn_Click);
            // 
            // addMokitbtn
            // 
            this.addMokitbtn.Location = new System.Drawing.Point(714, 662);
            this.addMokitbtn.Name = "addMokitbtn";
            this.addMokitbtn.Size = new System.Drawing.Size(100, 23);
            this.addMokitbtn.TabIndex = 15;
            this.addMokitbtn.Text = "Lisää";
            this.addMokitbtn.UseVisualStyleBackColor = true;
            this.addMokitbtn.Click += new System.EventHandler(this.addMokitbtn_Click);
            // 
            // osoiteMokitTb
            // 
            this.osoiteMokitTb.Location = new System.Drawing.Point(764, 225);
            this.osoiteMokitTb.Name = "osoiteMokitTb";
            this.osoiteMokitTb.Size = new System.Drawing.Size(262, 23);
            this.osoiteMokitTb.TabIndex = 3;
            // 
            // mokkinimiTb
            // 
            this.mokkinimiTb.Location = new System.Drawing.Point(764, 138);
            this.mokkinimiTb.Name = "mokkinimiTb";
            this.mokkinimiTb.Size = new System.Drawing.Size(262, 23);
            this.mokkinimiTb.TabIndex = 1;
            // 
            // kuvausMokitTb
            // 
            this.kuvausMokitTb.Location = new System.Drawing.Point(764, 269);
            this.kuvausMokitTb.Multiline = true;
            this.kuvausMokitTb.Name = "kuvausMokitTb";
            this.kuvausMokitTb.Size = new System.Drawing.Size(262, 113);
            this.kuvausMokitTb.TabIndex = 4;
            // 
            // varusteluMokitTb
            // 
            this.varusteluMokitTb.Location = new System.Drawing.Point(764, 400);
            this.varusteluMokitTb.Multiline = true;
            this.varusteluMokitTb.Name = "varusteluMokitTb";
            this.varusteluMokitTb.Size = new System.Drawing.Size(262, 143);
            this.varusteluMokitTb.TabIndex = 5;
            // 
            // hlomaaraLbl
            // 
            this.hlomaaraLbl.BackColor = System.Drawing.Color.Transparent;
            this.hlomaaraLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hlomaaraLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hlomaaraLbl.Location = new System.Drawing.Point(1071, 270);
            this.hlomaaraLbl.Name = "hlomaaraLbl";
            this.hlomaaraLbl.Size = new System.Drawing.Size(85, 23);
            this.hlomaaraLbl.TabIndex = 28;
            this.hlomaaraLbl.Text = "Hlömäärä";
            this.hlomaaraLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kuvausMokitlbl
            // 
            this.kuvausMokitlbl.BackColor = System.Drawing.Color.Transparent;
            this.kuvausMokitlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kuvausMokitlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kuvausMokitlbl.Location = new System.Drawing.Point(673, 269);
            this.kuvausMokitlbl.Name = "kuvausMokitlbl";
            this.kuvausMokitlbl.Size = new System.Drawing.Size(85, 23);
            this.kuvausMokitlbl.TabIndex = 29;
            this.kuvausMokitlbl.Text = "Kuvaus";
            this.kuvausMokitlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // postinroMokitlbl
            // 
            this.postinroMokitlbl.BackColor = System.Drawing.Color.Transparent;
            this.postinroMokitlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postinroMokitlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.postinroMokitlbl.Location = new System.Drawing.Point(1068, 136);
            this.postinroMokitlbl.Name = "postinroMokitlbl";
            this.postinroMokitlbl.Size = new System.Drawing.Size(85, 23);
            this.postinroMokitlbl.TabIndex = 30;
            this.postinroMokitlbl.Text = "Postinumero";
            this.postinroMokitlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // osoiteMokitlbl
            // 
            this.osoiteMokitlbl.BackColor = System.Drawing.Color.Transparent;
            this.osoiteMokitlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.osoiteMokitlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.osoiteMokitlbl.Location = new System.Drawing.Point(673, 223);
            this.osoiteMokitlbl.Name = "osoiteMokitlbl";
            this.osoiteMokitlbl.Size = new System.Drawing.Size(85, 23);
            this.osoiteMokitlbl.TabIndex = 31;
            this.osoiteMokitlbl.Text = "Katuosoite";
            this.osoiteMokitlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hintaMokitlbl
            // 
            this.hintaMokitlbl.BackColor = System.Drawing.Color.Transparent;
            this.hintaMokitlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hintaMokitlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hintaMokitlbl.Location = new System.Drawing.Point(1070, 225);
            this.hintaMokitlbl.Name = "hintaMokitlbl";
            this.hintaMokitlbl.Size = new System.Drawing.Size(85, 23);
            this.hintaMokitlbl.TabIndex = 32;
            this.hintaMokitlbl.Text = "Hinta";
            this.hintaMokitlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mokkinimiLbl
            // 
            this.mokkinimiLbl.BackColor = System.Drawing.Color.Transparent;
            this.mokkinimiLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mokkinimiLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mokkinimiLbl.Location = new System.Drawing.Point(673, 136);
            this.mokkinimiLbl.Name = "mokkinimiLbl";
            this.mokkinimiLbl.Size = new System.Drawing.Size(85, 23);
            this.mokkinimiLbl.TabIndex = 33;
            this.mokkinimiLbl.Text = "Mökin nimi";
            this.mokkinimiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // varusteluMokitlbl
            // 
            this.varusteluMokitlbl.BackColor = System.Drawing.Color.Transparent;
            this.varusteluMokitlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.varusteluMokitlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.varusteluMokitlbl.Location = new System.Drawing.Point(673, 398);
            this.varusteluMokitlbl.Name = "varusteluMokitlbl";
            this.varusteluMokitlbl.Size = new System.Drawing.Size(85, 23);
            this.varusteluMokitlbl.TabIndex = 35;
            this.varusteluMokitlbl.Text = "Varustelu";
            this.varusteluMokitlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aluenimiLbl
            // 
            this.aluenimiLbl.BackColor = System.Drawing.Color.Transparent;
            this.aluenimiLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aluenimiLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aluenimiLbl.Location = new System.Drawing.Point(673, 180);
            this.aluenimiLbl.Name = "aluenimiLbl";
            this.aluenimiLbl.Size = new System.Drawing.Size(85, 23);
            this.aluenimiLbl.TabIndex = 36;
            this.aluenimiLbl.Text = "Alueen nimi";
            this.aluenimiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editMokitbtn
            // 
            this.editMokitbtn.Location = new System.Drawing.Point(926, 662);
            this.editMokitbtn.Name = "editMokitbtn";
            this.editMokitbtn.Size = new System.Drawing.Size(100, 23);
            this.editMokitbtn.TabIndex = 38;
            this.editMokitbtn.Text = "Muokkaa";
            this.editMokitbtn.UseVisualStyleBackColor = true;
            this.editMokitbtn.Click += new System.EventHandler(this.editMokitbtn_Click);
            // 
            // saveMokitbtn
            // 
            this.saveMokitbtn.Location = new System.Drawing.Point(1032, 662);
            this.saveMokitbtn.Name = "saveMokitbtn";
            this.saveMokitbtn.Size = new System.Drawing.Size(100, 23);
            this.saveMokitbtn.TabIndex = 39;
            this.saveMokitbtn.Text = "Päivitä";
            this.saveMokitbtn.UseVisualStyleBackColor = true;
            this.saveMokitbtn.Click += new System.EventHandler(this.saveMokitbtn_Click);
            // 
            // miniPalvelupb
            // 
            this.miniPalvelupb.BackColor = System.Drawing.Color.Transparent;
            this.miniPalvelupb.BackgroundImage = global::NewbiezApp.Properties.Resources.palvelubutton;
            this.miniPalvelupb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniPalvelupb.Location = new System.Drawing.Point(910, 12);
            this.miniPalvelupb.Name = "miniPalvelupb";
            this.miniPalvelupb.Size = new System.Drawing.Size(70, 69);
            this.miniPalvelupb.TabIndex = 43;
            this.miniPalvelupb.TabStop = false;
            this.miniPalvelupb.Click += new System.EventHandler(this.miniPalvelupb_Click);
            // 
            // alueMokitCb
            // 
            this.alueMokitCb.FormattingEnabled = true;
            this.alueMokitCb.Location = new System.Drawing.Point(764, 180);
            this.alueMokitCb.Name = "alueMokitCb";
            this.alueMokitCb.Size = new System.Drawing.Size(262, 23);
            this.alueMokitCb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1076, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "Toimipaikka";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // postinroMokitTb
            // 
            this.postinroMokitTb.Location = new System.Drawing.Point(1160, 138);
            this.postinroMokitTb.Name = "postinroMokitTb";
            this.postinroMokitTb.Size = new System.Drawing.Size(112, 23);
            this.postinroMokitTb.TabIndex = 6;
            // 
            // toimipaikkaMokitTb
            // 
            this.toimipaikkaMokitTb.Location = new System.Drawing.Point(1162, 184);
            this.toimipaikkaMokitTb.Name = "toimipaikkaMokitTb";
            this.toimipaikkaMokitTb.Size = new System.Drawing.Size(111, 23);
            this.toimipaikkaMokitTb.TabIndex = 7;
            // 
            // hintaMokitnup
            // 
            this.hintaMokitnup.Location = new System.Drawing.Point(1160, 229);
            this.hintaMokitnup.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.hintaMokitnup.Name = "hintaMokitnup";
            this.hintaMokitnup.Size = new System.Drawing.Size(112, 23);
            this.hintaMokitnup.TabIndex = 8;
            // 
            // hloMokitnup
            // 
            this.hloMokitnup.Location = new System.Drawing.Point(1160, 270);
            this.hloMokitnup.Name = "hloMokitnup";
            this.hloMokitnup.Size = new System.Drawing.Size(112, 23);
            this.hloMokitnup.TabIndex = 9;
            // 
            // MokitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::NewbiezApp.Properties.Resources.sivutaustat1x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 697);
            this.Controls.Add(this.hloMokitnup);
            this.Controls.Add(this.hintaMokitnup);
            this.Controls.Add(this.toimipaikkaMokitTb);
            this.Controls.Add(this.postinroMokitTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alueMokitCb);
            this.Controls.Add(this.miniPalvelupb);
            this.Controls.Add(this.saveMokitbtn);
            this.Controls.Add(this.editMokitbtn);
            this.Controls.Add(this.aluenimiLbl);
            this.Controls.Add(this.varusteluMokitlbl);
            this.Controls.Add(this.mokkinimiLbl);
            this.Controls.Add(this.hintaMokitlbl);
            this.Controls.Add(this.osoiteMokitlbl);
            this.Controls.Add(this.postinroMokitlbl);
            this.Controls.Add(this.kuvausMokitlbl);
            this.Controls.Add(this.hlomaaraLbl);
            this.Controls.Add(this.varusteluMokitTb);
            this.Controls.Add(this.kuvausMokitTb);
            this.Controls.Add(this.mokkinimiTb);
            this.Controls.Add(this.osoiteMokitTb);
            this.Controls.Add(this.deleteMokitbtn);
            this.Controls.Add(this.getMokitbtn);
            this.Controls.Add(this.addMokitbtn);
            this.Controls.Add(this.mokitDgv);
            this.Controls.Add(this.miniLaskutuspb);
            this.Controls.Add(this.miniAsiakastiedotpb);
            this.Controls.Add(this.miniVarauksetpb);
            this.Controls.Add(this.logopb);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 736);
            this.MinimumSize = new System.Drawing.Size(1300, 736);
            this.Name = "MokitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mökit";
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniVarauksetpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniAsiakastiedotpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniLaskutuspb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokitDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniPalvelupb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hintaMokitnup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hloMokitnup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox logopb;
        private PictureBox miniVarauksetpb;
        private PictureBox miniAsiakastiedotpb;
        private PictureBox miniLaskutuspb;
        private DataGridView mokitDgv;
        private Button deleteMokitbtn;
        private Button getMokitbtn;
        private Button addMokitbtn;
        private TextBox hlomaaraTb;
        private TextBox hintaMokitTb;
        private TextBox osoiteMokitTb;
        private TextBox mokkinimiTb;
        private TextBox kuvausMokitTb;
        private TextBox varusteluMokitTb;
        private Label hlomaaraLbl;
        private Label kuvausMokitlbl;
        private Label postinroMokitlbl;
        private Label osoiteMokitlbl;
        private Label hintaMokitlbl;
        private Label mokkinimiLbl;
        private Label varusteluMokitlbl;
        private Label aluenimiLbl;
        private Button editMokitbtn;
        private Button saveMokitbtn;
        private BindingSource mokkiBindingSource;
        private PictureBox miniPalvelupb;
        private ComboBox alueMokitCb;
        private Label label1;
        private TextBox postinroMokitTb;
        private TextBox toimipaikkaMokitTb;
        private NumericUpDown hintaMokitnup;
        private NumericUpDown hloMokitnup;
        private DataGridViewTextBoxColumn mokkiIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alueIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mokkinimiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn katuosoiteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hintaDataGridViewTextBoxColumn;
    }
}