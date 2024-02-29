using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
namespace ToIco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox.Items.Add("16x16");
            comboBox.Items.Add("32x32");
            comboBox.Items.Add("48x48");
        }

        //Resizes image for preview in picturebox
        public Bitmap ViewImage(Bitmap oImage)
        {
            Bitmap nImage = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(nImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(oImage, 0, 0, pictureBox.Width, pictureBox.Height);
            }
            return nImage;

        }
        //Resize Image to combobox selected
        public Bitmap ResizeImage(Bitmap oImage)
        {
            int dimension;
            switch (comboBox.SelectedItem)
            {
                case "16x16":
                    dimension = 16;
                    break;
                case "32x32":
                    dimension = 32;
                    break;
                case "48x48":
                    dimension = 48;
                    break;
                default:
                    dimension = 16;
                    break;
            }
            Bitmap nImage = new Bitmap(dimension, dimension);
            using (Graphics g = Graphics.FromImage(nImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(oImage, 0, 0, dimension, dimension);
            }
            return nImage;

        }
        public void ConvertImage(Bitmap oImage, string fPath)
        {
            
            string nPath = fPath.Replace(Path.GetExtension(fPath).ToLower(), ".ico");
            using (Icon icon = Icon.FromHandle(oImage.GetHicon()))
            {
                using (var fileStream = new System.IO.FileStream(nPath, System.IO.FileMode.Create))
                {
                    icon.Save(fileStream);
                }
            }
            //Bitmap loadedicon = new System.Drawing.Bitmap(nPath);
            Image iconvar = null;
            iconvar?.Dispose();
            using (Bitmap tempimage = new Bitmap(nPath, true))
            {
                iconvar = new Bitmap(tempimage);
                convertPreview.Image = iconvar;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();

            openfd.Title = "Select an image";
            openfd.Filter = "Text Files (*.png; *.jpg; *.jpeg; *.bmp; *.gif)|*.png; *.jpg; *.jpeg; *.bmp; *.gif|All Files (*.*)|*.*";
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                string fileName = openfd.FileName;
                filePath.Text = fileName;

                try
                {
                    // Display the selected image in the PictureBox
                    Bitmap loadedimage = new System.Drawing.Bitmap(fileName);
                    Bitmap resized = ViewImage(loadedimage);
                    pictureBox.Image = resized;

                }
                catch (Exception ex)
                {
                    // Display error message if unable to load image
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                Bitmap loadedimage = new System.Drawing.Bitmap(filePath.Text);
                Bitmap resize = ResizeImage(loadedimage);
                ConvertImage(resize, filePath.Text);
            }
            else
            {
                MessageBox.Show("No image selected...");
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
