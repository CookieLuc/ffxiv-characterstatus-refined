using Dalamud.Data;
using Dalamud.Game;
using Dalamud.Game.ClientState;
using Dalamud.IoC;
using Dalamud.Plugin;

#pragma warning disable 8618
namespace CharacterPanelRefined; 

// ReSharper disable UnusedAutoPropertyAccessor.Local
internal class Service {
    internal static void Initialize(DalamudPluginInterface pluginInterface) => pluginInterface.Create<Service>();
    
    [PluginService] public static ClientState ClientState { get; private set; }

    [PluginService]
    [RequiredVersion("1.0")]
    internal static SigScanner SigScanner { get; private set; }

    [PluginService]
    [RequiredVersion("1.0")]
    internal static DataManager DataManager { get; private set; }
}
#pragma warning restore 8618