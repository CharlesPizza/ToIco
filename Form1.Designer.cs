namespace ToIco
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
            button1 = new Button();
            filePath = new TextBox();
            openFileDialog = new OpenFileDialog();
            pictureBox = new PictureBox();
            convert = new Button();
            comboBox = new ComboBox();
            convertPreview = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)convertPreview).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(428, 11);
            button1.Name = "button1";
            button1.Size = new Size(138, 23);
            button1.TabIndex = 0;
            button1.Text = "Select Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // filePath
            // 
            filePath.Location = new Point(12, 12);
            filePath.Name = "filePath";
            filePath.Size = new Size(410, 23);
            filePath.TabIndex = 1;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(12, 41);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(554, 397);
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // convert
            // 
            convert.Location = new Point(713, 78);
            convert.Name = "convert";
            convert.Size = new Size(75, 23);
            convert.TabIndex = 3;
            convert.Text = "Convert";
            convert.UseVisualStyleBackColor = true;
            convert.Click += button2_Click;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(572, 78);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(135, 23);
            comboBox.TabIndex = 5;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // convertPreview
            // 
            convertPreview.Location = new Point(643, 128);
            convertPreview.Name = "convertPreview";
            convertPreview.Size = new Size(64, 64);
            convertPreview.TabIndex = 6;
            convertPreview.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(convertPreview);
            Controls.Add(comboBox);
            Controls.Add(convert);
            Controls.Add(pictureBox);
            Controls.Add(filePath);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)convertPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox filePath;
        private OpenFileDialog openFileDialog;
        private PictureBox pictureBox;
        private Button convert;
        private ComboBox comboBox;
        private PictureBox convertPreview;
    }
}
