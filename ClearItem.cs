using Exiled.API.Features;
using Exiled.API.Enums;
using System;

namespace clearItem
{
    public class ClearItem : Plugin<Config>
    {
        public override string Name => "Clear Item";
        public override string Author => "dheb";

        public static ClearItem Instance { get; private set; }
        public override PluginPriority Priority { get; } = PluginPriority.Medium;
        public override Version RequiredExiledVersion => new Version(6, 0, 0);
        public override Version Version => new Version(1, 0, 0);

        public override void OnEnabled()
        {
            Log.Info("Clear Item plugin has been successfully enabled!");
            Instance = this;
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Log.Info("Clear Item plugin has been disabled.");
            Instance = null;
            UnregisterEvents();
            base.OnDisabled();
        }

        private void RegisterEvents() {}
        private void UnregisterEvents() {}
    }
}
