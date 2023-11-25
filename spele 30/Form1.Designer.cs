namespace spele_30
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_over = new System.Windows.Forms.Label();
            this.lyf_1 = new System.Windows.Forms.PictureBox();
            this.lyf_2 = new System.Windows.Forms.PictureBox();
            this.lyf_3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.butStart = new System.Windows.Forms.Button();
            this.Duck_box = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duck_box)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::spele_30.Properties.Resources.pixil_frame_0__3_;
            this.player.Location = new System.Drawing.Point(310, 514);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(132, 187);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // lbl_score
            // 
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(322, 9);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(154, 44);
            this.lbl_score.TabIndex = 1;
            this.lbl_score.Text = "Score:  0";
            this.lbl_score.Click += new System.EventHandler(this.lbl_score_Click);
            // 
            // lbl_over
            // 
            this.lbl_over.BackColor = System.Drawing.Color.Transparent;
            this.lbl_over.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_over.ForeColor = System.Drawing.Color.Red;
            this.lbl_over.Location = new System.Drawing.Point(251, 194);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(290, 76);
            this.lbl_over.TabIndex = 2;
            this.lbl_over.Text = "Game-Over";
            this.lbl_over.Click += new System.EventHandler(this.lbl_over_Click);
            // 
            // lyf_1
            // 
            this.lyf_1.BackColor = System.Drawing.Color.Transparent;
            this.lyf_1.Location = new System.Drawing.Point(676, 12);
            this.lyf_1.Name = "lyf_1";
            this.lyf_1.Size = new System.Drawing.Size(31, 41);
            this.lyf_1.TabIndex = 3;
            this.lyf_1.TabStop = false;
            // 
            // lyf_2
            // 
            this.lyf_2.BackColor = System.Drawing.Color.Transparent;
            this.lyf_2.Location = new System.Drawing.Point(713, 12);
            this.lyf_2.Name = "lyf_2";
            this.lyf_2.Size = new System.Drawing.Size(31, 41);
            this.lyf_2.TabIndex = 4;
            this.lyf_2.TabStop = false;
            // 
            // lyf_3
            // 
            this.lyf_3.BackColor = System.Drawing.Color.Transparent;
            this.lyf_3.Location = new System.Drawing.Point(750, 12);
            this.lyf_3.Name = "lyf_3";
            this.lyf_3.Size = new System.Drawing.Size(31, 41);
            this.lyf_3.TabIndex = 5;
            this.lyf_3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // butStart
            // 
            this.butStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStart.ForeColor = System.Drawing.Color.Black;
            this.butStart.Location = new System.Drawing.Point(328, 466);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(128, 42);
            this.butStart.TabIndex = 6;
            this.butStart.Text = "START";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click_1);
            // 
            // Duck_box
            // 
            this.Duck_box.BackColor = System.Drawing.Color.Transparent;
            this.Duck_box.Image = global::spele_30.Properties.Resources.pixil_frame_0__6_;
            this.Duck_box.Location = new System.Drawing.Point(250, 82);
            this.Duck_box.Name = "Duck_box";
            this.Duck_box.Size = new System.Drawing.Size(206, 109);
            this.Duck_box.TabIndex = 7;
            this.Duck_box.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::spele_30.Properties.Resources.pixil_frame_0__4_;
            this.ClientSize = new System.Drawing.Size(787, 636);
            this.Controls.Add(this.Duck_box);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.lyf_3);
            this.Controls.Add(this.lyf_2);
            this.Controls.Add(this.lyf_1);
            this.Controls.Add(this.lbl_over);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Duck Hunt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duck_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_over;
        private System.Windows.Forms.PictureBox lyf_1;
        private System.Windows.Forms.PictureBox lyf_2;
        private System.Windows.Forms.PictureBox lyf_3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.PictureBox Duck_box;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

