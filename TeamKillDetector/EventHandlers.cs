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
            if (ev.Target.Team == ev.Killer.Team)
                ev.Target.Broadcast(Plugin.instance.Config.Time, Plugin.instance.Config.Message);
        }
    }
}
