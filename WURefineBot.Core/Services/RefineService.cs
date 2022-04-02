using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WURefineBot.Core.Interfaces.QueueCreators;
using WURefineBot.Core.Interfaces.Services;

namespace WURefineBot.Core.Services
{
    public class RefineService : IRefineService
    {
        private readonly IRefineQueue _refineQueue ;
        public RefineService(IRefineQueue refineQueue)
        {
            _refineQueue = refineQueue;
        }
        public void ExecuteRefine(WURefineBot.Core.Enums.Resources resource)
        {
            _refineQueue.GetQueue(resource);
        }
    }
}
