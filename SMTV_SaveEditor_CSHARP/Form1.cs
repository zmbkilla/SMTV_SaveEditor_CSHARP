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
            //FileStream fs = new FileStream(SaveC.Save_Dir, FileMode.Open);
            //fs.Close();
            using (BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir)))
            {
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

                for (int i = 0x91C; i <= 0x930; i++)
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
                    data_pl.numericUpDown1.Enabled = true;
                }
                data_pl.numericUpDown1.Value = cycleval;

                data_pl.textBox1.Text = Encoding.Unicode.GetString(fbytes);

                data_pl.textBox2.Text = Encoding.Unicode.GetString(lbytes);


                br.Close();
            }
            
            //fs.Close();

            flowLayoutPanel1.Controls.Add(data_pl);
        }

        //load decrypted save
        private void openDecryptedSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                if (opf.ShowDialog() == DialogResult.OK)
                {


                    SaveC.Save_Dir = opf.FileName.ToString();
                    if (SaveC.Save_Dir != null)
                    {
                        //FileStream fs = new FileStream(SaveC.Save_Dir, FileMode.Open);
                        //fs.Close();
                        BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir));
                        string savecheck = null;
                        for (int i = 0x0; i <= 0x1; i++)
                        {
                            br.BaseStream.Position = i;

                            savecheck += br.ReadByte().ToString("X2");
                        }
                        if (savecheck == "FFFC")
                        {
                            MessageBox.Show("save is encrypted");
                        }

                        br.Dispose();
                        br.Close();
                    }

                    MessageBox.Show("Save File Selected");
                    fullControls(this);
                }
            }

            
            

            



            
        }

        // load macca and glory
        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var data_pl = new PL_CuGl();
            //FileStream fs = new FileStream(SaveC.Save_Dir, FileMode.Open);
            //fs.Close();
            using (BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir)))
            {
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



                int mval = Int32.Parse(Macca, System.Globalization.NumberStyles.HexNumber);
                int gval = Int32.Parse(Glory, System.Globalization.NumberStyles.HexNumber);





                data_pl.numericUpDown1.Value = mval;
                data_pl.numericUpDown2.Value = gval;

                br.Close();
            }
           
            //fs.Close();

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
            executeToolStripMenuItem1.Enabled = false;
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
            tp.SetToolTip(button1, "Edit Save Information");
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
            //FileStream fs = new FileStream(SaveC.Save_Dir, FileMode.Open);
            //fs.Close();

            
            using (BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir)))
            {
                string STR = null;
                string VIT = null;
                string MAG = null;
                string AGI = null;
                string LU = null;
                string HP = null;
                string MP = null;
                string stra = null;
                string strc = null;
                string vita = null;
                string vitc = null;
                string maga = null;
                string magc = null;
                string agia = null;
                string agic = null;
                string lua = null;
                string luc = null;
                string hpa = null;
                string hpc = null;
                string mpa = null;
                string mpc = null;
                string s1 = null;
                string s2 = null;
                string s3 = null;
                string s4 = null;
                string s5 = null;
                string s6 = null;
                string s7 = null;
                string s8 = null;



                int skill1 = 0x970;
                int skilladd = skill1 + 1;
                int skill2 = skill1 + 8;
                int skill3 = skill2 + 8;
                int skill4 = skill3 + 8;
                int skill5 = skill4 + 8;
                int skill6 = skill5 + 8;
                int skill7 = skill6 + 8;
                int skill8 = skill7 + 8;

                //str
                for (int i = 0x8C1; i >= 0x8C0; i--)
                {
                    br.BaseStream.Position = i;

                    STR += br.ReadByte().ToString("X2");
                }

                for (int i = 0x8D1; i >= 0x8D0; i--)
                {
                    br.BaseStream.Position = i;

                    stra += br.ReadByte().ToString("X2");
                }

                for (int i = 0x8E1; i >= 0x8E0; i--)
                {
                    br.BaseStream.Position = i;

                    strc += br.ReadByte().ToString("X2");
                }
                //vit
                for (int i = 0x8C3; i >= 0x8C2; i--)
                {
                    br.BaseStream.Position = i;

                    VIT += br.ReadByte().ToString("X2");
                }

                for (int i = 0x8D3; i >= 0x8D2; i--)
                {
                    br.BaseStream.Position = i;

                    vita += br.ReadByte().ToString("X2");
                }

                for (int i = 0x8E3; i >= 0x8E2; i--)
                {
                    br.BaseStream.Position = i;

                    vitc += br.ReadByte().ToString("X2");
                }

                //mag

                for (int i = 0x8C5; i >= 0x8C4; i--)
                {
                    br.BaseStream.Position = i;

                    MAG += br.ReadByte().ToString("X2");
                }

                for (int i = 0x8D5; i >= 0x8D4; i--)
                {
                    br.BaseStream.Position = i;

                    maga += br.ReadByte().ToString("X2");
                }

                for (int i = 0x8E5; i >= 0x8E4; i--)
                {
                    br.BaseStream.Position = i;

                    magc += br.ReadByte().ToString("X2");
                }
                //agi
                for (int i = 0x8C7; i >= 0x8C6; i--)
                {
                    br.BaseStream.Position = i;

                    AGI += br.ReadByte().ToString("X2");
                }

                for (int i = 0x8D7; i >= 0x8D6; i--)
                {
                    br.BaseStream.Position = i;

                    agia += br.ReadByte().ToString("X2");
                }

                for (int i = 0x8E7; i >= 0x8E6; i--)
                {
                    br.BaseStream.Position = i;

                    agic += br.ReadByte().ToString("X2");
                }

                //lu

                for (int i = 0x8C9; i >= 0x8C8; i--)
                {
                    br.BaseStream.Position = i;

                    LU += br.ReadByte().ToString("X2");
                }

                for (int i = 0x8D9; i >= 0x8D8; i--)
                {
                    br.BaseStream.Position = i;

                    lua += br.ReadByte().ToString("X2");
                }

                for (int i = 0x8E9; i >= 0x8E8; i--)
                {
                    br.BaseStream.Position = i;

                    luc += br.ReadByte().ToString("X2");
                }

                //hp


                for (int i = 0x8BD; i >= 0x8BC; i--)
                {
                    br.BaseStream.Position = i;

                    HP += br.ReadByte().ToString("X2");
                }

                for (int i = 0x8CD; i >= 0x8CC; i--)
                {
                    br.BaseStream.Position = i;

                    hpa += br.ReadByte().ToString("X2");
                }

                for (int i = 0x8DD; i >= 0x8DC; i--)
                {
                    br.BaseStream.Position = i;

                    hpc += br.ReadByte().ToString("X2");
                }

                //mp

                for (int i = 0x8BF; i >= 0x8BE; i--)
                {
                    br.BaseStream.Position = i;

                    MP += br.ReadByte().ToString("X2");
                }

                for (int i = 0x8CF; i >= 0x8CE; i--)
                {
                    br.BaseStream.Position = i;

                    mpa += br.ReadByte().ToString("X2");
                }

                for (int i = 0x8DF; i >= 0x8DE; i--)
                {
                    br.BaseStream.Position = i;

                    mpc += br.ReadByte().ToString("X2");
                }

                //skills
                for (int i = skilladd; i >= skill1; i--)
                {
                    br.BaseStream.Position = i;
                    s1 += br.ReadByte().ToString("X2");
                }

                skilladd = skill2 + 1;

                for (int i = skilladd; i >= skill2; i--)
                {
                    br.BaseStream.Position = i;
                    s2 += br.ReadByte().ToString("X2");
                }

                skilladd = skill3 + 1;

                for (int i = skilladd; i >= skill3; i--)
                {
                    br.BaseStream.Position = i;
                    s3 += br.ReadByte().ToString("X2");
                }

                skilladd = skill4 + 1;

                for (int i = skilladd; i >= skill4; i--)
                {
                    br.BaseStream.Position = i;
                    s4 += br.ReadByte().ToString("X2");
                }

                skilladd = skill5 + 1;

                for (int i = skilladd; i >= skill5; i--)
                {
                    br.BaseStream.Position = i;
                    s5 += br.ReadByte().ToString("X2");
                }

                skilladd = skill6 + 1;

                for (int i = skilladd; i >= skill6; i--)
                {
                    br.BaseStream.Position = i;
                    s6 += br.ReadByte().ToString("X2");
                }

                skilladd = skill7 + 1;

                for (int i = skilladd; i >= skill7; i--)
                {
                    br.BaseStream.Position = i;
                    s7 += br.ReadByte().ToString("X2");
                }

                skilladd = skill8 + 1;

                for (int i = skilladd; i >= skill8; i--)
                {
                    br.BaseStream.Position = i;
                    s8 += br.ReadByte().ToString("X2");
                }



                int strval = Int32.Parse(STR, System.Globalization.NumberStyles.HexNumber);
                int straval = Int32.Parse(stra, System.Globalization.NumberStyles.HexNumber);
                int strcval = Int32.Parse(strc, System.Globalization.NumberStyles.HexNumber);
                int vitval = Int32.Parse(VIT, System.Globalization.NumberStyles.HexNumber);
                int vitaval = Int32.Parse(vita, System.Globalization.NumberStyles.HexNumber);
                int vitcval = Int32.Parse(vitc, System.Globalization.NumberStyles.HexNumber);
                int magval = Int32.Parse(MAG, System.Globalization.NumberStyles.HexNumber);
                int magaval = Int32.Parse(maga, System.Globalization.NumberStyles.HexNumber);
                int magcval = Int32.Parse(magc, System.Globalization.NumberStyles.HexNumber);
                int agival = Int32.Parse(AGI, System.Globalization.NumberStyles.HexNumber);
                int agiaval = Int32.Parse(agia, System.Globalization.NumberStyles.HexNumber);
                int agicval = Int32.Parse(agic, System.Globalization.NumberStyles.HexNumber);
                int luval = Int32.Parse(LU, System.Globalization.NumberStyles.HexNumber);
                int luaval = Int32.Parse(lua, System.Globalization.NumberStyles.HexNumber);
                int lucval = Int32.Parse(luc, System.Globalization.NumberStyles.HexNumber);
                int hpval = Int32.Parse(HP, System.Globalization.NumberStyles.HexNumber);
                int mpval = Int32.Parse(MP, System.Globalization.NumberStyles.HexNumber);
                int hpaval = Int32.Parse(hpa, System.Globalization.NumberStyles.HexNumber);
                int hpcval = Int32.Parse(hpc, System.Globalization.NumberStyles.HexNumber);
                int mpaval = Int32.Parse(mpa, System.Globalization.NumberStyles.HexNumber);
                int mpcval = Int32.Parse(mpc, System.Globalization.NumberStyles.HexNumber);

                int s1val = Int32.Parse(s1, System.Globalization.NumberStyles.HexNumber);
                int s2val = Int32.Parse(s2, System.Globalization.NumberStyles.HexNumber);
                int s3val = Int32.Parse(s3, System.Globalization.NumberStyles.HexNumber);
                int s4val = Int32.Parse(s4, System.Globalization.NumberStyles.HexNumber);
                int s5val = Int32.Parse(s5, System.Globalization.NumberStyles.HexNumber);
                int s6val = Int32.Parse(s6, System.Globalization.NumberStyles.HexNumber);
                int s7val = Int32.Parse(s7, System.Globalization.NumberStyles.HexNumber);
                int s8val = Int32.Parse(s8, System.Globalization.NumberStyles.HexNumber);





                data_pl.numericUpDown1.Value = strval;
                data_pl.numericUpDown2.Value = vitval;
                data_pl.numericUpDown3.Value = magval;
                data_pl.numericUpDown4.Value = agival;
                data_pl.numericUpDown5.Value = luval;
                data_pl.numericUpDown6.Value = hpval;
                data_pl.numericUpDown7.Value = mpval;
                data_pl.numericUpDown8.Value = straval;
                data_pl.numericUpDown9.Value = strcval;
                data_pl.numericUpDown10.Value = vitaval;
                data_pl.numericUpDown11.Value = vitcval;
                data_pl.numericUpDown12.Value = magaval;
                data_pl.numericUpDown13.Value = magcval;
                data_pl.numericUpDown14.Value = agiaval;
                data_pl.numericUpDown15.Value = agicval;
                data_pl.numericUpDown16.Value = luaval;
                data_pl.numericUpDown17.Value = lucval;
                data_pl.numericUpDown18.Value = hpaval;
                data_pl.numericUpDown19.Value = hpcval;
                data_pl.numericUpDown20.Value = mpaval;
                data_pl.numericUpDown21.Value = mpcval;
                data_pl.comboBox1.SelectedIndex = s1val - 1;
                data_pl.comboBox2.SelectedIndex = s2val - 1;
                data_pl.comboBox3.SelectedIndex = s3val - 1;
                data_pl.comboBox4.SelectedIndex = s4val - 1;
                data_pl.comboBox5.SelectedIndex = s5val - 1;
                data_pl.comboBox6.SelectedIndex = s6val - 1;
                data_pl.comboBox7.SelectedIndex = s7val - 1;
                data_pl.comboBox8.SelectedIndex = s8val - 1;

                try
                {
                    


                    br.Dispose();
                    br.Close();

                   

                }
                catch (Exception exp)
                {
                    //Assuming you have included using 'namespace System.Diagnostics'
                    Debug.WriteLine(exp.ToString());
                }

                br.Close();
                br.Dispose();

                

            }
            
            //fs.Close();

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
            if(SaveC.Input_Dir != null)
            {
                try
                {
                    SaveCrypt.CryptFile(SaveC.Input_Dir);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "error");
                }
                
            }
            
            
            //string svArgs = "/K " + @"""" + SaveC.Util_Dir + " -i " + @"""" + SaveC.Input_Dir + "\"";
            //Process.Start("cmd.exe", svArgs);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var data_pl = new PL_inv();


            

            flowLayoutPanel1.Controls.Add(data_pl);
        }

        private void inputToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opd = new OpenFileDialog())
            {
                if (opd.ShowDialog() == DialogResult.OK)
                {
                    inputToolStripMenuItem1.Text = opd.FileName.ToString();
                    SaveC.Input_Dir = opd.FileName.ToString();

                    if (SaveC.Input_Dir != null && SaveC.Output_Dir != null)
                    {
                        executeToolStripMenuItem1.Enabled = true;
                    }

                }
            } 

           
        }

        private void executeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (SaveC.Input_Dir != null && SaveC.Output_Dir != null)
            {
                try
                {
                    SaveCrypt.CryptFile(SaveC.Input_Dir,SaveC.Output_Dir);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "error");
                }

            }
        }

        private void outputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                outputToolStripMenuItem.Text = sfd.FileName.ToString();
                SaveC.Output_Dir = sfd.FileName.ToString();
                if (SaveC.Input_Dir != null && SaveC.Output_Dir != null)
                {
                    executeToolStripMenuItem1.Enabled = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var data_pl = new PL_Soul();




            flowLayoutPanel1.Controls.Add(data_pl);
        }
    }
}
