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
            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                Screen.PrimaryScreen.Bounds.Height,
                                PixelFormat.Format24bppRgb);

            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                        Screen.PrimaryScreen.Bounds.Y,
                                        0,
                                        0,
                                        Screen.PrimaryScreen.Bounds.Size,
                                        CopyPixelOperation.SourceCopy);
            return bmpScreenshot;
        }
    }
}
