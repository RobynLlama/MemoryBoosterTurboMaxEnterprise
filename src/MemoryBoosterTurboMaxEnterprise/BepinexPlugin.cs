using BepInEx;
using BepInEx.Logging;
using Ostranauts.Core;

namespace MemoryBoosterTurboMaxEnterprise;

[BepInPlugin(LCMPluginInfo.PLUGIN_GUID, LCMPluginInfo.PLUGIN_NAME, LCMPluginInfo.PLUGIN_VERSION)]
public class RobynSoftEnterprisePlugin : BaseUnityPlugin
{
  internal static ManualLogSource Log = null!;

  private void Awake()
  {
    Log = Logger;
    Log.LogInfo($"""
    Memory Booster Turbo Max Enterprise Edition is now loaded!
      Version:   {LCMPluginInfo.PLUGIN_VERSION}
      License:   Enterprise (VALIDATED)
      Patent-No: US-12382966-B1
    """);


    CrewSim.OnGameFinishedLoading.AddListener(EnterpriseCallbacks.LoadGameEnterpriseListeners.LoadGameEnterpriseCallback);
    LoadManager.OnSaveFinished.AddListener(EnterpriseCallbacks.LoadGameEnterpriseListeners.LoadGameEnterpriseCallback);
  }

}
