using WURefineBot.Core.Interfaces.Menagers.Resources;

namespace WURefineBot.Core.Interfaces.Menagers
{
    interface IResourcesManager
    {
        IResource GetResource(WURefineBot.Core.Enums.Resources resources);
    }
}
