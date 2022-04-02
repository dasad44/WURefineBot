using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WURefineBot.Core.Interfaces.Services
{
    public interface IRefineService
    {
        void ExecuteRefine(WURefineBot.Core.Enums.Resources resource);
    }
}
