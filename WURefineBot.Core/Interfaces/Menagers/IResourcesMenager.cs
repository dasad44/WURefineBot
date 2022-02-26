using WURefineBot.Core.Interfaces.Menagers.Resources;

namespace WURefineBot.Core.Interfaces.Menagers
{
    interface IResourcesMenager
    {
        IResource GetResource(WURefineBot.Core.Enums.Resources resources);
    }
}
