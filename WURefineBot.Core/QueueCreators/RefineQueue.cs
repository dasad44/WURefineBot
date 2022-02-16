using System.Collections.Generic;
using System.Drawing;
using WURefineBot.Core.Interfaces.QueueCreators;
using WURefineBot.Infrastructure.Imaging;
using WURefineBot.Infrastructure.Interfaces;

namespace WURefineBot.Core.QueueCreators
{
    class RefineQueue : IRefineQueue 
    {
        private readonly List<Bitmap> _imageList;
        public RefineQueue()
        {
            _imageList = new List<Bitmap>();
        }

        public List<Bitmap> CreateQueue()
        {
            GetImagesFromResources();
            return _imageList;
        }
        
        private void GetImagesFromResources()
        {
            _imageList.Add(WURefineBot.Core.Properties.Resources.Menu);
            _imageList.Add(WURefineBot.Core.Properties.Resources.equipment);
            _imageList.Add(WURefineBot.Core.Properties.Resources.resources);
            _imageList.Add(WURefineBot.Core.Properties.Resources.lasers);
            //to do : wybór surowca
            _imageList.Add(WURefineBot.Core.Properties.Resources.enrich);
        }
    }
}
