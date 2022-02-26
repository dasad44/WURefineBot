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
        private readonly IResourcesManager _resourcesManager;
        private readonly List<Bitmap> _imageList;
        public RefineQueue(IResourcesManager resourcesManager)
        {
            _imageList = new List<Bitmap>();
            _resourcesManager = resourcesManager;
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
            var ss = _resourcesManager.GetResource(resource);          
            _imageList.Add(ss.GetImage());
            _imageList.Add(WURefineBot.Core.Properties.Resources.enrich);
        }
    }
}
