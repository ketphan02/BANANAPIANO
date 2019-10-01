using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANANAPIANO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 'q') PlayWav(Properties.Resources.A, false);
            else if (e.KeyChar == 'w') PlayWav(Properties.Resources.B, false);
            else if (e.KeyChar == 'e') PlayWav(Properties.Resources.C, false);
            else if (e.KeyChar == 'r') PlayWav(Properties.Resources.D, false);
            else if (e.KeyChar == 't') PlayWav(Properties.Resources.E, false);
            else if (e.KeyChar == 'y') PlayWav(Properties.Resources.F, false);
            else if (e.KeyChar == 'u') PlayWav(Properties.Resources.G, false);
        }

        private SoundPlayer pl = null;

        private void PlayWav(Stream stream, bool play_looping)
        {
            // Stop the player if it is running.
            if (pl != null)
            {
                pl.Stop();
                pl.Dispose();
                pl = null;
            }
            
            if (stream == null) return;
            
            pl = new SoundPlayer(stream);
            
            if (play_looping)
                pl.PlayLooping();
            else
                pl.Play();
        }
    }
}
