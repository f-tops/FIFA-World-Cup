namespace WindowsForms_Aplikacija
{
    partial class MainForm
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
            this.favouritePlayers2 = new WindowsForms_Aplikacija.FavouritePlayers();
            this.SuspendLayout();
            // 
            // favouritePlayers2
            // 
            this.favouritePlayers2.Location = new System.Drawing.Point(-3, -1);
            this.favouritePlayers2.Name = "favouritePlayers2";
            this.favouritePlayers2.Size = new System.Drawing.Size(643, 450);
            this.favouritePlayers2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.favouritePlayers2);
            this.Name = "MainForm";
            this.Text = "Omiljeni igrači";
            this.ResumeLayout(false);

        }

        #endregion

        private FavouritePlayers favouritePlayers1;
        private FavouritePlayers favouritePlayers2;
    }
}