namespace BreakoutGame
{
    partial class BreakoutForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BreakoutForm));
            this.picPaddle = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuitGame = new System.Windows.Forms.Button();
            this.btnResme = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPaddle
            // 
            this.picPaddle.BackColor = System.Drawing.Color.Transparent;
            this.picPaddle.Image = ((System.Drawing.Image)(resources.GetObject("picPaddle.Image")));
            this.picPaddle.Location = new System.Drawing.Point(336, 526);
            this.picPaddle.Margin = new System.Windows.Forms.Padding(5);
            this.picPaddle.Name = "picPaddle";
            this.picPaddle.Size = new System.Drawing.Size(116, 12);
            this.picPaddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPaddle.TabIndex = 0;
            this.picPaddle.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Transparent;
            this.picBall.Image = ((System.Drawing.Image)(resources.GetObject("picBall.Image")));
            this.picBall.Location = new System.Drawing.Point(376, 486);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(32, 32);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBall.TabIndex = 1;
            this.picBall.TabStop = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGameOver.Location = new System.Drawing.Point(213, 13);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(364, 74);
            this.lblGameOver.TabIndex = 2;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "stone_block.png");
            this.imageList1.Images.SetKeyName(1, "blue_block.png");
            this.imageList1.Images.SetKeyName(2, "brown_block.png");
            this.imageList1.Images.SetKeyName(3, "green_block.png");
            this.imageList1.Images.SetKeyName(4, "pink_block.png");
            this.imageList1.Images.SetKeyName(5, "red_block.png");
            this.imageList1.Images.SetKeyName(6, "skyblue_block.png");
            this.imageList1.Images.SetKeyName(7, "violet_block.png");
            this.imageList1.Images.SetKeyName(8, "yellow_block.png");
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenu.BackgroundImage")));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.btnQuitGame);
            this.pnlMenu.Controls.Add(this.btnResme);
            this.pnlMenu.Controls.Add(this.btnNewGame);
            this.pnlMenu.Location = new System.Drawing.Point(192, 166);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(400, 300);
            this.pnlMenu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(136, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "MENU";
            // 
            // btnQuitGame
            // 
            this.btnQuitGame.BackColor = System.Drawing.Color.Gold;
            this.btnQuitGame.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitGame.ForeColor = System.Drawing.Color.Tomato;
            this.btnQuitGame.Location = new System.Drawing.Point(111, 162);
            this.btnQuitGame.Name = "btnQuitGame";
            this.btnQuitGame.Size = new System.Drawing.Size(200, 42);
            this.btnQuitGame.TabIndex = 2;
            this.btnQuitGame.Text = "QUIT GAME";
            this.btnQuitGame.UseVisualStyleBackColor = false;
            this.btnQuitGame.Click += new System.EventHandler(this.btnQuitGame_Click);
            // 
            // btnResme
            // 
            this.btnResme.BackColor = System.Drawing.Color.Gold;
            this.btnResme.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResme.ForeColor = System.Drawing.Color.Tomato;
            this.btnResme.Location = new System.Drawing.Point(111, 114);
            this.btnResme.Name = "btnResme";
            this.btnResme.Size = new System.Drawing.Size(200, 42);
            this.btnResme.TabIndex = 1;
            this.btnResme.Text = "Resume";
            this.btnResme.UseVisualStyleBackColor = false;
            this.btnResme.Click += new System.EventHandler(this.btnResme_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Gold;
            this.btnNewGame.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Tomato;
            this.btnNewGame.Location = new System.Drawing.Point(111, 66);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(200, 42);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "NEW GAME";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(13, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 35);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "00000";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdown.Font = new System.Drawing.Font("Showcard Gothic", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCountdown.Location = new System.Drawing.Point(661, 146);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(82, 98);
            this.lblCountdown.TabIndex = 5;
            this.lblCountdown.Text = "3";
            this.lblCountdown.Visible = false;
            // 
            // BreakoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 620);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.picPaddle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "BreakoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Breakout!";
            this.Load += new System.EventHandler(this.BreakoutForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BreakoutForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BreakoutForm_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BreakoutForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPaddle;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnQuitGame;
        private System.Windows.Forms.Button btnResme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCountdown;
    }
}

