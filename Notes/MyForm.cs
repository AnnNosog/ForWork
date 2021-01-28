using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class NoteWork : Form
    {
        FormChange form2;      

        public Label LabelRF
        {
            set { lb_RF = value; }
            get { return lb_RF; }
        }

        public Label LabelRB
        {
            set { lb_RB = value; }
            get { return lb_RB; }
        }

        public NoteWork()
        {
            Program.f1 = this;
            InitializeComponent();
            StreamReader sr = new StreamReader("NoteWork.txt");

            //tb_note.Text = sr.ReadToEnd();
            lb_note.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2 = new FormChange();
            form2.Show(this);
        }      
      
        private void свернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}