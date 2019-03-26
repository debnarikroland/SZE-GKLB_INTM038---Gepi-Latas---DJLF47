using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Stitching;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace DJLF47___GKLB_INTM038___Stitching
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Filter = "jpg files (*.jpg)|*.jpg";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                dataGridViewKepek.Rows.Clear();
                Image<Bgr, byte>[] forrasKepek = new Image<Bgr, byte>[dlg.FileNames.Length];
            }
        }
    }
}
