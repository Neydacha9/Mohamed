namespace Win1
{
    partial class FormPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaint));
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            whitebtn = new Button();
            blackbtn = new Button();
            redbtn = new Button();
            greenbtn = new Button();
            bluebtn = new Button();
            yellowbtn = new Button();
            purplebtn = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            XLbl = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            YLbl = new ToolStripStatusLabel();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            Clearbtn = new ToolStripMenuItem();
            Savebtn = new ToolStripMenuItem();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            Xlblb = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            Ylblb = new ToolStripStatusLabel();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            Xlblbl = new ToolStripStatusLabel();
            toolStripStatusLabel6 = new ToolStripStatusLabel();
            Ylblbl = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 399);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(whitebtn);
            flowLayoutPanel1.Controls.Add(blackbtn);
            flowLayoutPanel1.Controls.Add(redbtn);
            flowLayoutPanel1.Controls.Add(greenbtn);
            flowLayoutPanel1.Controls.Add(bluebtn);
            flowLayoutPanel1.Controls.Add(yellowbtn);
            flowLayoutPanel1.Controls.Add(purplebtn);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 28);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // whitebtn
            // 
            whitebtn.BackColor = Color.White;
            whitebtn.Location = new Point(3, 3);
            whitebtn.Name = "whitebtn";
            whitebtn.Size = new Size(20, 20);
            whitebtn.TabIndex = 2;
            whitebtn.UseVisualStyleBackColor = false;
            whitebtn.Click += whitebtn_Click;
            // 
            // blackbtn
            // 
            blackbtn.BackColor = Color.Black;
            blackbtn.Location = new Point(29, 3);
            blackbtn.Name = "blackbtn";
            blackbtn.Size = new Size(20, 20);
            blackbtn.TabIndex = 3;
            blackbtn.UseVisualStyleBackColor = false;
            // 
            // redbtn
            // 
            redbtn.BackColor = Color.Red;
            redbtn.Location = new Point(55, 3);
            redbtn.Name = "redbtn";
            redbtn.Size = new Size(20, 20);
            redbtn.TabIndex = 4;
            redbtn.UseVisualStyleBackColor = false;
            // 
            // greenbtn
            // 
            greenbtn.BackColor = Color.Green;
            greenbtn.Location = new Point(81, 3);
            greenbtn.Name = "greenbtn";
            greenbtn.Size = new Size(20, 20);
            greenbtn.TabIndex = 5;
            greenbtn.UseVisualStyleBackColor = false;
            // 
            // bluebtn
            // 
            bluebtn.BackColor = Color.Blue;
            bluebtn.Location = new Point(107, 3);
            bluebtn.Name = "bluebtn";
            bluebtn.Size = new Size(20, 20);
            bluebtn.TabIndex = 6;
            bluebtn.UseVisualStyleBackColor = false;
            // 
            // yellowbtn
            // 
            yellowbtn.BackColor = Color.Yellow;
            yellowbtn.Location = new Point(133, 3);
            yellowbtn.Name = "yellowbtn";
            yellowbtn.Size = new Size(20, 20);
            yellowbtn.TabIndex = 7;
            yellowbtn.UseVisualStyleBackColor = false;
            // 
            // purplebtn
            // 
            purplebtn.BackColor = Color.Purple;
            purplebtn.Location = new Point(159, 3);
            purplebtn.Name = "purplebtn";
            purplebtn.Size = new Size(20, 20);
            purplebtn.TabIndex = 8;
            purplebtn.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, XLbl, toolStripStatusLabel2, YLbl, toolStripDropDownButton1, toolStripStatusLabel3, Xlblb, toolStripStatusLabel4, Ylblb, toolStripStatusLabel5, Xlblbl, toolStripStatusLabel6, Ylblbl });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(14, 17);
            toolStripStatusLabel1.Text = "X";
            // 
            // XLbl
            // 
            XLbl.Name = "XLbl";
            XLbl.Size = new Size(13, 17);
            XLbl.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(14, 17);
            toolStripStatusLabel2.Text = "Y";
            // 
            // YLbl
            // 
            YLbl.Name = "YLbl";
            YLbl.Size = new Size(13, 17);
            YLbl.Text = "0";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { Clearbtn, Savebtn });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 20);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // Clearbtn
            // 
            Clearbtn.Name = "Clearbtn";
            Clearbtn.Size = new Size(99, 22);
            Clearbtn.Text = "clear";
            Clearbtn.Click += closeToolStripMenuItem_Click;
            // 
            // Savebtn
            // 
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(99, 22);
            Savebtn.Text = "save";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(14, 17);
            toolStripStatusLabel3.Text = "X";
            // 
            // Xlblb
            // 
            Xlblb.Name = "Xlblb";
            Xlblb.Size = new Size(13, 17);
            Xlblb.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(14, 17);
            toolStripStatusLabel4.Text = "Y";
            // 
            // Ylblb
            // 
            Ylblb.Name = "Ylblb";
            Ylblb.Size = new Size(13, 17);
            Ylblb.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(14, 17);
            toolStripStatusLabel5.Text = "X";
            // 
            // Xlblbl
            // 
            Xlblbl.Name = "Xlblbl";
            Xlblbl.Size = new Size(13, 17);
            Xlblbl.Text = "0";
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new Size(14, 17);
            toolStripStatusLabel6.Text = "Y";
            // 
            // Ylblbl
            // 
            Ylblbl.Name = "Ylblbl";
            Ylblbl.Size = new Size(13, 17);
            Ylblbl.Text = "0";
            // 
            // FormPaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel1);
            Name = "FormPaint";
            Text = "  ";
            Load += FormPaint_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button whitebtn;
        private Button blackbtn;
        private Button redbtn;
        private Button greenbtn;
        private Button bluebtn;
        private Button yellowbtn;
        private Button purplebtn;
        private StatusStrip statusStrip1_Click;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel XLbl;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel YLbl;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem Clearbtn;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel Xlblb;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel Ylblb;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel Xlblbl;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private ToolStripStatusLabel Ylblbl;
        private ToolStripMenuItem Savebtn;
    }
}