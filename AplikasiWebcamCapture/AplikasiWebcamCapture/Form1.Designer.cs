namespace AplikasiWebcamCapture
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
            WebcamList = new ComboBox();
            START = new Button();
            CAPTURE = new Button();
            SAVEIMAGE = new Button();
            EXIT = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // WebcamList
            // 
            WebcamList.FormattingEnabled = true;
            WebcamList.Location = new Point(28, 19);
            WebcamList.Name = "WebcamList";
            WebcamList.Size = new Size(151, 28);
            WebcamList.TabIndex = 0;
            // 
            // START
            // 
            START.Location = new Point(185, 19);
            START.Name = "START";
            START.Size = new Size(94, 28);
            START.TabIndex = 1;
            START.Text = "START";
            START.UseVisualStyleBackColor = true;
            START.Click += START_Click;
            // 
            // CAPTURE
            // 
            CAPTURE.Location = new Point(285, 19);
            CAPTURE.Name = "CAPTURE";
            CAPTURE.Size = new Size(94, 28);
            CAPTURE.TabIndex = 2;
            CAPTURE.Text = "CAPTURE";
            CAPTURE.UseVisualStyleBackColor = true;
            CAPTURE.Click += CAPTURE_Click;
            // 
            // SAVEIMAGE
            // 
            SAVEIMAGE.Location = new Point(385, 19);
            SAVEIMAGE.Name = "SAVEIMAGE";
            SAVEIMAGE.Size = new Size(107, 28);
            SAVEIMAGE.TabIndex = 3;
            SAVEIMAGE.Text = "SAVE IMAGE";
            SAVEIMAGE.UseVisualStyleBackColor = true;
            SAVEIMAGE.Click += SAVEIMAGE_Click;
            // 
            // EXIT
            // 
            EXIT.BackColor = Color.Red;
            EXIT.Location = new Point(729, 19);
            EXIT.Name = "EXIT";
            EXIT.Size = new Size(29, 28);
            EXIT.TabIndex = 4;
            EXIT.Text = "X";
            EXIT.UseVisualStyleBackColor = false;
            EXIT.Click += EXIT_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(28, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(730, 264);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 258);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(368, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(359, 258);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 351);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(EXIT);
            Controls.Add(SAVEIMAGE);
            Controls.Add(CAPTURE);
            Controls.Add(START);
            Controls.Add(WebcamList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox WebcamList;
        private Button START;
        private Button CAPTURE;
        private Button SAVEIMAGE;
        private Button EXIT;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}