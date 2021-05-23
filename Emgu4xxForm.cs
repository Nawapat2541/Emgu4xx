using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Features2D;
using Emgu.CV.Util;

namespace Emgu4xx
{
    public partial class Emgu4xxForm : Form
    {
        Dictionary<string, Image<Bgr, byte>> imgList;
        Rectangle rect;
        Point StartROI, EndROI;
        bool Selecting, MouseDown;
        public Emgu4xxForm()
        {
            InitializeComponent();
            Selecting = false;
            rect = Rectangle.Empty;
            imgList = new Dictionary<string, Image<Bgr, byte>>();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Emgu4xxForm_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                imgList.Clear();
                OpenFileDialog ofd = new OpenFileDialog();
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    var imgInput = new Image<Bgr, byte>(ofd.FileName);
                    AddImage(imgInput, "Input");
                    pictureBox1.Image = imgInput.AsBitmap();
                    pictureBox2.Image = pictureBox1.Image;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddImage(Image<Bgr, byte> img, string keyname)
        {
            if (!treeView1.Nodes.ContainsKey(keyname))
            {
                TreeNode node = new TreeNode(keyname);
                node.Name = keyname;
                treeView1.Nodes.Add(node);
                treeView1.SelectedNode = node;
            }

            if (!imgList.ContainsKey(keyname))
            {
                imgList.Add(keyname, img);
            }
            else
            {
                imgList[keyname] = img;
            }
        }

        private void color_BasedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null) return;

                var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();
                img._SmoothGaussian(5);

                Bgr lower = new Bgr(0, 150, 0);
                Bgr higher = new Bgr(100, 255, 30);

                var mask = img.InRange(lower, higher).Not();
                img.SetValue(new Bgr(0, 0, 0), mask);
                pictureBox2.Image = img.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, EventArgs e)
        {

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null) return;

                var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();
                img._SmoothGaussian(5);

                Bgr lower = new Bgr(0, 0, 150);
                Bgr higher = new Bgr(100, 50, 255);

                var mask = img.InRange(lower, higher).Not();
                img.SetValue(new Bgr(0, 0, 0), mask);
                pictureBox2.Image = img.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectROIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selecting = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Selecting)
            {
                MouseDown = true;
                StartROI = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Selecting)
            {
                int width = Math.Max(StartROI.X, e.X) - Math.Min(StartROI.X, e.X);
                int height = Math.Max(StartROI.Y, e.Y) - Math.Min(StartROI.Y, e.Y);
                rect = new Rectangle(Math.Min(StartROI.X, e.X),
                    Math.Min(StartROI.Y, e.Y),
                    width,
                    height);
                Refresh();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (MouseDown)
            {
                using (Pen pen = new Pen(Color.Red, 3))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (Selecting)
            {
                Selecting = false;
                MouseDown = false;
            }
        }

        private void getRegionOfROIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null)
                    return;

                if (rect == Rectangle.Empty)
                    return;

                var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();

                img.ROI = rect;
                var imgROI = img.Copy();
                img.ROI = Rectangle.Empty;

                pictureBox1.Image = imgROI.ToBitmap();
                AddImage(imgROI, "ROI Image");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                pictureBox1.Image = imgList[e.Node.Text].AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void harrisDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ApplyHarrisCorner();
                HarrisParametersForm parameters = new HarrisParametersForm(0, 255, 200);
                parameters.OnApply += ApplyHarrisCorner;
                parameters.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ApplyHarrisCorner(int threshold = 200)
        {
            try
            {
                if (imgList["Input"] == null)
                {
                    return;
                }

                var img = imgList["Input"].Clone();
                var gray = img.Convert<Gray, byte>();

                var corners = new Mat();
                CvInvoke.CornerHarris(gray, corners, 2);
                CvInvoke.Normalize(corners, corners, 255, 0, Emgu.CV.CvEnum.NormType.MinMax);

                Matrix<float> matrix = new Matrix<float>(corners.Rows, corners.Cols);
                corners.CopyTo(matrix);

                for (int i = 0; i < matrix.Rows; i++)
                {
                    for (int j = 0; j < matrix.Cols; j++)
                    {
                        if (matrix[i, j] > threshold)
                        {
                            CvInvoke.Circle(img, new Point(j, i), 5, new MCvScalar(0, 0, 255));
                        }
                    }
                }

                pictureBox1.Image = img.AsBitmap();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void shiTomasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgList["Input"] == null)
                {
                    return;
                }

                var img = imgList["Input"].Clone();
                var gray = img.Convert<Gray, byte>();

                GFTTDetector detector = new GFTTDetector(2000, 0.06);
                var cornors = detector.Detect(gray);

                Mat outing = new Mat();
                Features2DToolbox.DrawKeypoints(img, new VectorOfKeyPoint(cornors), outing, new Bgr(0, 0, 255));

                pictureBox1.Image = outing.ToBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null) return;

                var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();
                img._SmoothGaussian(5);

                Bgr lower = new Bgr(150, 0, 0);
                Bgr higher = new Bgr(255, 70, 100);

                var mask = img.InRange(lower, higher).Not();
                img.SetValue(new Bgr(0, 0, 0), mask);
                pictureBox2.Image = img.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
