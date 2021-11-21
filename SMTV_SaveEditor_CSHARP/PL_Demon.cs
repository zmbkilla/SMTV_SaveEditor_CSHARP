﻿using System;
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
            decimal maga = numericUpDown11.Value;
            decimal magc = numericUpDown12.Value;
            decimal agia = numericUpDown11.Value;
            decimal agic = numericUpDown12.Value;
            decimal lua = numericUpDown11.Value;
            decimal luc = numericUpDown12.Value;
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

            br.Close();


            BinaryWriter bw = new BinaryWriter(File.OpenWrite(SaveC.Save_Dir));

            //demon id
            int slot0ID = 0xAE6;
            int slotmod = slot0ID + (comboBox1.SelectedIndex * 392);
            int slotmoda = 0, slotmodc = 0;

            bw.BaseStream.Position = slotmod;
            bw.Write(bDID);
            //str
            int slot0STR = 0xA98;
            int slot0STRa = 0xAB8;
            int slot0STRc = 0xAC8;
            slotmod = slot0STR + (comboBox1.SelectedIndex * 392);
            slotmoda = slot0STRa + (comboBox1.SelectedIndex * 392);
            slotmodc = slot0STRc + (comboBox1.SelectedIndex * 392);

            bw.BaseStream.Position = slotmod;
            bw.Write(bstr);

            bw.BaseStream.Position = slotmoda;
            bw.Write(bstra);

            bw.BaseStream.Position = slotmodc;
            bw.Write(bstrc);
            //vit
            int slot0VIT = 0xA9A;
            int slot0VITa = 0xABA;
            int slot0VITc = 0xACA;
            slotmod = slot0VIT + (comboBox1.SelectedIndex * 392);
            slotmoda = slot0VITa + (comboBox1.SelectedIndex * 392);
            slotmodc = slot0VITc + (comboBox1.SelectedIndex * 392);



            bw.BaseStream.Position = slotmod;
            bw.Write(bvit);

            bw.BaseStream.Position = slotmoda;
            bw.Write(bvita);

            bw.BaseStream.Position = slotmodc;
            bw.Write(bvitc);
            //mag
            int slot0MAG = 0xA9C;
            int slot0MAGa = 0xABC;
            int slot0MAGc = 0xACC;
            slotmod = slot0MAG + (comboBox1.SelectedIndex * 392);
            slotmoda = slot0MAGa + (comboBox1.SelectedIndex * 392);
            slotmodc = slot0MAGc + (comboBox1.SelectedIndex * 392);

            bw.BaseStream.Position = slotmod;
            bw.Write(bmag);

            bw.BaseStream.Position = slotmoda;
            bw.Write(bmaga);

            bw.BaseStream.Position = slotmodc;
            bw.Write(bmagc);
            //agi
            int slot0AGI = 0xA9E;
            int slot0AGIa = 0xABE;
            int slot0AGIc = 0xACE;
            slotmod = slot0AGI + (comboBox1.SelectedIndex * 392);
            slotmoda = slot0AGIa + (comboBox1.SelectedIndex * 392);
            slotmodc = slot0AGIc + (comboBox1.SelectedIndex * 392);

            bw.BaseStream.Position = slotmod;
            bw.Write(bagi);

            bw.BaseStream.Position = slotmoda;
            bw.Write(bagia);

            bw.BaseStream.Position = slotmodc;
            bw.Write(bagic);
            //lu
            int slot0LU = 0xAA0;
            int slot0LUa = 0xAC0;
            int slot0LUc = 0xAD0;
            slotmod = slot0LU + (comboBox1.SelectedIndex * 392);
            slotmoda = slot0LUa + (comboBox1.SelectedIndex * 392);
            slotmodc = slot0LUc + (comboBox1.SelectedIndex * 392);

            bw.BaseStream.Position = slotmod;
            bw.Write(blu);

            bw.BaseStream.Position = slotmod;
            bw.Write(blua);

            bw.BaseStream.Position = slotmod;
            bw.Write(bluc);

            //hp
            int slot0HP = 0xA94;
            slotmod = slot0HP + (comboBox1.SelectedIndex * 392);

            bw.BaseStream.Position = slotmod;
            bw.Write(bhp);

            //mp
            int slot0MP = 0xA96;
            slotmod = slot0MP + (comboBox1.SelectedIndex * 392);

            byte test1 = bmp[0];
            byte test2 = bmp[1];

            bw.BaseStream.Position = slotmod;
            bw.Write(bmp, 0,2);


            br.Close();
            fs.Close();
            bw.Close();

            MessageBox.Show("Changes applied","Success");

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
            numericUpDown8.Value = test[7];
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
           
        }
    }
}
