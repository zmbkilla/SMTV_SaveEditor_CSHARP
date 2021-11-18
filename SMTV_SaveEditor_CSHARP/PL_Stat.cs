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
    public partial class PL_Stat : UserControl
    {
        public PL_Stat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(SaveC.Save_Dir, FileMode.Open);
            fs.Close();
            BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir));
            decimal str = numericUpDown1.Value;
            decimal vit = numericUpDown2.Value;
            decimal mag = numericUpDown3.Value;
            decimal agi = numericUpDown4.Value;
            decimal lu = numericUpDown5.Value;
            //char[] fcharar = Mac.ToCharArray();


            byte[] bstr = BitConverter.GetBytes(Convert.ToInt32(str));
            byte[] bvit = BitConverter.GetBytes(Convert.ToInt32(vit));
            byte[] bmag = BitConverter.GetBytes(Convert.ToInt32(mag));
            byte[] bagi = BitConverter.GetBytes(Convert.ToInt32(agi));
            byte[] blu = BitConverter.GetBytes(Convert.ToInt32(lu));

            br.Close();
            BinaryWriter BWriter = new BinaryWriter(File.OpenWrite(SaveC.Save_Dir));


            BWriter.BaseStream.Position = 0x8C0;
            BWriter.Write(bstr);


            BWriter.BaseStream.Position = 0x8C2;
            BWriter.Write(bvit);

            BWriter.BaseStream.Position = 0x8C4;
            BWriter.Write(bstr);


            BWriter.BaseStream.Position = 0x8C6;
            BWriter.Write(bvit);

            BWriter.BaseStream.Position = 0x8C6;
            BWriter.Write(bvit);


            // }
            BWriter.Close();



            MessageBox.Show("success");
        }
    }
}
