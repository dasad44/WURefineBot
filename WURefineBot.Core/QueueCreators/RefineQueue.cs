using System.Collections.Generic;
using System.Drawing;
using WURefineBot.Core.Interfaces.Menagers;
using WURefineBot.Core.Interfaces.QueueCreators;
using WURefineBot.Infrastructure.Imaging;
using WURefineBot.Infrastructure.Interfaces;

namespace WURefineBot.Core.QueueCreators
{
    class RefineQueue : IRefineQueue 
    {
        private readonly IResourcesMenager _resourcesMenager;
        private readonly List<Bitmap> _imageList;
        public RefineQueue(IResourcesMenager resourcesMenager)
        {
            _imageList = new List<Bitmap>();
            _resourcesMenager = resourcesMenager;
        }

        public List<Bitmap> CreateQueue(WURefineBot.Core.Enums.Resources resource)
        {
            GetImagesFromResources(resource);         
            return _imageList;
        }
        
        private void GetImagesFromResources(WURefineBot.Core.Enums.Resources resource) 
        {
            _imageList.Add(WURefineBot.Core.Properties.Resources.Menu);
            _imageList.Add(WURefineBot.Core.Properties.Resources.equipment);
            _imageList.Add(WURefineBot.Core.Properties.Resources.resources);
            _imageList.Add(WURefineBot.Core.Properties.Resources.lasers);
            var ss = _resourcesMenager.GetResource(resource);          
            _imageList.Add(ss.Getimage());
            _imageList.Add(WURefineBot.Core.Properties.Resources.enrich);
        }
    }
}
