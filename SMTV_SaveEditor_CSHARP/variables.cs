using System;
using System.Collections.Generic;
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
            string Dvit = null;
            string Dmag = null;
            string Dagi = null;
            string Dlu = null;

            int slot0ID = 0xAE6;
            int slot0STR = 0xA98;
            int slot0VIT = 0xA9A;
            int slot0MAG = 0xA9C;
            int slot0AGI = 0xA9E;
            int slot0LU = 0xAA0;


            int slotmod = slot0ID + (392 * index);
            int slotend = slotmod + 1;



            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Did += br.ReadByte().ToString("X2");
            }

            slotmod = slot0STR + (392 * index);
            slotend = slotmod + 1;


            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dstr += br.ReadByte().ToString("X2");
            }

            slotmod = slot0VIT + (392 * index);
            slotend = slotmod + 1;

            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dvit += br.ReadByte().ToString("X2");
            }

            slotmod = slot0MAG + (392 * index);
            slotend = slotmod + 1;

            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dmag += br.ReadByte().ToString("X2");
            }

            slotmod = slot0AGI + (392 * index);
            slotend = slotmod + 1;

            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dagi += br.ReadByte().ToString("X2");
            }

            slotmod = slot0LU + (392 * index);
            slotend = slotmod + 1;

            for (int i = slotend; i >= slotmod; i--)
            {
                br.BaseStream.Position = i;

                Dlu += br.ReadByte().ToString("X2");
            }

            int didval = Int32.Parse(Did, System.Globalization.NumberStyles.HexNumber);
            int strval = Int32.Parse(Dstr, System.Globalization.NumberStyles.HexNumber);
            int vitval = Int32.Parse(Dvit, System.Globalization.NumberStyles.HexNumber);
            int magval = Int32.Parse(Dmag, System.Globalization.NumberStyles.HexNumber);
            int agival = Int32.Parse(Dagi, System.Globalization.NumberStyles.HexNumber);
            int luval = Int32.Parse(Dlu, System.Globalization.NumberStyles.HexNumber);
            fs.Close();
            fs.Close();
            br.Close();
            int[] intarr = new int[] {didval,strval,vitval,magval,agival,luval };
            
            return intarr;
        }

    }
}
