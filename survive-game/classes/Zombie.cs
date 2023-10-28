using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static survive_game.Player;

namespace survive_game
{
    class Zombie
    {

        public int speed = 1;
        public int attacke = 1;

        public static List<PictureBox> zombieList = new List<PictureBox>();

        public static void MakeZombie(Random rnd, Form frm, PictureBox picPlayer)
        {

            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            ZombiesSpawnDirection(zombie, rnd, frm);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombieList.Add(zombie);
            frm.Controls.Add(zombie);
            picPlayer.BringToFront();

        }

        public void Attacke(Control item, PictureBox picPlayer)
        {
            if (item is PictureBox && (string)item.Tag == "zombie")
            {
                if (picPlayer.Bounds.IntersectsWith(item.Bounds))
                {
                    playerHelth -= attacke;
                }
            }
        }

        public void Move(Control item, PictureBox picPlayer)
        {
            if ((string)item.Tag == "zombie" && !picPlayer.Bounds.IntersectsWith(item.Bounds))
            {
                if (item is PictureBox && item.Left > picPlayer.Left)
                {
                    ((PictureBox)item).Left -= speed;
                    ((PictureBox)item).Image = Properties.Resources.zleft;
                }
                if (item is PictureBox && item.Top > picPlayer.Top)
                {
                    ((PictureBox)item).Top -= speed;
                    ((PictureBox)item).Image = Properties.Resources.zup;
                }
                if (item is PictureBox && item.Left < picPlayer.Left)
                {
                    ((PictureBox)item).Left += speed;
                    ((PictureBox)item).Image = Properties.Resources.zright;
                }
                if (item is PictureBox && item.Top < picPlayer.Top)
                {
                    ((PictureBox)item).Top += speed;
                    ((PictureBox)item).Image = Properties.Resources.zdown;
                }
            }
        }

        private static void ZombiesSpawnDirection(PictureBox zombie, Random rnd, Form frm)
        {
            int SpawnDirection = rnd.Next(1, 5);
            switch (SpawnDirection)
            {
                case 1:
                    zombie.Left = rnd.Next(-100, -50);
                    zombie.Top = rnd.Next(-100, frm.ClientSize.Height + 100);
                    break;

                case 2:
                    zombie.Left = rnd.Next(-100, frm.ClientSize.Width + 100);
                    zombie.Top = rnd.Next(-100, -50);
                    break;

                case 3:
                    zombie.Left = rnd.Next(frm.ClientSize.Width, frm.ClientSize.Width + 100);
                    zombie.Top = rnd.Next(-100, frm.ClientSize.Height + 100);
                    break;

                case 4:
                    zombie.Left = rnd.Next(-100, -50);
                    zombie.Top = rnd.Next(frm.ClientSize.Height, frm.ClientSize.Height + 100);
                    break;

                default:
                    break;
            }
        }

    }
}
