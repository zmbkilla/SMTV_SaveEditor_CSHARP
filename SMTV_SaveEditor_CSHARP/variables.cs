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

        public static Stream savestreamR()
        {
            Stream stream = File.OpenRead(SaveC.Save_Dir);
            return stream;
        }

        public static Stream savestreamW()
        {
            Stream stream = File.OpenWrite(SaveC.Save_Dir);
            return stream;
        }

        public static int[] demonquery(int index)
        {

            //FileStream fs = new FileStream(SaveC.Save_Dir, FileMode.Open);
            //fs.Close();
            using (BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir)))
            {
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
                string Dhpa = null;
                string Dhpc = null;
                string Dmp = null;
                string Dmpa = null;
                string Dmpc = null;
                string s1 = null;
                string s2 = null;
                string s3 = null;
                string s4 = null;
                string s5 = null;
                string s6 = null;
                string s7 = null;
                string s8 = null;

                int slot0ID = 0xAE6;
                int slot0STR = 0xA98; // or - 83
                int slot0STRa = slot0STR + 16;
                int slot0STRc = slot0STRa + 16;
                int slot0VIT = 0xA9A;
                int slot0VITa = slot0VIT + 16;
                int slot0VITc = slot0VITa + 16;
                int slot0MAG = 0xA9C;
                int slot0MAGa = slot0MAG + 16;
                int slot0MAGc = slot0MAGa + 16;
                int slot0AGI = 0xA9E;
                int slot0AGIa = slot0AGI + 16;
                int slot0AGIc = slot0AGIa + 16;
                int slot0LU = 0xAA0;
                int slot0LUa = slot0LU + 16;
                int slot0LUc = slot0LUa + 16;
                int slot0HP = 0xA94;
                int slot0HPa = slot0HP + 16;
                int slot0HPc = slot0HPa + 16;
                int slot0MP = 0xA96;
                int slot0MPa = slot0MP + 16;
                int slot0MPc = slot0MPa + 16;

                int slot0s1 = slot0ID + 10;
                int slot0s2 = slot0s1 + 8;
                int slot0s3 = slot0s2 + 8;
                int slot0s4 = slot0s3 + 8;
                int slot0s5 = slot0s4 + 8;
                int slot0s6 = slot0s5 + 8;
                int slot0s7 = slot0s6 + 8;
                int slot0s8 = slot0s7 + 8;


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

                slotmod = slot0HPa + (392 * index);
                slotend = slotmod + 1;

                for (int i = slotend; i >= slotmod; i--)
                {
                    br.BaseStream.Position = i;

                    Dhpa += br.ReadByte().ToString("X2");
                }

                slotmod = slot0HPc + (392 * index);
                slotend = slotmod + 1;

                for (int i = slotend; i >= slotmod; i--)
                {
                    br.BaseStream.Position = i;

                    Dhpc += br.ReadByte().ToString("X2");
                }


                //mp

                slotmod = slot0MP + (392 * index);
                slotend = slotmod + 1;

                for (int i = slotend; i >= slotmod; i--)
                {
                    br.BaseStream.Position = i;

                    Dmp += br.ReadByte().ToString("X2");
                }

                slotmod = slot0MPa + (392 * index);
                slotend = slotmod + 1;

                for (int i = slotend; i >= slotmod; i--)
                {
                    br.BaseStream.Position = i;

                    Dmpa += br.ReadByte().ToString("X2");
                }

                slotmod = slot0MPc + (392 * index);
                slotend = slotmod + 1;

                for (int i = slotend; i >= slotmod; i--)
                {
                    br.BaseStream.Position = i;

                    Dmpc += br.ReadByte().ToString("X2");
                }
                //skills

                slotmod = slot0s1 + (392 * index);
                slotend = slotmod + 1;

                for (int i = slotend; i >= slotmod; i--)
                {
                    br.BaseStream.Position = i;

                    s1 += br.ReadByte().ToString("X2");
                }

                slotmod = slot0s2 + (392 * index);
                slotend = slotmod + 1;

                for (int i = slotend; i >= slotmod; i--)
                {
                    br.BaseStream.Position = i;

                    s2 += br.ReadByte().ToString("X2");
                }

                slotmod = slot0s3 + (392 * index);
                slotend = slotmod + 1;

                for (int i = slotend; i >= slotmod; i--)
                {
                    br.BaseStream.Position = i;

                    s3 += br.ReadByte().ToString("X2");
                }

                slotmod = slot0s4 + (392 * index);
                slotend = slotmod + 1;

                for (int i = slotend; i >= slotmod; i--)
                {
                    br.BaseStream.Position = i;

                    s4 += br.ReadByte().ToString("X2");
                }

                slotmod = slot0s5 + (392 * index);
                slotend = slotmod + 1;

                for (int i = slotend; i >= slotmod; i--)
                {
                    br.BaseStream.Position = i;

                    s5 += br.ReadByte().ToString("X2");
                }

                slotmod = slot0s6 + (392 * index);
                slotend = slotmod + 1;

                for (int i = slotend; i >= slotmod; i--)
                {
                    br.BaseStream.Position = i;

                    s6 += br.ReadByte().ToString("X2");
                }

                slotmod = slot0s7 + (392 * index);
                slotend = slotmod + 1;

                for (int i = slotend; i >= slotmod; i--)
                {
                    br.BaseStream.Position = i;

                    s7 += br.ReadByte().ToString("X2");
                }

                slotmod = slot0s8 + (392 * index);
                slotend = slotmod + 1;

                for (int i = slotend; i >= slotmod; i--)
                {
                    br.BaseStream.Position = i;

                    s8 += br.ReadByte().ToString("X2");
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
                int agiaval = Int32.Parse(Dagia, System.Globalization.NumberStyles.HexNumber);
                int agicval = Int32.Parse(Dagic, System.Globalization.NumberStyles.HexNumber);
                int luaval = Int32.Parse(Dlua, System.Globalization.NumberStyles.HexNumber);
                int lucval = Int32.Parse(Dluc, System.Globalization.NumberStyles.HexNumber);
                int hpaval = Int32.Parse(Dhpa, System.Globalization.NumberStyles.HexNumber);
                int hpcval = Int32.Parse(Dhpc, System.Globalization.NumberStyles.HexNumber);
                int mpaval = Int32.Parse(Dmpa, System.Globalization.NumberStyles.HexNumber);
                int mpcval = Int32.Parse(Dmpc, System.Globalization.NumberStyles.HexNumber);
                int s1val = Int32.Parse(s1, System.Globalization.NumberStyles.HexNumber);
                int s2val = Int32.Parse(s2, System.Globalization.NumberStyles.HexNumber);
                int s3val = Int32.Parse(s3, System.Globalization.NumberStyles.HexNumber);
                int s4val = Int32.Parse(s4, System.Globalization.NumberStyles.HexNumber);
                int s5val = Int32.Parse(s5, System.Globalization.NumberStyles.HexNumber);
                int s6val = Int32.Parse(s6, System.Globalization.NumberStyles.HexNumber);
                int s7val = Int32.Parse(s7, System.Globalization.NumberStyles.HexNumber);
                int s8val = Int32.Parse(s8, System.Globalization.NumberStyles.HexNumber);
                //fs.Close();
                //fs.Close();
                br.Close();
                int[] intarr = new int[] { didval, strval, vitval, magval, agival, luval, hpval, mpval, straval, strcval, vitaval, vitcval, magaval, magcval, agiaval, agicval, luaval, lucval, hpaval, hpcval, mpaval, mpcval, s1val, s2val, s3val, s4val, s5val, s6val, s7val, s8val };

                return intarr;
            }
            
        }

        public static DataTable ReadDemonDB()
        {
            var fileName = string.Format("{0}\\DemonDB.xls", Directory.GetCurrentDirectory());
            var filetest = Encoding.ASCII.GetString(
    Encoding.Convert(
        Encoding.UTF8,
        Encoding.GetEncoding(
            Encoding.ASCII.EncodingName,
            new EncoderReplacementFallback(string.Empty),
            new DecoderExceptionFallback()
            ),
        Encoding.UTF8.GetBytes(fileName)
    ));
            var connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0; data source={0};User Id =admin;Password=;Extended Properties=Excel 8.0;", fileName);

            var adapter = new OleDbDataAdapter("SELECT * FROM [DemonList$]", connectionString);
            var ds = new DataSet();
            var data = new DataTable();
            adapter.Fill(data);

            

            
            adapter.Dispose();
            ds.Dispose();

            return data;
        }

        public static int[] itemlist()
        {
            int[] itemid;
            // FileStream fs = new FileStream(SaveC.Save_Dir, FileMode.Open);
            // fs.Close();
            using (BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir)))
            {
                List<int> ItemCode = new List<int>();

                for (int i = 0x33A1; i <= 0x340E; i++)
                {
                    string hex = null;

                    if (i == 0x33BD)
                    {
                        i = 0x33C4;
                        continue;
                    }
                    else if (i == 0x33D0)
                    {

                        i = 0x33D1;
                        continue;

                    }
                    else if (i == 0x33D6)
                    {
                        continue;
                    }
                    else if (i == 0x33D8)
                    {
                        i = 0x33DB;
                        continue;
                    }
                    else if (i == 0x33E5)
                    {
                        continue;
                    }
                    else if (i == 0x33E8)
                    {
                        i = 0x33F1;
                        continue;
                    }

                    br.BaseStream.Position = i;
                    hex = br.ReadByte().ToString("X2");

                    
                    
                    

                    ItemCode.Add(Int32.Parse(hex, System.Globalization.NumberStyles.HexNumber));

                }

                itemid = ItemCode.ToArray();

                return itemid;
            } 
            
        }

        public static DataTable ReadItemDB()
        {
            var fileName = string.Format("{0}\\DemonDB.xls", Directory.GetCurrentDirectory());
            
            var connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0; data source={0};User Id =admin;Password=;Extended Properties=Excel 8.0;", fileName);

            var adapter = new OleDbDataAdapter("SELECT * FROM [ItemList$]", connectionString);
            var ds = new DataSet();
            var data = new DataTable();
            adapter.Fill(data);




            adapter.Dispose();
            ds.Dispose();

            return data;
        }

        public static DataTable essenceu()
        {
            var fileName = string.Format("{0}\\DemonDB.xls", Directory.GetCurrentDirectory());

            var connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0; data source={0};User Id =admin;Password=;Extended Properties=Excel 8.0;", fileName);

            var adapter = new OleDbDataAdapter("SELECT * FROM [EssenceList$]", connectionString);
            var ds = new DataSet();
            var data = new DataTable();
            adapter.Fill(data);




            adapter.Dispose();
            ds.Dispose();

            return data;

        }

        public static int[] essencea()
        {
            using (BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir)))
            {
                List<int> loada = new List<int>();

                for (int i = 0x382F; i <= 0x3923; i++)
                {
                    string hex;
                    br.BaseStream.Position = i;
                    hex = br.ReadByte().ToString("X2");

                    if (i == 0x3896)
                    {
                        i = 0x3899;
                        continue;
                    }

                    loada.Add(Int32.Parse(hex, System.Globalization.NumberStyles.HexNumber));
                }

                int[] rint = loada.ToArray();
                br.Close();
                return rint;
            }

            
                
            
        }

        public static int demonoff(int i)
        {
            BinaryReader br = new BinaryReader(File.OpenRead(SaveC.Save_Dir));
            string pos = null;

            br.BaseStream.Position = i;
            pos = br.ReadByte().ToString();

            int convert = Int32.Parse(pos, System.Globalization.NumberStyles.HexNumber);
            br.Close();
            return convert;

        }



    }
}
