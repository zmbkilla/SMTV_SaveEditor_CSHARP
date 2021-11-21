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
    public partial class PL_CuGl : UserControl
    {
        public PL_CuGl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(SaveC.Save_Dir, FileMode.Open);
            fs.Close();
            BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir));
            decimal Mac = numericUpDown1.Value;
            decimal Glo = numericUpDown2.Value;
            //char[] fcharar = Mac.ToCharArray();


            byte[] bmac = BitConverter.GetBytes(Convert.ToInt32(Mac));
            byte[] bglo = BitConverter.GetBytes(Convert.ToInt32(Glo));

            br.Close();
            BinaryWriter BWriter = new BinaryWriter(File.OpenWrite(SaveC.Save_Dir));


            // for (int i = 0x904, ii = 0; i <= 0x91C && ii < FName.Length; i+=2, ii++)
            // {
            //     char ichar = fcharar[ii];
            //     int value = Convert.ToInt32(ichar);
            //     string hexoutput = string.Format("0x{0:X}", value);


            //byte[] rMac = Encoding.Unicode.GetBytes(Mac);
            //string convert = Convert.ToString(rMac);

            



            //int imac = Convert.ToInt32(Mac);
            

            //string hexvalue = imac.ToString("X");

            //byte[] pls = new byte[imac];

            //Array.Reverse(pls);
            BWriter.BaseStream.Position = 0x2F70;
            BWriter.Write(bmac, 0, 4);


            BWriter.BaseStream.Position = 0x2F88;
            BWriter.Write(bglo, 0, 4);


            // }
            BWriter.Close();



            MessageBox.Show("success");
        }
    }
}
