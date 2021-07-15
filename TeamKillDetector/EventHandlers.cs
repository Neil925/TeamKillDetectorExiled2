using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs;

namespace TeamKillDetector
{
    internal class EventHandlers
    {
        public void OnDied(DiedEventArgs ev)
        {
            if (ev.Target.Side == ev.Killer.Side)
                ev.Target.Broadcast(Plugin.instance.Config.Time, Plugin.instance.Config.Message.Replace("{Player}", $"{ev.Killer.Nickname} {ev.Killer.RawUserId}").Replace("{Time}", DateTime.Now.ToString()));
        }
    }
}
