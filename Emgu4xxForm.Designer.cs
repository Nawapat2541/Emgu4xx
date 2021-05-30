
namespace Emgu4xx
{
    partial class Emgu4xxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feature2DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featureDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harrisDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shiTomasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findContourSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.color_BasedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getRegionOfROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.segmentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watershedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.feature2DToolStripMenuItem,
            this.utilityToolStripMenuItem,
            this.processToolStripMenuItem,
            this.segmentationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1494, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // feature2DToolStripMenuItem
            // 
            this.feature2DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.featureDetectorToolStripMenuItem});
            this.feature2DToolStripMenuItem.Name = "feature2DToolStripMenuItem";
            this.feature2DToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.feature2DToolStripMenuItem.Text = "Feature 2D";
            // 
            // featureDetectorToolStripMenuItem
            // 
            this.featureDetectorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.harrisDetectorToolStripMenuItem,
            this.shiTomasiToolStripMenuItem});
            this.featureDetectorToolStripMenuItem.Name = "featureDetectorToolStripMenuItem";
            this.featureDetectorToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.featureDetectorToolStripMenuItem.Text = "Feature Detector";
            // 
            // harrisDetectorToolStripMenuItem
            // 
            this.harrisDetectorToolStripMenuItem.Name = "harrisDetectorToolStripMenuItem";
            this.harrisDetectorToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.harrisDetectorToolStripMenuItem.Text = "Harris Detector";
            this.harrisDetectorToolStripMenuItem.Click += new System.EventHandler(this.harrisDetectorToolStripMenuItem_Click);
            // 
            // shiTomasiToolStripMenuItem
            // 
            this.shiTomasiToolStripMenuItem.Name = "shiTomasiToolStripMenuItem";
            this.shiTomasiToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.shiTomasiToolStripMenuItem.Text = "Shi-Tomasi";
            this.shiTomasiToolStripMenuItem.Click += new System.EventHandler(this.shiTomasiToolStripMenuItem_Click);
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.utilityToolStripMenuItem.Text = "Utility";
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findContourSortToolStripMenuItem,
            this.objectDetectionToolStripMenuItem,
            this.processROIToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // findContourSortToolStripMenuItem
            // 
            this.findContourSortToolStripMenuItem.Name = "findContourSortToolStripMenuItem";
            this.findContourSortToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.findContourSortToolStripMenuItem.Text = "Find Contour & Sort";
            // 
            // objectDetectionToolStripMenuItem
            // 
            this.objectDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.color_BasedToolStripMenuItem});
            this.objectDetectionToolStripMenuItem.Name = "objectDetectionToolStripMenuItem";
            this.objectDetectionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.objectDetectionToolStripMenuItem.Text = "ObjectDetection";
            // 
            // color_BasedToolStripMenuItem
            // 
            this.color_BasedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.redToolStripMenuItem});
            this.color_BasedToolStripMenuItem.Name = "color_BasedToolStripMenuItem";
            this.color_BasedToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.color_BasedToolStripMenuItem.Text = "Color-Based";
            this.color_BasedToolStripMenuItem.Click += new System.EventHandler(this.color_BasedToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // processROIToolStripMenuItem
            // 
            this.processROIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectROIToolStripMenuItem,
            this.getRegionOfROIToolStripMenuItem});
            this.processROIToolStripMenuItem.Name = "processROIToolStripMenuItem";
            this.processROIToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.processROIToolStripMenuItem.Text = "Process ROI";
            // 
            // selectROIToolStripMenuItem
            // 
            this.selectROIToolStripMenuItem.Name = "selectROIToolStripMenuItem";
            this.selectROIToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.selectROIToolStripMenuItem.Text = "Select ROI";
            this.selectROIToolStripMenuItem.Click += new System.EventHandler(this.selectROIToolStripMenuItem_Click);
            // 
            // getRegionOfROIToolStripMenuItem
            // 
            this.getRegionOfROIToolStripMenuItem.Name = "getRegionOfROIToolStripMenuItem";
            this.getRegionOfROIToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.getRegionOfROIToolStripMenuItem.Text = "Get Region of ROI";
            this.getRegionOfROIToolStripMenuItem.Click += new System.EventHandler(this.getRegionOfROIToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 407);
            this.panel1.TabIndex = 4;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(251, 340);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(615, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(520, 347);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1448, 413);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(292, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 407);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // segmentationToolStripMenuItem
            // 
            this.segmentationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.watershedToolStripMenuItem});
            this.segmentationToolStripMenuItem.Name = "segmentationToolStripMenuItem";
            this.segmentationToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.segmentationToolStripMenuItem.Text = "Segmentation";
            // 
            // watershedToolStripMenuItem
            // 
            this.watershedToolStripMenuItem.Name = "watershedToolStripMenuItem";
            this.watershedToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.watershedToolStripMenuItem.Text = "Watershed";
            this.watershedToolStripMenuItem.Click += new System.EventHandler(this.watershedToolStripMenuItem_Click);
            // 
            // Emgu4xxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Emgu4xxForm";
            this.Text = "Emgu4xxForm";
            this.Load += new System.EventHandler(this.Emgu4xxForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feature2DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findContourSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem color_BasedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem processROIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectROIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getRegionOfROIToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem featureDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harrisDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shiTomasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segmentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watershedToolStripMenuItem;
    }
}

