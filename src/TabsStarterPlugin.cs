using BepInEx;
using UnityEngine;

namespace TabsStarterMod
{
    [BepInPlugin("com.malter1.tabsstartermod", "TABS Starter Mod", "0.1.0")]
    public sealed class TabsStarterPlugin : BaseUnityPlugin
    {
        private void Awake()
        {
            Logger.LogInfo("TABS Starter Mod loaded successfully.");
        }
    }
}
