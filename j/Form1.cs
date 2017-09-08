using System;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading; 
using System.IO;
using System.Drawing;
using System.Media;
namespace j
{
    public partial class Form1 : Form
    {

        public Form1()
        { InitializeComponent(); }
   


        int koor_x = Screen.PrimaryScreen.Bounds.Width ;
        int koor_y = Screen.PrimaryScreen.Bounds.Height ;
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
        public string Pcommand;
        string yol = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\dittiri.mp3";
        SoundPlayer player = new SoundPlayer();
        private void Form1_Load(object sender, EventArgs e)
        {
            bool TekProcess;
            Mutex mx = new Mutex(true, "Muttexyeah", out TekProcess);
            if (!TekProcess)
            {
                MessageBox.Show("Başka bir kopya çalıştıramazsınız");
                Application.ExitThread();

            }
                player.Stream = Properties.Resources.kisne;
                this.Location = new Point(10, 10);
                
        }

        /*
        bool a = true;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (a)
                e.Cancel = true;

        }
  private string tuslar="";
          private void Form1_KeyDown(object sender, KeyEventArgs e)
          {
              if (e.KeyCode == Keys.Enter)
              {
                  if (tuslar == "QUIT")
                  {
                      try
                      {
                          tuslar = "";
                          DialogResult = MessageBox.Show("Korktun mu :D", "Hack Bitecek!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                          if (DialogResult == DialogResult.Yes)
                          {
                              a = false;
                             
                              Application.Exit();
                          }
                      }
                      catch { }

                  }
                  else
                  {
                      tuslar = "";
                  }
              }
              else
              {
                  tuslar += e.KeyCode;
              }


        

          }*/
        private void Form1_MouseEnter(object sender, EventArgs e)
        {
           
                Random f1 = new Random();
                this.Location = new Point(Convert.ToInt32(f1.Next(10,koor_x-300)), Convert.ToInt32(f1.Next(10,koor_y-200)));
                player.Play();

        }
    }
}
