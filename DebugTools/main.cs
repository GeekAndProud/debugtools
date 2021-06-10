using DebugTools;
using MelonLoader;
using System;
using System.Collections;
using UIExpansionKit.API;

[assembly: MelonInfo(typeof(main), "DebugTools", "0.1.0", "Tommosaurus",
    "https://github.com/GeekAndProud/debugtools")]
[assembly: MelonGame("VRChat", "VRChat")]

namespace DebugTools
{
    public class main : MelonMod
    {
        AvatarDebugConsole buggy;
        FaceCamera facecam;
        public override void OnApplicationStart()
        {
            ExpansionKitApi.GetExpandedMenu(ExpandedMenu.QuickMenu).AddSimpleButton("Reset Debug Window", () => resetDebugWindow());
        }

        private void resetDebugWindow()
        {
            buggy.gameObject.transform.position = new UnityEngine.Vector3(facecam.gameObject.transform.position.x, facecam.gameObject.transform.position.y, facecam.gameObject.transform.position.z);            
        }

        public override void OnUpdate()
        {
        }
    }
}
