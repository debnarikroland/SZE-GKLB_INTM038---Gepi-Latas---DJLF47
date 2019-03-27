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
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dataGridViewKepek.Rows.Clear();
                Image<Bgr, byte>[] forrasKepek = new Image<Bgr, byte>[dlg.FileNames.Length];
                for (int i = 0; i < forrasKepek.Length; i++)
                {
                    forrasKepek[i] = new Image<Bgr, byte>(dlg.FileNames[i]);
                    using (Image<Bgr, byte> miniPicture = forrasKepek[i].Resize(200, 200, Emgu.CV.CvEnum.Inter.Cubic, true))
                    {
                        DataGridViewRow sor = dataGridViewKepek.Rows[dataGridViewKepek.Rows.Add()];
                        sor.Cells["FileName"].Value = dlg.FileNames[i];
                        sor.Cells["View"].Value = miniPicture.ToBitmap();
                        sor.Height = 200;
                    }
                }
                try
                {
                    //0 - Panormáma; 1 - Szekkenlés
                    //true - Try GPU; false - No
                    using (Stitcher varras = new Stitcher(0, true))
                    {
                        using (AKAZEFeaturesFinder kereso = new AKAZEFeaturesFinder(Emgu.CV.Features2D.AKAZE.DescriptorType.Mldb,0,3, 0.0001F,4,4,Emgu.CV.Features2D.KAZE.Diffusivity.PmG2))
                        {

                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Convert.ToDecimal(trackBar1.Value)/100);
        }
    }
}

