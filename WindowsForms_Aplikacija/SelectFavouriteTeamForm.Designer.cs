namespace WindowsForms_Aplikacija
{
    partial class SelectFavouriteTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectFavouriteTeamForm));
            this.lblOdabirTima = new System.Windows.Forms.Label();
            this.cbTimovi = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNaslovTim = new System.Windows.Forms.Label();
            this.btnSprem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOdabirTima
            // 
            this.lblOdabirTima.AutoSize = true;
            this.lblOdabirTima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdabirTima.Location = new System.Drawing.Point(107, 201);
            this.lblOdabirTima.Name = "lblOdabirTima";
            this.lblOdabirTima.Size = new System.Drawing.Size(123, 13);
            this.lblOdabirTima.TabIndex = 0;
            this.lblOdabirTima.Text = "Odaberi najdraži tim:";
            // 
            // cbTimovi
            // 
            this.cbTimovi.FormattingEnabled = true;
            this.cbTimovi.Location = new System.Drawing.Point(98, 227);
            this.cbTimovi.Name = "cbTimovi";
            this.cbTimovi.Size = new System.Drawing.Size(136, 21);
            this.cbTimovi.TabIndex = 1;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(207, 319);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 2;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblNaslovTim);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 100);
            this.panel1.TabIndex = 3;
            // 
            // lblNaslovTim
            // 
            this.lblNaslovTim.AutoSize = true;
            this.lblNaslovTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslovTim.Location = new System.Drawing.Point(122, 19);
            this.lblNaslovTim.Name = "lblNaslovTim";
            this.lblNaslovTim.Size = new System.Drawing.Size(68, 33);
            this.lblNaslovTim.TabIndex = 0;
            this.lblNaslovTim.Text = "TIM";
            // 
            // btnSprem
            // 
            this.btnSprem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSprem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSprem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSprem.Location = new System.Drawing.Point(98, 273);
            this.btnSprem.Name = "btnSprem";
            this.btnSprem.Size = new System.Drawing.Size(132, 36);
            this.btnSprem.TabIndex = 6;
            this.btnSprem.Text = "SPREMI";
            this.btnSprem.UseVisualStyleBackColor = false;
            this.btnSprem.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 68);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // SelectFavouriteTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 321);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSprem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.cbTimovi);
            this.Controls.Add(this.lblOdabirTima);
            this.Name = "SelectFavouriteTeamForm";
            this.Text = "SelectFavouriteTeam";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOdabirTima;
        private System.Windows.Forms.ComboBox cbTimovi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNaslovTim;
        private System.Windows.Forms.Button btnSprem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}