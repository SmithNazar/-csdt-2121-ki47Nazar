using ISynthSounds;
using LowNotesApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synthesizer
{
    public partial class Synthesizer : Form
    {
        public List<ISynthPlugin> app_plugins;
        public int Index { get; set; }

        static List<ISynthPlugin> ReadPlugins()
        {
            List<ISynthPlugin> plugins = new List<ISynthPlugin>();

            if (!Directory.Exists("..\\..\\Extensions"))
            {
                Directory.CreateDirectory("..\\..\\Extensions");
            }
            
            var files = Directory.GetFiles("..\\..\\Extensions", "*.dll");

            foreach (var file in files)
            {
                var assembly = Assembly.LoadFile(Path.Combine(Directory.GetCurrentDirectory(), file));
                var plugin_type = assembly.GetTypes().Where(t => typeof(ISynthPlugin).IsAssignableFrom(t)).ToArray();

                foreach (var plugin_t in plugin_type)
                {
                    var pluginInstance = Activator.CreateInstance(plugin_t) as ISynthPlugin;
                    if (pluginInstance != null)
                        plugins.Add(pluginInstance);
                }
            }
            return plugins;
        }

        public Synthesizer()
        {
            InitializeComponent();
        }
        /*
        private void PlayNote(float f)
        {
            short[] wave = new short[SampleRate];
            byte[] bynaryWave = new byte[SampleRate * sizeof(short)];
            float frequency = f;

            for (int i = 0; i < SampleRate; i++)
            {
                wave[i] = Convert.ToInt16(short.MaxValue * Math.Sin(((Math.PI * 2 * frequency) / SampleRate) * i));
            }

            Buffer.BlockCopy(wave, 0, bynaryWave, 0, wave.Length * sizeof(short));

            using (MemoryStream memoryStream = new MemoryStream())
            using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
            {
                making a wave format file
                int blockAlign = BitsPerSample / 8;
                int subChunkTwoSize = SampleRate * blockAlign;
                binaryWriter.Write(new[] { 'R', 'I', 'F', 'F' });
                binaryWriter.Write(36 + subChunkTwoSize);
                binaryWriter.Write(new[] { 'W', 'A', 'V', 'E', 'f', 'm', 't', ' ' });
                binaryWriter.Write(16);
                binaryWriter.Write((short)1);
                binaryWriter.Write((short)1);
                binaryWriter.Write(SampleRate);
                binaryWriter.Write(SampleRate * blockAlign);
                binaryWriter.Write((short)blockAlign);
                binaryWriter.Write(BitsPerSample);
                binaryWriter.Write(new[] { 'd', 'a', 't', 'a' });
                binaryWriter.Write(subChunkTwoSize);
                binaryWriter.Write(bynaryWave);
                memoryStream.Position = 0;
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer(memoryStream);
                sp.Play();
                new SoundPlayer(memoryStream).Play();
            }
        }
        */
        private void Synthesizer_Load(object sender, EventArgs e)
        {
            
            app_plugins = ReadPlugins();
            listBox1.Items.AddRange(app_plugins.Select(x => x.Name).ToArray());
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            listBox1.SelectedIndex = 0;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Index = listBox1.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            app_plugins[Index].PlayNote(app_plugins[Index].C);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            app_plugins[Index].PlayNote(app_plugins[Index].C_S);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            app_plugins[Index].PlayNote(app_plugins[Index].D);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            app_plugins[Index].PlayNote(app_plugins[Index].D_S);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            app_plugins[Index].PlayNote(app_plugins[Index].E);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            app_plugins[Index].PlayNote(app_plugins[Index].F);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            app_plugins[Index].PlayNote(app_plugins[Index].F_S);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            app_plugins[Index].PlayNote(app_plugins[Index].G);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            app_plugins[Index].PlayNote(app_plugins[Index].G_S);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            app_plugins[Index].PlayNote(app_plugins[Index].A);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            app_plugins[Index].PlayNote(app_plugins[Index].A_S);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            app_plugins[Index].PlayNote(app_plugins[Index].B);
        }
        // assigning keybord to buttons
        private void Synthesizer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
            {
                button1.PerformClick();
                //btncash_Click(null, null);
            }
            if (e.KeyCode == Keys.S)
            {
                button2.PerformClick();
                //btncash_Click(null, null);
            }
            if (e.KeyCode == Keys.X)
            {
                button3.PerformClick();
                //btncash_Click(null, null);
            }
            if (e.KeyCode == Keys.D)
            {
                button4.PerformClick();
                //btncash_Click(null, null);
            }
            if (e.KeyCode == Keys.C)
            {
                button5.PerformClick();
                //btncash_Click(null, null);
            }
            if (e.KeyCode == Keys.V)
            {
                button6.PerformClick();
                //btncash_Click(null, null);
            }
            if (e.KeyCode == Keys.G)
            {
                button7.PerformClick();
                //btncash_Click(null, null);
            }
            if (e.KeyCode == Keys.B)
            {
                button8.PerformClick();
                //btncash_Click(null, null);
            }
            if (e.KeyCode == Keys.H)
            {
                button9.PerformClick();
                //btncash_Click(null, null);
            }
            if (e.KeyCode == Keys.N)
            {
                button10.PerformClick();
                //btncash_Click(null, null);
            }
            if (e.KeyCode == Keys.J)
            {
                button11.PerformClick();
                //btncash_Click(null, null);
            }
            if (e.KeyCode == Keys.M)
            {
                button12.PerformClick();
                //btncash_Click(null, null);
            }
        }
    }
}
