using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;

using PlayerE = Exiled.Events.Handlers.Player;

namespace TeamKillDetector
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin instance;
        public override string Name { get; } = "TeamKillDetector";
        public override string Author { get; } = "Neil";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 11, 0);

        private EventHandlers _handler;

        public override void OnEnabled()
        {
            instance = this;

            _handler = new EventHandlers();

            PlayerE.Died += _handler.OnDied;

            base.OnDisabled();
        }

        public override void OnDisabled()
        {
            PlayerE.Died -= _handler.OnDied;

            _handler = null;

            instance = null;

            base.OnDisabled();
        }
    }
}
