using System;
using System.Windows.Forms;
using System.Drawing;
namespace ToIco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public Bitmap ResizeImage(Bitmap oImage)
        {
            Bitmap nImage = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(nImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(oImage, 0, 0, pictureBox.Width, pictureBox.Height);
            }
            return nImage;
        }
        public Bitmap ConvertImage(Bitmap oImage)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            
            openfd.Title = "Select an image";
            openfd.Filter = "Text Files (*.png)|*.png|All Files (*.*)|*.*";
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                string fileName = openfd.FileName;
                filePath.Text = fileName;

                try
                {
                    // Display the selected image in the PictureBox
                    Bitmap image = new System.Drawing.Bitmap(fileName);
                    Bitmap resized = ResizeImage(image);
                    pictureBox.Image = resized;
                    
                }
                catch (Exception ex)
                {
                    // Display error message if unable to load image
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }
    }
}
