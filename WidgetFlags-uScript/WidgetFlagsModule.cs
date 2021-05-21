using System;
using System.Collections.Generic;
using System.Linq;
using uScript.API.Attributes;
using System.Text;
using System.Threading.Tasks;
using SDG.Unturned;
using Steamworks;

namespace WidgetFlags_uScript
{
    [ScriptModule("WidgetFlags")]
    public class WidgetFlagsModule
    {
        [ScriptFunction]
        public static void Hide(string playerId, string widgetFlag)
        {
            var flag = (EPluginWidgetFlags)Enum.Parse(typeof(EPluginWidgetFlags), widgetFlag);
            var player = PlayerTool.getPlayer(new CSteamID(Convert.ToUInt64(playerId)));
            player.disablePluginWidgetFlag(flag);
        }

        [ScriptFunction]
        public static void Show(string playerId, string widgetFlag)
        {
            var flag = (EPluginWidgetFlags)Enum.Parse(typeof(EPluginWidgetFlags), widgetFlag);
            var player = PlayerTool.getPlayer(new CSteamID(Convert.ToUInt64(playerId)));
            player.enablePluginWidgetFlag(flag);
        }

    }
}
