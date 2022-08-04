namespace Grade10FinalProject
{
    partial class frmRelayRace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelayRace));
            this.picPlayer1Car = new System.Windows.Forms.PictureBox();
            this.picplayer2Car = new System.Windows.Forms.PictureBox();
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picCoin1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picplayer2Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin1)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer1Car
            // 
            this.picPlayer1Car.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer1Car.Image = ((System.Drawing.Image)(resources.GetObject("picPlayer1Car.Image")));
            this.picPlayer1Car.Location = new System.Drawing.Point(557, 59);
            this.picPlayer1Car.Name = "picPlayer1Car";
            this.picPlayer1Car.Size = new System.Drawing.Size(100, 50);
            this.picPlayer1Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer1Car.TabIndex = 0;
            this.picPlayer1Car.TabStop = false;
            this.picPlayer1Car.Click += new System.EventHandler(this.picCar_Click);
            // 
            // picplayer2Car
            // 
            this.picplayer2Car.BackColor = System.Drawing.Color.Transparent;
            this.picplayer2Car.Image = ((System.Drawing.Image)(resources.GetObject("picplayer2Car.Image")));
            this.picplayer2Car.Location = new System.Drawing.Point(715, 49);
            this.picplayer2Car.Name = "picplayer2Car";
            this.picplayer2Car.Size = new System.Drawing.Size(122, 60);
            this.picplayer2Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picplayer2Car.TabIndex = 1;
            this.picplayer2Car.TabStop = false;
            // 
            // tmrMove
            // 
            this.tmrMove.Enabled = true;
            this.tmrMove.Interval = 1;
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.Image = ((System.Drawing.Image)(resources.GetObject("picWall1.Image")));
            this.picWall1.Location = new System.Drawing.Point(595, 115);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(316, 173);
            this.picWall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall1.TabIndex = 2;
            this.picWall1.TabStop = false;
            // 
            // picCoin1
            // 
            this.picCoin1.BackColor = System.Drawing.Color.Transparent;
            this.picCoin1.Image = ((System.Drawing.Image)(resources.GetObject("picCoin1.Image")));
            this.picCoin1.Location = new System.Drawing.Point(540, 136);
            this.picCoin1.Name = "picCoin1";
            this.picCoin1.Size = new System.Drawing.Size(117, 49);
            this.picCoin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoin1.TabIndex = 3;
            this.picCoin1.TabStop = false;
            // 
            // frmRelayRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(999, 718);
            this.Controls.Add(this.picCoin1);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picplayer2Car);
            this.Controls.Add(this.picPlayer1Car);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelayRace";
            this.Text = "Relay Race";
            this.Load += new System.EventHandler(this.frmRelayRace_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picplayer2Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer1Car;
        private System.Windows.Forms.PictureBox picplayer2Car;
        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.PictureBox picWall1;
        private System.Windows.Forms.PictureBox picCoin1;
    }
}

