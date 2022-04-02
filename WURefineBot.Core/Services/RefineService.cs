using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WURefineBot.Core.Interfaces.QueueCreators;
using WURefineBot.Core.Interfaces.Services;
using WURefineBot.Infrastructure.AI;
using WURefineBot.Infrastructure.Interfaces;

namespace WURefineBot.Core.Services
{
    public class RefineService : IRefineService
    {
        private readonly IRefineQueue _refineQueue;
        private readonly IScreenHandler _screenHandler;
        public RefineService(IRefineQueue refineQueue, IScreenHandler screenHandler)
        {
            _refineQueue = refineQueue;
            _screenHandler = screenHandler;
        }
        public void ExecuteRefine(WURefineBot.Core.Enums.Resources resource)
        {
            var imageToFindList = _refineQueue.GetQueue(resource);

            foreach (var image in imageToFindList)
            {
                var fullScreen = _screenHandler.GetMainScreen();
                fullScreen.ifContainsSetMousePosition(image);
            }
        }
    }
}
