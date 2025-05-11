using System;

namespace MemoriaToolsInterfaces
{
    public interface IPluginView
    {
        void Initialize();
        string Title { get; }
        string ButtonName { get; }
        event EventHandler<ViewEventArgs> OnLogRequested;
    }
}
