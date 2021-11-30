using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SMTV_SaveEditor_CSHARP
{
    public partial class PL_Data : UserControl
    {

        public decimal dlcchk, ngpchk;
        public PL_Data()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                numericUpDown1.Enabled = true;
            }else if (checkBox2.Checked == false)
            {
                numericUpDown1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            


            //FileStream fs = new FileStream(SaveC.Save_Dir, FileMode.Open);
            //fs.Close();
            //BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir));
            string FName = textBox1.Text;
            string LName = textBox2.Text;
            char[] fcharar = FName.ToCharArray();
            decimal ngcycle = numericUpDown1.Value;
            if (checkBox1.Checked == true)
            {
                dlcchk = 255;
            }else if (checkBox1.Checked == false)
            {
                dlcchk = 0;
            }

            if (checkBox2.Checked == true)
            {
                ngpchk = 1;
                
            } else if (checkBox2.Checked == false)
            {
                ngpchk = 0;
                
            }

            byte[] bdlc = BitConverter.GetBytes(Convert.ToInt32(dlcchk));
            byte[] bngp = BitConverter.GetBytes(Convert.ToInt32(ngpchk));
            byte[] bcycle = BitConverter.GetBytes(Convert.ToInt32(ngcycle));
            //br.Close();
            BinaryWriter BWriter = new BinaryWriter(File.OpenWrite(SaveC.Save_Dir));

            // for (int i = 0x904, ii = 0; i <= 0x91C && ii < FName.Length; i+=2, ii++)
            // {
            //     char ichar = fcharar[ii];
            //     int value = Convert.ToInt32(ichar);
            //     string hexoutput = string.Format("0x{0:X}", value);


            BWriter.BaseStream.Position = 0x904;
            BWriter.Write(Encoding.Unicode.GetBytes(FName));


            BWriter.BaseStream.Position = 0x91C;
            BWriter.Write(Encoding.Unicode.GetBytes(LName));

            BWriter.BaseStream.Position = 0x45D;
            BWriter.Write(bdlc,0,1);

            BWriter.BaseStream.Position = 0x45C;
            BWriter.Write(bngp, 0, 1);

            if (checkBox2.Checked == true)
            {
                BWriter.BaseStream.Position = 0x436;
                BWriter.Write(bcycle, 0, 1);
            }


            // }

            BWriter.Close();

        }
    }
}
