using WURefineBot.Core.Interfaces.Menagers.Resources;

namespace WURefineBot.Core.Interfaces.Menagers
{
    public interface IResourcesManager
    {
        IResource GetResource(WURefineBot.Core.Enums.Resources resources);
    }
}
