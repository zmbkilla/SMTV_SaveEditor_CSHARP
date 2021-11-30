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
    public partial class PL_Items : UserControl
    {
        public PL_Items()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int position = Convert.ToInt32(label2.Text);
            decimal amount = numericUpDown1.Value;

            byte[] bamount = BitConverter.GetBytes(Convert.ToInt32(amount));

            BinaryWriter bw = new BinaryWriter(File.OpenWrite(SaveC.Save_Dir));


            bw.BaseStream.Position = position;
            bw.Write(bamount, 0, 1);
            bw.Close();

            MessageBox.Show("Item amount updated", "success");
        }
    }
}
