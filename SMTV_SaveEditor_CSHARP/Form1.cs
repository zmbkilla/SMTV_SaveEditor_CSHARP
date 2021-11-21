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
using System.Diagnostics;

namespace SMTV_SaveEditor_CSHARP
{
    public partial class Form1 : Form
    {
        public SoundPlayer sp;
        public bool musicp = true;
        public Form1()
        {
            InitializeComponent();
        }


        //player data button
        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var data_pl = new PL_Data();
            FileStream fs = new FileStream(SaveC.Save_Dir, FileMode.Open);
            fs.Close();
            BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir));
            string FName = null;
            string LName = null;
            string DLC = null;
            string NGplus = null;
            string cycle = null;

            for (int i = 0x904; i <= 0x91C; i++)
            {
                br.BaseStream.Position = i;
                
                FName += br.ReadByte().ToString("X2");
            }

            for (int i = 0x91C; i<= 0x930; i++)
            {
                br.BaseStream.Position = i;

                LName += br.ReadByte().ToString("X2");
            }

            br.BaseStream.Position = 0x45D;
            DLC += br.ReadByte().ToString("X2");

            br.BaseStream.Position = 0x45C;
            NGplus += br.ReadByte().ToString("X2");

            br.BaseStream.Position = 0x436;
            cycle += br.ReadByte().ToString("X2");

            br.Close();

            var fbytes = new byte[FName.Length / 2];
            for (var i = 0; i < fbytes.Length; i++)
            {
                fbytes[i] = Convert.ToByte(FName.Substring(i * 2, 2), 16);
            }

            var lbytes = new byte[LName.Length / 2];
            for (var i = 0; i < lbytes.Length; i++)
            {
                lbytes[i] = Convert.ToByte(LName.Substring(i * 2, 2), 16);
            }

            int dlcval = Int32.Parse(DLC, System.Globalization.NumberStyles.HexNumber);
            int ngval = Int32.Parse(NGplus, System.Globalization.NumberStyles.HexNumber);
            int cycleval = Int32.Parse(cycle, System.Globalization.NumberStyles.HexNumber);

            if (dlcval == 255)
            {
                data_pl.checkBox1.Checked = true;
            }

            if (ngval != 0)
            {
                data_pl.checkBox2.Checked = true;
            }
            data_pl.numericUpDown1.Value = cycleval;

            data_pl.textBox1.Text = Encoding.Unicode.GetString(fbytes);

            data_pl.textBox2.Text = Encoding.Unicode.GetString(lbytes);


            br.Close();
            fs.Close();

            flowLayoutPanel1.Controls.Add(data_pl);
        }

        //load decrypted save
        private void openDecryptedSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            
            

            if(opf.ShowDialog() == DialogResult.OK)
            {
                SaveC.Save_Dir = opf.FileName.ToString();
                MessageBox.Show("Save File Selected");
                fullControls(this);
            }



            
        }

        // load macca and glory
        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var data_pl = new PL_CuGl();
            FileStream fs = new FileStream(SaveC.Save_Dir, FileMode.Open);
            fs.Close();
            BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir));
            string Macca = null;
            string Glory = null;


            for (int i = 0x2F71; i >= 0x2F70; i--)
            {
                br.BaseStream.Position = i;

                Macca += br.ReadByte().ToString("X2");
            }

            for (int i = 0x2F89; i >= 0x2F88; i--)
            {
                br.BaseStream.Position = i;

                Glory += br.ReadByte().ToString("X2");
            }



            br.Close();

            //var fbytes = new byte[Macca.Length / 2];
            //for (var i = 0; i < fbytes.Length; i++)
            //{
            //    fbytes[i] = Convert.ToByte(Macca.Substring(i * 2, 2), 16);
            //}
            //
            //var lbytes = new byte[Glory.Length / 2];
            //for (var i = 0; i < lbytes.Length; i++)
            //{
            //    lbytes[i] = Convert.ToByte(Glory.Substring(i * 2, 2), 16);
            //}

            int mval = Int32.Parse(Macca, System.Globalization.NumberStyles.HexNumber);
            int gval = Int32.Parse(Glory, System.Globalization.NumberStyles.HexNumber);

            



            data_pl.numericUpDown1.Value = mval;
            data_pl.numericUpDown2.Value = gval;

            br.Close();
            fs.Close();

            flowLayoutPanel1.Controls.Add(data_pl);
        }
        // initialize form
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            Stream str = Properties.Resources.menu;
            sp = new SoundPlayer(str);
            sp.PlayLooping();

            if (SaveC.Save_Dir == null)
            {
                DisableControls(this);
                EnableControls(menuStrip1);
                
            }
            
        }


        private void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }
            con.Enabled = false;
            executeToolStripMenuItem.Enabled = false;
        }

        private void EnableControls(Control con)
        {
            if (con != null)
            {
                con.Enabled = true;
                EnableControls(con.Parent);
            }
        }
        //re-enable controls after loading file
        private void fullControls(Control con)
        {

            foreach (Control c in con.Controls)
            {
                fullControls(c);
            }
            con.Enabled = true;

            executeToolStripMenuItem.Enabled = false;
        }

        private void openDecryptedSaveToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(menuStrip1, "Open a decrypted save");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var data_pl = new PL_Demon();
            

            data_pl.comboBox1.SelectedIndex = 0;
           
            flowLayoutPanel1.Controls.Add(data_pl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var data_pl = new PL_Stat();
            FileStream fs = new FileStream(SaveC.Save_Dir, FileMode.Open);
            fs.Close();
            BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir));
            string STR = null;
            string VIT = null;
            string MAG = null;
            string AGI = null;
            string LU = null;
            string HP = null;
            string MP = null;



            for (int i = 0x8C1; i >= 0x8C0; i--)
            {
                br.BaseStream.Position = i;

                STR += br.ReadByte().ToString("X2");
            }

            for (int i = 0x8C3; i >= 0x8C2; i--)
            {
                br.BaseStream.Position = i;

                VIT += br.ReadByte().ToString("X2");
            }

            for (int i = 0x8C5; i >= 0x8C4; i--)
            {
                br.BaseStream.Position = i;

                MAG += br.ReadByte().ToString("X2");
            }

            for (int i = 0x8C7; i >= 0x8C6; i--)
            {
                br.BaseStream.Position = i;

                AGI += br.ReadByte().ToString("X2");
            }

            for (int i = 0x8C9; i >= 0x8C8; i--)
            {
                br.BaseStream.Position = i;

                LU += br.ReadByte().ToString("X2");
            }

            for (int i = 0x8BD; i >= 0x8BC; i--)
            {
                br.BaseStream.Position = i;

                HP += br.ReadByte().ToString("X2");
            }

            for (int i = 0x8BF; i >= 0x8BE; i--)
            {
                br.BaseStream.Position = i;

                MP += br.ReadByte().ToString("X2");
            }


            int strval = Int32.Parse(STR, System.Globalization.NumberStyles.HexNumber);
            int vitval = Int32.Parse(VIT, System.Globalization.NumberStyles.HexNumber);
            int magval = Int32.Parse(MAG, System.Globalization.NumberStyles.HexNumber);
            int agival = Int32.Parse(AGI, System.Globalization.NumberStyles.HexNumber);
            int luval = Int32.Parse(LU, System.Globalization.NumberStyles.HexNumber);
            int hpval = Int32.Parse(HP, System.Globalization.NumberStyles.HexNumber);
            int mpval = Int32.Parse(MP, System.Globalization.NumberStyles.HexNumber);





            data_pl.numericUpDown1.Value = strval;
            data_pl.numericUpDown2.Value = vitval;
            data_pl.numericUpDown3.Value = magval;
            data_pl.numericUpDown4.Value = agival;
            data_pl.numericUpDown5.Value = luval;
            data_pl.numericUpDown6.Value = hpval;
            data_pl.numericUpDown7.Value = mpval;


            br.Close();
            fs.Close();

            flowLayoutPanel1.Controls.Add(data_pl);
        }

        private void stopPlayMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (musicp == true)
            {
                sp.Stop();
            } else if (musicp == false)
            {
                sp.PlayLooping();
            }
        }

        private void selectExePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();

            if (opd.ShowDialog() == DialogResult.OK)
            {
                SaveC.Util_Dir = opd.FileName.ToString();
            }
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();

            if (opd.ShowDialog() == DialogResult.OK)
            {
                inputToolStripMenuItem.Text = opd.FileName.ToString();
                SaveC.Input_Dir = opd.FileName.ToString();
                executeToolStripMenuItem.Enabled = true;
            }
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string svArgs = "/K " + @"""" + SaveC.Util_Dir + " -i " + @"""" + SaveC.Input_Dir + "\"";
            Process.Start("cmd.exe", svArgs);
        }
    }
}
