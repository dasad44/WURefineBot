
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WURefineBot.Infrastructure.Imaging;
using WURefineBot;

namespace WURefineBot.Core.QueueCreators
{
    class RefineQueue
    {
        public List<Bitmap> CreateQueue(string pictures)
        {       
            List<Bitmap> ImageList = new List<Bitmap>();
            ScreenHandler screenHandler = new ScreenHandler();
            screenHandler.GetImage(pictures);
            ImageList.Add(WURefineBot.Core.Properties.Resources.Menu);
            ImageList.Add(WURefineBot.Core.Properties.Resources.equipment);
            ImageList.Add(WURefineBot.Core.Properties.Resources.resources);
            ImageList.Add(WURefineBot.Core.Properties.Resources.lasers);
            //to do : wybór surowca
            ImageList.Add(WURefineBot.Core.Properties.Resources.enrich);
            return new List<Bitmap>(CreateQueue(pictures));
        }      
    }
}
