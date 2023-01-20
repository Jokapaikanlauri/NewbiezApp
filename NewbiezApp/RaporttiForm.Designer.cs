namespace NewbiezApp
{
    partial class RaporttiForm
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
            this.logopb = new System.Windows.Forms.PictureBox();
            this.getRaportitLbl = new System.Windows.Forms.Label();
            this.alueRaportitCmb = new System.Windows.Forms.ComboBox();
            this.alueRaportitlbl = new System.Windows.Forms.Label();
            this.beginRaportitdtp = new System.Windows.Forms.DateTimePicker();
            this.endRaportitdtp = new System.Windows.Forms.DateTimePicker();
            this.Raportitcmb = new System.Windows.Forms.ComboBox();
            this.timeRaportitlbl = new System.Windows.Forms.Label();
            this.showRaportitBtn = new System.Windows.Forms.Button();
            this.dataRaportitLb = new System.Windows.Forms.ListBox();
            this.lpalveluRaportitCmb = new System.Windows.Forms.ComboBox();
            this.lpalveluRaportitlbl = new System.Windows.Forms.Label();
            this.LpalveluRaportitCb = new System.Windows.Forms.CheckBox();
            this.alueRaportitRb = new System.Windows.Forms.RadioButton();
            this.aikaRaportitRb = new System.Windows.Forms.RadioButton();
            this.lineRaportitLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).BeginInit();
            this.SuspendLayout();
            // 
            // logopb
            // 
            this.logopb.BackColor = System.Drawing.Color.Transparent;
            this.logopb.BackgroundImage = global::NewbiezApp.Properties.Resources.vnlogo;
            this.logopb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logopb.Location = new System.Drawing.Point(0, 0);
            this.logopb.Name = "logopb";
            this.logopb.Size = new System.Drawing.Size(160, 163);
            this.logopb.TabIndex = 2;
            this.logopb.TabStop = false;
            // 
            // getRaportitLbl
            // 
            this.getRaportitLbl.BackColor = System.Drawing.Color.Transparent;
            this.getRaportitLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getRaportitLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.getRaportitLbl.Location = new System.Drawing.Point(181, 24);
            this.getRaportitLbl.Name = "getRaportitLbl";
            this.getRaportitLbl.Size = new System.Drawing.Size(95, 23);
            this.getRaportitLbl.TabIndex = 60;
            this.getRaportitLbl.Text = "Hae";
            this.getRaportitLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alueRaportitCmb
            // 
            this.alueRaportitCmb.FormattingEnabled = true;
            this.alueRaportitCmb.Location = new System.Drawing.Point(294, 89);
            this.alueRaportitCmb.Name = "alueRaportitCmb";
            this.alueRaportitCmb.Size = new System.Drawing.Size(130, 23);
            this.alueRaportitCmb.TabIndex = 59;
            // 
            // alueRaportitlbl
            // 
            this.alueRaportitlbl.BackColor = System.Drawing.Color.Transparent;
            this.alueRaportitlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alueRaportitlbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.alueRaportitlbl.Location = new System.Drawing.Point(186, 89);
            this.alueRaportitlbl.Name = "alueRaportitlbl";
            this.alueRaportitlbl.Size = new System.Drawing.Size(90, 23);
            this.alueRaportitlbl.TabIndex = 58;
            this.alueRaportitlbl.Text = "Alueelta";
            this.alueRaportitlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // beginRaportitdtp
            // 
            this.beginRaportitdtp.Location = new System.Drawing.Point(576, 89);
            this.beginRaportitdtp.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.beginRaportitdtp.Name = "beginRaportitdtp";
            this.beginRaportitdtp.Size = new System.Drawing.Size(200, 23);
            this.beginRaportitdtp.TabIndex = 63;
            this.beginRaportitdtp.Value = new System.DateTime(2022, 4, 30, 0, 0, 0, 0);
            // 
            // endRaportitdtp
            // 
            this.endRaportitdtp.Location = new System.Drawing.Point(803, 89);
            this.endRaportitdtp.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.endRaportitdtp.Name = "endRaportitdtp";
            this.endRaportitdtp.Size = new System.Drawing.Size(200, 23);
            this.endRaportitdtp.TabIndex = 64;
            this.endRaportitdtp.Value = new System.DateTime(2022, 4, 30, 0, 0, 0, 0);
            // 
            // Raportitcmb
            // 
            this.Raportitcmb.FormattingEnabled = true;
            this.Raportitcmb.Items.AddRange(new object[] {
            "Majoittumiset",
            "Palvelut"});
            this.Raportitcmb.Location = new System.Drawing.Point(294, 27);
            this.Raportitcmb.Name = "Raportitcmb";
            this.Raportitcmb.Size = new System.Drawing.Size(130, 23);
            this.Raportitcmb.TabIndex = 65;
            this.Raportitcmb.Click += new System.EventHandler(this.Raportitcmb_Click);
            // 
            // timeRaportitlbl
            // 
            this.timeRaportitlbl.BackColor = System.Drawing.Color.Transparent;
            this.timeRaportitlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeRaportitlbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timeRaportitlbl.Location = new System.Drawing.Point(456, 89);
            this.timeRaportitlbl.Name = "timeRaportitlbl";
            this.timeRaportitlbl.Size = new System.Drawing.Size(114, 23);
            this.timeRaportitlbl.TabIndex = 66;
            this.timeRaportitlbl.Text = "Aikavälillä";
            this.timeRaportitlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showRaportitBtn
            // 
            this.showRaportitBtn.Location = new System.Drawing.Point(856, 140);
            this.showRaportitBtn.Name = "showRaportitBtn";
            this.showRaportitBtn.Size = new System.Drawing.Size(93, 23);
            this.showRaportitBtn.TabIndex = 67;
            this.showRaportitBtn.Text = "Näytä";
            this.showRaportitBtn.UseVisualStyleBackColor = true;
            this.showRaportitBtn.Click += new System.EventHandler(this.showRaportitBtn_Click);
            // 
            // dataRaportitLb
            // 
            this.dataRaportitLb.FormattingEnabled = true;
            this.dataRaportitLb.ItemHeight = 15;
            this.dataRaportitLb.Location = new System.Drawing.Point(267, 180);
            this.dataRaportitLb.Name = "dataRaportitLb";
            this.dataRaportitLb.ScrollAlwaysVisible = true;
            this.dataRaportitLb.Size = new System.Drawing.Size(682, 334);
            this.dataRaportitLb.TabIndex = 69;
            // 
            // lpalveluRaportitCmb
            // 
            this.lpalveluRaportitCmb.FormattingEnabled = true;
            this.lpalveluRaportitCmb.Location = new System.Drawing.Point(723, 27);
            this.lpalveluRaportitCmb.Name = "lpalveluRaportitCmb";
            this.lpalveluRaportitCmb.Size = new System.Drawing.Size(130, 23);
            this.lpalveluRaportitCmb.TabIndex = 70;
            // 
            // lpalveluRaportitlbl
            // 
            this.lpalveluRaportitlbl.BackColor = System.Drawing.Color.Transparent;
            this.lpalveluRaportitlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lpalveluRaportitlbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lpalveluRaportitlbl.Location = new System.Drawing.Point(622, 27);
            this.lpalveluRaportitlbl.Name = "lpalveluRaportitlbl";
            this.lpalveluRaportitlbl.Size = new System.Drawing.Size(95, 23);
            this.lpalveluRaportitlbl.TabIndex = 71;
            this.lpalveluRaportitlbl.Text = "Lisäpalvelu";
            this.lpalveluRaportitlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LpalveluRaportitCb
            // 
            this.LpalveluRaportitCb.AutoSize = true;
            this.LpalveluRaportitCb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LpalveluRaportitCb.Location = new System.Drawing.Point(456, 29);
            this.LpalveluRaportitCb.Name = "LpalveluRaportitCb";
            this.LpalveluRaportitCb.Size = new System.Drawing.Size(160, 21);
            this.LpalveluRaportitCb.TabIndex = 72;
            this.LpalveluRaportitCb.Text = "Hae tiettyä lisäpalvelua";
            this.LpalveluRaportitCb.UseVisualStyleBackColor = true;
            this.LpalveluRaportitCb.CheckedChanged += new System.EventHandler(this.LpalveluRaportitCb_CheckedChanged);
            // 
            // alueRaportitRb
            // 
            this.alueRaportitRb.AutoSize = true;
            this.alueRaportitRb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alueRaportitRb.Location = new System.Drawing.Point(884, 28);
            this.alueRaportitRb.Name = "alueRaportitRb";
            this.alueRaportitRb.Size = new System.Drawing.Size(71, 21);
            this.alueRaportitRb.TabIndex = 73;
            this.alueRaportitRb.TabStop = true;
            this.alueRaportitRb.Text = "Alueella";
            this.alueRaportitRb.UseVisualStyleBackColor = true;
            this.alueRaportitRb.CheckedChanged += new System.EventHandler(this.alueRaportitRb_CheckedChanged);
            // 
            // aikaRaportitRb
            // 
            this.aikaRaportitRb.AutoSize = true;
            this.aikaRaportitRb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aikaRaportitRb.Location = new System.Drawing.Point(961, 28);
            this.aikaRaportitRb.Name = "aikaRaportitRb";
            this.aikaRaportitRb.Size = new System.Drawing.Size(82, 21);
            this.aikaRaportitRb.TabIndex = 74;
            this.aikaRaportitRb.TabStop = true;
            this.aikaRaportitRb.Text = "Aikavälillä";
            this.aikaRaportitRb.UseVisualStyleBackColor = true;
            this.aikaRaportitRb.CheckedChanged += new System.EventHandler(this.aikaRaportitRb_CheckedChanged);
            // 
            // lineRaportitLbl
            // 
            this.lineRaportitLbl.BackColor = System.Drawing.Color.Transparent;
            this.lineRaportitLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lineRaportitLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lineRaportitLbl.Location = new System.Drawing.Point(782, 90);
            this.lineRaportitLbl.Name = "lineRaportitLbl";
            this.lineRaportitLbl.Size = new System.Drawing.Size(15, 23);
            this.lineRaportitLbl.TabIndex = 75;
            this.lineRaportitLbl.Text = "-";
            this.lineRaportitLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RaporttiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1092, 586);
            this.Controls.Add(this.lineRaportitLbl);
            this.Controls.Add(this.aikaRaportitRb);
            this.Controls.Add(this.alueRaportitRb);
            this.Controls.Add(this.LpalveluRaportitCb);
            this.Controls.Add(this.lpalveluRaportitlbl);
            this.Controls.Add(this.lpalveluRaportitCmb);
            this.Controls.Add(this.dataRaportitLb);
            this.Controls.Add(this.showRaportitBtn);
            this.Controls.Add(this.timeRaportitlbl);
            this.Controls.Add(this.Raportitcmb);
            this.Controls.Add(this.endRaportitdtp);
            this.Controls.Add(this.beginRaportitdtp);
            this.Controls.Add(this.getRaportitLbl);
            this.Controls.Add(this.alueRaportitCmb);
            this.Controls.Add(this.alueRaportitlbl);
            this.Controls.Add(this.logopb);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1108, 625);
            this.MinimumSize = new System.Drawing.Size(1108, 625);
            this.Name = "RaporttiForm";
            this.Text = "Raportit";
            this.Load += new System.EventHandler(this.RaporttiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox logopb;
        private Label getRaportitLbl;
        private ComboBox alueRaportitCmb;
        private Label alueRaportitlbl;
        private DateTimePicker beginRaportitdtp;
        private DateTimePicker endRaportitdtp;
        private ComboBox Raportitcmb;
        private Label timeRaportitlbl;
        private Button showRaportitBtn;
        private ListBox dataRaportitLb;
        private ComboBox lpalveluRaportitCmb;
        private Label lpalveluRaportitlbl;
        private CheckBox LpalveluRaportitCb;
        private RadioButton alueRaportitRb;
        private RadioButton aikaRaportitRb;
        private Label lineRaportitLbl;
    }
}