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
            //FileStream fs = new FileStream(SaveC.Save_Dir, FileMode.Open);
            //fs.Close();
            //BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir));




            decimal iDemonID = numericUpDown6.Value;
            decimal str = numericUpDown1.Value;
            decimal vit = numericUpDown2.Value;
            decimal mag = numericUpDown3.Value;
            decimal agi = numericUpDown4.Value;
            decimal lu = numericUpDown5.Value;
            decimal hp = numericUpDown7.Value;
            decimal mp = numericUpDown8.Value;
            decimal stra = numericUpDown9.Value;
            decimal strc = numericUpDown10.Value;
            decimal vita = numericUpDown11.Value;
            decimal vitc = numericUpDown12.Value;
            decimal maga = numericUpDown13.Value;
            decimal magc = numericUpDown14.Value;
            decimal agia = numericUpDown15.Value;
            decimal agic = numericUpDown16.Value;
            decimal lua = numericUpDown17.Value;
            decimal luc = numericUpDown18.Value;
            decimal hpa = numericUpDown19.Value;
            decimal hpc = numericUpDown20.Value;
            decimal mpa = numericUpDown21.Value;
            decimal mpc = numericUpDown22.Value;

            decimal s1 = comboBox2.SelectedIndex + 1;
            decimal s2 = comboBox3.SelectedIndex + 1;
            decimal s3 = comboBox4.SelectedIndex + 1;
            decimal s4 = comboBox5.SelectedIndex + 1;
            decimal s5 = comboBox6.SelectedIndex + 1;
            decimal s6 = comboBox7.SelectedIndex + 1;
            decimal s7 = comboBox8.SelectedIndex + 1;
            decimal s8 = comboBox9.SelectedIndex + 1;

            byte[] bDID = BitConverter.GetBytes(Convert.ToInt32(iDemonID));
            byte[] bstr = BitConverter.GetBytes(Convert.ToInt32(str));
            byte[] bvit = BitConverter.GetBytes(Convert.ToInt32(vit));
            byte[] bmag = BitConverter.GetBytes(Convert.ToInt32(mag));
            byte[] bagi = BitConverter.GetBytes(Convert.ToInt32(agi));
            byte[] blu = BitConverter.GetBytes(Convert.ToInt32(lu));
            byte[] bhp = BitConverter.GetBytes(Convert.ToInt32(hp));
            byte[] bmp = BitConverter.GetBytes(Convert.ToInt32(mp));
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
            byte[] bhpa = BitConverter.GetBytes(Convert.ToInt32(hpa));
            byte[] bhpc = BitConverter.GetBytes(Convert.ToInt32(hpc));
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

            
            
            BinaryWriter bw = new BinaryWriter(File.OpenWrite(SaveC.Save_Dir));

            //demon id
            int slot0ID = 0xAE6;
            int slotmod = slot0ID + (comboBox1.SelectedIndex * 392);
            int slotmoda = 0, slotmodc = 0;

            bw.BaseStream.Position = slotmod;
            bw.Write(bDID, 0, 2);
            //str
            int slot0STR = 0xA98;
            int slot0STRa = slot0STR + 16;
            int slot0STRc = slot0STRa + 16;
            slotmod = slot0STR + (comboBox1.SelectedIndex * 392);
            slotmoda = slot0STRa + (comboBox1.SelectedIndex * 392);
            slotmodc = slot0STRc + (comboBox1.SelectedIndex * 392);

            bw.BaseStream.Position = slotmod;
            bw.Write(bstr, 0, 2);

            bw.BaseStream.Position = slotmoda;
            bw.Write(bstra, 0, 2);

            bw.BaseStream.Position = slotmodc;
            bw.Write(bstrc, 0, 2);
            //vit
            int slot0VIT = 0xA9A;
            int slot0VITa = slot0VIT + 16;
            int slot0VITc = slot0VITa + 16;
            slotmod = slot0VIT + (comboBox1.SelectedIndex * 392);
            slotmoda = slot0VITa + (comboBox1.SelectedIndex * 392);
            slotmodc = slot0VITc + (comboBox1.SelectedIndex * 392);



            bw.BaseStream.Position = slotmod;
            bw.Write(bvit, 0, 2);

            bw.BaseStream.Position = slotmoda;
            bw.Write(bvita, 0, 2);

            bw.BaseStream.Position = slotmodc;
            bw.Write(bvitc, 0, 2);
            //mag
            int slot0MAG = 0xA9C;
            int slot0MAGa = slot0MAG + 16;
            int slot0MAGc = slot0MAGa + 16;
            slotmod = slot0MAG + (comboBox1.SelectedIndex * 392);
            slotmoda = slot0MAGa + (comboBox1.SelectedIndex * 392);
            slotmodc = slot0MAGc + (comboBox1.SelectedIndex * 392);

            bw.BaseStream.Position = slotmod;
            bw.Write(bmag, 0, 2);

            bw.BaseStream.Position = slotmoda;
            bw.Write(bmaga, 0, 2);

            bw.BaseStream.Position = slotmodc;
            bw.Write(bmagc, 0, 2);
            //agi
            int slot0AGI = 0xA9E;
            int slot0AGIa = slot0AGI + 16;
            int slot0AGIc = slot0AGIa + 16;
            slotmod = slot0AGI + (comboBox1.SelectedIndex * 392);
            slotmoda = slot0AGIa + (comboBox1.SelectedIndex * 392);
            slotmodc = slot0AGIc + (comboBox1.SelectedIndex * 392);

            bw.BaseStream.Position = slotmod;
            bw.Write(bagi, 0, 2);

            bw.BaseStream.Position = slotmoda;
            bw.Write(bagia, 0, 2);

            bw.BaseStream.Position = slotmodc;
            bw.Write(bagic, 0, 2);
            //lu
            int slot0LU = 0xAA0;
            int slot0LUa = slot0LU + 16;
            int slot0LUc = slot0LUa + 16;
            slotmod = slot0LU + (comboBox1.SelectedIndex * 392);
            slotmoda = slot0LUa + (comboBox1.SelectedIndex * 392);
            slotmodc = slot0LUc + (comboBox1.SelectedIndex * 392);

            bw.BaseStream.Position = slotmod;
            bw.Write(blu, 0, 2);

            bw.BaseStream.Position = slotmoda;
            bw.Write(blua, 0, 2);

            bw.BaseStream.Position = slotmodc;
            bw.Write(bluc, 0, 2);

            //hp
            int slot0HP = 0xA94;
            int slot0HPa = slot0HP + 16;
            int slot0HPc = slot0HPa + 16;
            slotmod = slot0HP + (comboBox1.SelectedIndex * 392);
            slotmoda = slot0HPa + (comboBox1.SelectedIndex * 392);
            slotmodc = slot0HPc + (comboBox1.SelectedIndex * 392);

            bw.BaseStream.Position = slotmod;
            bw.Write(bhp,0,2);

            bw.BaseStream.Position = slotmoda;
            bw.Write(bhpa,0,2);

            bw.BaseStream.Position = slotmodc;
            bw.Write(bhpc, 0, 2);
            //mp
            int slot0MP = 0xA96;
            int slot0MPa = slot0MP + 16;
            int slot0MPc = slot0MPa + 16;
            slotmod = slot0MP + (comboBox1.SelectedIndex * 392);
            slotmoda = slot0MPa + (comboBox1.SelectedIndex * 392);
            slotmodc = slot0MPc + (comboBox1.SelectedIndex * 392);



            bw.BaseStream.Position = slotmod;
            bw.Write(bmp, 0,2);

            bw.BaseStream.Position = slotmoda;
            bw.Write(bmpa, 0, 2);

            bw.BaseStream.Position = slotmodc;
            bw.Write(bmpc, 0, 2);


            //skills


            int slot0s1 = slot0ID + 10;
            slotmod = slot0s1 + (comboBox1.SelectedIndex * 392);
            bw.BaseStream.Position = slotmod;
            bw.Write(bs1, 0, 2);

            int slot0s2 = slot0s1 + 8;
            slotmod = slot0s2 + (comboBox1.SelectedIndex * 392);
            bw.BaseStream.Position = slotmod;
            bw.Write(bs2, 0, 2);

            int slot0s3 = slot0s2 + 8;
            slotmod = slot0s3 + (comboBox1.SelectedIndex * 392);
            bw.BaseStream.Position = slotmod;
            bw.Write(bs3, 0, 2);

            int slot0s4 = slot0s3 + 8;
            slotmod = slot0s4 + (comboBox1.SelectedIndex * 392);
            bw.BaseStream.Position = slotmod;
            bw.Write(bs4, 0, 2);

            int slot0s5 = slot0s4 + 8;
            slotmod = slot0s5 + (comboBox1.SelectedIndex * 392);
            bw.BaseStream.Position = slotmod;
            bw.Write(bs5, 0, 2);

            int slot0s6 = slot0s5 + 8;
            slotmod = slot0s6 + (comboBox1.SelectedIndex * 392);
            bw.BaseStream.Position = slotmod;
            bw.Write(bs6, 0, 2);

            int slot0s7 = slot0s6 + 8;
            slotmod = slot0s7 + (comboBox1.SelectedIndex * 392);
            bw.BaseStream.Position = slotmod;
            bw.Write(bs7, 0, 2);

            int slot0s8 = slot0s7 + 8;
            slotmod = slot0s8 + (comboBox1.SelectedIndex * 392);
            bw.BaseStream.Position = slotmod;
            bw.Write(bs8, 0, 2);


            //br.Close();
            //fs.Close();
            bw.Close();

            MessageBox.Show("Changes applied","Success");

            //reload

            var test = variables.demonquery(comboBox1.SelectedIndex);
            var dname = variables.ReadDemonDB();



            if (test[0] == 65535)
            {
                MessageBox.Show("this slot is empty.", "Warning");
                button1.Enabled = false;
                return;
            }



            //id
            numericUpDown6.Value = test[0];
            label19.Text = dname.Rows[Convert.ToInt32(test[0] - 1)]["DemonName"].ToString();
            //hp/mp
            numericUpDown7.Value = test[6];
            numericUpDown19.Value = test[18];
            numericUpDown20.Value = test[19];

            numericUpDown8.Value = test[7];
            numericUpDown21.Value = test[20];
            numericUpDown22.Value = test[21];
            //stats
            //str
            numericUpDown1.Value = test[1];
            numericUpDown9.Value = test[8];
            numericUpDown10.Value = test[9];
            //vit
            numericUpDown2.Value = test[2];
            numericUpDown11.Value = test[10];
            numericUpDown12.Value = test[11];
            //mag
            numericUpDown3.Value = test[3];
            numericUpDown13.Value = test[12];
            numericUpDown14.Value = test[13];
            //agi
            numericUpDown4.Value = test[4];
            numericUpDown15.Value = test[14];
            numericUpDown16.Value = test[15];
            //lu
            numericUpDown5.Value = test[5];
            numericUpDown17.Value = test[16];
            numericUpDown18.Value = test[17];
            button1.Enabled = true;
            //skills
            //skills
            if (test[22] != 0)
            {
                comboBox2.SelectedIndex = Convert.ToInt32(test[22]) - 1;
            }

            if (test[23] != 0)
            {
                comboBox3.SelectedIndex = Convert.ToInt32(test[23]) - 1;
            }

            if (test[24] != 0)
            {
                comboBox4.SelectedIndex = Convert.ToInt32(test[24]) - 1;
            }

            if (test[25] != 0)
            {
                comboBox5.SelectedIndex = Convert.ToInt32(test[25]) - 1;
            }

            if (test[26] != 0)
            {
                comboBox6.SelectedIndex = Convert.ToInt32(test[26]) - 1;
            }

            if (test[27] != 0)
            {
                comboBox7.SelectedIndex = Convert.ToInt32(test[27]) - 1;
            }

            if (test[28] != 0)
            {
                comboBox8.SelectedIndex = Convert.ToInt32(test[28]) - 1;
            }

            if (test[29] != 0)
            {
                comboBox9.SelectedIndex = Convert.ToInt32(test[29]) - 1;
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var test = variables.demonquery(comboBox1.SelectedIndex);
            var test2 = variables.ReadDemonDB();

            

            if(test[0] == 65535)
            {
                MessageBox.Show("this slot is empty.", "Warning");
                button1.Enabled = false;
                return;
            }



            //id
            numericUpDown6.Value = test[0];
            label19.Text = test2.Rows[Convert.ToInt32(test[0] - 1)]["DemonName"].ToString();
            //hp/mp
            numericUpDown7.Value = test[6];
            numericUpDown19.Value = test[18];
            numericUpDown20.Value = test[19];

            numericUpDown8.Value = test[7];
            numericUpDown21.Value = test[20];
            numericUpDown22.Value = test[21];
            //stats
            //str
            numericUpDown1.Value = test[1];
            numericUpDown9.Value = test[8];
            numericUpDown10.Value = test[9];
            //vit
            numericUpDown2.Value = test[2];
            numericUpDown11.Value = test[10];
            numericUpDown12.Value = test[11];
            //mag
            numericUpDown3.Value = test[3];
            numericUpDown13.Value = test[12];
            numericUpDown14.Value = test[13];
            //agi
            numericUpDown4.Value = test[4];
            numericUpDown15.Value = test[14];
            numericUpDown16.Value = test[15];
            //lu
            numericUpDown5.Value = test[5];
            numericUpDown17.Value = test[16];
            numericUpDown18.Value = test[17];

            //skills
            if (test[22] != 0)
            {
                comboBox2.SelectedIndex = Convert.ToInt32(test[22]) - 1;
            }                             
                                          
            if (test[23] != 0)            
            {                             
                comboBox3.SelectedIndex = Convert.ToInt32(test[23]) - 1;
            }                             
                                          
            if (test[24] != 0)            
            {                             
                comboBox4.SelectedIndex = Convert.ToInt32(test[24]) - 1;
            }                             
                                          
            if (test[25] != 0)            
            {                             
                comboBox5.SelectedIndex = Convert.ToInt32(test[25]) - 1;
            }                             
                                          
            if (test[26] != 0)            
            {                             
                comboBox6.SelectedIndex = Convert.ToInt32(test[26]) - 1;
            }                             
                                          
            if (test[27] != 0)            
            {                             
                comboBox7.SelectedIndex = Convert.ToInt32(test[27]) - 1;
            }                             
                                          
            if (test[28] != 0)            
            {                             
                comboBox8.SelectedIndex = Convert.ToInt32(test[28]) - 1;
            }                             
                                          
            if (test[29] != 0)            
            {                             
                comboBox9.SelectedIndex = Convert.ToInt32(test[29]) - 1;
            }



            button1.Enabled = true;
           
        }
    }
}
