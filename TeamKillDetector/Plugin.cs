using System;
using Exiled.API.Features;

using PlayerE = Exiled.Events.Handlers.Player;

namespace TeamKillDetector
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin instance;
        public override string Name => "TeamKillDetector";
        public override string Author => "Neil";
        public override Version Version => new Version(2, 0, 1);
        public override Version RequiredExiledVersion => new Version(3, 0, 5);

        private EventHandlers _handler;

        public override void OnEnabled()
        {
            instance = this;

            _handler = new EventHandlers();

            PlayerE.Died += _handler.OnDied;

            base.OnEnabled();
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
