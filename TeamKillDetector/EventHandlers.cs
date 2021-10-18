using System;
using System.Globalization;
using Exiled.Events.EventArgs;

namespace TeamKillDetector
{
    internal class EventHandlers
    {
        internal void OnDied(DiedEventArgs ev)
        {
            if (ev.Target.Side != ev.Killer.Side || ev.Killer == ev.Target)
                return;
            
            ev.Target.Broadcast(Plugin.instance.Config.Time, Plugin.instance.Config.Message.Replace("{Player}", $"{ev.Killer.Nickname}{(Plugin.instance.Config.IncludeID ? " (" + ev.Killer.RawUserId + ")" : "")}").Replace("{Time}", DateTime.Now.ToString(CultureInfo.InvariantCulture)));
        }
    }
}
