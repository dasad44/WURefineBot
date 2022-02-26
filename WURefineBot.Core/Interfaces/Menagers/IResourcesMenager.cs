using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WURefineBot.Core.Interfaces.Menagers;
using WURefineBot.Core.Interfaces.Menagers.Resources;


namespace WURefineBot.Core.Interfaces.Menagers
{
     interface IResourcesMenager
    {
        IResource GetResource(Resources resources);
    }
}
