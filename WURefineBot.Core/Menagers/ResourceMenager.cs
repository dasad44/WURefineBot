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
    class ResourceMenager : IResourcesMenager
    {
        private IResource _resource;
        public IResource GetResource(Resources resources)
        {
            switch (resources)
            {
                case Resources.Darkonit:
                    _resource = new DarkonitResource();
                    break;
                case Resources.Dungid:
                    _resource = new DungidResourece();
                    break;
            }
            return _resource;
        }

    }
    class DarkonitResource : IResource
    {
        public Bitmap Getimage()
        {
            return new Bitmap(WURefineBot.Core.Properties.Resources.darkonit);
        }
    }
    class DungidResourece : IResource
    {
        public Bitmap Getimage()
        {
            return new Bitmap(WURefineBot.Core.Properties.Resources.dungid);
        }
    }
}
