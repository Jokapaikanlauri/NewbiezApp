namespace NewbiezApp
{
    partial class AsiakasForm
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
            this.miniMokitpb = new System.Windows.Forms.PictureBox();
            this.miniLaskutuspb = new System.Windows.Forms.PictureBox();
            this.asiakasDgv = new System.Windows.Forms.DataGridView();
            this.asiakasIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sukunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAsiakasbtn = new System.Windows.Forms.Button();
            this.addAsiakasbtn = new System.Windows.Forms.Button();
            this.editAsiakasbtn = new System.Windows.Forms.Button();
            this.asiakasIDtb = new System.Windows.Forms.TextBox();
            this.postinroAsiakastb = new System.Windows.Forms.TextBox();
            this.lahiosTb = new System.Windows.Forms.TextBox();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.puhnroTb = new System.Windows.Forms.TextBox();
            this.sukunimiTb = new System.Windows.Forms.TextBox();
            this.etunimiTb = new System.Windows.Forms.TextBox();
            this.asiakasIDlbl = new System.Windows.Forms.Label();
            this.etunimiLbl = new System.Windows.Forms.Label();
            this.sukunimiLbl = new System.Windows.Forms.Label();
            this.puhnroLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.lahiosLbl = new System.Windows.Forms.Label();
            this.postinroAsiakaslbl = new System.Windows.Forms.Label();
            this.postiToimipaikkalb = new System.Windows.Forms.Label();
            this.postiToimipaikkatb = new System.Windows.Forms.TextBox();
            this.miniPalvelupb = new System.Windows.Forms.PictureBox();
            this.paivitaAsiakasBtn = new System.Windows.Forms.Button();
            this.delAsiakasbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniVarauksetpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMokitpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniLaskutuspb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniPalvelupb)).BeginInit();
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
            this.logopb.TabIndex = 3;
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
            this.miniVarauksetpb.TabIndex = 11;
            this.miniVarauksetpb.TabStop = false;
            this.miniVarauksetpb.Click += new System.EventHandler(this.miniVarauksetpb_Click);
            // 
            // miniMokitpb
            // 
            this.miniMokitpb.BackColor = System.Drawing.Color.Transparent;
            this.miniMokitpb.BackgroundImage = global::NewbiezApp.Properties.Resources.icons8_country_house_96;
            this.miniMokitpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniMokitpb.Location = new System.Drawing.Point(1090, 12);
            this.miniMokitpb.Name = "miniMokitpb";
            this.miniMokitpb.Size = new System.Drawing.Size(72, 69);
            this.miniMokitpb.TabIndex = 12;
            this.miniMokitpb.TabStop = false;
            this.miniMokitpb.Click += new System.EventHandler(this.miniMokitpb_Click);
            // 
            // miniLaskutuspb
            // 
            this.miniLaskutuspb.BackColor = System.Drawing.Color.Transparent;
            this.miniLaskutuspb.BackgroundImage = global::NewbiezApp.Properties.Resources.icons8_check_dollar_96_1_;
            this.miniLaskutuspb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniLaskutuspb.Location = new System.Drawing.Point(1000, 12);
            this.miniLaskutuspb.Name = "miniLaskutuspb";
            this.miniLaskutuspb.Size = new System.Drawing.Size(70, 69);
            this.miniLaskutuspb.TabIndex = 14;
            this.miniLaskutuspb.TabStop = false;
            this.miniLaskutuspb.Click += new System.EventHandler(this.miniLaskutuspb_Click);
            // 
            // asiakasDgv
            // 
            this.asiakasDgv.AutoGenerateColumns = false;
            this.asiakasDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.asiakasDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.asiakasDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.asiakasDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.asiakasDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asiakasDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asiakasIdDataGridViewTextBoxColumn,
            this.etunimiDataGridViewTextBoxColumn,
            this.sukunimiDataGridViewTextBoxColumn,
            this.lahiosoiteDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.puhelinnroDataGridViewTextBoxColumn});
            this.asiakasDgv.DataSource = this.asiakasBindingSource;
            this.asiakasDgv.Location = new System.Drawing.Point(17, 373);
            this.asiakasDgv.Name = "asiakasDgv";
            this.asiakasDgv.RowTemplate.Height = 25;
            this.asiakasDgv.Size = new System.Drawing.Size(1255, 310);
            this.asiakasDgv.TabIndex = 15;
            this.asiakasDgv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.asiakasDgv_MouseDoubleClick);
            // 
            // asiakasIdDataGridViewTextBoxColumn
            // 
            this.asiakasIdDataGridViewTextBoxColumn.DataPropertyName = "AsiakasId";
            this.asiakasIdDataGridViewTextBoxColumn.HeaderText = "AsiakasId";
            this.asiakasIdDataGridViewTextBoxColumn.Name = "asiakasIdDataGridViewTextBoxColumn";
            this.asiakasIdDataGridViewTextBoxColumn.Width = 81;
            // 
            // etunimiDataGridViewTextBoxColumn
            // 
            this.etunimiDataGridViewTextBoxColumn.DataPropertyName = "Etunimi";
            this.etunimiDataGridViewTextBoxColumn.HeaderText = "Etunimi";
            this.etunimiDataGridViewTextBoxColumn.Name = "etunimiDataGridViewTextBoxColumn";
            this.etunimiDataGridViewTextBoxColumn.Width = 73;
            // 
            // sukunimiDataGridViewTextBoxColumn
            // 
            this.sukunimiDataGridViewTextBoxColumn.DataPropertyName = "Sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.HeaderText = "Sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.Name = "sukunimiDataGridViewTextBoxColumn";
            this.sukunimiDataGridViewTextBoxColumn.Width = 82;
            // 
            // lahiosoiteDataGridViewTextBoxColumn
            // 
            this.lahiosoiteDataGridViewTextBoxColumn.DataPropertyName = "Lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.HeaderText = "Lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.Name = "lahiosoiteDataGridViewTextBoxColumn";
            this.lahiosoiteDataGridViewTextBoxColumn.Width = 86;
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "Postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "Postinro";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            this.postinroDataGridViewTextBoxColumn.Width = 76;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 61;
            // 
            // puhelinnroDataGridViewTextBoxColumn
            // 
            this.puhelinnroDataGridViewTextBoxColumn.DataPropertyName = "Puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.HeaderText = "Puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.Name = "puhelinnroDataGridViewTextBoxColumn";
            this.puhelinnroDataGridViewTextBoxColumn.Width = 90;
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataSource = typeof(NewbiezApp.Classes.Asiakas);
            // 
            // getAsiakasbtn
            // 
            this.getAsiakasbtn.Location = new System.Drawing.Point(947, 194);
            this.getAsiakasbtn.Name = "getAsiakasbtn";
            this.getAsiakasbtn.Size = new System.Drawing.Size(100, 23);
            this.getAsiakasbtn.TabIndex = 9;
            this.getAsiakasbtn.Text = "Hae";
            this.getAsiakasbtn.UseVisualStyleBackColor = true;
            this.getAsiakasbtn.Click += new System.EventHandler(this.getAsiakasbtn_Click);
            // 
            // addAsiakasbtn
            // 
            this.addAsiakasbtn.Location = new System.Drawing.Point(947, 151);
            this.addAsiakasbtn.Name = "addAsiakasbtn";
            this.addAsiakasbtn.Size = new System.Drawing.Size(100, 23);
            this.addAsiakasbtn.TabIndex = 8;
            this.addAsiakasbtn.Text = "Lisää";
            this.addAsiakasbtn.UseVisualStyleBackColor = true;
            this.addAsiakasbtn.Click += new System.EventHandler(this.addAsiakasbtn_Click);
            // 
            // editAsiakasbtn
            // 
            this.editAsiakasbtn.Location = new System.Drawing.Point(947, 236);
            this.editAsiakasbtn.Name = "editAsiakasbtn";
            this.editAsiakasbtn.Size = new System.Drawing.Size(100, 23);
            this.editAsiakasbtn.TabIndex = 10;
            this.editAsiakasbtn.Text = "Muokkaa";
            this.editAsiakasbtn.UseVisualStyleBackColor = true;
            this.editAsiakasbtn.Click += new System.EventHandler(this.editAsiakasbtn_Click);
            // 
            // asiakasIDtb
            // 
            this.asiakasIDtb.Location = new System.Drawing.Point(143, 147);
            this.asiakasIDtb.Name = "asiakasIDtb";
            this.asiakasIDtb.Size = new System.Drawing.Size(301, 23);
            this.asiakasIDtb.TabIndex = 1;
            // 
            // postinroAsiakastb
            // 
            this.postinroAsiakastb.Location = new System.Drawing.Point(584, 236);
            this.postinroAsiakastb.MaxLength = 5;
            this.postinroAsiakastb.Name = "postinroAsiakastb";
            this.postinroAsiakastb.Size = new System.Drawing.Size(301, 23);
            this.postinroAsiakastb.TabIndex = 7;
            this.postinroAsiakastb.TextChanged += new System.EventHandler(this.postinroAsiakastb_TextChanged);
            // 
            // lahiosTb
            // 
            this.lahiosTb.Location = new System.Drawing.Point(584, 193);
            this.lahiosTb.MaxLength = 40;
            this.lahiosTb.Name = "lahiosTb";
            this.lahiosTb.Size = new System.Drawing.Size(301, 23);
            this.lahiosTb.TabIndex = 6;
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(584, 151);
            this.emailTb.MaxLength = 50;
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(301, 23);
            this.emailTb.TabIndex = 5;
            // 
            // puhnroTb
            // 
            this.puhnroTb.Location = new System.Drawing.Point(143, 278);
            this.puhnroTb.MaxLength = 15;
            this.puhnroTb.Name = "puhnroTb";
            this.puhnroTb.Size = new System.Drawing.Size(301, 23);
            this.puhnroTb.TabIndex = 4;
            this.puhnroTb.TextChanged += new System.EventHandler(this.puhnroTb_TextChanged);
            // 
            // sukunimiTb
            // 
            this.sukunimiTb.Location = new System.Drawing.Point(143, 238);
            this.sukunimiTb.MaxLength = 40;
            this.sukunimiTb.Name = "sukunimiTb";
            this.sukunimiTb.Size = new System.Drawing.Size(301, 23);
            this.sukunimiTb.TabIndex = 3;
            // 
            // etunimiTb
            // 
            this.etunimiTb.Location = new System.Drawing.Point(143, 191);
            this.etunimiTb.MaxLength = 20;
            this.etunimiTb.Name = "etunimiTb";
            this.etunimiTb.Size = new System.Drawing.Size(301, 23);
            this.etunimiTb.TabIndex = 2;
            // 
            // asiakasIDlbl
            // 
            this.asiakasIDlbl.BackColor = System.Drawing.Color.Transparent;
            this.asiakasIDlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asiakasIDlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.asiakasIDlbl.Location = new System.Drawing.Point(55, 147);
            this.asiakasIDlbl.Name = "asiakasIDlbl";
            this.asiakasIDlbl.Size = new System.Drawing.Size(82, 23);
            this.asiakasIDlbl.TabIndex = 26;
            this.asiakasIDlbl.Text = "Asiakas ID";
            this.asiakasIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // etunimiLbl
            // 
            this.etunimiLbl.BackColor = System.Drawing.Color.Transparent;
            this.etunimiLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.etunimiLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.etunimiLbl.Location = new System.Drawing.Point(55, 191);
            this.etunimiLbl.Name = "etunimiLbl";
            this.etunimiLbl.Size = new System.Drawing.Size(82, 23);
            this.etunimiLbl.TabIndex = 27;
            this.etunimiLbl.Text = "Etunimi";
            this.etunimiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sukunimiLbl
            // 
            this.sukunimiLbl.BackColor = System.Drawing.Color.Transparent;
            this.sukunimiLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sukunimiLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sukunimiLbl.Location = new System.Drawing.Point(55, 238);
            this.sukunimiLbl.Name = "sukunimiLbl";
            this.sukunimiLbl.Size = new System.Drawing.Size(82, 23);
            this.sukunimiLbl.TabIndex = 28;
            this.sukunimiLbl.Text = "Sukunimi";
            this.sukunimiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // puhnroLbl
            // 
            this.puhnroLbl.BackColor = System.Drawing.Color.Transparent;
            this.puhnroLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.puhnroLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.puhnroLbl.Location = new System.Drawing.Point(55, 278);
            this.puhnroLbl.Name = "puhnroLbl";
            this.puhnroLbl.Size = new System.Drawing.Size(82, 23);
            this.puhnroLbl.TabIndex = 29;
            this.puhnroLbl.Text = "Puhelin";
            this.puhnroLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailLbl
            // 
            this.emailLbl.BackColor = System.Drawing.Color.Transparent;
            this.emailLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailLbl.Location = new System.Drawing.Point(496, 149);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(82, 23);
            this.emailLbl.TabIndex = 30;
            this.emailLbl.Text = "Email";
            this.emailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lahiosLbl
            // 
            this.lahiosLbl.BackColor = System.Drawing.Color.Transparent;
            this.lahiosLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lahiosLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lahiosLbl.Location = new System.Drawing.Point(496, 193);
            this.lahiosLbl.Name = "lahiosLbl";
            this.lahiosLbl.Size = new System.Drawing.Size(82, 23);
            this.lahiosLbl.TabIndex = 31;
            this.lahiosLbl.Text = "Lähiosoite";
            this.lahiosLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // postinroAsiakaslbl
            // 
            this.postinroAsiakaslbl.BackColor = System.Drawing.Color.Transparent;
            this.postinroAsiakaslbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postinroAsiakaslbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.postinroAsiakaslbl.Location = new System.Drawing.Point(496, 236);
            this.postinroAsiakaslbl.Name = "postinroAsiakaslbl";
            this.postinroAsiakaslbl.Size = new System.Drawing.Size(82, 23);
            this.postinroAsiakaslbl.TabIndex = 32;
            this.postinroAsiakaslbl.Text = "Postinumero";
            this.postinroAsiakaslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // postiToimipaikkalb
            // 
            this.postiToimipaikkalb.AutoSize = true;
            this.postiToimipaikkalb.BackColor = System.Drawing.Color.Transparent;
            this.postiToimipaikkalb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postiToimipaikkalb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.postiToimipaikkalb.Location = new System.Drawing.Point(476, 284);
            this.postiToimipaikkalb.Name = "postiToimipaikkalb";
            this.postiToimipaikkalb.Size = new System.Drawing.Size(102, 17);
            this.postiToimipaikkalb.TabIndex = 33;
            this.postiToimipaikkalb.Text = "Postitoimipaikka";
            this.postiToimipaikkalb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // postiToimipaikkatb
            // 
            this.postiToimipaikkatb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.postiToimipaikkatb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.postiToimipaikkatb.Location = new System.Drawing.Point(584, 280);
            this.postiToimipaikkatb.Name = "postiToimipaikkatb";
            this.postiToimipaikkatb.Size = new System.Drawing.Size(301, 23);
            this.postiToimipaikkatb.TabIndex = 8;
            // 
            // miniPalvelupb
            // 
            this.miniPalvelupb.BackColor = System.Drawing.Color.Transparent;
            this.miniPalvelupb.BackgroundImage = global::NewbiezApp.Properties.Resources.palvelubutton;
            this.miniPalvelupb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniPalvelupb.Location = new System.Drawing.Point(910, 12);
            this.miniPalvelupb.Name = "miniPalvelupb";
            this.miniPalvelupb.Size = new System.Drawing.Size(70, 69);
            this.miniPalvelupb.TabIndex = 44;
            this.miniPalvelupb.TabStop = false;
            this.miniPalvelupb.Click += new System.EventHandler(this.miniPalvelupb_Click);
            // 
            // paivitaAsiakasBtn
            // 
            this.paivitaAsiakasBtn.Location = new System.Drawing.Point(947, 280);
            this.paivitaAsiakasBtn.Name = "paivitaAsiakasBtn";
            this.paivitaAsiakasBtn.Size = new System.Drawing.Size(100, 23);
            this.paivitaAsiakasBtn.TabIndex = 11;
            this.paivitaAsiakasBtn.Text = "Päivitä";
            this.paivitaAsiakasBtn.UseVisualStyleBackColor = true;
            this.paivitaAsiakasBtn.Click += new System.EventHandler(this.paivitaAsiakasBtn_Click);
            // 
            // delAsiakasbtn
            // 
            this.delAsiakasbtn.Location = new System.Drawing.Point(947, 322);
            this.delAsiakasbtn.Name = "delAsiakasbtn";
            this.delAsiakasbtn.Size = new System.Drawing.Size(100, 23);
            this.delAsiakasbtn.TabIndex = 12;
            this.delAsiakasbtn.Text = "Poista";
            this.delAsiakasbtn.UseVisualStyleBackColor = true;
            this.delAsiakasbtn.Click += new System.EventHandler(this.delAsiakasbtn_Click);
            // 
            // AsiakasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewbiezApp.Properties.Resources.sivutaustat1x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1284, 697);
            this.Controls.Add(this.delAsiakasbtn);
            this.Controls.Add(this.paivitaAsiakasBtn);
            this.Controls.Add(this.miniPalvelupb);
            this.Controls.Add(this.postiToimipaikkatb);
            this.Controls.Add(this.postiToimipaikkalb);
            this.Controls.Add(this.postinroAsiakaslbl);
            this.Controls.Add(this.lahiosLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.puhnroLbl);
            this.Controls.Add(this.sukunimiLbl);
            this.Controls.Add(this.etunimiLbl);
            this.Controls.Add(this.asiakasIDlbl);
            this.Controls.Add(this.etunimiTb);
            this.Controls.Add(this.sukunimiTb);
            this.Controls.Add(this.puhnroTb);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.lahiosTb);
            this.Controls.Add(this.postinroAsiakastb);
            this.Controls.Add(this.asiakasIDtb);
            this.Controls.Add(this.editAsiakasbtn);
            this.Controls.Add(this.addAsiakasbtn);
            this.Controls.Add(this.getAsiakasbtn);
            this.Controls.Add(this.asiakasDgv);
            this.Controls.Add(this.miniLaskutuspb);
            this.Controls.Add(this.miniMokitpb);
            this.Controls.Add(this.miniVarauksetpb);
            this.Controls.Add(this.logopb);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 736);
            this.MinimumSize = new System.Drawing.Size(1300, 736);
            this.Name = "AsiakasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asiakas";
            this.Load += new System.EventHandler(this.AsiakasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniVarauksetpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMokitpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniLaskutuspb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniPalvelupb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox logopb;
        private PictureBox miniVarauksetpb;
        private PictureBox miniMokitpb;
        private PictureBox miniLaskutuspb;
        private DataGridView asiakasDgv;
        private Button getAsiakasbtn;
        private Button addAsiakasbtn;
        private Button editAsiakasbtn;
        private TextBox asiakasIDtb;
        private TextBox postinroAsiakastb;
        private TextBox lahiosTb;
        private TextBox emailTb;
        private TextBox puhnroTb;
        private TextBox sukunimiTb;
        private TextBox etunimiTb;
        private Label asiakasIDlbl;
        private Label etunimiLbl;
        private Label sukunimiLbl;
        private Label puhnroLbl;
        private Label emailLbl;
        private Label lahiosLbl;
        private Label postinroAsiakaslbl;
        private BindingSource asiakasBindingSource;
        private Label postiToimipaikkalb;
        private TextBox postiToimipaikkatb;
        private PictureBox miniPalvelupb;
        private Button paivitaAsiakasBtn;
        private DataGridViewTextBoxColumn asiakasIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn etunimiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sukunimiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lahiosoiteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn puhelinnroDataGridViewTextBoxColumn;
        private Button delAsiakasbtn;
    }
}