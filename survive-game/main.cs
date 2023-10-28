using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static survive_game.Bullet;
using static survive_game.Zombie;
using static survive_game.Player;



namespace survive_game
{
    public partial class main : Form
    {

        public main()
        {
            InitializeComponent();
            reStartGame();
            if (MessageBox.Show("وقتی که مردی برای دوباره بازی کردن کافیه اینتر رو بزنی \nهر سی تا کیل ، میزان سختی بازی یک دونه افزایش پیدا میکنه\nهر زامبی ایی که بکشی بهت جون اضافه میشه \n با دکمه های بالا ، پایین ، چپ ، راست و دکمه های \n میتونی راه بری  w ، s ، a ، d\n با اسپیس هم میتونی تیر بزنی", "!چیزایی که باید قبل از بازی کردن بدونی", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                runGame = false;
                timRunGame.Enabled = true;
            }
        }

        Player player = new Player();
        Zombie zombie = new Zombie();
        Bullet bullet = new Bullet();

        Random rnd = new Random();

        bool runGame = true;
        bool gameOver = false;


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            player.Direction(timer1, e, picPlayer);

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                reStartGame();
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            player.Stop(e);

            // Shot bullet
            if (e.KeyCode == Keys.Space && ammoCount > 0 && timer1.Enabled)
            {
                ammoCount--;
                bullet.shoot(playerDirection, picPlayer, this);

                // Bullet drop on the ground
                if (ammoCount == 1)
                {
                    bullet.drop(rnd, this, picPlayer);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // HP updater
            if (progressBar1.Value > 1 && progressBar1.Value <= 100)
            {
                if (playerHelth > 100)
                {
                    playerHelth = 100;
                }
                else if (playerHelth < 0)
                {
                    playerHelth = 0;
                }
                progressBar1.Value = playerHelth;
            }
            // Lose
            else
            {
                timer1.Stop();
                gameOver = true;
                picPlayer.Image = Properties.Resources.dead;
                progressBar1.Value = 0;
            }

            #region Labels updater

            lblAmmo.Text = "Ammo : " + ammoCount.ToString();
            lblKill.Text = "Kill : " + player.score.ToString();
            lblKheshab.Text = "Kheshab : " + kheshab.ToString();
            lblTedadZambi.Text = "Zombis : " + (player.level + 2).ToString();
            lblLevel.Text = "Level : " + player.level.ToString();
            lblAdadHP.Text = progressBar1.Value.ToString() + '%';

            #endregion

            /*
                if (playerHelth <= 20)
                {
                    progressBar1.BackColor = Color.Red;
                }
            */

            // Player move
            player.Move(picPlayer, this);

            foreach (Control item in this.Controls)
            {
                // Ammo pickup
                bullet.PicUp(item, picPlayer, this);

                // Zombies attacke
                zombie.Attacke(item, picPlayer);

                //  Zombies move
                zombie.Move(item, picPlayer);

                //  Player attack
                player.Attack(this, item, rnd, picPlayer);

            }

        }

        private void lblClickToStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblClickToStart.Visible = false;
        }

        #region ToolTips
        private void lblKeshab_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lblKheshab, "تعداد تیر های روی زمین");
        }

        private void lblTedadZambi_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lblTedadZambi, "تعداد زامبی های موجود");
        }

        private void lblDifficulty_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lblLevel, "میزان سختی بازی");
        }

        private void lblKill_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lblKill, "تعداد زامبی هایی که کشتی");
        }

        private void lblAmmo_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lblAmmo, "تعداد تیر");
        }

        #endregion

        // Timer for Approval of rules
        private void timRunGame_Tick(object sender, EventArgs e)
        {
            if (runGame == false)
            {
                Application.Exit();
            }
        }


        private void reStartGame()
        {
            picPlayer.Image = Properties.Resources.up;

            foreach (Control ammo in this.Controls)
            {
                if (ammo is PictureBox && (string)ammo.Tag == "ammo")
                {
                    this.Controls.Remove(ammo);
                    ammo.Dispose();
                }
            }

            foreach (PictureBox item in zombieList)
            {
                this.Controls.Remove(item);
            }
            zombieList.Clear();

            for (int i = 0; i < 3; i++)
            {
                MakeZombie(rnd, this, picPlayer);
            }

            player.goUp = false;
            player.goDown = false;
            player.goLeft = false;
            player.goRight = false;

            gameOver = false;

            picPlayer.Left = 404;
            picPlayer.Top = 429;
            playerHelth = 100;
            progressBar1.Value = 100;
            playerDirection = "up";
            player.heal = 5;
            player.score = 0;
            kheshab = 5;
            player.level = 1;
            zombie.attacke = 1;
            zombie.speed = 1;
            lblKheshab.Text = "Kheshab : " + kheshab.ToString();
            lblTedadZambi.Text = "Zombis : " + (player.level + 2).ToString();
            lblLevel.Text = "Level : " + player.level.ToString();
            lblKill.Text = "Kill : " + player.score.ToString();
            lblAmmo.Text = "Ammo : " + kheshab.ToString();
            ammoCount = kheshab;
            
            lblClickToStart.Visible = true;

        }

    }
}
