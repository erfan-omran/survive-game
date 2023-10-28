using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static survive_game.Bullet;
using static survive_game.Zombie;


namespace survive_game
{
    class Player
    {

        public bool goUp, goDown, goLeft, goRight;

        public static string playerDirection = "up";

        public static int playerHelth = 100;
        public int speed = 10;
        public int score = 0;
        public int heal = 5;
        public int level = 1;

        public void Direction(Timer time, KeyEventArgs e, PictureBox picPlayer)
        {
            if (time.Enabled)
            {
                if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                {
                    goUp = true;
                    playerDirection = "up";
                    picPlayer.Image = Properties.Resources.up;
                }
                else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                {
                    goDown = true;
                    playerDirection = "down";
                    picPlayer.Image = Properties.Resources.down;

                }
                else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                {
                    goLeft = true;
                    playerDirection = "left";
                    picPlayer.Image = Properties.Resources.left;
                }
                else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                {
                    goRight = true;
                    playerDirection = "right";
                    picPlayer.Image = Properties.Resources.right;
                }
            }
        }

        public void Move(PictureBox picPlayer, Form frm)
        {
            if (goUp && picPlayer.Top > 30)
            {
                picPlayer.Top -= speed;
            }
            else if (goDown && picPlayer.Top + picPlayer.Height < frm.Height - 31)
            {
                picPlayer.Top += speed;
            }
            else if (goLeft && picPlayer.Left > 0)
            {
                picPlayer.Left -= speed;
            }
            else if (goRight && picPlayer.Left + picPlayer.Width < frm.Width)
            {
                picPlayer.Left += speed;
            }
        }

        public void Stop(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        public void Attack(Form frm, Control item, Random rnd, PictureBox picPlayer)
        {
            foreach (Control j in frm.Controls)
            {
                if ((j is PictureBox && (string)j.Tag == "bullet") && (item is PictureBox && (string)item.Tag == "zombie") && item.Bounds.IntersectsWith(j.Bounds))
                {
                    playerHelth += heal;
                    score++;
                    DifficultyLevelUp(rnd, frm, picPlayer);
                    frm.Controls.Remove(j);
                    j.Dispose();
                    frm.Controls.Remove(item);
                    item.Dispose();
                    MakeZombie(rnd, frm, picPlayer);
                }
            }
        }

        private void DifficultyLevelUp(Random rnd, Form frm, PictureBox picPlayer)
        {
            if (score % 30 == 0)
            {
                level++;
                MakeZombie(rnd, frm, picPlayer);
                heal += 1;
                if (kheshab <= 20)
                {
                    kheshab += 2;
                }
            }
        }

    }
}
