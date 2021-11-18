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

            decimal iDemonID = Convert.ToDecimal(comboBox2.Text);
            decimal str = numericUpDown1.Value;
            decimal vit = numericUpDown2.Value;
            decimal mag = numericUpDown3.Value;
            decimal agi = numericUpDown4.Value;
            decimal lu = numericUpDown5.Value;
            byte[] bDID = BitConverter.GetBytes(Convert.ToInt32(iDemonID));
            byte[] bstr = BitConverter.GetBytes(Convert.ToInt32(str));
            byte[] bvit = BitConverter.GetBytes(Convert.ToInt32(vit));
            byte[] bmag = BitConverter.GetBytes(Convert.ToInt32(mag));
            byte[] bagi = BitConverter.GetBytes(Convert.ToInt32(agi));
            byte[] blu = BitConverter.GetBytes(Convert.ToInt32(lu));

            br.Close();


            BinaryWriter bw = new BinaryWriter(File.OpenWrite(SaveC.Save_Dir));

            int slot0ID = 0xAE6;
            int slotmod = slot0ID + (comboBox1.SelectedIndex * 392);

            bw.BaseStream.Position = slotmod;
            bw.Write(bDID);

            int slot0STR = 0xA98;
            slotmod = slot0STR + (comboBox1.SelectedIndex * 392);

            bw.BaseStream.Position = slotmod;
            bw.Write(bstr);

            int slot0VIT = 0xA9A;
            slotmod = slot0VIT + (comboBox1.SelectedIndex * 392);

            bw.BaseStream.Position = slotmod;
            bw.Write(bvit);

            int slot0MAG = 0xA9C;
            slotmod = slot0MAG + (comboBox1.SelectedIndex * 392);

            bw.BaseStream.Position = slotmod;
            bw.Write(bmag);

            int slot0AGI = 0xA9E;
            slotmod = slot0AGI + (comboBox1.SelectedIndex * 392);

            bw.BaseStream.Position = slotmod;
            bw.Write(bagi);

            int slot0LU = 0xAA0;
            slotmod = slot0LU + (comboBox1.SelectedIndex * 392);

            bw.BaseStream.Position = slotmod;
            bw.Write(blu);

            MessageBox.Show("Changes applied","Success");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var test = variables.demonquery(comboBox1.SelectedIndex);

            comboBox2.Text = test[0].ToString();
            numericUpDown1.Value = test[1];
            numericUpDown2.Value = test[2];
            numericUpDown3.Value = test[3];
            numericUpDown4.Value = test[4];
            numericUpDown5.Value = test[5];

           
        }
    }
}
