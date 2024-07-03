using VoidManager.CustomGUI;
using VoidManager.Utilities;

namespace ExternalCameraDistance
{
    internal class GUI : ModSettingsMenu
    {
        private static string zoomDistance = Configs.ShipZoomConfig.Value.ToString();
        private static string zoomSpeed = Configs.ZoomSpeedConfig.Value.ToString();

        public override string Name() => "External Camera Distance";

        public override void OnOpen()
        {
            zoomDistance = Configs.ShipZoomConfig.Value.ToString();
        }

        public override void Draw()
        {
            if (GUITools.DrawTextField("Zoom Distance", ref zoomDistance, Configs.ShipZoomConfig.DefaultValue.ToString()))
            {
                if (float.TryParse(zoomDistance, out float zoom))
                {
                    Configs.ShipZoomConfig.Value = zoom;
                }
                zoomDistance = Configs.ShipZoomConfig.Value.ToString();
            }

            if (GUITools.DrawTextField("Zoom Rate", ref zoomSpeed, Configs.ZoomSpeedConfig.DefaultValue.ToString()))
            {
                if (float.TryParse(zoomSpeed, out float rate))
                {
                    Configs.ZoomSpeedConfig.Value = rate;
                }
                zoomSpeed = Configs.ZoomSpeedConfig.Value.ToString();
            }
        }
    }
}
