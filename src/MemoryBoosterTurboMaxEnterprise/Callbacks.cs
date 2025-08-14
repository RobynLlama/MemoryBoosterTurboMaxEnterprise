using System;

namespace MemoryBoosterTurboMaxEnterprise.EnterpriseCallbacks;

public static class LoadGameEnterpriseListeners
{
  public static void LoadGameEnterpriseCallback()
  {
    RobynSoftEnterprisePlugin.Log.LogMessage("Game has finished saving or loading, engaging enterprise level algorithms to compact heap!");

    try
    {
      GC.Collect();
      GC.WaitForPendingFinalizers();
      GC.Collect();
    }
    catch (Exception ex)
    {
      RobynSoftEnterprisePlugin.Log.LogError($"Memory Booster Turbo Max Enterprise Edition has encountered an error during GC Compacting: {ex}");
    }
  }
}
