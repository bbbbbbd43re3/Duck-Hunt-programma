using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

// Koda idejas/pamācība ņemta no:
//https://www.youtube.com/@mooict
//https://stackoverflow.com/
//https://www.w3schools.com/cs/index.php
//Kods nav apzināti kopēts no šo pamācību saitēm. Varbūt pāris koda funkcijas var sakrist ar internetā atrodamo informāciju piem:
//(protected override void OnPaint) ko es meklēju internetā, lai samazinātu spēlēs tēla "flickering/mirgošanu".
//Bullet class izveidi, ko es atradu https://www.youtube.com/@mooict youtube kanālā, bet kods ir veidots pēc manis paša saprašanas,uzlabošanas un adaptēšanas man nepieciešajam rezultātam..






namespace spele_30

{
    public partial class Form1 : Form

    {
        private Timer bulletCooldownTimer = new Timer();
        private bool canShoot = true;
        public Form1()
          
        {
             


            bulletCooldownTimer.Interval = 490; // Ievieš intervālu pirms katras izšautās lodes, lai nevarētu vienkārši spiest space.
            bulletCooldownTimer.Tick += BulletCooldownTimerTick;
            bulletCooldownTimer.Start();


            InitializeComponent();
            MinimizeBox = true;
            MaximizeBox = false;
            RestartGame();
            lbl_over.Hide();
           lbl_score.Hide();
            Duck_box.Show();
        }


        bool gameStarted = false; //ievieš bool datu tipu gamestarted = false/true. 

        private void BulletCooldownTimerTick(object sender, EventArgs e)
        {
            canShoot = true;
            bulletCooldownTimer.Stop(); 
        }


        //izveido START button
        private void butStart_Click_1(object sender, EventArgs e)
        {
            gameStarted = true; // kad poga tiek uzspiesta bool datu tips izmainās uz gameStarted = true (spēle sāk darboties)
            butStart.Visible = false; // Paslēpj START pogu.
            lbl_score.Show();
            this.Focus(); // Ignorē START pogas atrašanos pēc spēles sākšanās.
            RestartGame();
        }
        

        private void lbl_score_Click(object sender, EventArgs e)
        {

        }


        private void Makeducks()
        {
            if (gameStarted) // ja spēle sākusies 
            {
                Duck_box.Hide();
                PictureBox ducks = new PictureBox();
                ducks.Tag = "ducks";
                ducks.Image = Properties.Resources.output_onlinegiftools__2_;
                ducks.BackColor = Color.Transparent;
                int duckTop = randNumb.Next(250, 400);
                int duckLeft = randNumb.Next(0, 0);

                bool collisionDetected;
                do
                {
                    collisionDetected = false;

                    duckTop = randNumb.Next(50, 250);
                    duckLeft = randNumb.Next(-20, 0);
                    // kods nestrāda kā vajag pīles var ievietoties viena uz otras:

                    // izmanto taisnstūti lai reprezentētu jaunās pīles robežas
                    Rectangle newDuckBounds = new Rectangle(duckLeft, duckTop, ducks.Width, ducks.Height);

                    foreach (PictureBox duck in DuckList)
                    {
                        Rectangle existingDuckBounds = new Rectangle(duck.Left, duck.Top, duck.Width, duck.Height);

                        // izmanto taisnstūti lai reprezentētu esošās pīles robežas
                        if (newDuckBounds.IntersectsWith(existingDuckBounds))
                        {
                            collisionDetected = true;
                            break; 
                        }
                    }
                } while (collisionDetected);





                ducks.Top = duckTop;
                ducks.Left = duckLeft;

                DuckList.Add(ducks);
                this.Controls.Add(ducks);
                player.BringToFront();

                ducks.Height = 75;
                ducks.Width = 75;

                duck_speed = randNumb.Next(3, 5);
            }
        }


        //izveidojam lodi
        private void ShootBullet(string direction)
        {
            if (gameStarted && canShoot)
            {
                
                Bullet shootBullet = new Bullet();
                shootBullet.direction = direction;
                // nosakam no kurienes lode tiks izšauta
                shootBullet.BulletTop = player.Top + (player.Height + 0) + (player.Width - 50);

                shootBullet.MakeBullet(this, player);


                canShoot = false; // lai inicētu lodes
                bulletCooldownTimer.Start();
                {

                }
            }

        }



        bool right, left;
        int speed = 10;
       private int duck_speed = 0;
        string facing = "up";
        int score;

        Random randNumb = new Random();
        List<PictureBox> DuckList = new List<PictureBox>();
        private Control i;

        
        int life = -1;


        private void timer1_Tick(object sender, EventArgs e)
        {
            // ja spēlētājs iziet no dotajām robežām viņš apstājas.
            if (left && player.Left > -90)
            {
                player.Left -= speed;
            }

            if (right && player.Left < 630)
            {
                player.Left += speed;
            }



            void life_index()
            {
                if (life == 0)
                {
                    // Noslēpj Game-Over label ja vēl ir atlikušas dzīvības.
                    lbl_over.Hide();                 

                    // Zaudējot dzīvbu pārvēš to baltā krāsā "Tiek ievietots baltās sirds attēls"                   
                    lyf_1.Image = Properties.Resources.life_white; 
                }
                else if (life == 1)
                {
                    lbl_over.Hide();
                    lyf_2.Image = Properties.Resources.life_white;
                }
                else if (life == 2)
                {
                    lyf_3.Image = Properties.Resources.life_white;
                    lbl_over.Show(); // kad dzīvības beigušās, parādās label Game-Over
                    timer1.Stop();// spēle tiek apstādināta
                    butStart.Visible = true; 
                    gameStarted = false;  // ievieš stadiju, ka spēle nav sākusies
                    Duck_box.Visible = true;
                }




            }


            // izveido pīles kustēšanās virzienu
            for (int i = DuckList.Count - 1; i >= 0; i--)
            {
                PictureBox duck = DuckList[i];
                duck.Left += duck_speed;

                // pārbauda vai pīle ir izgājusi no noteiktās robežas
                if (duck.Right > 900)
                {
                    // Ja pīle ir izgājusi ārpus robežas spēlētājs zaudē dzīvību
                    life++;
                    life_index();
                    this.Controls.Remove(duck);
                    DuckList.RemoveAt(i);
                    Makeducks();
                }
                for (int bulletIndex = Bullet.BulletList.Count - 1; bulletIndex >= 0; bulletIndex--)
                {
                    Bullet bullet = Bullet.BulletList[bulletIndex];

                    for (int duckIndex = DuckList.Count - 1; duckIndex >= 0; duckIndex--)
                    {
                        PictureBox duckToCheck = DuckList[duckIndex];

                        if (duckToCheck.Bounds.IntersectsWith(bullet.Bounds))
                        {
                            // Duck hit by a bullet
                            this.Controls.Remove(duckToCheck);
                            DuckList.RemoveAt(duckIndex);
                            Bullet.BulletList[bulletIndex].Dispose(); // Noņem lodi

                            // palielina rezultātu
                            score++;
                            lbl_score.Text = "Score: " + score;

                            // Izveidot jaunu pīli, lai aizstātu iznicināto
                            Makeducks();
                        }
                    }
                }



            }          
        }

       //Restartē spēli. Visi elementi atgriežas vecajos "values"
        private void RestartGame()
        {
            duck_speed = randNumb.Next(3, 6);
            // esošās pīles noņem no spēles laukuma
            foreach (PictureBox i in DuckList)
            {

                this.Controls.Remove(i);
            }
            lyf_1.Image = Properties.Resources.life;
            lyf_2.Image = Properties.Resources.life;
            lyf_3.Image = Properties.Resources.life;
            lbl_over.Hide();
            DuckList.Clear();
            lbl_score.Text = "Score:0";
            life = -1;
            score = 0;

            for (int i = 0; i < 2; i++) 
            {
                Makeducks();
            }

            left = false;
            right = false;




            timer1.Start();



        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void lbl_over_Click(object sender, EventArgs e)
        {
            if (gameStarted)
            { return; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_over_Click_1(object sender, EventArgs e)
        {

        }
        // fORM 1 EVENTS noskam pogai funkciju
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
                facing = "up";
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
                facing = "up";
            }

        }

        private void player_Click_1(object sender, EventArgs e)
        {

        }
        // fORM 1 EVENTS noskam pogai funkciju
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Space)

                ShootBullet(facing);

        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            
        }

        // Ignorēt OnPaint metodi pielāgotai krāsošanai lai mainītu , kā objekti attiecas uz fonu.

        protected override void OnPaint(PaintEventArgs e)
        {
            
            base.OnPaint(e);

            
            e.Graphics.DrawImage(Properties.Resources.pixil_frame_0__4_, 0, 0, this.Width, this.Height);

           
        }
        








    }
    }


