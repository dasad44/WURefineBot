using System;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System.Drawing;
using System.Runtime.InteropServices;

namespace WURefineBot.Infrastructure.AI
{
    public static class AIHandler
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        public static void ifContainsSetMousePosition(this Bitmap template, Bitmap bmp)
        {
            bmp = AForge.Imaging.Image.Clone(bmp, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Rectangle tempRect = new Rectangle();
            const Int32 divisor = 4;

            ExhaustiveTemplateMatching etm = new ExhaustiveTemplateMatching(0.9f);

            TemplateMatch[] tm = etm.ProcessImage(
                new ResizeNearestNeighbor(template.Width / divisor, template.Height / divisor).Apply(template),
                new ResizeNearestNeighbor(bmp.Width / divisor, bmp.Height / divisor).Apply(bmp)
                );
            try
            {
                tempRect = tm[0].Rectangle;
            }
            catch (IndexOutOfRangeException ex)
            { }
            SetPositionAndClick(tempRect.Location.X * 4 + 3, tempRect.Location.Y * 4 + 3);
        }
        private static void SetPositionAndClick(int X, int Y)
        {
            SetCursorPos(X, Y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
    }
}
