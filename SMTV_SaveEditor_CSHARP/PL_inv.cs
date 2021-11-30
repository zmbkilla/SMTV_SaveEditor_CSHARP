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
    public partial class PL_inv : UserControl
    {
        public PL_inv()
        {
            InitializeComponent();
        }

        private void PL_inv_Load(object sender, EventArgs e)
        {
            var invlist = variables.itemlist();
            int invlistc = invlist.Count() - 3;
            var itemdb = variables.ReadItemDB();
            
            for (int i = 0; i <= invlistc; i++)
            {
                var itemform = new PL_Items();
                itemform.numericUpDown1.Value = invlist[i];

                if (i <= 81)
                {
                    itemform.label1.Text = itemdb.Rows[i]["itemcode"].ToString();
                    itemform.label2.Text = itemdb.Rows[i]["decimal"].ToString();
                }
                
                flowLayoutPanel1.Controls.Add(itemform);
            }

            MessageBox.Show("item count: " + flowLayoutPanel1.Controls.Count + "control count: " + flowLayoutPanel1.Controls.Count, "test");
        }
    }
}
