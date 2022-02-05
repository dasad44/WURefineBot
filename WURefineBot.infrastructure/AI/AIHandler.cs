using System;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System.Drawing;
using WURefineBot.Infrastructure.Interfaces;

namespace WURefineBot.Infrastructure.AI
{
    static class AIHandler 
    {
        public static bool Contains(this Bitmap template, Bitmap bmp)
        {
            Rectangle tempRect;
            const Int32 divisor = 4;
            const Int32 epsilon = 10;

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
            {
                return false;
            }

            Color pixelColor = template.GetPixel(bmp.Width, bmp.Height);
            if (Math.Abs(bmp.Width / divisor - tempRect.Width) < epsilon
                &&
                Math.Abs(bmp.Height / divisor - tempRect.Height) < epsilon)
            {
                return true;
            }
            return false;
        }
    }
}
