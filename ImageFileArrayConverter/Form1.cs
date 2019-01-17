using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// 下記を参照の追加すること
// WindowsBase
// PresentationCore

namespace ImageFileArrayConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void SaveImage(string filename, Array bmpData, int width, int height, BitmapEncoder encoder, System.Windows.Media.PixelFormat format, double dpi = 96)
        {
            int stride = ((width * format.BitsPerPixel + 31) / 32) * 4;

            System.Windows.Media.Imaging.BitmapSource bs = System.Windows.Media.Imaging.BitmapSource.Create(
                width,
                height,
                dpi,
                dpi,
                format,
                null,
                bmpData,
                stride);


            using (Stream stream = new FileStream(filename, FileMode.Create))
            {
                var bf = BitmapFrame.Create(bs);
                encoder.Frames.Add(bf);
                encoder.Save(stream);
            }


        }
    }
}
