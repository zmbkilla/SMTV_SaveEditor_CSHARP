using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTV_SaveEditor_CSHARP
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }


        //player data button
        private void button1_Click(object sender, EventArgs e)
        {
            var data_pl = new PL_Data();
            FileStream fs = new FileStream(SaveC.Save_Dir, FileMode.Open);
            fs.Close();
            BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir));
            string FName = null;
            string LName = null;

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


            data_pl.textBox1.Text = Encoding.Unicode.GetString(fbytes);

            data_pl.textBox2.Text = Encoding.Unicode.GetString(lbytes);
            
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

        // [NOT WORKING] load macca and glory
        private void button2_Click(object sender, EventArgs e)
        {
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

            flowLayoutPanel1.Controls.Add(data_pl);
        }
        // initialize form
        private void Form1_Load(object sender, EventArgs e)
        {
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
        }

        private void openDecryptedSaveToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(menuStrip1, "Open a decrypted save");
        }
    }
}
