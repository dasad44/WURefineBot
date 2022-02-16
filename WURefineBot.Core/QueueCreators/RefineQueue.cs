using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WURefineBot.Infrastructure.Imaging;

namespace WURefineBot.Core.QueueCreators
{
    class RefineQueue
    {
        public List<Bitmap> CreateQueue(string pictures)
        {
            
            ScreenHandler screenHandler = new ScreenHandler();
            screenHandler.GetImage(pictures);
            return new List<Bitmap>(CreateQueue(pictures));
        }      
    }
}
