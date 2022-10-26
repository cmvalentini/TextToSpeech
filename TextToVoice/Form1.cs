using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TextToVoice
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer _ss;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_talk_Click(object sender, EventArgs e)
        {
            _ss = new SpeechSynthesizer();
            _ss.SpeakAsync(textrtb.Text);
            btn_talk.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // _ss.SpeakAsyncCancelAll();
            _ss.Pause();
            btn_talk.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (_ss != null)
            {
                if (_ss.State == SynthesizerState.Paused)
                {
                    _ss.Resume();
                    btn_talk.Visible = true;
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _ss.SpeakAsyncCancelAll();
            btn_talk.Visible = true;
        }
    }
}
