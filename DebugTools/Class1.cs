using DebugTools;
using MelonLoader;
using System;
using System.Collections;
using UIExpansionKit.API;

[assembly: MelonInfo(typeof(main), "DebugTools", "1.0.0", "Tommosaurus",
    "https://github.com/GeekAndProud/debugtools")]
[assembly: MelonGame("VRChat", "VRChat")]

namespace DebugTools
{
    public class main : MelonMod
    {
        VRCUiManager uiman;
        public override void OnApplicationStart()
        {
            ExpansionKitApi.GetExpandedMenu(ExpandedMenu.QuickMenu).AddSimpleButton("Reset Debug Window", () => resetDebugWindow());
        }

        private void resetDebugWindow()
        {

        }

        public override void OnUpdate()
        {
        }
    }
}
