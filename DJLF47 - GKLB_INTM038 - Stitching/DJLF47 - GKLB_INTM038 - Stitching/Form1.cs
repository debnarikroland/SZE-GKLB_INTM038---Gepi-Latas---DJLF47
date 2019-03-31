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
using Emgu.CV.Features2D;
using Emgu.CV.Stitching;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace DJLF47___GKLB_INTM038___Stitching
{
    public partial class Form1 : Form
    {
        public AKAZE.DescriptorType descriptorTipus;
        public KAZE.Diffusivity difuzivitasi;
        public Image<Bgr, byte> miniPicture;
        int channelNumber = 3;
        float treshold = 0.0001F;
        

        

        public Form1()
        {
            InitializeComponent();
            descriptorTipus = AKAZE.DescriptorType.Mldb;
            
            label1.Text = "0.0001";
        }

        private void open_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(treshold));
            if (KazeRadio.Checked)
            {
                descriptorTipus = AKAZE.DescriptorType.Kaze;
            }
            else if (KazeUpRadio.Checked)
            {
                descriptorTipus = AKAZE.DescriptorType.KazeUpright;
            }
            else if (MldbRadio.Checked)
            {
                descriptorTipus = AKAZE.DescriptorType.Mldb;
            }
            else if (MldbUpRadio.Checked)
            {
                descriptorTipus = AKAZE.DescriptorType.MldbUpright;
            }
            else
            {
                MldbRadio.Checked = true ;
            }


            if (Channel1Radio.Checked)
            {
                channelNumber = 1;
            }
            else if (Channel2Radio.Checked)
            {
                channelNumber = 2;
            }
            else if (Channerl3Radio.Checked)
            {
                channelNumber = 3;
            }
            else
            {
                Channerl3Radio.Checked = true;
            }

            if (CharbonnierRadio.Checked)
            {
                difuzivitasi = KAZE.Diffusivity.Charbonnier;
            }
            else if (PmG1Radio.Checked)
            {
                difuzivitasi = KAZE.Diffusivity.PmG1;
            }
            else if (PmG2Radio.Checked)
            {
                difuzivitasi = KAZE.Diffusivity.PmG2;
            }
            else if(WeickerRadio.Checked)
            {
                difuzivitasi = KAZE.Diffusivity.Weickert;
            }
            else
            {
                PmG1Radio.Checked = true;
            }


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
                miniPicture = null;
                try
                {
                    //0 - Panormáma; 1 - Szekkenlés
                    //true - Try GPU; false - No
                    using (Stitcher varras = new Stitcher(0, true))
                    {
                        using (AKAZEFeaturesFinder kereso = new AKAZEFeaturesFinder(descriptorTipus, 0, channelNumber, treshold, 4, 4, difuzivitasi))
                        {
                            varras.SetFeaturesFinder(kereso);
                            using (VectorOfMat vm = new VectorOfMat())
                            {
                                Mat result = new Mat();
                                vm.Push(forrasKepek);
                                Stitcher.Status stitchStatus = varras.Stitch(vm, result);
                                if (stitchStatus == Stitcher.Status.Ok)
                                {
                                    resultImage.Image = result;
                                    forrasKepek = null;
                                }
                                else
                                {
                                    MessageBox.Show(this, String.Format("Stiching Error: {0}", stitchStatus));
                                    resultImage.Image = null;
                                }
                            }
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
            label1.Text = Convert.ToString(Convert.ToDouble(TresholdTrack.Value)/10000);
            treshold =  (float)(Convert.ToDouble(TresholdTrack.Value) / 10000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

