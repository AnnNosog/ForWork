using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class FormChange : Form
    {

        private NoteWork buf;

        public FormChange()
        {
            InitializeComponent();            
        }

        public FormChange(NoteWork f)
        {
            InitializeComponent();
        }

        private void tb_RF_ch_TextChanged(object sender, EventArgs e)
        {
            buf = (NoteWork)this.Owner;
            buf.LabelRF.Text = tb_RF_ch.Text;
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void tb_RB_ch_TextChanged(object sender, EventArgs e)
        {
            buf = (NoteWork)this.Owner;
            buf.LabelRB.Text = tb_RB_ch.Text;
        }

    }
}