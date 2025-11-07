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
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            whitebtn = new Button();
            blackbtn = new Button();
            redbtn = new Button();
            greenbtn = new Button();
            bluebtn = new Button();
            yellowbtn = new Button();
            purplebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 399);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            blackbtn.Click += blackbtn_Click;
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
            // FormPaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel1);
            Name = "FormPaint";
            Text = "FormPaint";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
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
    }
}