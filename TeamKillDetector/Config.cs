using System.ComponentModel;
using Exiled.API.Interfaces;

namespace TeamKillDetector
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("Message displayed to the target of a team Kill. {Player} is the Killer and {Time} is the time od the incident.")]
        public string Message { get; private set; } = "<color=yellow>{Player}</color> <color=red>team-killed you at</color> <color=yellow>{Time}.</color> <color=red>Screenshot this message as evidence for staff.</color>";

        [Description("Amount of time the message from above gets displayed.")]
        public ushort Time { get; private set; } = 8;

        [Description("Whether or not to display a the ID in the kill message.")]
        public bool InludeID { get; private set; } = false;
    }
}
