namespace Player_Musica
{
    partial class PrincipalForm1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm1));
            this.list_musica = new System.Windows.Forms.ListBox();
            this.ImagensPNGbtn = new System.Windows.Forms.ImageList(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.Minimizar = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_arquivo = new System.Windows.Forms.Button();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // list_musica
            // 
            this.list_musica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_musica.FormattingEnabled = true;
            this.list_musica.Location = new System.Drawing.Point(12, 35);
            this.list_musica.Name = "list_musica";
            this.list_musica.Size = new System.Drawing.Size(331, 429);
            this.list_musica.TabIndex = 0;
            this.list_musica.SelectedIndexChanged += new System.EventHandler(this.list_musica_SelectedIndexChanged);
            // 
            // ImagensPNGbtn
            // 
            this.ImagensPNGbtn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagensPNGbtn.ImageStream")));
            this.ImagensPNGbtn.TransparentColor = System.Drawing.Color.Transparent;
            this.ImagensPNGbtn.Images.SetKeyName(0, "botao-play.png");
            this.ImagensPNGbtn.Images.SetKeyName(1, "botao-de-pausa-de-video.png");
            this.ImagensPNGbtn.Images.SetKeyName(2, "next.png");
            this.ImagensPNGbtn.Images.SetKeyName(3, "previous.png");
            this.ImagensPNGbtn.Images.SetKeyName(4, "music-file.png");
            this.ImagensPNGbtn.Images.SetKeyName(5, "more.png");
            this.ImagensPNGbtn.Images.SetKeyName(6, "heart.png");
            this.ImagensPNGbtn.Images.SetKeyName(7, "return.png");
            this.ImagensPNGbtn.Images.SetKeyName(8, "stop-button.png");
            this.ImagensPNGbtn.Images.SetKeyName(9, "close.png");
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(859, 118);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 232);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pBar
            // 
            this.pBar.BackColor = System.Drawing.Color.White;
            this.pBar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.pBar.Location = new System.Drawing.Point(368, 461);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(464, 10);
            this.pBar.TabIndex = 7;
            this.pBar.Click += new System.EventHandler(this.pBar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.SlateGray;
            this.Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimizar.ForeColor = System.Drawing.Color.Black;
            this.Minimizar.Location = new System.Drawing.Point(873, 3);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(31, 23);
            this.Minimizar.TabIndex = 8;
            this.Minimizar.Text = "-";
            this.Minimizar.UseVisualStyleBackColor = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.SlateGray;
            this.Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fechar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechar.ForeColor = System.Drawing.Color.Black;
            this.Fechar.Location = new System.Drawing.Point(910, 3);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(31, 23);
            this.Fechar.TabIndex = 9;
            this.Fechar.Text = "X";
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.ForeColor = System.Drawing.Color.Black;
            this.lbl_time.Location = new System.Drawing.Point(848, 457);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(0, 13);
            this.lbl_time.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Controls.Add(this.Fechar);
            this.panel1.Controls.Add(this.Minimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 29);
            this.panel1.TabIndex = 11;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Black;
            this.lblLogo.Location = new System.Drawing.Point(36, 7);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(161, 19);
            this.lblLogo.TabIndex = 12;
            this.lblLogo.Text = "📻 GTI Player Music ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Player_Musica.Properties.Resources.apple_music_android_logo_icon_134021;
            this.pictureBox1.Location = new System.Drawing.Point(466, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.White;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.Gold;
            this.btn_next.ImageKey = "next.png";
            this.btn_next.ImageList = this.ImagensPNGbtn;
            this.btn_next.Location = new System.Drawing.Point(687, 482);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(52, 51);
            this.btn_next.TabIndex = 5;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.White;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.Color.Gold;
            this.btn_play.ImageKey = "botao-play.png";
            this.btn_play.ImageList = this.ImagensPNGbtn;
            this.btn_play.Location = new System.Drawing.Point(537, 482);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(52, 51);
            this.btn_play.TabIndex = 4;
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.ForeColor = System.Drawing.Color.Gold;
            this.btn_back.ImageKey = "previous.png";
            this.btn_back.ImageList = this.ImagensPNGbtn;
            this.btn_back.Location = new System.Drawing.Point(466, 482);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(52, 51);
            this.btn_back.TabIndex = 3;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.White;
            this.btn_stop.FlatAppearance.BorderSize = 0;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.ForeColor = System.Drawing.Color.Gold;
            this.btn_stop.ImageIndex = 8;
            this.btn_stop.ImageList = this.ImagensPNGbtn;
            this.btn_stop.Location = new System.Drawing.Point(612, 482);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(52, 51);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_arquivo
            // 
            this.btn_arquivo.BackColor = System.Drawing.Color.White;
            this.btn_arquivo.FlatAppearance.BorderSize = 0;
            this.btn_arquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_arquivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_arquivo.ForeColor = System.Drawing.Color.Black;
            this.btn_arquivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_arquivo.ImageKey = "music-file.png";
            this.btn_arquivo.ImageList = this.ImagensPNGbtn;
            this.btn_arquivo.Location = new System.Drawing.Point(69, 482);
            this.btn_arquivo.Name = "btn_arquivo";
            this.btn_arquivo.Size = new System.Drawing.Size(208, 46);
            this.btn_arquivo.TabIndex = 1;
            this.btn_arquivo.Text = "Abrir Músicas";
            this.btn_arquivo.UseVisualStyleBackColor = false;
            this.btn_arquivo.Click += new System.EventHandler(this.btn_arquivo_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.Black;
            this.lblVolume.Location = new System.Drawing.Point(856, 353);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(56, 16);
            this.lblVolume.TabIndex = 13;
            this.lblVolume.Text = "Volume";
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl100.ForeColor = System.Drawing.Color.Black;
            this.lbl100.Location = new System.Drawing.Point(856, 99);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(47, 16);
            this.lbl100.TabIndex = 14;
            this.lbl100.Text = "  100%";
            // 
            // PrincipalForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(953, 588);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_arquivo);
            this.Controls.Add(this.list_musica);
            this.ForeColor = System.Drawing.Color.Indigo;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_musica;
        private System.Windows.Forms.Button btn_arquivo;
        private System.Windows.Forms.ImageList ImagensPNGbtn;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Button Minimizar;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lbl100;
    }
}

