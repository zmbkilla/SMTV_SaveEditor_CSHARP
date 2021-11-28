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
            decimal stra = numericUpDown8.Value;
            decimal strc = numericUpDown9.Value;
            decimal vita = numericUpDown10.Value;
            decimal vitc = numericUpDown11.Value;
            decimal maga = numericUpDown12.Value;
            decimal magc = numericUpDown13.Value;
            decimal agia = numericUpDown14.Value;
            decimal agic = numericUpDown15.Value;
            decimal lua = numericUpDown16.Value;
            decimal luc = numericUpDown17.Value;
            decimal hp = numericUpDown6.Value;
            decimal hpa = numericUpDown18.Value;
            decimal hpc = numericUpDown19.Value;
            decimal mp = numericUpDown7.Value;
            decimal mpa = numericUpDown20.Value;
            decimal mpc = numericUpDown21.Value;
            //char[] fcharar = Mac.ToCharArray();


            byte[] bstr = BitConverter.GetBytes(Convert.ToInt32(str));
            byte[] bvit = BitConverter.GetBytes(Convert.ToInt32(vit));
            byte[] bmag = BitConverter.GetBytes(Convert.ToInt32(mag));
            byte[] bagi = BitConverter.GetBytes(Convert.ToInt32(agi));
            byte[] blu = BitConverter.GetBytes(Convert.ToInt32(lu));
            byte[] bstra = BitConverter.GetBytes(Convert.ToInt32(stra));
            byte[] bstrc = BitConverter.GetBytes(Convert.ToInt32(strc));
            byte[] bvita = BitConverter.GetBytes(Convert.ToInt32(vita));
            byte[] bvitc = BitConverter.GetBytes(Convert.ToInt32(vitc));
            byte[] bmaga = BitConverter.GetBytes(Convert.ToInt32(maga));
            byte[] bmagc = BitConverter.GetBytes(Convert.ToInt32(magc));
            byte[] bagia = BitConverter.GetBytes(Convert.ToInt32(agia));
            byte[] bagic = BitConverter.GetBytes(Convert.ToInt32(agic));
            byte[] blua = BitConverter.GetBytes(Convert.ToInt32(lua));
            byte[] bluc = BitConverter.GetBytes(Convert.ToInt32(luc));
            byte[] bhp = BitConverter.GetBytes(Convert.ToInt32(hp));
            byte[] bhpa = BitConverter.GetBytes(Convert.ToInt32(hpa));
            byte[] bhpc = BitConverter.GetBytes(Convert.ToInt32(hpc));
            byte[] bmp = BitConverter.GetBytes(Convert.ToInt32(mp));
            byte[] bmpa = BitConverter.GetBytes(Convert.ToInt32(mpa));
            byte[] bmpc = BitConverter.GetBytes(Convert.ToInt32(mpc));


            br.Close();
            BinaryWriter BWriter = new BinaryWriter(File.OpenWrite(SaveC.Save_Dir));

            //str
            BWriter.BaseStream.Position = 0x8C0;
            BWriter.Write(bstr, 0, 2);

            BWriter.BaseStream.Position = 0x8D0;
            BWriter.Write(bstra, 0, 2);

            BWriter.BaseStream.Position = 0x8E0;
            BWriter.Write(bstrc, 0, 2);

            //vit
            BWriter.BaseStream.Position = 0x8C2;
            BWriter.Write(bvit, 0, 2);

            BWriter.BaseStream.Position = 0x8D2;
            BWriter.Write(bvita, 0, 2);

            BWriter.BaseStream.Position = 0x8E2;
            BWriter.Write(bvitc, 0, 2);

            //mag
            BWriter.BaseStream.Position = 0x8C4;
            BWriter.Write(bmag, 0, 2);

            BWriter.BaseStream.Position = 0x8D4;
            BWriter.Write(bmaga, 0, 2);

            BWriter.BaseStream.Position = 0x8E4;
            BWriter.Write(bmagc, 0, 2);

            //agi
            BWriter.BaseStream.Position = 0x8C6;
            BWriter.Write(bagi, 0, 2);

            BWriter.BaseStream.Position = 0x8D6;
            BWriter.Write(bagia, 0, 2);

            BWriter.BaseStream.Position = 0x8E6;
            BWriter.Write(bagic, 0, 2);
            //lu
            BWriter.BaseStream.Position = 0x8C8;
            BWriter.Write(blu, 0, 2);

            BWriter.BaseStream.Position = 0x8D8;
            BWriter.Write(blua, 0, 2);

            BWriter.BaseStream.Position = 0x8E8;
            BWriter.Write(bluc, 0, 2);


            // hp
            BWriter.BaseStream.Position = 0x8BC;
            BWriter.Write(bhp, 0, 2);

            BWriter.BaseStream.Position = 0x8DC;
            BWriter.Write(bhpa, 0, 2);

            BWriter.BaseStream.Position = 0x8F0;
            BWriter.Write(bhpc, 0, 2);

            //mp
            BWriter.BaseStream.Position = 0x8BE;
            BWriter.Write(bmp, 0, 2);

            BWriter.BaseStream.Position = 0x8DE;
            BWriter.Write(bmpa, 0, 2);

            BWriter.BaseStream.Position = 0x8F2;
            BWriter.Write(bmpc, 0, 2);

            BWriter.Close();



            MessageBox.Show("success");
        }
    }
}
