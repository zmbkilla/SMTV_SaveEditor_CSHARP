using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTV_SaveEditor_CSHARP
{
    public partial class PL_Soul : UserControl
    {
        public PL_Soul()
        {
            InitializeComponent();
        }

        private void PL_Soul_Load(object sender, EventArgs e)
        {

            var essenceu = variables.essenceu();
            var essencea = variables.essencea();
            int count = essenceu.Rows.Count - 1;
            
            
            for (int i = 0; i <= count; i++)
            {
                var datarows = new PL_Essence();
                datarows.label1.Text = essenceu.Rows[i]["name"].ToString();

                string test = essenceu.Rows[i]["PositionID"].ToString();
                int change = Convert.ToInt32(test,16);
                int converter = variables.demonoff(change);

                if (converter == 0)
                {
                    datarows.checkBox1.Checked = false;
                } else if( converter == 1)
                {
                    datarows.checkBox1.Checked = true;
                }

                datarows.label2.Text = test;

                flowLayoutPanel1.Controls.Add(datarows);
            }
        }
    }
}
