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
        public PL_Data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(SaveC.Save_Dir, FileMode.Open);
            fs.Close();
            BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir));
            string FName = textBox1.Text;
            char[] fcharar = FName.ToCharArray();
            br.Close();
            BinaryWriter BWriter = new BinaryWriter(File.OpenWrite(SaveC.Save_Dir));

            // for (int i = 0x904, ii = 0; i <= 0x91C && ii < FName.Length; i+=2, ii++)
            // {
            //     char ichar = fcharar[ii];
            //     int value = Convert.ToInt32(ichar);
            //     string hexoutput = string.Format("0x{0:X}", value);


            BWriter.BaseStream.Position = 0x904;
            BWriter.Write(Encoding.Unicode.GetBytes(FName));

            // }
            BWriter.Close();

        }

       

        
    }
}
