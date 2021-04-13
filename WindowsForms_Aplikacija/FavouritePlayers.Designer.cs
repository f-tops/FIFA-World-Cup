namespace WindowsForms_Aplikacija
{
    partial class FavouritePlayers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbAllPlayers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFavPlayers = new System.Windows.Forms.ListBox();
            this.btnLijevo = new System.Windows.Forms.Button();
            this.btnDesno = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igračiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brojGolovaIKartonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brojPosjetiteljaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postavkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Svi igrači";
            // 
            // lbAllPlayers
            // 
            this.lbAllPlayers.FormattingEnabled = true;
            this.lbAllPlayers.Location = new System.Drawing.Point(63, 138);
            this.lbAllPlayers.Name = "lbAllPlayers";
            this.lbAllPlayers.Size = new System.Drawing.Size(197, 225);
            this.lbAllPlayers.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Omiljeni igrači (maksimalno 3)";
            // 
            // lbFavPlayers
            // 
            this.lbFavPlayers.FormattingEnabled = true;
            this.lbFavPlayers.Location = new System.Drawing.Point(349, 138);
            this.lbFavPlayers.Name = "lbFavPlayers";
            this.lbFavPlayers.Size = new System.Drawing.Size(196, 225);
            this.lbFavPlayers.TabIndex = 2;
            // 
            // btnLijevo
            // 
            this.btnLijevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLijevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLijevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLijevo.Location = new System.Drawing.Point(268, 216);
            this.btnLijevo.Name = "btnLijevo";
            this.btnLijevo.Size = new System.Drawing.Size(75, 23);
            this.btnLijevo.TabIndex = 7;
            this.btnLijevo.Text = "<<<";
            this.btnLijevo.UseVisualStyleBackColor = false;
            this.btnLijevo.Click += new System.EventHandler(this.btnLijevo_Click);
            // 
            // btnDesno
            // 
            this.btnDesno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDesno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDesno.Location = new System.Drawing.Point(268, 303);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(75, 23);
            this.btnDesno.TabIndex = 8;
            this.btnDesno.Text = ">>>";
            this.btnDesno.UseVisualStyleBackColor = false;
            this.btnDesno.Click += new System.EventHandler(this.btnDesno_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.kategorijeToolStripMenuItem,
            this.postavkeToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(593, 24);
            this.menuStrip2.TabIndex = 16;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // kategorijeToolStripMenuItem
            // 
            this.kategorijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.igračiToolStripMenuItem,
            this.rangListeToolStripMenuItem});
            this.kategorijeToolStripMenuItem.Name = "kategorijeToolStripMenuItem";
            this.kategorijeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.kategorijeToolStripMenuItem.Text = "Kategorije";
            // 
            // igračiToolStripMenuItem
            // 
            this.igračiToolStripMenuItem.Name = "igračiToolStripMenuItem";
            this.igračiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.igračiToolStripMenuItem.Text = "Igrači";
            this.igračiToolStripMenuItem.Click += new System.EventHandler(this.igračiToolStripMenuItem_Click);
            // 
            // rangListeToolStripMenuItem
            // 
            this.rangListeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brojGolovaIKartonaToolStripMenuItem,
            this.brojPosjetiteljaToolStripMenuItem});
            this.rangListeToolStripMenuItem.Name = "rangListeToolStripMenuItem";
            this.rangListeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rangListeToolStripMenuItem.Text = "Rang liste";
            // 
            // brojGolovaIKartonaToolStripMenuItem
            // 
            this.brojGolovaIKartonaToolStripMenuItem.Name = "brojGolovaIKartonaToolStripMenuItem";
            this.brojGolovaIKartonaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.brojGolovaIKartonaToolStripMenuItem.Text = "Broj golova i kartona";
            this.brojGolovaIKartonaToolStripMenuItem.Click += new System.EventHandler(this.brojGolovaIKartonaToolStripMenuItem_Click);
            // 
            // brojPosjetiteljaToolStripMenuItem
            // 
            this.brojPosjetiteljaToolStripMenuItem.Name = "brojPosjetiteljaToolStripMenuItem";
            this.brojPosjetiteljaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.brojPosjetiteljaToolStripMenuItem.Text = "Broj posjetitelja";
            this.brojPosjetiteljaToolStripMenuItem.Click += new System.EventHandler(this.brojPosjetiteljaToolStripMenuItem_Click);
            // 
            // postavkeToolStripMenuItem
            // 
            this.postavkeToolStripMenuItem.Name = "postavkeToolStripMenuItem";
            this.postavkeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.postavkeToolStripMenuItem.Text = "Postavke";
            this.postavkeToolStripMenuItem.Click += new System.EventHandler(this.postavkeToolStripMenuItem_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSpremi.Location = new System.Drawing.Point(268, 380);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 18;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(23, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 58);
            this.panel1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "OMILJENI IGRAČI";
            // 
            // FavouritePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnDesno);
            this.Controls.Add(this.btnLijevo);
            this.Controls.Add(this.lbAllPlayers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFavPlayers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FavouritePlayers";
            this.Size = new System.Drawing.Size(593, 412);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAllPlayers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbFavPlayers;
        private System.Windows.Forms.Button btnLijevo;
        private System.Windows.Forms.Button btnDesno;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igračiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rangListeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postavkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brojGolovaIKartonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brojPosjetiteljaToolStripMenuItem;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}
