using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTV_SaveEditor_CSHARP
{
    class variables
    {
        public static int mReverseval;
        public static int gReverseval;



        public static int[] demonid = new int[] { 0xAe6, 0xC6e, 0xDF6, 0xF7E, 0x1101, 0x128E, 0x1416, 0x159E, 0x1726, 0x18AE, 0x1A36 };

        public static int[] demonquery(int index)
        {
            
            FileStream fs = new FileStream(SaveC.Save_Dir, FileMode.Open);
            fs.Close();
            BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir));
            string Did = null;
            string Dstr = null;
            string Dstra = null;
            string Dstrc = null;
            string Dvit = null;
            string Dvita = null;
            string Dvitc = null;
            string Dmag = null;
            string Dmaga = null;
            string Dmagc = null;
            string Dagi = null;
            string Dagia = null;
            string Dagic = null;
            string Dlu = null;
            string Dlua = null;
            string Dluc = null;
            string Dhp = null;
            string Dmp = null;

            int slot0ID = 0xAE6;
            int slot0STR = 0xA98;
            int slot0STRa = 0xAB8;
            int slot0STRc = 0xAC8;
            int slot0VIT = 0xA9A;
            int slot0VITa = 0xABA;
            int slot0VITc = 0xACA;
            int slot0MAG = 0xA9C;
            int slot0MAGa = 0xABC;
            int slot0MAGc = 0xACC;
            int slot0AGI = 0xA9E;
            int slot0AGIa = 0xABE;
            int slot0AGIc = 0xACE;
            int slot0LU = 0xAA0;
            int slot0LUa = 0xAC0;
            int slot0LUc = 0xAD0;
            int slot0HP = 0xA94;
            int slot0MP = 0xA96;


            int slotmod = slot0ID + (392 * index);
            int slotend = slotmod + 1;


            //id
            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Did += br.ReadByte().ToString("X2");
            }

            //str
            slotmod = slot0STR + (392 * index);
            slotend = slotmod + 1;


            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dstr += br.ReadByte().ToString("X2");
            }

            slotmod = slot0STRa + (392 * index);
            slotend = slotmod + 1;


            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dstra += br.ReadByte().ToString("X2");
            }

            slotmod = slot0STRc + (392 * index);
            slotend = slotmod + 1;


            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dstrc += br.ReadByte().ToString("X2");
            }
            //vit
            slotmod = slot0VIT + (392 * index);
            slotend = slotmod + 1;

            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dvit += br.ReadByte().ToString("X2");
            }

            slotmod = slot0VITa + (392 * index);
            slotend = slotmod + 1;


            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dvita += br.ReadByte().ToString("X2");
            }

            slotmod = slot0VITc + (392 * index);
            slotend = slotmod + 1;


            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dvitc += br.ReadByte().ToString("X2");
            }

            //mag

            slotmod = slot0MAG + (392 * index);
            slotend = slotmod + 1;

            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dmag += br.ReadByte().ToString("X2");
            }

            slotmod = slot0MAGa + (392 * index);
            slotend = slotmod + 1;

            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dmaga += br.ReadByte().ToString("X2");
            }

            slotmod = slot0MAGc + (392 * index);
            slotend = slotmod + 1;

            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dmagc += br.ReadByte().ToString("X2");
            }

            //agi

            slotmod = slot0AGI + (392 * index);
            slotend = slotmod + 1;

            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dagi += br.ReadByte().ToString("X2");
            }

            slotmod = slot0AGIa + (392 * index);
            slotend = slotmod + 1;

            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dagia += br.ReadByte().ToString("X2");
            }

            slotmod = slot0AGIc + (392 * index);
            slotend = slotmod + 1;

            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dagic += br.ReadByte().ToString("X2");
            }

            //lu

            slotmod = slot0LU + (392 * index);
            slotend = slotmod + 1;

            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dlu += br.ReadByte().ToString("X2");
            }

            slotmod = slot0LUa + (392 * index);
            slotend = slotmod + 1;

            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dlua += br.ReadByte().ToString("X2");
            }

            slotmod = slot0LUc + (392 * index);
            slotend = slotmod + 1;

            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dluc += br.ReadByte().ToString("X2");
            }

            //hp

            slotmod = slot0HP + (392 * index);
            slotend = slotmod + 1;

            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dhp += br.ReadByte().ToString("X2");
            }

            slotmod = slot0MP + (392 * index);
            slotend = slotmod + 1;

            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dmp += br.ReadByte().ToString("X2");
            }


            int didval = Int32.Parse(Did, System.Globalization.NumberStyles.HexNumber);
            int strval = Int32.Parse(Dstr, System.Globalization.NumberStyles.HexNumber);
            int vitval = Int32.Parse(Dvit, System.Globalization.NumberStyles.HexNumber);
            int magval = Int32.Parse(Dmag, System.Globalization.NumberStyles.HexNumber);
            int agival = Int32.Parse(Dagi, System.Globalization.NumberStyles.HexNumber);
            int luval = Int32.Parse(Dlu, System.Globalization.NumberStyles.HexNumber);
            int hpval = Int32.Parse(Dhp, System.Globalization.NumberStyles.HexNumber);
            int mpval = Int32.Parse(Dmp, System.Globalization.NumberStyles.HexNumber);
            int straval = Int32.Parse(Dstra, System.Globalization.NumberStyles.HexNumber);
            int strcval = Int32.Parse(Dstrc, System.Globalization.NumberStyles.HexNumber);
            int vitaval = Int32.Parse(Dvita, System.Globalization.NumberStyles.HexNumber);
            int vitcval = Int32.Parse(Dvitc, System.Globalization.NumberStyles.HexNumber);
            int magaval = Int32.Parse(Dmaga, System.Globalization.NumberStyles.HexNumber);
            int magcval = Int32.Parse(Dmagc, System.Globalization.NumberStyles.HexNumber);
            int agiaval = Int32.Parse(Dvita, System.Globalization.NumberStyles.HexNumber);
            int agicval = Int32.Parse(Dvitc, System.Globalization.NumberStyles.HexNumber);
            int luaval = Int32.Parse(Dvita, System.Globalization.NumberStyles.HexNumber);
            int lucval = Int32.Parse(Dvitc, System.Globalization.NumberStyles.HexNumber);
            fs.Close();
            fs.Close();
            br.Close();
            int[] intarr = new int[] {didval,strval,vitval,magval,agival,luval,hpval,mpval,straval,strcval,vitaval,vitcval,magaval,magcval,agiaval,agicval,luaval,lucval };
            
            return intarr;
        }

        public static DataTable ReadDemonDB()
        {
            var fileName = string.Format("{0}\\DemonDB.xls", Directory.GetCurrentDirectory());
            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fileName);

            var adapter = new OleDbDataAdapter("SELECT * FROM [DemonList$]", connectionString);
            var ds = new DataSet();
            var data = new DataTable();
            adapter.Fill(data);

            

            
            adapter.Dispose();
            ds.Dispose();

            return data;
        }

    }
}
