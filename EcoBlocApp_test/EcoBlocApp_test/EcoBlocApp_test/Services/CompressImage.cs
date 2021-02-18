using System;
using System.Collections.Generic;
using System.Text;

namespace EcoBlocApp_test.Services
{
    public static void CompressImage(string sourcepath, string destpath, int quality)
    {
        var FileName = Path.GetFileName(sourcepath);
        destpath = destpath + "\\" + FileName;
        using (Bitmap bmpl = new Bitmap(sourcepath))
        {
            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
            System.Drawing.Imaging.Encoder QualityEncoder = System.Drawing.Imaging.Encoder.Quality;
            EncoderParameters myEncoderParameters = new EncoderParameters(1);
            EncoderParameter myEncoderParameter = new EncoderParameter(QualityEncoder, quality);
            myEncoderParameters.Param[0] = myEncoderParameter;
            bmpl.Save(destpath, jpgEncoder, myEncoderParameters);
        }
    }

    private static ImageCodecInfo GetEncoder(ImageFormat format)
    {
        ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
        foreach (ImageCodecInfo codec in codecs)
        {
            if (codec.FormatID == format.Guid)
            {
                return codec;
            }
        }
        return null;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        string[] files = Directory.GetFiles(textBox1.Text);
        DialogResult result2 = folderBrowserDialog1.ShowDialog();
        if (result2 == DialogResult.OK)
        {
            foreach (var file in files)
            {
                string ext = Path.GetExtension(file).ToUpper();
                if (ext == ".PNG" || ext == ".JPG")
                {
                    CompressImage(file, folderBrowserDialog1.SelectedPath, (int)comboBox1.SelectedItem);
                }
                else
                {
                    MessageBox.Show("The selected file: " + textBox1.Text + " does not contain no imege.", "Compress Unsuccessfull!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClassGV.image = 1;
                    break;
                }
            }
            if (ClassGV.image != 1)
            {
                MessageBox.Show("Compressed images has been stored to\n" + folderBrowserDialog1.SelectedPath, "Compress Successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }