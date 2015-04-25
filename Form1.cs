using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;


namespace ImgCompressV1
{
    public partial class Form1 : Form
    {
        ToolTip toolTip = new ToolTip();
        public Form1()
        {
            InitializeComponent();
            trcBarImageQuaity.Value = 50;
        }

         private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string fileLocation = "";

            if (dlgResult == DialogResult.OK)
            {
                fileLocation = openFileDialog1.FileName;
            }
            else
            {
                fileLocation = "";
            }

            txtImageLocation.Text =Path.GetDirectoryName(fileLocation);  
            string sOutFileLocation = txtImageLocation.Text + "Out";
            txtOutput.Text = sOutFileLocation + "\\";
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            string fileLocation = txtImageLocation.Text;
            if (fileLocation == string.Empty)
            {
                MessageBox.Show("Check the File Location!", "Image Compress", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Create output folder
            string sOutFileLocation = fileLocation + "Out";
            txtOutput.Text = sOutFileLocation + "\\";
            if (Directory.Exists(sOutFileLocation))
            {
                Directory.Delete(sOutFileLocation);
            }
            Directory.CreateDirectory(sOutFileLocation);

            if (Directory.Exists(fileLocation))
            {
                CompressImages(txtImageLocation.Text);
                MessageBox.Show("Successfully Compressed", "Image Compress");
            }
            else
            {
                MessageBox.Show("Check the File Location!","Image Compress",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompressImages(string imgLocation)
        {
            //image extension
            List<string> imgExtension = new List<string>();
            imgExtension.Add(".jpg");
            imgExtension.Add(".jpeg");
            //imgExtension.Add(".png");

            DirectoryInfo dInfo = new DirectoryInfo(imgLocation);
            try
            {
                foreach (DirectoryInfo dir in dInfo.GetDirectories())
                    CompressImages(dir.FullName.ToString());
                foreach (FileInfo fInfo in dInfo.GetFiles())
                {
                    string fileExt = fInfo.Extension;
                    if (imgExtension.Contains(fileExt.ToLower()))
                    {
                        int quality = trcBarImageQuaity.Value;
                        CompressImagesExt(fInfo.FullName, quality);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString() + e.StackTrace.ToString());
            }
           
        }

        private void CompressImagesExt(string imageFilePath, int quality)
        {
            Image img = Image.FromFile(imageFilePath);
            try
            {
                if (quality < 0 || quality > 100)
                    throw new ArgumentOutOfRangeException("Quality out of range");

                EncoderParameter qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);

                ImageCodecInfo jpegCodecInfo = GetEncorderInfo("image/jpeg");

                EncoderParameters encoderParams = new EncoderParameters(1);
                encoderParams.Param[0] = qualityParam;

                string despath =txtOutput.Text +"\\" + Path.GetFileName(imageFilePath);
                img.Save(despath, jpegCodecInfo, encoderParams);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private ImageCodecInfo GetEncorderInfo(string mimeType)
        {
            ImageCodecInfo[] imgCodeInfoColl = ImageCodecInfo.GetImageEncoders();
            for (int i = 0; i < imgCodeInfoColl.Length; i++ )
            {
                if (imgCodeInfoColl[i].MimeType.Equals(mimeType))
                    return imgCodeInfoColl[i];
                  
            }

            return null;
        }

        private void trcBarImageQuaity_Scroll(object sender, EventArgs e)
        {
            toolTip.SetToolTip(trcBarImageQuaity, trcBarImageQuaity.Value.ToString());
        }
    }
}
