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
    public partial class PL_Demon : UserControl
    {
        public PL_Demon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(SaveC.Save_Dir, FileMode.Open);
            fs.Close();
            BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir));

            string iDemonID = comboBox2.Text;
            string DemonID = iDemonID.Substring(0, 4);

            BinaryWriter bw = new BinaryWriter(File.OpenWrite(SaveC.Save_Dir));

            bw.BaseStream.wr

        }
    }
}
