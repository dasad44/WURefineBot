using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using WURefineBot.Infrastructure.Interfaces;

namespace WURefineBot.Infrastructure.Imaging
{
     public class ScreenHandler : IScreenHandler
    {
        public Bitmap GetMainScreen()
        {       
            return new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                               Screen.PrimaryScreen.Bounds.Height,
                               PixelFormat.Format32bppArgb);
        }
        public Bitmap GetImage(string picture)
        {
            return new Bitmap(picture);
        }

    }
}
