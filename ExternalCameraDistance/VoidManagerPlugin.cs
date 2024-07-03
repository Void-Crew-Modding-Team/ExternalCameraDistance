using VoidManager.MPModChecks;

namespace ExternalCameraDistance
{
    public class VoidManagerPlugin : VoidManager.VoidPlugin
    {
        public override MultiplayerType MPType => MultiplayerType.Client;

        public override string Author => "18107";

        public override string Description => "Allows the player to change the external camera distance by scrolling";
    }
}
