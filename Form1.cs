using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Player_Musica
{
    public partial class PrincipalForm1 : Form
    {
        /*Array: 
         * Adicionamos as musicas, que sao elementos de demanda, assim podemos manipular o que vai ser colocado.
         */
        WindowsMediaPlayer musica;
        List<Musica> listaMusicas = new List<Musica>();
        string mp3;

        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public PrincipalForm1()
        {
            InitializeComponent();
            musica = new WindowsMediaPlayer();
            musica.settings.volume = 50;
            trackBar1.Value = 5;

        }


        private void btn_play_Click(object sender, EventArgs e)
        {
            Play(mp3);



        }
        /*If musica: Usa o if para controle dos button, para cada ação o button muda sua imagem. Dependendo do estado da musica, se esta parada, tocando, assim
         * por diante.
         *
         */

        private void Play(string mp3)
        {
            if (musica.playState == WMPPlayState.wmppsUndefined || musica.playState == WMPPlayState.wmppsStopped)
            {
                musica.URL = mp3;
                musica.controls.play();
                btn_play.ImageIndex = 1;
            }

            else if (musica.playState == WMPPlayState.wmppsPlaying)
            {
                musica.controls.pause();
                btn_play.ImageIndex = 0;
            }
            else if (musica.playState == WMPPlayState.wmppsPaused)
            {
                musica.controls.play();
                btn_play.ImageIndex = 1;
            }




        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            musica.controls.stop();
            btn_play.ImageIndex = 0;

        }
        /* foreach: Usa para ler apenas o elemento do array desejado.
         */
        private void btn_arquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog listaArquivos = new OpenFileDialog();

            listaArquivos.Filter = "Arquivos de som MP3 | *.mp3";
            listaArquivos.Multiselect = true;

            listaArquivos.ShowDialog();


            foreach (var arquivo in listaArquivos.FileNames)

                listaMusicas.Add(new Musica(arquivo));

            list_musica.Items.Clear();
            foreach (var item in listaMusicas)

                list_musica.Items.Add(Path.GetFileName(item.Arquivo));


        }

        private void list_musica_SelectedIndexChanged(object sender, EventArgs e)
        {
            mp3 = listaMusicas[list_musica.SelectedIndex].Arquivo;
            Play2(mp3);
        }
        /* Player2:
         * usa para tocar a musica assim que clicar nela.
         */
        private void Play2(string mp3)
        {
            musica.URL = mp3;
            musica.controls.play();
            btn_play.ImageIndex = 1;
        }


        private void pBar_Click(object sender, EventArgs e)
        {
            
        }
        /* If voltar: Utiliza o if para proxima uma musica na lista de musica
         */
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (list_musica.SelectedIndex < list_musica.Items.Count - 1)
            {
                list_musica.SelectedIndex = list_musica.SelectedIndex + 1;
            }

        }
        /* If voltar: Utiliza o if para voltar uma musica na lista de musica
         */
        private void btn_back_Click(object sender, EventArgs e)
        {
            if (list_musica.SelectedIndex > 0)
            {
                list_musica.SelectedIndex = list_musica.SelectedIndex - 1;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            musica.settings.volume = trackBar1.Value * 10;
        }

        /* Tempo da musica:
         utiliza o tempo da musica para prenncher o progresso da barra
         enquanto a musica toca, usa-se o WMPLimb para o controle do player de musica.
         
         
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (musica.playState == WMPPlayState.wmppsPlaying)
            {
                pBar.Maximum = (int)musica.controls.currentItem.duration;
                pBar.Value = (int)musica.controls.currentPosition;

                lbl_time.Text = musica.controls.currentPositionString;
            }

        }

        /* Switch:
        Funciona atraves de um dialogo, que tem que ser escolhido entre 2 button
        OK ou Cancel. Atribui uma variavel para o DialogResult que uma especie de retorne de
        mensagens, depois é so fazer o switch.
        */

        private void Fechar_Click(object sender, EventArgs e)
        {
            
            DialogResult close = DialogResult;

            close = MessageBox.Show("Deseja encerrar o programa?","Atenção",MessageBoxButtons.OKCancel);

            switch (close)
            {
                
                case DialogResult.OK: Application.Exit();
                    break;
                case DialogResult.Cancel:
                    break;
               
            }

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            DialogResult min = DialogResult;

            min = MessageBox.Show("Deseja minimizar o programa?", "Atenção", MessageBoxButtons.OKCancel);

            switch (min)
            {

                case DialogResult.OK:
                    this.WindowState = FormWindowState.Minimized;
                    break;
                case DialogResult.Cancel:
                    break;

            }
        }
    }

}



/* Classe: Usa a classe para criar um arquivo para depois usar no OpenFileDialog para ler os arquivos que vamos acessar.
 */
    public class Musica
    {
        public string Arquivo { get; set; }

        public Musica() { }

        public Musica(string arquivo) 
        {
            Arquivo= arquivo;
        }

    }

