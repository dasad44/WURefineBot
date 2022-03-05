using System;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System.Drawing;
using System.Runtime.InteropServices;

namespace WURefineBot.Infrastructure.AI
{
    static class AIHandler 
    {
        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);
        public static void ifContainsSetMousePosition(this Bitmap template, Bitmap bmp)
        {
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
            SetPosition(tempRect.Location.X * 4, tempRect.Location.Y * 4);
        }
        private static void SetPosition(int X, int Y)
        {
            SetCursorPos(X, Y);
        }
    }
}
