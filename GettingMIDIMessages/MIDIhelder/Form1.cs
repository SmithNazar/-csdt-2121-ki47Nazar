using MIDIDID;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIDIhelder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        static string pip;
        public string ChangeTextBoxViaMidiDevice()
        {
            var midi = new ProgramMidid();
            string parseME = midi.noteOnHold;
            return parseME;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var midi = new ProgramMidid();
            midi.StartListeting();
            pip = midi.noteOnHold;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (pip.StartsWith("Note On [0] (36"))
                {
                    label1.Text = "note c";
                }
                if (pip.StartsWith("Note On [0] (37"))
                {
                    label1.Text = "note c#";
                }
            }
        }
    }
}
