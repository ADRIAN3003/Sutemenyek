
namespace Sutemenyek
{
    partial class frmSutemenyek
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
            this.btnRendel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSomloi = new System.Windows.Forms.Label();
            this.lblRakoczi = new System.Windows.Forms.Label();
            this.lblCsoki = new System.Windows.Forms.Label();
            this.lblMarcipan = new System.Windows.Forms.Label();
            this.lblEszterhazy = new System.Windows.Forms.Label();
            this.nSomloi = new System.Windows.Forms.NumericUpDown();
            this.nRakoczi = new System.Windows.Forms.NumericUpDown();
            this.nCsoki = new System.Windows.Forms.NumericUpDown();
            this.nMarcipan = new System.Windows.Forms.NumericUpDown();
            this.nEszterhazy = new System.Windows.Forms.NumericUpDown();
            this.lblSomloiAr = new System.Windows.Forms.Label();
            this.lblRakocziAr = new System.Windows.Forms.Label();
            this.lblCsokiAr = new System.Windows.Forms.Label();
            this.lblEszterhazyAr = new System.Windows.Forms.Label();
            this.lblMarcipanAr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nSomloi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRakoczi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCsoki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMarcipan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEszterhazy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRendel
            // 
            this.btnRendel.Location = new System.Drawing.Point(189, 342);
            this.btnRendel.Name = "btnRendel";
            this.btnRendel.Size = new System.Drawing.Size(109, 32);
            this.btnRendel.TabIndex = 0;
            this.btnRendel.Text = "RENDEL";
            this.btnRendel.UseVisualStyleBackColor = true;
            this.btnRendel.Click += new System.EventHandler(this.btnRendel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(166, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Árlista";
            // 
            // lblSomloi
            // 
            this.lblSomloi.AutoSize = true;
            this.lblSomloi.Location = new System.Drawing.Point(69, 104);
            this.lblSomloi.Name = "lblSomloi";
            this.lblSomloi.Size = new System.Drawing.Size(116, 20);
            this.lblSomloi.TabIndex = 2;
            this.lblSomloi.Text = "Somlói galuska";
            // 
            // lblRakoczi
            // 
            this.lblRakoczi.AutoSize = true;
            this.lblRakoczi.Location = new System.Drawing.Point(69, 140);
            this.lblRakoczi.Name = "lblRakoczi";
            this.lblRakoczi.Size = new System.Drawing.Size(106, 20);
            this.lblRakoczi.TabIndex = 2;
            this.lblRakoczi.Text = "Rákózci túrós";
            // 
            // lblCsoki
            // 
            this.lblCsoki.AutoSize = true;
            this.lblCsoki.Location = new System.Drawing.Point(69, 177);
            this.lblCsoki.Name = "lblCsoki";
            this.lblCsoki.Size = new System.Drawing.Size(85, 20);
            this.lblCsoki.TabIndex = 2;
            this.lblCsoki.Text = "Csoki torta";
            // 
            // lblMarcipan
            // 
            this.lblMarcipan.AutoSize = true;
            this.lblMarcipan.Location = new System.Drawing.Point(69, 215);
            this.lblMarcipan.Name = "lblMarcipan";
            this.lblMarcipan.Size = new System.Drawing.Size(122, 20);
            this.lblMarcipan.TabIndex = 2;
            this.lblMarcipan.Text = "Marcipán alagút";
            // 
            // lblEszterhazy
            // 
            this.lblEszterhazy.AutoSize = true;
            this.lblEszterhazy.Location = new System.Drawing.Point(69, 252);
            this.lblEszterhazy.Name = "lblEszterhazy";
            this.lblEszterhazy.Size = new System.Drawing.Size(134, 20);
            this.lblEszterhazy.TabIndex = 2;
            this.lblEszterhazy.Text = "Eszterházy szelet";
            // 
            // nSomloi
            // 
            this.nSomloi.Location = new System.Drawing.Point(334, 102);
            this.nSomloi.Name = "nSomloi";
            this.nSomloi.Size = new System.Drawing.Size(42, 26);
            this.nSomloi.TabIndex = 3;
            this.nSomloi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nSomloi.ValueChanged += new System.EventHandler(this.nSomloi_ValueChanged);
            // 
            // nRakoczi
            // 
            this.nRakoczi.Location = new System.Drawing.Point(334, 138);
            this.nRakoczi.Name = "nRakoczi";
            this.nRakoczi.Size = new System.Drawing.Size(42, 26);
            this.nRakoczi.TabIndex = 3;
            this.nRakoczi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRakoczi.ValueChanged += new System.EventHandler(this.nRakoczi_ValueChanged);
            // 
            // nCsoki
            // 
            this.nCsoki.Location = new System.Drawing.Point(334, 175);
            this.nCsoki.Name = "nCsoki";
            this.nCsoki.Size = new System.Drawing.Size(42, 26);
            this.nCsoki.TabIndex = 3;
            this.nCsoki.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nCsoki.ValueChanged += new System.EventHandler(this.nCsoki_ValueChanged);
            // 
            // nMarcipan
            // 
            this.nMarcipan.Location = new System.Drawing.Point(334, 213);
            this.nMarcipan.Name = "nMarcipan";
            this.nMarcipan.Size = new System.Drawing.Size(42, 26);
            this.nMarcipan.TabIndex = 3;
            this.nMarcipan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMarcipan.ValueChanged += new System.EventHandler(this.nMarcipan_ValueChanged);
            // 
            // nEszterhazy
            // 
            this.nEszterhazy.Location = new System.Drawing.Point(334, 250);
            this.nEszterhazy.Name = "nEszterhazy";
            this.nEszterhazy.Size = new System.Drawing.Size(42, 26);
            this.nEszterhazy.TabIndex = 3;
            this.nEszterhazy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nEszterhazy.ValueChanged += new System.EventHandler(this.nEszterhazy_ValueChanged);
            // 
            // lblSomloiAr
            // 
            this.lblSomloiAr.AutoSize = true;
            this.lblSomloiAr.Location = new System.Drawing.Point(382, 104);
            this.lblSomloiAr.Name = "lblSomloiAr";
            this.lblSomloiAr.Size = new System.Drawing.Size(37, 20);
            this.lblSomloiAr.TabIndex = 2;
            this.lblSomloiAr.Text = "0 Ft";
            // 
            // lblRakocziAr
            // 
            this.lblRakocziAr.AutoSize = true;
            this.lblRakocziAr.Location = new System.Drawing.Point(382, 140);
            this.lblRakocziAr.Name = "lblRakocziAr";
            this.lblRakocziAr.Size = new System.Drawing.Size(37, 20);
            this.lblRakocziAr.TabIndex = 2;
            this.lblRakocziAr.Text = "0 Ft";
            // 
            // lblCsokiAr
            // 
            this.lblCsokiAr.AutoSize = true;
            this.lblCsokiAr.Location = new System.Drawing.Point(382, 177);
            this.lblCsokiAr.Name = "lblCsokiAr";
            this.lblCsokiAr.Size = new System.Drawing.Size(37, 20);
            this.lblCsokiAr.TabIndex = 2;
            this.lblCsokiAr.Text = "0 Ft";
            // 
            // lblEszterhazyAr
            // 
            this.lblEszterhazyAr.AutoSize = true;
            this.lblEszterhazyAr.Location = new System.Drawing.Point(382, 252);
            this.lblEszterhazyAr.Name = "lblEszterhazyAr";
            this.lblEszterhazyAr.Size = new System.Drawing.Size(37, 20);
            this.lblEszterhazyAr.TabIndex = 2;
            this.lblEszterhazyAr.Text = "0 Ft";
            // 
            // lblMarcipanAr
            // 
            this.lblMarcipanAr.AutoSize = true;
            this.lblMarcipanAr.Location = new System.Drawing.Point(382, 215);
            this.lblMarcipanAr.Name = "lblMarcipanAr";
            this.lblMarcipanAr.Size = new System.Drawing.Size(37, 20);
            this.lblMarcipanAr.TabIndex = 2;
            this.lblMarcipanAr.Text = "0 Ft";
            // 
            // frmSutemenyek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 418);
            this.Controls.Add(this.nEszterhazy);
            this.Controls.Add(this.nMarcipan);
            this.Controls.Add(this.nCsoki);
            this.Controls.Add(this.nRakoczi);
            this.Controls.Add(this.nSomloi);
            this.Controls.Add(this.lblEszterhazy);
            this.Controls.Add(this.lblMarcipan);
            this.Controls.Add(this.lblCsoki);
            this.Controls.Add(this.lblRakoczi);
            this.Controls.Add(this.lblMarcipanAr);
            this.Controls.Add(this.lblEszterhazyAr);
            this.Controls.Add(this.lblCsokiAr);
            this.Controls.Add(this.lblRakocziAr);
            this.Controls.Add(this.lblSomloiAr);
            this.Controls.Add(this.lblSomloi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRendel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSutemenyek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Itallap";
            this.Load += new System.EventHandler(this.frmSutemenyek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nSomloi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRakoczi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCsoki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMarcipan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEszterhazy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRendel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSomloi;
        private System.Windows.Forms.Label lblRakoczi;
        private System.Windows.Forms.Label lblCsoki;
        private System.Windows.Forms.Label lblMarcipan;
        private System.Windows.Forms.Label lblEszterhazy;
        private System.Windows.Forms.NumericUpDown nSomloi;
        private System.Windows.Forms.NumericUpDown nRakoczi;
        private System.Windows.Forms.NumericUpDown nCsoki;
        private System.Windows.Forms.NumericUpDown nMarcipan;
        private System.Windows.Forms.NumericUpDown nEszterhazy;
        private System.Windows.Forms.Label lblSomloiAr;
        private System.Windows.Forms.Label lblRakocziAr;
        private System.Windows.Forms.Label lblCsokiAr;
        private System.Windows.Forms.Label lblEszterhazyAr;
        private System.Windows.Forms.Label lblMarcipanAr;
    }
}