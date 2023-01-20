namespace NewbiezApp
{
    partial class VillageNewbies
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.alueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logopb = new System.Windows.Forms.PictureBox();
            this.asiakastiedotpb = new System.Windows.Forms.PictureBox();
            this.laskutuspb = new System.Windows.Forms.PictureBox();
            this.mokitpb = new System.Windows.Forms.PictureBox();
            this.varauksetpb = new System.Windows.Forms.PictureBox();
            this.laskutuslbl = new System.Windows.Forms.Label();
            this.asiakastiedotlbl = new System.Windows.Forms.Label();
            this.majoituslbl = new System.Windows.Forms.Label();
            this.varauksetlbl = new System.Windows.Forms.Label();
            this.palvelutlbl = new System.Windows.Forms.Label();
            this.palvelupb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakastiedotpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskutuspb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokitpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palvelupb)).BeginInit();
            this.SuspendLayout();
            // 
            // alueBindingSource
            // 
            this.alueBindingSource.DataSource = typeof(NewbiezApp.Classes.Alue);
            // 
            // logopb
            // 
            this.logopb.BackColor = System.Drawing.Color.Transparent;
            this.logopb.BackgroundImage = global::NewbiezApp.Properties.Resources.vnlogo;
            this.logopb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logopb.Location = new System.Drawing.Point(12, 12);
            this.logopb.Name = "logopb";
            this.logopb.Size = new System.Drawing.Size(90, 93);
            this.logopb.TabIndex = 0;
            this.logopb.TabStop = false;
            // 
            // asiakastiedotpb
            // 
            this.asiakastiedotpb.BackColor = System.Drawing.Color.Transparent;
            this.asiakastiedotpb.BackgroundImage = global::NewbiezApp.Properties.Resources.icons8_business_group_96_1_;
            this.asiakastiedotpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.asiakastiedotpb.Location = new System.Drawing.Point(300, 245);
            this.asiakastiedotpb.Name = "asiakastiedotpb";
            this.asiakastiedotpb.Size = new System.Drawing.Size(186, 181);
            this.asiakastiedotpb.TabIndex = 1;
            this.asiakastiedotpb.TabStop = false;
            this.asiakastiedotpb.Click += new System.EventHandler(this.asiakastiedotpb_Click);
            // 
            // laskutuspb
            // 
            this.laskutuspb.BackColor = System.Drawing.Color.Transparent;
            this.laskutuspb.BackgroundImage = global::NewbiezApp.Properties.Resources.icons8_check_dollar_96_1_;
            this.laskutuspb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.laskutuspb.Location = new System.Drawing.Point(50, 245);
            this.laskutuspb.Name = "laskutuspb";
            this.laskutuspb.Size = new System.Drawing.Size(190, 181);
            this.laskutuspb.TabIndex = 2;
            this.laskutuspb.TabStop = false;
            this.laskutuspb.Click += new System.EventHandler(this.laskutuspb_Click);
            // 
            // mokitpb
            // 
            this.mokitpb.BackColor = System.Drawing.Color.Transparent;
            this.mokitpb.BackgroundImage = global::NewbiezApp.Properties.Resources.icons8_country_house_96;
            this.mokitpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mokitpb.Location = new System.Drawing.Point(550, 245);
            this.mokitpb.Name = "mokitpb";
            this.mokitpb.Size = new System.Drawing.Size(177, 181);
            this.mokitpb.TabIndex = 3;
            this.mokitpb.TabStop = false;
            this.mokitpb.Click += new System.EventHandler(this.mokitpb_Click);
            // 
            // varauksetpb
            // 
            this.varauksetpb.BackColor = System.Drawing.Color.Transparent;
            this.varauksetpb.BackgroundImage = global::NewbiezApp.Properties.Resources.icons8_briefcase_96;
            this.varauksetpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.varauksetpb.Location = new System.Drawing.Point(800, 245);
            this.varauksetpb.Name = "varauksetpb";
            this.varauksetpb.Size = new System.Drawing.Size(185, 181);
            this.varauksetpb.TabIndex = 4;
            this.varauksetpb.TabStop = false;
            this.varauksetpb.Click += new System.EventHandler(this.varauksetpb_Click);
            // 
            // laskutuslbl
            // 
            this.laskutuslbl.AutoSize = true;
            this.laskutuslbl.BackColor = System.Drawing.Color.Transparent;
            this.laskutuslbl.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.laskutuslbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.laskutuslbl.Location = new System.Drawing.Point(78, 429);
            this.laskutuslbl.Name = "laskutuslbl";
            this.laskutuslbl.Size = new System.Drawing.Size(131, 31);
            this.laskutuslbl.TabIndex = 5;
            this.laskutuslbl.Text = "LASKUTUS";
            // 
            // asiakastiedotlbl
            // 
            this.asiakastiedotlbl.AutoSize = true;
            this.asiakastiedotlbl.BackColor = System.Drawing.Color.Transparent;
            this.asiakastiedotlbl.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.asiakastiedotlbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.asiakastiedotlbl.Location = new System.Drawing.Point(298, 428);
            this.asiakastiedotlbl.Name = "asiakastiedotlbl";
            this.asiakastiedotlbl.Size = new System.Drawing.Size(188, 31);
            this.asiakastiedotlbl.TabIndex = 6;
            this.asiakastiedotlbl.Text = "ASIAKASTIEDOT";
            // 
            // majoituslbl
            // 
            this.majoituslbl.AutoSize = true;
            this.majoituslbl.BackColor = System.Drawing.Color.Transparent;
            this.majoituslbl.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.majoituslbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.majoituslbl.Location = new System.Drawing.Point(577, 428);
            this.majoituslbl.Name = "majoituslbl";
            this.majoituslbl.Size = new System.Drawing.Size(130, 31);
            this.majoituslbl.TabIndex = 7;
            this.majoituslbl.Text = "MAJOITUS";
            // 
            // varauksetlbl
            // 
            this.varauksetlbl.AutoSize = true;
            this.varauksetlbl.BackColor = System.Drawing.Color.Transparent;
            this.varauksetlbl.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.varauksetlbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.varauksetlbl.Location = new System.Drawing.Point(822, 429);
            this.varauksetlbl.Name = "varauksetlbl";
            this.varauksetlbl.Size = new System.Drawing.Size(145, 31);
            this.varauksetlbl.TabIndex = 8;
            this.varauksetlbl.Text = "VARAUKSET";
            // 
            // palvelutlbl
            // 
            this.palvelutlbl.AutoSize = true;
            this.palvelutlbl.BackColor = System.Drawing.Color.Transparent;
            this.palvelutlbl.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.palvelutlbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.palvelutlbl.Location = new System.Drawing.Point(1081, 429);
            this.palvelutlbl.Name = "palvelutlbl";
            this.palvelutlbl.Size = new System.Drawing.Size(123, 31);
            this.palvelutlbl.TabIndex = 10;
            this.palvelutlbl.Text = "PALVELUT";
            // 
            // palvelupb
            // 
            this.palvelupb.BackColor = System.Drawing.Color.Transparent;
            this.palvelupb.BackgroundImage = global::NewbiezApp.Properties.Resources.palvelubutton;
            this.palvelupb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.palvelupb.Location = new System.Drawing.Point(1050, 245);
            this.palvelupb.Name = "palvelupb";
            this.palvelupb.Size = new System.Drawing.Size(185, 181);
            this.palvelupb.TabIndex = 11;
            this.palvelupb.TabStop = false;
            this.palvelupb.Click += new System.EventHandler(this.palvelupb_Click);
            // 
            // VillageNewbies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewbiezApp.Properties.Resources.aloitustaustakuva;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 697);
            this.Controls.Add(this.palvelupb);
            this.Controls.Add(this.palvelutlbl);
            this.Controls.Add(this.varauksetlbl);
            this.Controls.Add(this.majoituslbl);
            this.Controls.Add(this.asiakastiedotlbl);
            this.Controls.Add(this.laskutuslbl);
            this.Controls.Add(this.varauksetpb);
            this.Controls.Add(this.mokitpb);
            this.Controls.Add(this.laskutuspb);
            this.Controls.Add(this.asiakastiedotpb);
            this.Controls.Add(this.logopb);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 736);
            this.MinimumSize = new System.Drawing.Size(1300, 736);
            this.Name = "VillageNewbies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Village Newbies Application 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakastiedotpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskutuspb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokitpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palvelupb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource alueBindingSource;
        private PictureBox logopb;
        private PictureBox asiakastiedotpb;
        private PictureBox laskutuspb;
        private PictureBox mokitpb;
        private PictureBox varauksetpb;
        private Label laskutuslbl;
        private Label asiakastiedotlbl;
        private Label majoituslbl;
        private Label varauksetlbl;
        private Label palvelutlbl;
        private PictureBox palvelupb;
    }
}