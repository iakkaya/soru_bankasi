namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            buttonA = new Button();
            buttonB = new Button();
            buttonC = new Button();
            buttonD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelSoruno = new Label();
            labelDogru = new Label();
            labelYanlıs = new Label();
            buttonSonra = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(355, 156);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // buttonA
            // 
            buttonA.Location = new Point(1, 164);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(156, 59);
            buttonA.TabIndex = 1;
            buttonA.Text = "A";
            buttonA.UseVisualStyleBackColor = true;
            buttonA.Click += buttonA_Click;
            // 
            // buttonB
            // 
            buttonB.Location = new Point(200, 164);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(156, 59);
            buttonB.TabIndex = 2;
            buttonB.Text = "B";
            buttonB.UseVisualStyleBackColor = true;
            buttonB.Click += buttonB_Click;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(1, 243);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(156, 59);
            buttonC.TabIndex = 3;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonD
            // 
            buttonD.Location = new Point(200, 243);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(156, 59);
            buttonD.TabIndex = 4;
            buttonD.Text = "D";
            buttonD.UseVisualStyleBackColor = true;
            buttonD.Click += buttonD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(427, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 5;
            label1.Text = "SORU NO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(436, 49);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 6;
            label2.Text = "DOGRU :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 90);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 7;
            label3.Text = "YANLIŞ :";
            // 
            // labelSoruno
            // 
            labelSoruno.AutoSize = true;
            labelSoruno.Location = new Point(523, 9);
            labelSoruno.Name = "labelSoruno";
            labelSoruno.Size = new Size(17, 20);
            labelSoruno.TabIndex = 8;
            labelSoruno.Text = "0";
            // 
            // labelDogru
            // 
            labelDogru.AutoSize = true;
            labelDogru.Location = new Point(523, 52);
            labelDogru.Name = "labelDogru";
            labelDogru.Size = new Size(17, 20);
            labelDogru.TabIndex = 9;
            labelDogru.Text = "0";
            // 
            // labelYanlıs
            // 
            labelYanlıs.AutoSize = true;
            labelYanlıs.Location = new Point(523, 90);
            labelYanlıs.Name = "labelYanlıs";
            labelYanlıs.Size = new Size(17, 20);
            labelYanlıs.TabIndex = 10;
            labelYanlıs.Text = "0";
            // 
            // buttonSonra
            // 
            buttonSonra.Location = new Point(427, 142);
            buttonSonra.Name = "buttonSonra";
            buttonSonra.Size = new Size(166, 37);
            buttonSonra.TabIndex = 11;
            buttonSonra.Text = "SONRAKİ SORU";
            buttonSonra.UseVisualStyleBackColor = true;
            buttonSonra.Click += buttonSonra_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(585, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.indir;
            pictureBox2.Location = new Point(384, 185);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 117);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(556, 349);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 14;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(556, 395);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 15;
            label5.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSonra);
            Controls.Add(labelYanlıs);
            Controls.Add(labelDogru);
            Controls.Add(labelSoruno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonD);
            Controls.Add(buttonC);
            Controls.Add(buttonB);
            Controls.Add(buttonA);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button buttonA;
        private Button buttonB;
        private Button buttonC;
        private Button buttonD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelSoruno;
        private Label labelDogru;
        private Label labelYanlıs;
        private Button buttonSonra;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}
