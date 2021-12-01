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
            //FileStream fs = new FileStream(SaveC.Save_Dir, FileMode.Open);
            //fs.Close();
            //BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir));
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

            decimal s1 = comboBox1.SelectedIndex + 1;
            decimal s2 = comboBox2.SelectedIndex + 1;
            decimal s3 = comboBox3.SelectedIndex + 1;
            decimal s4 = comboBox4.SelectedIndex + 1;
            decimal s5 = comboBox5.SelectedIndex + 1;
            decimal s6 = comboBox6.SelectedIndex + 1;
            decimal s7 = comboBox7.SelectedIndex + 1;
            decimal s8 = comboBox8.SelectedIndex + 1;

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
            byte[] bs1 = BitConverter.GetBytes(Convert.ToInt32(s1));
            byte[] bs2 = BitConverter.GetBytes(Convert.ToInt32(s2));
            byte[] bs3 = BitConverter.GetBytes(Convert.ToInt32(s3));
            byte[] bs4 = BitConverter.GetBytes(Convert.ToInt32(s4));
            byte[] bs5 = BitConverter.GetBytes(Convert.ToInt32(s5));
            byte[] bs6 = BitConverter.GetBytes(Convert.ToInt32(s6));
            byte[] bs7 = BitConverter.GetBytes(Convert.ToInt32(s7));
            byte[] bs8 = BitConverter.GetBytes(Convert.ToInt32(s8));


            //br.Close();




            using (BinaryWriter BWriter = new BinaryWriter(File.OpenWrite(SaveC.Save_Dir)))
            {
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


                //skills
                int slot0s1 = 0x970;

                BWriter.BaseStream.Position = slot0s1;
                BWriter.Write(bs1, 0, 2);

                int slot0s2 = slot0s1 + 8;

                BWriter.BaseStream.Position = slot0s2;
                BWriter.Write(bs2, 0, 2);

                int slot0s3 = slot0s2 + 8;

                BWriter.BaseStream.Position = slot0s3;
                BWriter.Write(bs3, 0, 2);

                int slot0s4 = slot0s3 + 8;

                BWriter.BaseStream.Position = slot0s4;
                BWriter.Write(bs4, 0, 2);

                int slot0s5 = slot0s4 + 8;

                BWriter.BaseStream.Position = slot0s5;
                BWriter.Write(bs5, 0, 2);

                int slot0s6 = slot0s5 + 8;

                BWriter.BaseStream.Position = slot0s6;
                BWriter.Write(bs6, 0, 2);

                int slot0s7 = slot0s6 + 8;

                BWriter.BaseStream.Position = slot0s7;
                BWriter.Write(bs7, 0, 2);

                int slot0s8 = slot0s7 + 8;

                BWriter.BaseStream.Position = slot0s8;
                BWriter.Write(bs8, 0, 2);

                BWriter.Close();
                

            }

           

            MessageBox.Show("success");
        }
    }
}
