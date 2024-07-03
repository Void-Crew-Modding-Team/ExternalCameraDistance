using BepInEx;
using CG;
using CG.Input;
using Gameplay.Helm;
using HarmonyLib;
using UnityEngine;

namespace ExternalCameraDistance
{
    [HarmonyPatch(typeof(ShipExternalCamera))]
    internal class ShipExternalCameraPatch
    {
        [HarmonyPatch("Move")]
        static void Postfix(ShipExternalCamera __instance)
        {
            float scroll = -UnityInput.Current.mouseScrollDelta.y;
            if (scroll != 0 && !ServiceBase<InputService>.Instance.CursorVisibilityControl.IsCursorShown)
            {
                Configs.ShipZoomConfig.Value = Mathf.Clamp(Configs.ShipZoomConfig.Value + scroll * Configs.ZoomSpeedConfig.Value, -85, 265);
            }
            __instance.Anchor.transform.position += -__instance.Anchor.transform.forward * Configs.ShipZoomConfig.Value;
        }
    }
}
