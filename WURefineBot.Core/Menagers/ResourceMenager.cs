using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WURefineBot.Core.Interfaces.Menagers;
using WURefineBot.Core.Interfaces.Menagers.Resources;

namespace WURefineBot.Core.Menagers
{
    class ResourceMenager : IResourcesManager
    {
        private IResource _resource;
        public IResource GetResource(WURefineBot.Core.Enums.Resources resources)
        {
            switch (resources)
            {
                case WURefineBot.Core.Enums.Resources.Darkonit:
                    _resource = new DarkonitResource();
                    break;
                case WURefineBot.Core.Enums.Resources.Dungid:
                    _resource = new DungidResourece();
                    break;
            }
            return _resource;
        }

    }
    class DarkonitResource : IResource
    {
        public Bitmap GetImage()
        {
            return new Bitmap(WURefineBot.Core.Properties.Resources.darkonit);
        }
    }
    class DungidResourece : IResource
    {
        public Bitmap GetImage()
        {
            return new Bitmap(WURefineBot.Core.Properties.Resources.dungid);
        }
    }
}
