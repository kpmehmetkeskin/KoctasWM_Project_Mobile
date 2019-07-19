namespace KoctasWM_Project
{
    partial class KoliNoPopUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.koliNoText = new System.Windows.Forms.TextBox();
            this.koliNoLabel = new System.Windows.Forms.Label();
            this.checkListYazdir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // koliNoText
            // 
            this.koliNoText.Location = new System.Drawing.Point(26, 80);
            this.koliNoText.Name = "koliNoText";
            this.koliNoText.Size = new System.Drawing.Size(275, 23);
            this.koliNoText.TabIndex = 0;
            // 
            // koliNoLabel
            // 
            this.koliNoLabel.Location = new System.Drawing.Point(26, 57);
            this.koliNoLabel.Name = "koliNoLabel";
            this.koliNoLabel.Size = new System.Drawing.Size(275, 20);
            this.koliNoLabel.Text = "Koli Numarası";
            // 
            // checkListYazdir
            // 
            this.checkListYazdir.Location = new System.Drawing.Point(91, 119);
            this.checkListYazdir.Name = "checkListYazdir";
            this.checkListYazdir.Size = new System.Drawing.Size(116, 20);
            this.checkListYazdir.TabIndex = 2;
            this.checkListYazdir.Text = "yazdir";
            this.checkListYazdir.Click += new System.EventHandler(this.checkListYazdir_Click_1);
            // 
            // KoliNoPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.checkListYazdir);
            this.Controls.Add(this.koliNoLabel);
            this.Controls.Add(this.koliNoText);
            this.Menu = this.mainMenu1;
            this.Name = "KoliNoPopUp";
            this.Text = "Koli No Giriş";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox koliNoText;
        private System.Windows.Forms.Label koliNoLabel;
        private System.Windows.Forms.Button checkListYazdir;
    }
}