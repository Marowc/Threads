namespace ImageProcessing
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
            pictureBoxOriginal = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            loadButton = new Button();
            ProcessButton = new Button();
            pictureBoxTreshold = new PictureBox();
            pictureBoxNegative = new PictureBox();
            pictureBoxGray = new PictureBox();
            pictureBoxFlip = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTreshold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNegative).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGray).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlip).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            pictureBoxOriginal.Location = new Point(12, 12);
            pictureBoxOriginal.Name = "pictureBoxOriginal";
            pictureBoxOriginal.Size = new Size(345, 345);
            pictureBoxOriginal.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOriginal.TabIndex = 0;
            pictureBoxOriginal.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // loadButton
            // 
            loadButton.Location = new Point(363, 136);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(108, 42);
            loadButton.TabIndex = 1;
            loadButton.Text = "load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // ProcessButton
            // 
            ProcessButton.Location = new Point(363, 184);
            ProcessButton.Name = "ProcessButton";
            ProcessButton.Size = new Size(108, 42);
            ProcessButton.TabIndex = 2;
            ProcessButton.Text = "parallel processing";
            ProcessButton.UseVisualStyleBackColor = true;
            ProcessButton.Click += ProcessButton_Click;
            // 
            // pictureBoxTreshold
            // 
            pictureBoxTreshold.Location = new Point(490, 12);
            pictureBoxTreshold.Name = "pictureBoxTreshold";
            pictureBoxTreshold.Size = new Size(169, 169);
            pictureBoxTreshold.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTreshold.TabIndex = 3;
            pictureBoxTreshold.TabStop = false;
            // 
            // pictureBoxNegative
            // 
            pictureBoxNegative.Location = new Point(490, 191);
            pictureBoxNegative.Name = "pictureBoxNegative";
            pictureBoxNegative.Size = new Size(169, 169);
            pictureBoxNegative.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxNegative.TabIndex = 4;
            pictureBoxNegative.TabStop = false;
            // 
            // pictureBoxGray
            // 
            pictureBoxGray.Location = new Point(665, 14);
            pictureBoxGray.Name = "pictureBoxGray";
            pictureBoxGray.Size = new Size(169, 167);
            pictureBoxGray.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGray.TabIndex = 5;
            pictureBoxGray.TabStop = false;
            // 
            // pictureBoxFlip
            // 
            pictureBoxFlip.Location = new Point(665, 191);
            pictureBoxFlip.Name = "pictureBoxFlip";
            pictureBoxFlip.Size = new Size(169, 167);
            pictureBoxFlip.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFlip.TabIndex = 6;
            pictureBoxFlip.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 370);
            Controls.Add(pictureBoxFlip);
            Controls.Add(pictureBoxGray);
            Controls.Add(pictureBoxNegative);
            Controls.Add(pictureBoxTreshold);
            Controls.Add(ProcessButton);
            Controls.Add(loadButton);
            Controls.Add(pictureBoxOriginal);
            Name = "Form1";
            Text = "ImageProcessing";
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTreshold).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNegative).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGray).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlip).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxOriginal;
        private OpenFileDialog openFileDialog1;
        private Button loadButton;
        private Button ProcessButton;
        private PictureBox pictureBoxTreshold;
        private PictureBox pictureBoxNegative;
        private PictureBox pictureBoxGray;
        private PictureBox pictureBoxFlip;
    }
}
