using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WURefineBot.Infrastructure.Interfaces;

namespace WURefineBot.Infrastructure.Imaging
{
    class ScreenHandler : IScreenHandler
    {
        public Bitmap ScreenCapture()
        {
            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                               Screen.PrimaryScreen.Bounds.Height,
                               PixelFormat.Format32bppArgb);          
            return bmpScreenshot;
        }
        public Bitmap ConvertToBmp(string picture)
        {
            Bitmap myBitmap = new Bitmap(picture);
            return myBitmap;
        }

    }
}
