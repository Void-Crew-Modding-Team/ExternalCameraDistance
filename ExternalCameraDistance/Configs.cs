using BepInEx.Configuration;

namespace ExternalCameraDistance
{
    internal class Configs
    {
        internal static ConfigEntry<float> ShipZoomConfig;
        internal static ConfigEntry<float> ZoomSpeedConfig;

        internal static void Load(BepinPlugin plugin)
        {
            ShipZoomConfig = plugin.Config.Bind("ExternalCameraDistance", "ZoomLevel", 20f);
            ZoomSpeedConfig = plugin.Config.Bind("ExternalCameraDistance", "ZoomRate", 0.05f);
        }
    }
}
