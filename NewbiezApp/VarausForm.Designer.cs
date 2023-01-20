namespace NewbiezApp
{
    partial class VarausForm
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
            this.miniMokitpb = new System.Windows.Forms.PictureBox();
            this.miniAsiakastiedotpb = new System.Windows.Forms.PictureBox();
            this.miniLaskutuspb = new System.Windows.Forms.PictureBox();
            this.varausDgv = new System.Windows.Forms.DataGridView();
            this.varausIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsiakasId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MokkiMokkiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarattuPvm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VahvistusPvm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarattuAlkupvm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarattuLoppupvm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varausIDtb = new System.Windows.Forms.TextBox();
            this.asiakasIDVaraustb = new System.Windows.Forms.TextBox();
            this.mokkiIDVaraustb = new System.Windows.Forms.TextBox();
            this.reservedVarausdtp = new System.Windows.Forms.DateTimePicker();
            this.lastDayVarausdtp = new System.Windows.Forms.DateTimePicker();
            this.firstDayVarausdtp = new System.Windows.Forms.DateTimePicker();
            this.confirmedVarausdtp = new System.Windows.Forms.DateTimePicker();
            this.varausIDlbl = new System.Windows.Forms.Label();
            this.asiakasIDVarauslbl = new System.Windows.Forms.Label();
            this.mokkiIDVarauslbl = new System.Windows.Forms.Label();
            this.reservedVarauslbl = new System.Windows.Forms.Label();
            this.confirmedVarauslbl = new System.Windows.Forms.Label();
            this.firstDayVarauslbl = new System.Windows.Forms.Label();
            this.lastDayVarauslbl = new System.Windows.Forms.Label();
            this.addVarausbtn = new System.Windows.Forms.Button();
            this.getVarausbtn = new System.Windows.Forms.Button();
            this.editVarausbtn = new System.Windows.Forms.Button();
            this.deleteVarausbtn = new System.Windows.Forms.Button();
            this.palveluLkmVarauslbl = new System.Windows.Forms.Label();
            this.sendBillVarauscb = new System.Windows.Forms.CheckBox();
            this.miniPalvelupb = new System.Windows.Forms.PictureBox();
            this.emptyVarausbtn = new System.Windows.Forms.Button();
            this.billCreatedVarauslbl = new System.Windows.Forms.Label();
            this.varauksenPalvelutdgv = new System.Windows.Forms.DataGridView();
            this.varausIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palveluIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lkmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varauksenPalvelutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addPalveluVarausbtn = new System.Windows.Forms.Button();
            this.editPalveluVarausbtn = new System.Windows.Forms.Button();
            this.deletePalveluVarausbtn = new System.Windows.Forms.Button();
            this.ServicesVarauslbl = new System.Windows.Forms.Label();
            this.palvelunNimiVarauslbl = new System.Windows.Forms.Label();
            this.palveluLkmVarausNud = new System.Windows.Forms.NumericUpDown();
            this.palvelunNimiVarausCmb = new System.Windows.Forms.ComboBox();
            this.refreshVarausbtn = new System.Windows.Forms.Button();
            this.showRapportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMokitpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniAsiakastiedotpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniLaskutuspb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniPalvelupb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenPalvelutdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenPalvelutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluLkmVarausNud)).BeginInit();
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
            this.logopb.TabIndex = 4;
            this.logopb.TabStop = false;
            this.logopb.Click += new System.EventHandler(this.logopb_Click);
            // 
            // miniMokitpb
            // 
            this.miniMokitpb.BackColor = System.Drawing.Color.Transparent;
            this.miniMokitpb.BackgroundImage = global::NewbiezApp.Properties.Resources.icons8_country_house_96;
            this.miniMokitpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniMokitpb.Location = new System.Drawing.Point(1180, 12);
            this.miniMokitpb.Name = "miniMokitpb";
            this.miniMokitpb.Size = new System.Drawing.Size(72, 69);
            this.miniMokitpb.TabIndex = 13;
            this.miniMokitpb.TabStop = false;
            this.miniMokitpb.Click += new System.EventHandler(this.miniMokitpb_Click);
            // 
            // miniAsiakastiedotpb
            // 
            this.miniAsiakastiedotpb.BackColor = System.Drawing.Color.Transparent;
            this.miniAsiakastiedotpb.BackgroundImage = global::NewbiezApp.Properties.Resources.icons8_business_group_96_1_;
            this.miniAsiakastiedotpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniAsiakastiedotpb.Location = new System.Drawing.Point(1090, 12);
            this.miniAsiakastiedotpb.Name = "miniAsiakastiedotpb";
            this.miniAsiakastiedotpb.Size = new System.Drawing.Size(68, 69);
            this.miniAsiakastiedotpb.TabIndex = 14;
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
            this.miniLaskutuspb.TabIndex = 15;
            this.miniLaskutuspb.TabStop = false;
            this.miniLaskutuspb.Click += new System.EventHandler(this.miniLaskutuspb_Click);
            // 
            // varausDgv
            // 
            this.varausDgv.AutoGenerateColumns = false;
            this.varausDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.varausDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.varausDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varausDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varausIdDataGridViewTextBoxColumn,
            this.AsiakasId,
            this.MokkiMokkiId,
            this.VarattuPvm,
            this.VahvistusPvm,
            this.VarattuAlkupvm,
            this.VarattuLoppupvm});
            this.varausDgv.DataSource = this.varausBindingSource;
            this.varausDgv.Location = new System.Drawing.Point(12, 111);
            this.varausDgv.Name = "varausDgv";
            this.varausDgv.RowTemplate.Height = 25;
            this.varausDgv.Size = new System.Drawing.Size(644, 574);
            this.varausDgv.TabIndex = 1;
            this.varausDgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.varausDgv_CellMouseClick);
            // 
            // varausIdDataGridViewTextBoxColumn
            // 
            this.varausIdDataGridViewTextBoxColumn.DataPropertyName = "VarausId";
            this.varausIdDataGridViewTextBoxColumn.HeaderText = "VarausId";
            this.varausIdDataGridViewTextBoxColumn.Name = "varausIdDataGridViewTextBoxColumn";
            // 
            // AsiakasId
            // 
            this.AsiakasId.DataPropertyName = "AsiakasId";
            this.AsiakasId.HeaderText = "AsiakasId";
            this.AsiakasId.Name = "AsiakasId";
            // 
            // MokkiMokkiId
            // 
            this.MokkiMokkiId.DataPropertyName = "MokkiMokkiId";
            this.MokkiMokkiId.HeaderText = "MokkiMokkiId";
            this.MokkiMokkiId.Name = "MokkiMokkiId";
            // 
            // VarattuPvm
            // 
            this.VarattuPvm.DataPropertyName = "VarattuPvm";
            this.VarattuPvm.HeaderText = "VarattuPvm";
            this.VarattuPvm.Name = "VarattuPvm";
            this.VarattuPvm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VarattuPvm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VahvistusPvm
            // 
            this.VahvistusPvm.DataPropertyName = "VahvistusPvm";
            this.VahvistusPvm.HeaderText = "VahvistusPvm";
            this.VahvistusPvm.Name = "VahvistusPvm";
            this.VahvistusPvm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VahvistusPvm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VarattuAlkupvm
            // 
            this.VarattuAlkupvm.DataPropertyName = "VarattuAlkupvm";
            this.VarattuAlkupvm.HeaderText = "VarattuAlkupvm";
            this.VarattuAlkupvm.Name = "VarattuAlkupvm";
            this.VarattuAlkupvm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VarattuAlkupvm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VarattuLoppupvm
            // 
            this.VarattuLoppupvm.DataPropertyName = "VarattuLoppupvm";
            this.VarattuLoppupvm.HeaderText = "VarattuLoppupvm";
            this.VarattuLoppupvm.Name = "VarattuLoppupvm";
            this.VarattuLoppupvm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VarattuLoppupvm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataSource = typeof(NewbiezApp.Classes.Varaus);
            // 
            // varausIDtb
            // 
            this.varausIDtb.Enabled = false;
            this.varausIDtb.Location = new System.Drawing.Point(755, 165);
            this.varausIDtb.Name = "varausIDtb";
            this.varausIDtb.ReadOnly = true;
            this.varausIDtb.Size = new System.Drawing.Size(200, 23);
            this.varausIDtb.TabIndex = 8;
            // 
            // asiakasIDVaraustb
            // 
            this.asiakasIDVaraustb.Location = new System.Drawing.Point(755, 194);
            this.asiakasIDVaraustb.Name = "asiakasIDVaraustb";
            this.asiakasIDVaraustb.Size = new System.Drawing.Size(200, 23);
            this.asiakasIDVaraustb.TabIndex = 9;
            // 
            // mokkiIDVaraustb
            // 
            this.mokkiIDVaraustb.Location = new System.Drawing.Point(755, 223);
            this.mokkiIDVaraustb.Name = "mokkiIDVaraustb";
            this.mokkiIDVaraustb.Size = new System.Drawing.Size(200, 23);
            this.mokkiIDVaraustb.TabIndex = 10;
            // 
            // reservedVarausdtp
            // 
            this.reservedVarausdtp.Location = new System.Drawing.Point(755, 266);
            this.reservedVarausdtp.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.reservedVarausdtp.Name = "reservedVarausdtp";
            this.reservedVarausdtp.Size = new System.Drawing.Size(200, 23);
            this.reservedVarausdtp.TabIndex = 11;
            // 
            // lastDayVarausdtp
            // 
            this.lastDayVarausdtp.Location = new System.Drawing.Point(1072, 305);
            this.lastDayVarausdtp.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.lastDayVarausdtp.Name = "lastDayVarausdtp";
            this.lastDayVarausdtp.Size = new System.Drawing.Size(200, 23);
            this.lastDayVarausdtp.TabIndex = 14;
            // 
            // firstDayVarausdtp
            // 
            this.firstDayVarausdtp.Location = new System.Drawing.Point(755, 305);
            this.firstDayVarausdtp.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.firstDayVarausdtp.Name = "firstDayVarausdtp";
            this.firstDayVarausdtp.Size = new System.Drawing.Size(200, 23);
            this.firstDayVarausdtp.TabIndex = 13;
            this.firstDayVarausdtp.ValueChanged += new System.EventHandler(this.firstDayVarausdtp_ValueChanged);
            // 
            // confirmedVarausdtp
            // 
            this.confirmedVarausdtp.Location = new System.Drawing.Point(1072, 266);
            this.confirmedVarausdtp.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.confirmedVarausdtp.Name = "confirmedVarausdtp";
            this.confirmedVarausdtp.Size = new System.Drawing.Size(200, 23);
            this.confirmedVarausdtp.TabIndex = 12;
            // 
            // varausIDlbl
            // 
            this.varausIDlbl.BackColor = System.Drawing.Color.Transparent;
            this.varausIDlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.varausIDlbl.Location = new System.Drawing.Point(662, 165);
            this.varausIDlbl.Name = "varausIDlbl";
            this.varausIDlbl.Size = new System.Drawing.Size(87, 23);
            this.varausIDlbl.TabIndex = 24;
            this.varausIDlbl.Text = "Varaus ID";
            this.varausIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // asiakasIDVarauslbl
            // 
            this.asiakasIDVarauslbl.BackColor = System.Drawing.Color.Transparent;
            this.asiakasIDVarauslbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asiakasIDVarauslbl.Location = new System.Drawing.Point(662, 194);
            this.asiakasIDVarauslbl.Name = "asiakasIDVarauslbl";
            this.asiakasIDVarauslbl.Size = new System.Drawing.Size(87, 23);
            this.asiakasIDVarauslbl.TabIndex = 25;
            this.asiakasIDVarauslbl.Text = "Asiakas ID";
            this.asiakasIDVarauslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mokkiIDVarauslbl
            // 
            this.mokkiIDVarauslbl.BackColor = System.Drawing.Color.Transparent;
            this.mokkiIDVarauslbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mokkiIDVarauslbl.Location = new System.Drawing.Point(662, 223);
            this.mokkiIDVarauslbl.Name = "mokkiIDVarauslbl";
            this.mokkiIDVarauslbl.Size = new System.Drawing.Size(87, 23);
            this.mokkiIDVarauslbl.TabIndex = 26;
            this.mokkiIDVarauslbl.Text = "Mökki ID";
            this.mokkiIDVarauslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reservedVarauslbl
            // 
            this.reservedVarauslbl.BackColor = System.Drawing.Color.Transparent;
            this.reservedVarauslbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reservedVarauslbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reservedVarauslbl.Location = new System.Drawing.Point(662, 266);
            this.reservedVarauslbl.Name = "reservedVarauslbl";
            this.reservedVarauslbl.Size = new System.Drawing.Size(87, 23);
            this.reservedVarauslbl.TabIndex = 27;
            this.reservedVarauslbl.Text = "Varattu";
            this.reservedVarauslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmedVarauslbl
            // 
            this.confirmedVarauslbl.BackColor = System.Drawing.Color.Transparent;
            this.confirmedVarauslbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmedVarauslbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmedVarauslbl.Location = new System.Drawing.Point(979, 266);
            this.confirmedVarauslbl.Name = "confirmedVarauslbl";
            this.confirmedVarauslbl.Size = new System.Drawing.Size(87, 23);
            this.confirmedVarauslbl.TabIndex = 28;
            this.confirmedVarauslbl.Text = "Vahvistettu";
            this.confirmedVarauslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstDayVarauslbl
            // 
            this.firstDayVarauslbl.BackColor = System.Drawing.Color.Transparent;
            this.firstDayVarauslbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstDayVarauslbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstDayVarauslbl.Location = new System.Drawing.Point(662, 305);
            this.firstDayVarauslbl.Name = "firstDayVarauslbl";
            this.firstDayVarauslbl.Size = new System.Drawing.Size(87, 23);
            this.firstDayVarauslbl.TabIndex = 29;
            this.firstDayVarauslbl.Text = "Alk. pvm";
            this.firstDayVarauslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastDayVarauslbl
            // 
            this.lastDayVarauslbl.BackColor = System.Drawing.Color.Transparent;
            this.lastDayVarauslbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastDayVarauslbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastDayVarauslbl.Location = new System.Drawing.Point(979, 305);
            this.lastDayVarauslbl.Name = "lastDayVarauslbl";
            this.lastDayVarauslbl.Size = new System.Drawing.Size(87, 23);
            this.lastDayVarauslbl.TabIndex = 30;
            this.lastDayVarauslbl.Text = "Lop. pvm";
            this.lastDayVarauslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addVarausbtn
            // 
            this.addVarausbtn.Location = new System.Drawing.Point(664, 111);
            this.addVarausbtn.Name = "addVarausbtn";
            this.addVarausbtn.Size = new System.Drawing.Size(84, 23);
            this.addVarausbtn.TabIndex = 2;
            this.addVarausbtn.Text = "Lisää";
            this.addVarausbtn.UseVisualStyleBackColor = true;
            this.addVarausbtn.Click += new System.EventHandler(this.addVarausbtn_Click);
            // 
            // getVarausbtn
            // 
            this.getVarausbtn.Location = new System.Drawing.Point(754, 111);
            this.getVarausbtn.Name = "getVarausbtn";
            this.getVarausbtn.Size = new System.Drawing.Size(84, 23);
            this.getVarausbtn.TabIndex = 3;
            this.getVarausbtn.Text = "Hae";
            this.getVarausbtn.UseVisualStyleBackColor = true;
            this.getVarausbtn.Click += new System.EventHandler(this.getVarausbtn_Click);
            // 
            // editVarausbtn
            // 
            this.editVarausbtn.Location = new System.Drawing.Point(844, 111);
            this.editVarausbtn.Name = "editVarausbtn";
            this.editVarausbtn.Size = new System.Drawing.Size(84, 23);
            this.editVarausbtn.TabIndex = 4;
            this.editVarausbtn.Text = "Muokkaa";
            this.editVarausbtn.UseVisualStyleBackColor = true;
            this.editVarausbtn.Click += new System.EventHandler(this.editVarausbtn_Click);
            // 
            // deleteVarausbtn
            // 
            this.deleteVarausbtn.Location = new System.Drawing.Point(934, 111);
            this.deleteVarausbtn.Name = "deleteVarausbtn";
            this.deleteVarausbtn.Size = new System.Drawing.Size(84, 23);
            this.deleteVarausbtn.TabIndex = 5;
            this.deleteVarausbtn.Text = "Poista";
            this.deleteVarausbtn.UseVisualStyleBackColor = true;
            this.deleteVarausbtn.Click += new System.EventHandler(this.deleteVarausbtn_Click);
            // 
            // palveluLkmVarauslbl
            // 
            this.palveluLkmVarauslbl.BackColor = System.Drawing.Color.Transparent;
            this.palveluLkmVarauslbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.palveluLkmVarauslbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.palveluLkmVarauslbl.Location = new System.Drawing.Point(661, 445);
            this.palveluLkmVarauslbl.Name = "palveluLkmVarauslbl";
            this.palveluLkmVarauslbl.Size = new System.Drawing.Size(87, 23);
            this.palveluLkmVarauslbl.TabIndex = 39;
            this.palveluLkmVarauslbl.Text = "Lkm";
            this.palveluLkmVarauslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sendBillVarauscb
            // 
            this.sendBillVarauscb.AutoSize = true;
            this.sendBillVarauscb.BackColor = System.Drawing.Color.Transparent;
            this.sendBillVarauscb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sendBillVarauscb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sendBillVarauscb.Location = new System.Drawing.Point(1079, 412);
            this.sendBillVarauscb.Name = "sendBillVarauscb";
            this.sendBillVarauscb.Size = new System.Drawing.Size(173, 21);
            this.sendBillVarauscb.TabIndex = 21;
            this.sendBillVarauscb.Text = "Muodosta ja lähetä lasku";
            this.sendBillVarauscb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sendBillVarauscb.UseVisualStyleBackColor = false;
            this.sendBillVarauscb.CheckedChanged += new System.EventHandler(this.sendBillVarauscb_CheckedChanged);
            // 
            // miniPalvelupb
            // 
            this.miniPalvelupb.BackColor = System.Drawing.Color.Transparent;
            this.miniPalvelupb.BackgroundImage = global::NewbiezApp.Properties.Resources.palvelubutton;
            this.miniPalvelupb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniPalvelupb.Location = new System.Drawing.Point(910, 12);
            this.miniPalvelupb.Name = "miniPalvelupb";
            this.miniPalvelupb.Size = new System.Drawing.Size(70, 69);
            this.miniPalvelupb.TabIndex = 42;
            this.miniPalvelupb.TabStop = false;
            this.miniPalvelupb.Click += new System.EventHandler(this.miniPalvelupb_Click);
            // 
            // emptyVarausbtn
            // 
            this.emptyVarausbtn.Location = new System.Drawing.Point(1090, 111);
            this.emptyVarausbtn.Name = "emptyVarausbtn";
            this.emptyVarausbtn.Size = new System.Drawing.Size(84, 23);
            this.emptyVarausbtn.TabIndex = 6;
            this.emptyVarausbtn.Text = "Tyhjennä";
            this.emptyVarausbtn.UseVisualStyleBackColor = true;
            this.emptyVarausbtn.Click += new System.EventHandler(this.emptyVarausbtn_Click);
            // 
            // billCreatedVarauslbl
            // 
            this.billCreatedVarauslbl.BackColor = System.Drawing.Color.Transparent;
            this.billCreatedVarauslbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.billCreatedVarauslbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.billCreatedVarauslbl.Location = new System.Drawing.Point(1081, 412);
            this.billCreatedVarauslbl.Name = "billCreatedVarauslbl";
            this.billCreatedVarauslbl.Size = new System.Drawing.Size(152, 23);
            this.billCreatedVarauslbl.TabIndex = 43;
            this.billCreatedVarauslbl.Text = "Lasku muodostettu";
            this.billCreatedVarauslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.billCreatedVarauslbl.Visible = false;
            // 
            // varauksenPalvelutdgv
            // 
            this.varauksenPalvelutdgv.AutoGenerateColumns = false;
            this.varauksenPalvelutdgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.varauksenPalvelutdgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.varauksenPalvelutdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varauksenPalvelutdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varausIdDataGridViewTextBoxColumn1,
            this.palveluIdDataGridViewTextBoxColumn,
            this.lkmDataGridViewTextBoxColumn});
            this.varauksenPalvelutdgv.DataSource = this.varauksenPalvelutBindingSource;
            this.varauksenPalvelutdgv.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.varauksenPalvelutdgv.Location = new System.Drawing.Point(666, 523);
            this.varauksenPalvelutdgv.Name = "varauksenPalvelutdgv";
            this.varauksenPalvelutdgv.RowTemplate.Height = 25;
            this.varauksenPalvelutdgv.Size = new System.Drawing.Size(363, 162);
            this.varauksenPalvelutdgv.TabIndex = 20;
            this.varauksenPalvelutdgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.varauksenPalvelutdgv_CellMouseClick);
            // 
            // varausIdDataGridViewTextBoxColumn1
            // 
            this.varausIdDataGridViewTextBoxColumn1.DataPropertyName = "VarausId";
            this.varausIdDataGridViewTextBoxColumn1.HeaderText = "VarausId";
            this.varausIdDataGridViewTextBoxColumn1.Name = "varausIdDataGridViewTextBoxColumn1";
            // 
            // palveluIdDataGridViewTextBoxColumn
            // 
            this.palveluIdDataGridViewTextBoxColumn.DataPropertyName = "PalveluId";
            this.palveluIdDataGridViewTextBoxColumn.HeaderText = "PalveluId";
            this.palveluIdDataGridViewTextBoxColumn.Name = "palveluIdDataGridViewTextBoxColumn";
            // 
            // lkmDataGridViewTextBoxColumn
            // 
            this.lkmDataGridViewTextBoxColumn.DataPropertyName = "Lkm";
            this.lkmDataGridViewTextBoxColumn.HeaderText = "Lkm";
            this.lkmDataGridViewTextBoxColumn.Name = "lkmDataGridViewTextBoxColumn";
            // 
            // varauksenPalvelutBindingSource
            // 
            this.varauksenPalvelutBindingSource.DataSource = typeof(NewbiezApp.Classes.VarauksenPalvelut);
            // 
            // addPalveluVarausbtn
            // 
            this.addPalveluVarausbtn.Location = new System.Drawing.Point(890, 410);
            this.addPalveluVarausbtn.Name = "addPalveluVarausbtn";
            this.addPalveluVarausbtn.Size = new System.Drawing.Size(65, 23);
            this.addPalveluVarausbtn.TabIndex = 17;
            this.addPalveluVarausbtn.Text = "Lisää";
            this.addPalveluVarausbtn.UseVisualStyleBackColor = true;
            this.addPalveluVarausbtn.Click += new System.EventHandler(this.addPalveluVarausbtn_Click);
            // 
            // editPalveluVarausbtn
            // 
            this.editPalveluVarausbtn.Location = new System.Drawing.Point(890, 439);
            this.editPalveluVarausbtn.Name = "editPalveluVarausbtn";
            this.editPalveluVarausbtn.Size = new System.Drawing.Size(65, 23);
            this.editPalveluVarausbtn.TabIndex = 18;
            this.editPalveluVarausbtn.Text = "Muokkaa";
            this.editPalveluVarausbtn.UseVisualStyleBackColor = true;
            this.editPalveluVarausbtn.Click += new System.EventHandler(this.editPalveluVarausbtn_Click);
            // 
            // deletePalveluVarausbtn
            // 
            this.deletePalveluVarausbtn.Location = new System.Drawing.Point(890, 468);
            this.deletePalveluVarausbtn.Name = "deletePalveluVarausbtn";
            this.deletePalveluVarausbtn.Size = new System.Drawing.Size(65, 23);
            this.deletePalveluVarausbtn.TabIndex = 19;
            this.deletePalveluVarausbtn.Text = "Poista";
            this.deletePalveluVarausbtn.UseVisualStyleBackColor = true;
            this.deletePalveluVarausbtn.Click += new System.EventHandler(this.deletePalveluVarausbtn_Click);
            // 
            // ServicesVarauslbl
            // 
            this.ServicesVarauslbl.BackColor = System.Drawing.Color.Transparent;
            this.ServicesVarauslbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ServicesVarauslbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ServicesVarauslbl.Location = new System.Drawing.Point(754, 365);
            this.ServicesVarauslbl.Name = "ServicesVarauslbl";
            this.ServicesVarauslbl.Size = new System.Drawing.Size(146, 23);
            this.ServicesVarauslbl.TabIndex = 48;
            this.ServicesVarauslbl.Text = "Varauksen palvelut";
            this.ServicesVarauslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // palvelunNimiVarauslbl
            // 
            this.palvelunNimiVarauslbl.BackColor = System.Drawing.Color.Transparent;
            this.palvelunNimiVarauslbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.palvelunNimiVarauslbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.palvelunNimiVarauslbl.Location = new System.Drawing.Point(661, 415);
            this.palvelunNimiVarauslbl.Name = "palvelunNimiVarauslbl";
            this.palvelunNimiVarauslbl.Size = new System.Drawing.Size(87, 23);
            this.palvelunNimiVarauslbl.TabIndex = 51;
            this.palvelunNimiVarauslbl.Text = "Palvelu";
            this.palvelunNimiVarauslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // palveluLkmVarausNud
            // 
            this.palveluLkmVarausNud.Location = new System.Drawing.Point(754, 444);
            this.palveluLkmVarausNud.Name = "palveluLkmVarausNud";
            this.palveluLkmVarausNud.Size = new System.Drawing.Size(59, 23);
            this.palveluLkmVarausNud.TabIndex = 16;
            // 
            // palvelunNimiVarausCmb
            // 
            this.palvelunNimiVarausCmb.FormattingEnabled = true;
            this.palvelunNimiVarausCmb.Location = new System.Drawing.Point(754, 412);
            this.palvelunNimiVarausCmb.Name = "palvelunNimiVarausCmb";
            this.palvelunNimiVarausCmb.Size = new System.Drawing.Size(130, 23);
            this.palvelunNimiVarausCmb.TabIndex = 15;
            // 
            // refreshVarausbtn
            // 
            this.refreshVarausbtn.Location = new System.Drawing.Point(1180, 111);
            this.refreshVarausbtn.Name = "refreshVarausbtn";
            this.refreshVarausbtn.Size = new System.Drawing.Size(84, 23);
            this.refreshVarausbtn.TabIndex = 7;
            this.refreshVarausbtn.Text = "Päivitä";
            this.refreshVarausbtn.UseVisualStyleBackColor = true;
            this.refreshVarausbtn.Click += new System.EventHandler(this.refreshVarausbtn_Click);
            // 
            // showRapportBtn
            // 
            this.showRapportBtn.Location = new System.Drawing.Point(1081, 580);
            this.showRapportBtn.Name = "showRapportBtn";
            this.showRapportBtn.Size = new System.Drawing.Size(93, 23);
            this.showRapportBtn.TabIndex = 22;
            this.showRapportBtn.Text = "Raportit";
            this.showRapportBtn.UseVisualStyleBackColor = true;
            this.showRapportBtn.Click += new System.EventHandler(this.showRapportBtn_Click);
            // 
            // VarausForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::NewbiezApp.Properties.Resources.sivutaustat1x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 697);
            this.Controls.Add(this.showRapportBtn);
            this.Controls.Add(this.refreshVarausbtn);
            this.Controls.Add(this.palvelunNimiVarausCmb);
            this.Controls.Add(this.palveluLkmVarausNud);
            this.Controls.Add(this.palvelunNimiVarauslbl);
            this.Controls.Add(this.ServicesVarauslbl);
            this.Controls.Add(this.deletePalveluVarausbtn);
            this.Controls.Add(this.editPalveluVarausbtn);
            this.Controls.Add(this.addPalveluVarausbtn);
            this.Controls.Add(this.varauksenPalvelutdgv);
            this.Controls.Add(this.billCreatedVarauslbl);
            this.Controls.Add(this.emptyVarausbtn);
            this.Controls.Add(this.miniPalvelupb);
            this.Controls.Add(this.sendBillVarauscb);
            this.Controls.Add(this.palveluLkmVarauslbl);
            this.Controls.Add(this.deleteVarausbtn);
            this.Controls.Add(this.editVarausbtn);
            this.Controls.Add(this.getVarausbtn);
            this.Controls.Add(this.addVarausbtn);
            this.Controls.Add(this.lastDayVarauslbl);
            this.Controls.Add(this.firstDayVarauslbl);
            this.Controls.Add(this.confirmedVarauslbl);
            this.Controls.Add(this.reservedVarauslbl);
            this.Controls.Add(this.mokkiIDVarauslbl);
            this.Controls.Add(this.asiakasIDVarauslbl);
            this.Controls.Add(this.varausIDlbl);
            this.Controls.Add(this.confirmedVarausdtp);
            this.Controls.Add(this.firstDayVarausdtp);
            this.Controls.Add(this.lastDayVarausdtp);
            this.Controls.Add(this.reservedVarausdtp);
            this.Controls.Add(this.mokkiIDVaraustb);
            this.Controls.Add(this.asiakasIDVaraustb);
            this.Controls.Add(this.varausIDtb);
            this.Controls.Add(this.varausDgv);
            this.Controls.Add(this.miniLaskutuspb);
            this.Controls.Add(this.miniAsiakastiedotpb);
            this.Controls.Add(this.miniMokitpb);
            this.Controls.Add(this.logopb);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 736);
            this.MinimumSize = new System.Drawing.Size(1300, 736);
            this.Name = "VarausForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Varaus";
            this.Load += new System.EventHandler(this.VarausForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMokitpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniAsiakastiedotpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniLaskutuspb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniPalvelupb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenPalvelutdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenPalvelutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluLkmVarausNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox logopb;
        private PictureBox miniMokitpb;
        private PictureBox miniAsiakastiedotpb;
        private PictureBox miniLaskutuspb;
        private DataGridView varausDgv;
        private TextBox varausIDtb;
        private TextBox asiakasIDVaraustb;
        private TextBox mokkiIDVaraustb;
        private DateTimePicker reservedVarausdtp;
        private DateTimePicker lastDayVarausdtp;
        private DateTimePicker firstDayVarausdtp;
        private DateTimePicker confirmedVarausdtp;
        private Label varausIDlbl;
        private Label asiakasIDVarauslbl;
        private Label mokkiIDVarauslbl;
        private Label reservedVarauslbl;
        private Label confirmedVarauslbl;
        private Label firstDayVarauslbl;
        private Label lastDayVarauslbl;
        private Button addVarausbtn;
        private Button getVarausbtn;
        private Button editVarausbtn;
        private Button deleteVarausbtn;
        private Label palveluLkmVarauslbl;
        private CheckBox sendBillVarauscb;
        private BindingSource varausBindingSource;
        private PictureBox miniPalvelupb;
        private Button emptyVarausbtn;
        private Label billCreatedVarauslbl;
        private DataGridView varauksenPalvelutdgv;
        private BindingSource varauksenPalvelutBindingSource;
        private Button addPalveluVarausbtn;
        private Button editPalveluVarausbtn;
        private Button deletePalveluVarausbtn;
        private Label ServicesVarauslbl;
        private Label palvelunNimiVarauslbl;
        private NumericUpDown palveluLkmVarausNud;
        private ComboBox palvelunNimiVarausCmb;
        private DataGridViewTextBoxColumn varausIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn palveluIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lkmDataGridViewTextBoxColumn;
        private Button refreshVarausbtn;
        private Button showRapportBtn;
        private DataGridViewTextBoxColumn varausIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn AsiakasId;
        private DataGridViewTextBoxColumn MokkiMokkiId;
        private DataGridViewTextBoxColumn VarattuPvm;
        private DataGridViewTextBoxColumn VahvistusPvm;
        private DataGridViewTextBoxColumn VarattuAlkupvm;
        private DataGridViewTextBoxColumn VarattuLoppupvm;
    }
}