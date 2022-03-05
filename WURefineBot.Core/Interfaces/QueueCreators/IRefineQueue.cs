using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WURefineBot.Core.Interfaces.QueueCreators
{
    public interface IRefineQueue
    {
        List<Bitmap> GetQueue(WURefineBot.Core.Enums.Resources resource);
    }
}
