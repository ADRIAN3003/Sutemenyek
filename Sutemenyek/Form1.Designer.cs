
namespace Sutemenyek
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mFajl = new System.Windows.Forms.ToolStripMenuItem();
            this.mSutemenyek = new System.Windows.Forms.ToolStripMenuItem();
            this.mNevjegy = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdSutemeny = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFajl,
            this.mSutemenyek,
            this.mNevjegy});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mFajl
            // 
            this.mFajl.Name = "mFajl";
            this.mFajl.Size = new System.Drawing.Size(37, 20);
            this.mFajl.Text = "Fájl";
            this.mFajl.Click += new System.EventHandler(this.mFajl_Click);
            // 
            // mSutemenyek
            // 
            this.mSutemenyek.Enabled = false;
            this.mSutemenyek.Name = "mSutemenyek";
            this.mSutemenyek.Size = new System.Drawing.Size(84, 20);
            this.mSutemenyek.Text = "Sütemények";
            this.mSutemenyek.Click += new System.EventHandler(this.mSutemenyek_Click);
            // 
            // mNevjegy
            // 
            this.mNevjegy.Name = "mNevjegy";
            this.mNevjegy.Size = new System.Drawing.Size(62, 20);
            this.mNevjegy.Text = "Névjegy";
            this.mNevjegy.Click += new System.EventHandler(this.mNevjegy_Click);
            // 
            // ofdSutemeny
            // 
            this.ofdSutemeny.Filter = "Adatfájl|*.txt";
            this.ofdSutemeny.Title = "Fájl kiválasztása";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(418, 413);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sütemények";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mFajl;
        private System.Windows.Forms.ToolStripMenuItem mSutemenyek;
        private System.Windows.Forms.ToolStripMenuItem mNevjegy;
        private System.Windows.Forms.OpenFileDialog ofdSutemeny;
    }
}

