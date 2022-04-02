using System.Collections.Generic;
using System.Drawing;
using WURefineBot.Core.Interfaces.Menagers;
using WURefineBot.Core.Interfaces.QueueCreators;
using WURefineBot.Infrastructure.Imaging;
using WURefineBot.Infrastructure.Interfaces;

namespace WURefineBot.Core.QueueCreators
{
    public class RefineQueue : IRefineQueue 
    {
        private readonly IResourcesManager _resourcesManager;
        private readonly List<Bitmap> _imageList;
        public RefineQueue(IResourcesManager resourcesManager)
        {
            _imageList = new List<Bitmap>();
            _resourcesManager = resourcesManager;
        }

        public List<Bitmap> GetQueue(WURefineBot.Core.Enums.Resources resource)
        {
            CreateImageList(resource);         
            return _imageList;
        }
        
        private void CreateImageList(WURefineBot.Core.Enums.Resources resource) 
        {
            _imageList.Add(WURefineBot.Core.Properties.Resources.Menu);
            _imageList.Add(WURefineBot.Core.Properties.Resources.equipment);
            _imageList.Add(WURefineBot.Core.Properties.Resources.resources);
            _imageList.Add(WURefineBot.Core.Properties.Resources.lasers);          
            _imageList.Add(_resourcesManager.GetResource(resource).GetImage());
            _imageList.Add(WURefineBot.Core.Properties.Resources.enrich);
        }
    }
}
