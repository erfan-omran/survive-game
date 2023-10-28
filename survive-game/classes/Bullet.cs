using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace survive_game
{
    class Bullet
    {

        public string direction;

        public int bulletTop, bulletLeft;
        public static int ammoCount = kheshab;
        public static int kheshab = 5;
        int speed = 20;

        PictureBox bullet = new PictureBox();
        Timer bulletTimer = new Timer();

        public void Make(main form)
        {

            bullet.BackColor = Color.White;
            bullet.Size = new Size(5, 5);
            bullet.Tag = "bullet";
            bullet.Top = bulletTop;
            bullet.Left = bulletLeft;
            bullet.BringToFront();

            form.Controls.Add(bullet);

            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(bulletTimerEvent);
            bulletTimer.Start();

        }

        public void PicUp(Control item, PictureBox picPlayer, Form frm)
        {
            if (item is PictureBox && (string)item.Tag == "ammo")
            {
                if (picPlayer.Bounds.IntersectsWith(item.Bounds))
                {
                    frm.Controls.Remove(item);
                    ((PictureBox)item).Dispose();
                    ammoCount += kheshab;
                }
            }
        }

        public void drop(Random rnd, Form frm, PictureBox picPlayer)
        {

            PictureBox ammo = new PictureBox();
            ammo.Tag = "ammo";
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.Left = rnd.Next(10, (frm.ClientSize.Width) - ammo.Width);
            ammo.Top = rnd.Next(32, frm.ClientSize.Height - (ammo.Height + 23));
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            frm.Controls.Add(ammo);
            ammo.BringToFront();
            picPlayer.BringToFront();

        }

        public void shoot(string direction,PictureBox picPlayer,Form frm)
        {

            Bullet bullet = new Bullet();
            bullet.direction = direction;
            bullet.bulletLeft = picPlayer.Left + (picPlayer.Width / 2);
            bullet.bulletTop = picPlayer.Top + (picPlayer.Height / 2);
            bullet.Make((main)frm);

        }

        void bulletTimerEvent(object sender, EventArgs e)
        {

            if (direction == "up")
            {
                bullet.Top -= speed;
            }
            else if (direction == "down")
            {
                bullet.Top += speed;
            }
            else if (direction == "left")
            {
                bullet.Left -= speed;
            }
            else if (direction == "right")
            {
                bullet.Left += speed;
            }

            if (bullet.Left < 10 || bullet.Left > 870 || bullet.Top < 10 || bullet.Top > 560)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }

        }

    }
}
