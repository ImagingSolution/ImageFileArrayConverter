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

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {

            //ファイルを開くダイアログボックスの作成  
            var ofd = new OpenFileDialog();
            //ファイルフィルタ  
            ofd.Filter = "Image File(*.bmp,*.png,*.tif)|*.bmp;*.png;*.tif";
            //ダイアログの表示 （Cancelボタンがクリックされた場合は何もしない）
            if (ofd.ShowDialog() == DialogResult.Cancel) return;

            PixelFormat format;

            var data = FileConvertArray(ofd.FileName, out format);

            MessageBox.Show(format.ToString() + $"({format.BitsPerPixel}bit)");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {




        }

        private void btnBgr101010Bmp_Click(object sender, EventArgs e)
        {

            SaveImage(
                "Bgr101010.bmp",
                Bgr101010Data(),
                1024,
                384,
                PixelFormats.Bgr101010
                );

        }

        private void btnBgr101010Tif_Click(object sender, EventArgs e)
        {
            SaveImage(
                "Bgr101010.tif",
                Bgr101010Data(),
                1024,
                384,
                PixelFormats.Bgr101010
                );
        }

        private void btnBgr101010Png_Click(object sender, EventArgs e)
        {
            SaveImage(
                "Bgr101010.png",
                Bgr101010Data(),
                1024,
                384,
                PixelFormats.Bgr101010
                );
        }

        private void btnGray16Bmp_Click(object sender, EventArgs e)
        {
            SaveImage(
                "Gray16.bmp",
                Gray16Data(),
                1024,
                384,
                PixelFormats.Gray16
                );
        }

        private void btnGray16Tif_Click(object sender, EventArgs e)
        {
            SaveImage(
                "Gray16.tif",
                Gray16Data(),
                1024,
                384,
                PixelFormats.Gray16
                );
        }

        private void btnGray16Png_Click(object sender, EventArgs e)
        {
            SaveImage(
                "Gray16.png",
                Gray16Data(),
                1024,
                384,
                PixelFormats.Gray16
                );
        }

        private void btnRgb48Bmp_Click(object sender, EventArgs e)
        {
            SaveImage(
                "Rgb48.bmp",
                Rgb48Data(),
                1024,
                384,
                PixelFormats.Rgb48
                );
        }

        private void btnRgb48Tif_Click(object sender, EventArgs e)
        {
            SaveImage(
                "Rgb48.tif",
                Rgb48Data(),
                1024,
                384,
                PixelFormats.Rgb48
                );
        }

        private void btnRgb48Png_Click(object sender, EventArgs e)
        {
            SaveImage(
                "Rgb48.png",
                Rgb48Data(),
                1024,
                384,
                PixelFormats.Rgb48
                );
        }


        private Array FileConvertArray(string filename, out PixelFormat format)
        {

            Array arr;

            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {

                BitmapFrame bitmapFrame = BitmapFrame.Create(
                    fs,
                    BitmapCreateOptions.PreservePixelFormat,
                    BitmapCacheOption.Default
                    )
                    ;

                //BitmapDecoder decoder = new TiffBitmapDecoder(fs, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
                //BitmapDecoder decoder = new BmpBitmapDecoder(fs, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
                //BitmapDecoder decoder = new PngBitmapDecoder(fs, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);

                //BitmapFrame bitmapFrame = decoder.Frames[0];

                int width = bitmapFrame.PixelWidth;
                int height = bitmapFrame.PixelHeight;
                format = bitmapFrame.Format;

                int stride = ((width * format.BitsPerPixel + 31) / 32) * 4;

                if (format == PixelFormats.Gray16)
                {
                    arr = new ushort[width * height];
                }
                else if (format == PixelFormats.Rgb48)
                {
                    arr = new ushort[width * 3 * height];
                }
                else
                {
                    arr = new byte[stride * height];
                }

                // 輝度データを配列へコピー
                bitmapFrame.CopyPixels(arr, stride, 0);
            }
            return arr;
        }

        private void SaveImage(string filename, Array bmpData, int width, int height, System.Windows.Media.PixelFormat format, double dpi = 96)
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

            // ファイル名の拡張子
            var ext = Path.GetExtension(filename).ToLower();

            BitmapEncoder encoder;

            switch (ext)
            {
                case ".bmp":
                    encoder = new BmpBitmapEncoder();
                    break;

                case ".tif":
                    encoder = new TiffBitmapEncoder { Compression = TiffCompressOption.None };
                    break;

                case ".png":
                    encoder = new PngBitmapEncoder();
                    break;

                default:
                    encoder = null;
                    break;
            }

            using (Stream stream = new FileStream(filename, FileMode.Create))
            {
                var bf = BitmapFrame.Create(bs);
                encoder.Frames.Add(bf);
                encoder.Save(stream);
            }

        }

        /// <summary>
        /// PixelFormats.Bgr101010用データの作成
        /// </summary>
        /// <returns></returns>
        private uint[] Bgr101010Data()
        {

            int width = 1024;
            int height = 384;

            uint[] data = new uint[width * height];

            // R (29 .. 20bit)
            for (int j = 0; j < 128; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    data[i + j * width] = (uint)(i << 20);
                }
            }

            // G (19 .. 10bit)
            for (int j = 128; j < 256; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    data[i + j * width] = (uint)(i << 10);
                }
            }

            // B (9 .. 0bit)
            for (int j = 256; j < 384; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    data[i + j * width] = (uint)(i);
                }
            }

            return data;

        }


        private ushort[] Gray16Data()
        {
            int width = 1024;
            int height = 384;

            ushort[] data = new ushort[width * height];

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    data[i + j * width] = (ushort)(i << 6);
                }
            }

            return data;

        }

        private ushort[] Rgb48Data()
        {

            int width = 1024;
            int height = 384;

            ushort[] data = new ushort[width * 3 * height];

            // R 
            for (int j = 0; j < 128; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    data[i * 3 + j * width * 3] = (ushort)(i << 6);
                }
            }

            // G 
            for (int j = 128; j < 256; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    data[i * 3 + 1 + j * width * 3] = (ushort)(i << 6);
                }
            }

            // B
            for (int j = 256; j < 384; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    data[i * 3 + 2 + j * width * 3] = (ushort)(i << 6);
                }
            }

            return data;

        }


    }
}
