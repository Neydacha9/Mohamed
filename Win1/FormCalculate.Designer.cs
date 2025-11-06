namespace Win1
{
    partial class FormCalculate
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
            substractionbtn = new Button();
            summbtn = new Button();
            multplicationbtn = new Button();
            divisionbtn = new Button();
            name1txt = new TextBox();
            name2txt = new TextBox();
            name3txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // substractionbtn
            // 
            substractionbtn.Location = new Point(410, 271);
            substractionbtn.Name = "substractionbtn";
            substractionbtn.Size = new Size(93, 23);
            substractionbtn.TabIndex = 0;
            substractionbtn.Text = "вычитание";
            substractionbtn.UseVisualStyleBackColor = true;
            substractionbtn.Click += substractionbtn_Click;
            // 
            // summbtn
            // 
            summbtn.Location = new Point(311, 271);
            summbtn.Name = "summbtn";
            summbtn.Size = new Size(93, 23);
            summbtn.TabIndex = 1;
            summbtn.Text = "сложение";
            summbtn.UseVisualStyleBackColor = true;
            summbtn.Click += summbtn_Click;
            // 
            // multplicationbtn
            // 
            multplicationbtn.Location = new Point(311, 317);
            multplicationbtn.Name = "multplicationbtn";
            multplicationbtn.Size = new Size(93, 23);
            multplicationbtn.TabIndex = 2;
            multplicationbtn.Text = "умножение";
            multplicationbtn.UseVisualStyleBackColor = true;
            multplicationbtn.Click += multplicationbtn_Click;
            // 
            // divisionbtn
            // 
            divisionbtn.Location = new Point(410, 317);
            divisionbtn.Name = "divisionbtn";
            divisionbtn.Size = new Size(93, 23);
            divisionbtn.TabIndex = 3;
            divisionbtn.Text = "деление";
            divisionbtn.UseVisualStyleBackColor = true;
            divisionbtn.Click += divisionbtn_Click;
            // 
            // name1txt
            // 
            name1txt.Location = new Point(350, 160);
            name1txt.Name = "name1txt";
            name1txt.Size = new Size(100, 23);
            name1txt.TabIndex = 4;
            // 
            // name2txt
            // 
            name2txt.Location = new Point(350, 206);
            name2txt.Name = "name2txt";
            name2txt.Size = new Size(100, 23);
            name2txt.TabIndex = 5;
            // 
            // name3txt
            // 
            name3txt.Location = new Point(507, 186);
            name3txt.Name = "name3txt";
            name3txt.Size = new Size(100, 23);
            name3txt.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 163);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 7;
            label1.Text = "первое число";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 209);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 8;
            label2.Text = "второе число";
            // 
            // FormCalculate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(name3txt);
            Controls.Add(name2txt);
            Controls.Add(name1txt);
            Controls.Add(divisionbtn);
            Controls.Add(multplicationbtn);
            Controls.Add(summbtn);
            Controls.Add(substractionbtn);
            Name = "FormCalculate";
            Text = "FormCalculate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button substractionbtn;
        private Button button2;
        private Button multplicationbtn;
        private Button divisionbtn;
        private TextBox name1txt;
        private TextBox name2txt;
        private TextBox name3txt;
        private Label label1;
        private Label label2;
        private Button summbtn;
    }
}