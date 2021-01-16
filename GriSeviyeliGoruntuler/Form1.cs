using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math.Geometry;


namespace GriSeviyeliGoruntuler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] dosyalar;
        BackgroundWorker bg = new BackgroundWorker();

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            //bg.DoWork += Bg_DoWork;
            //bg.RunWorkerAsync();

        }

        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < dosyalar.Length - 1; i++)
            {
                pictureBox1.ImageLocation = dosyalar[i].ToString();
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void btnGriYap_Click(object sender, EventArgs e)
        {


            Bitmap image = new Bitmap(pictureBox1.Image);
            GrayscaleBT709 griResim = new GrayscaleBT709();
            pictureBox4.Image = griResim.Apply((Bitmap)pictureBox1.Image);
        }

        private void btnBinaryYap_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Threshold threshold = new Threshold();
            pictureBox4.Image = threshold.Apply(Grayscale.CommonAlgorithms.BT709.Apply(image));
        }

        private void btnOtsuAlgoritmasiUygula_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            OtsuThreshold otsuFiltre = new OtsuThreshold();
            //Bitmap filtreliResim = otsuFiltre.Apply(image.PixelFormat != PixelFormat.Format8bppIndexed ? Grayscale.CommonAlgorithms.BT709.Apply(image) : image);
            Bitmap filtreliResim = otsuFiltre.Apply(Grayscale.CommonAlgorithms.BT709.Apply(image));
            pictureBox4.Image = filtreliResim;
            this.Text = "Threshold Değeri : " + otsuFiltre.ThresholdValue.ToString();
        }

        private void btnDondur_Click(object sender, EventArgs e)
        {

            DocumentSkewChecker skewChecker = new DocumentSkewChecker();
            double angle = skewChecker.GetSkewAngle((Bitmap) pictureBox4.Image);
            RotateBilinear rotationFilter = new RotateBilinear(-angle);
            rotationFilter.FillColor = Color.White;
            // rotate image applying the filter
            Bitmap rotatedImage = rotationFilter.Apply((Bitmap)pictureBox4.Image);
            pictureBox1.Image = rotatedImage;

        }

        private void btnResimKlasoruSec_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {

                listBox1.Items.Clear();
                dosyalar = Directory.GetFiles(fbd.SelectedPath);
                foreach (string dosya in dosyalar)
                {
                    if (dosya.EndsWith(".jpg") || dosya.EndsWith(".jpeg"))
                        listBox1.Items.Add(dosya);
                }
            }
        }

        List<IntPoint> leftPoints, rightPoints, edgePoints;

        /*
        private void btnBlop_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            // lock image
            BitmapData bitmapData = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite, bitmap.PixelFormat);

            // step 1 - turn background to black
            ColorFiltering colorFilter = new ColorFiltering();

            colorFilter.Red = new IntRange(0, 64);
            colorFilter.Green = new IntRange(0, 64);
            colorFilter.Blue = new IntRange(0, 64);
            colorFilter.FillOutsideRange = false;
            colorFilter.ApplyInPlace(bitmapData);




            // step 2 - locating objects
            BlobCounter blobCounter = new BlobCounter();

            blobCounter.FilterBlobs = true;
            blobCounter.MinHeight = 5;
            blobCounter.MinWidth = 5;

            blobCounter.ProcessImage(bitmapData);
            Blob[] blobs = blobCounter.GetObjectsInformation();
            bitmap.UnlockBits(bitmapData);



            // step 3 - check objects' type and highlight
            SimpleShapeChecker shapeChecker = new SimpleShapeChecker();
            

            Graphics g = Graphics.FromImage(bitmap);
            Pen redPen = new Pen(Color.Red, 2);
            Pen yellowPen = new Pen(Color.Yellow, 2);
            Pen greenPen = new Pen(Color.Green, 2);
            Pen bluePen = new Pen(Color.Blue, 2);

            for (int i = 0, n = blobs.Length; i < n; i++)
            {
                List<IntPoint> edgePoints =
                    blobCounter.GetBlobsEdgePoints(blobs[i]);

                AForge.Point center;
                float radius;


                if (shapeChecker.IsCircle(edgePoints,out center, out radius))
                {
                    g.DrawEllipse(yellowPen,
                        (float)(center.X - radius), (float)(center.Y - radius),
                        (float)(radius * 2), (float)(radius * 2));
                }
                else
                {
                    List<IntPoint> corners;
                    if (shapeChecker.IsQuadrilateral(edgePoints, out corners))
                    {
                        if (shapeChecker.CheckPolygonSubType(corners) ==
                            PolygonSubType.Rectangle)
                        {
                            g.DrawPolygon(greenPen, ToPointsArray(corners));
                        }
                        else
                        {
                            g.DrawPolygon(bluePen, ToPointsArray(corners));
                        }
                    }
                    else
                    {
                        corners = PointsCloud.FindQuadrilateralCorners(edgePoints);
                        g.DrawPolygon(redPen, ToPointsArray(corners));
                    }
                }
            }

            redPen.Dispose();
            greenPen.Dispose();
            bluePen.Dispose();
            yellowPen.Dispose();
            g.Dispose();

        } 

        */
    
    }
}
