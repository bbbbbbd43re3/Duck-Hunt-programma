using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Media;

namespace spele_30
{
    public class Bullet : IDisposable
    {
        public string direction;
        public int BulletTop;
        public static List<Bullet> BulletList = new List<Bullet>();

        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();
        public Rectangle Bounds
        {
            get { return bullet.Bounds; }
        }

        public void MakeBullet(Form form, PictureBox player)
        {
            bullet.BackColor = Color.Black;
            bullet.Size = new Size(5, 6);
            bullet.Tag = "bullet";
            bullet.Top = player.Top;
            bullet.Left = player.Left + (player.Width - 42); 
            form.Controls.Add(bullet);

            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();

            BulletList.Add(this);
        }

        public void Dispose()
        {
            // attīra dotos resursus
            bulletTimer.Stop();
            bulletTimer.Dispose();
            bullet.Dispose();

            // izņem lodi no BulletList
            BulletList.Remove(this);
        }

        private void BulletTimerEvent(object sender, EventArgs e)
        {
            if (direction == "up")
            {
                bullet.Top -= speed;
            }

            if (bullet.Top < 0) // ja lode  <0 tiek noņemta.
            {
                
                Dispose(); 
            }
        }
    }
}