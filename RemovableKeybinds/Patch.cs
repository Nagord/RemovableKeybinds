using HarmonyLib;
using UnityEngine;

namespace RemovableKeybinds
{
    [HarmonyPatch(typeof(PLUIControlsMenu), "KeyCodeHandler")]
    class Patch
    {
        static void Prefix(ref KeyCode key)
        {
            PulsarPluginLoader.Utilities.Logger.Info("Running prefix");
            if(key == KeyCode.Escape)
            {
                PulsarPluginLoader.Utilities.Logger.Info("Matched check");
                key = KeyCode.None;
            }
        }
    }
}
