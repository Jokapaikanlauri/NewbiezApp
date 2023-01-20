namespace NewbiezApp
{
    partial class LaskutForm
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
            this.laskutDgv = new System.Windows.Forms.DataGridView();
            this.laskuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laskuIDtb = new System.Windows.Forms.TextBox();
            this.editLaskutbtn = new System.Windows.Forms.Button();
            this.getLaskutbtn = new System.Windows.Forms.Button();
            this.summaLaskutlbl = new System.Windows.Forms.Label();
            this.alvLaskutlbl = new System.Windows.Forms.Label();
            this.varausIDlbl = new System.Windows.Forms.Label();
            this.laskuIDlbl = new System.Windows.Forms.Label();
            this.showLaskutbtn = new System.Windows.Forms.Button();
            this.miniPalvelupb = new System.Windows.Forms.PictureBox();
            this.tilaLaskutlbl = new System.Windows.Forms.Label();
            this.varausIDcb = new System.Windows.Forms.ComboBox();
            this.alvLaskutNum = new System.Windows.Forms.NumericUpDown();
            this.summaLaskutNum = new System.Windows.Forms.NumericUpDown();
            this.refreshLaskutbtn = new System.Windows.Forms.Button();
            this.tilaLaskutcb = new System.Windows.Forms.ComboBox();
            this.muistutusLaskulbl = new System.Windows.Forms.Label();
            this.muistutusLaskuNum = new System.Windows.Forms.NumericUpDown();
            this.laskuIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varausIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniAsiakastiedotpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMokitpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniVarauksetpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskutDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniPalvelupb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alvLaskutNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summaLaskutNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muistutusLaskuNum)).BeginInit();
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
            this.logopb.TabIndex = 1;
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
            this.miniAsiakastiedotpb.TabIndex = 7;
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
            this.miniMokitpb.TabIndex = 8;
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
            this.miniVarauksetpb.TabIndex = 9;
            this.miniVarauksetpb.TabStop = false;
            this.miniVarauksetpb.Click += new System.EventHandler(this.miniVarauksetpb_Click);
            // 
            // laskutDgv
            // 
            this.laskutDgv.AutoGenerateColumns = false;
            this.laskutDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.laskutDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.laskutDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.laskutDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laskutDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.laskuIdDataGridViewTextBoxColumn,
            this.varausIdDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn,
            this.alvDataGridViewTextBoxColumn,
            this.Tila});
            this.laskutDgv.DataSource = this.laskuBindingSource;
            this.laskutDgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.laskutDgv.Location = new System.Drawing.Point(12, 134);
            this.laskutDgv.Name = "laskutDgv";
            this.laskutDgv.RowTemplate.Height = 25;
            this.laskutDgv.Size = new System.Drawing.Size(752, 529);
            this.laskutDgv.TabIndex = 10;
            this.laskutDgv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.laskutDgv_MouseClick);
            // 
            // laskuBindingSource
            // 
            this.laskuBindingSource.DataSource = typeof(NewbiezApp.Classes.Lasku);
            // 
            // laskuIDtb
            // 
            this.laskuIDtb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laskuIDtb.Location = new System.Drawing.Point(1056, 208);
            this.laskuIDtb.Name = "laskuIDtb";
            this.laskuIDtb.Size = new System.Drawing.Size(155, 23);
            this.laskuIDtb.TabIndex = 1;
            // 
            // editLaskutbtn
            // 
            this.editLaskutbtn.Location = new System.Drawing.Point(807, 298);
            this.editLaskutbtn.Name = "editLaskutbtn";
            this.editLaskutbtn.Size = new System.Drawing.Size(100, 23);
            this.editLaskutbtn.TabIndex = 8;
            this.editLaskutbtn.Text = "Muokkaa";
            this.editLaskutbtn.UseVisualStyleBackColor = true;
            this.editLaskutbtn.Click += new System.EventHandler(this.editLaskutbtn_Click);
            // 
            // getLaskutbtn
            // 
            this.getLaskutbtn.Location = new System.Drawing.Point(807, 257);
            this.getLaskutbtn.Name = "getLaskutbtn";
            this.getLaskutbtn.Size = new System.Drawing.Size(100, 23);
            this.getLaskutbtn.TabIndex = 7;
            this.getLaskutbtn.Text = "Hae";
            this.getLaskutbtn.UseVisualStyleBackColor = true;
            this.getLaskutbtn.Click += new System.EventHandler(this.getLaskutbtn_Click);
            // 
            // summaLaskutlbl
            // 
            this.summaLaskutlbl.BackColor = System.Drawing.Color.Transparent;
            this.summaLaskutlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.summaLaskutlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.summaLaskutlbl.Location = new System.Drawing.Point(950, 297);
            this.summaLaskutlbl.Name = "summaLaskutlbl";
            this.summaLaskutlbl.Size = new System.Drawing.Size(100, 23);
            this.summaLaskutlbl.TabIndex = 13;
            this.summaLaskutlbl.Text = "Summa";
            this.summaLaskutlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alvLaskutlbl
            // 
            this.alvLaskutlbl.BackColor = System.Drawing.Color.Transparent;
            this.alvLaskutlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alvLaskutlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.alvLaskutlbl.Location = new System.Drawing.Point(950, 349);
            this.alvLaskutlbl.Name = "alvLaskutlbl";
            this.alvLaskutlbl.Size = new System.Drawing.Size(100, 23);
            this.alvLaskutlbl.TabIndex = 12;
            this.alvLaskutlbl.Text = "ALV";
            this.alvLaskutlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // varausIDlbl
            // 
            this.varausIDlbl.BackColor = System.Drawing.Color.Transparent;
            this.varausIDlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.varausIDlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.varausIDlbl.Location = new System.Drawing.Point(950, 256);
            this.varausIDlbl.Name = "varausIDlbl";
            this.varausIDlbl.Size = new System.Drawing.Size(100, 23);
            this.varausIDlbl.TabIndex = 14;
            this.varausIDlbl.Text = "Varaus ID";
            this.varausIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laskuIDlbl
            // 
            this.laskuIDlbl.BackColor = System.Drawing.Color.Transparent;
            this.laskuIDlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laskuIDlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.laskuIDlbl.Location = new System.Drawing.Point(950, 208);
            this.laskuIDlbl.Name = "laskuIDlbl";
            this.laskuIDlbl.Size = new System.Drawing.Size(100, 23);
            this.laskuIDlbl.TabIndex = 11;
            this.laskuIDlbl.Text = "Lasku ID";
            this.laskuIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showLaskutbtn
            // 
            this.showLaskutbtn.Location = new System.Drawing.Point(807, 347);
            this.showLaskutbtn.Name = "showLaskutbtn";
            this.showLaskutbtn.Size = new System.Drawing.Size(100, 23);
            this.showLaskutbtn.TabIndex = 9;
            this.showLaskutbtn.Text = "Esikatsele";
            this.showLaskutbtn.UseVisualStyleBackColor = true;
            this.showLaskutbtn.Click += new System.EventHandler(this.showLaskutbtn_Click);
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
            // tilaLaskutlbl
            // 
            this.tilaLaskutlbl.BackColor = System.Drawing.Color.Transparent;
            this.tilaLaskutlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tilaLaskutlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tilaLaskutlbl.Location = new System.Drawing.Point(950, 399);
            this.tilaLaskutlbl.Name = "tilaLaskutlbl";
            this.tilaLaskutlbl.Size = new System.Drawing.Size(100, 23);
            this.tilaLaskutlbl.TabIndex = 45;
            this.tilaLaskutlbl.Text = "Laskun tila";
            this.tilaLaskutlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // varausIDcb
            // 
            this.varausIDcb.Enabled = false;
            this.varausIDcb.FormattingEnabled = true;
            this.varausIDcb.Location = new System.Drawing.Point(1053, 257);
            this.varausIDcb.Name = "varausIDcb";
            this.varausIDcb.Size = new System.Drawing.Size(158, 23);
            this.varausIDcb.TabIndex = 2;
            // 
            // alvLaskutNum
            // 
            this.alvLaskutNum.DecimalPlaces = 2;
            this.alvLaskutNum.Location = new System.Drawing.Point(1056, 347);
            this.alvLaskutNum.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.alvLaskutNum.Name = "alvLaskutNum";
            this.alvLaskutNum.Size = new System.Drawing.Size(155, 23);
            this.alvLaskutNum.TabIndex = 4;
            // 
            // summaLaskutNum
            // 
            this.summaLaskutNum.DecimalPlaces = 2;
            this.summaLaskutNum.Location = new System.Drawing.Point(1056, 297);
            this.summaLaskutNum.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.summaLaskutNum.Name = "summaLaskutNum";
            this.summaLaskutNum.Size = new System.Drawing.Size(155, 23);
            this.summaLaskutNum.TabIndex = 3;
            // 
            // refreshLaskutbtn
            // 
            this.refreshLaskutbtn.Location = new System.Drawing.Point(807, 207);
            this.refreshLaskutbtn.Name = "refreshLaskutbtn";
            this.refreshLaskutbtn.Size = new System.Drawing.Size(100, 23);
            this.refreshLaskutbtn.TabIndex = 6;
            this.refreshLaskutbtn.Text = "Päivitä";
            this.refreshLaskutbtn.UseVisualStyleBackColor = true;
            this.refreshLaskutbtn.Click += new System.EventHandler(this.refreshLaskutbtn_Click);
            // 
            // tilaLaskutcb
            // 
            this.tilaLaskutcb.FormattingEnabled = true;
            this.tilaLaskutcb.Items.AddRange(new object[] {
            "Sent",
            "Paid",
            "Reminded"});
            this.tilaLaskutcb.Location = new System.Drawing.Point(1056, 401);
            this.tilaLaskutcb.Name = "tilaLaskutcb";
            this.tilaLaskutcb.Size = new System.Drawing.Size(158, 23);
            this.tilaLaskutcb.TabIndex = 46;
            this.tilaLaskutcb.TextChanged += new System.EventHandler(this.tilaLaskutcb_TextChanged);
            // 
            // muistutusLaskulbl
            // 
            this.muistutusLaskulbl.AutoSize = true;
            this.muistutusLaskulbl.BackColor = System.Drawing.Color.Transparent;
            this.muistutusLaskulbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.muistutusLaskulbl.Location = new System.Drawing.Point(973, 458);
            this.muistutusLaskulbl.Name = "muistutusLaskulbl";
            this.muistutusLaskulbl.Size = new System.Drawing.Size(127, 15);
            this.muistutusLaskulbl.TabIndex = 47;
            this.muistutusLaskulbl.Text = "Aseta muistutusmaksu";
            this.muistutusLaskulbl.Visible = false;
            // 
            // muistutusLaskuNum
            // 
            this.muistutusLaskuNum.Location = new System.Drawing.Point(1120, 456);
            this.muistutusLaskuNum.Name = "muistutusLaskuNum";
            this.muistutusLaskuNum.Size = new System.Drawing.Size(94, 23);
            this.muistutusLaskuNum.TabIndex = 48;
            this.muistutusLaskuNum.Visible = false;
            // 
            // laskuIdDataGridViewTextBoxColumn
            // 
            this.laskuIdDataGridViewTextBoxColumn.DataPropertyName = "LaskuId";
            this.laskuIdDataGridViewTextBoxColumn.FillWeight = 69.79695F;
            this.laskuIdDataGridViewTextBoxColumn.HeaderText = "LaskuId";
            this.laskuIdDataGridViewTextBoxColumn.Name = "laskuIdDataGridViewTextBoxColumn";
            // 
            // varausIdDataGridViewTextBoxColumn
            // 
            this.varausIdDataGridViewTextBoxColumn.DataPropertyName = "VarausId";
            this.varausIdDataGridViewTextBoxColumn.FillWeight = 69.79695F;
            this.varausIdDataGridViewTextBoxColumn.HeaderText = "VarausId";
            this.varausIdDataGridViewTextBoxColumn.Name = "varausIdDataGridViewTextBoxColumn";
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            this.summaDataGridViewTextBoxColumn.FillWeight = 69.79695F;
            this.summaDataGridViewTextBoxColumn.HeaderText = "Summa";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            // 
            // alvDataGridViewTextBoxColumn
            // 
            this.alvDataGridViewTextBoxColumn.DataPropertyName = "Alv";
            this.alvDataGridViewTextBoxColumn.FillWeight = 50F;
            this.alvDataGridViewTextBoxColumn.HeaderText = "Alv";
            this.alvDataGridViewTextBoxColumn.Name = "alvDataGridViewTextBoxColumn";
            // 
            // Tila
            // 
            this.Tila.DataPropertyName = "Tila";
            this.Tila.FillWeight = 69.79695F;
            this.Tila.HeaderText = "Tila";
            this.Tila.Name = "Tila";
            // 
            // LaskutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewbiezApp.Properties.Resources.sivutaustat1x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 697);
            this.Controls.Add(this.muistutusLaskuNum);
            this.Controls.Add(this.muistutusLaskulbl);
            this.Controls.Add(this.tilaLaskutcb);
            this.Controls.Add(this.refreshLaskutbtn);
            this.Controls.Add(this.summaLaskutNum);
            this.Controls.Add(this.alvLaskutNum);
            this.Controls.Add(this.varausIDcb);
            this.Controls.Add(this.tilaLaskutlbl);
            this.Controls.Add(this.miniPalvelupb);
            this.Controls.Add(this.showLaskutbtn);
            this.Controls.Add(this.laskuIDlbl);
            this.Controls.Add(this.varausIDlbl);
            this.Controls.Add(this.alvLaskutlbl);
            this.Controls.Add(this.getLaskutbtn);
            this.Controls.Add(this.editLaskutbtn);
            this.Controls.Add(this.summaLaskutlbl);
            this.Controls.Add(this.laskuIDtb);
            this.Controls.Add(this.laskutDgv);
            this.Controls.Add(this.miniVarauksetpb);
            this.Controls.Add(this.miniMokitpb);
            this.Controls.Add(this.miniAsiakastiedotpb);
            this.Controls.Add(this.logopb);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 736);
            this.MinimumSize = new System.Drawing.Size(1300, 736);
            this.Name = "LaskutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laskut";
            this.Load += new System.EventHandler(this.LaskuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniAsiakastiedotpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMokitpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniVarauksetpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskutDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniPalvelupb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alvLaskutNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summaLaskutNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muistutusLaskuNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox logopb;
        private PictureBox miniAsiakastiedotpb;
        private PictureBox miniMokitpb;
        private PictureBox miniVarauksetpb;
        private DataGridView laskutDgv;
        private TextBox laskuIDtb;
        private Button editLaskutbtn;
        private Button getLaskutbtn;
        private BindingSource laskuBindingSource;
        private Label summaLaskutlbl;
        private Label alvLaskutlbl;
        private Label varausIDlbl;
        private Label laskuIDlbl;
        private Button showLaskutbtn;
        private PictureBox miniPalvelupb;
        private Label tilaLaskutlbl;
        private ComboBox varausIDcb;
        private NumericUpDown alvLaskutNum;
        private NumericUpDown summaLaskutNum;
        private Button refreshLaskutbtn;
        private ComboBox tilaLaskutcb;
        private Label muistutusLaskulbl;
        private NumericUpDown muistutusLaskuNum;
        private DataGridViewTextBoxColumn laskuIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn varausIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alvDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Tila;
    }
}