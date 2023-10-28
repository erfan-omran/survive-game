
namespace survive_game
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.lblAmmo = new System.Windows.Forms.Label();
            this.lblKill = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblAdadHP = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblClickToStart = new System.Windows.Forms.Label();
            this.lblTedadZambi = new System.Windows.Forms.Label();
            this.lblKheshab = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timRunGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmo.ForeColor = System.Drawing.Color.White;
            this.lblAmmo.Location = new System.Drawing.Point(12, 9);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(121, 29);
            this.lblAmmo.TabIndex = 0;
            this.lblAmmo.Text = "Ammo : 5";
            this.lblAmmo.MouseHover += new System.EventHandler(this.lblAmmo_MouseHover);
            // 
            // lblKill
            // 
            this.lblKill.AutoSize = true;
            this.lblKill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKill.ForeColor = System.Drawing.Color.White;
            this.lblKill.Location = new System.Drawing.Point(256, 9);
            this.lblKill.Name = "lblKill";
            this.lblKill.Size = new System.Drawing.Size(86, 29);
            this.lblKill.TabIndex = 0;
            this.lblKill.Text = "Kill : 0";
            this.lblKill.MouseHover += new System.EventHandler(this.lblKill_MouseHover);
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.ForeColor = System.Drawing.Color.White;
            this.lblHP.Location = new System.Drawing.Point(12, 662);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(69, 29);
            this.lblHP.TabIndex = 0;
            this.lblHP.Text = "HP : ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(74, 672);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1019, 15);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 100;
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::survive_game.Properties.Resources.up;
            this.picPlayer.Location = new System.Drawing.Point(565, 539);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(71, 100);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlayer.TabIndex = 2;
            this.picPlayer.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblAdadHP
            // 
            this.lblAdadHP.AutoSize = true;
            this.lblAdadHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdadHP.ForeColor = System.Drawing.Color.White;
            this.lblAdadHP.Location = new System.Drawing.Point(1099, 667);
            this.lblAdadHP.Name = "lblAdadHP";
            this.lblAdadHP.Size = new System.Drawing.Size(59, 24);
            this.lblAdadHP.TabIndex = 3;
            this.lblAdadHP.Text = "100%";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(1009, 9);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(111, 29);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.Text = "Level : 1";
            this.lblLevel.MouseHover += new System.EventHandler(this.lblDifficulty_MouseHover);
            // 
            // lblClickToStart
            // 
            this.lblClickToStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblClickToStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClickToStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickToStart.Location = new System.Drawing.Point(482, 280);
            this.lblClickToStart.Name = "lblClickToStart";
            this.lblClickToStart.Size = new System.Drawing.Size(220, 78);
            this.lblClickToStart.TabIndex = 5;
            this.lblClickToStart.Text = "Click here to start";
            this.lblClickToStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClickToStart.Click += new System.EventHandler(this.lblClickToStart_Click);
            // 
            // lblTedadZambi
            // 
            this.lblTedadZambi.AutoSize = true;
            this.lblTedadZambi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTedadZambi.ForeColor = System.Drawing.Color.White;
            this.lblTedadZambi.Location = new System.Drawing.Point(482, 9);
            this.lblTedadZambi.Name = "lblTedadZambi";
            this.lblTedadZambi.Size = new System.Drawing.Size(134, 29);
            this.lblTedadZambi.TabIndex = 0;
            this.lblTedadZambi.Text = "Zombis : 3";
            this.lblTedadZambi.MouseHover += new System.EventHandler(this.lblTedadZambi_MouseHover);
            // 
            // lblKheshab
            // 
            this.lblKheshab.AutoSize = true;
            this.lblKheshab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKheshab.ForeColor = System.Drawing.Color.White;
            this.lblKheshab.Location = new System.Drawing.Point(738, 9);
            this.lblKheshab.Name = "lblKheshab";
            this.lblKheshab.Size = new System.Drawing.Size(150, 29);
            this.lblKheshab.TabIndex = 0;
            this.lblKheshab.Text = "Kheshab : 5";
            this.lblKheshab.MouseHover += new System.EventHandler(this.lblKeshab_MouseHover);
            // 
            // timRunGame
            // 
            this.timRunGame.Tick += new System.EventHandler(this.timRunGame_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1165, 700);
            this.Controls.Add(this.lblClickToStart);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblAdadHP);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.lblKheshab);
            this.Controls.Add(this.lblTedadZambi);
            this.Controls.Add(this.lblKill);
            this.Controls.Add(this.lblAmmo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "survive";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.Label lblKill;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblAdadHP;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblClickToStart;
        private System.Windows.Forms.Label lblTedadZambi;
        private System.Windows.Forms.Label lblKheshab;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timRunGame;
    }
}

