using PulsarPluginLoader;

namespace RemovableKeybinds
{
    public class Plugin : PulsarPlugin
    {
        public override string Version => "1.0.0";

        public override string Author => "Dragon";

        public override string LongDescription => "Removes keybind if escape is typed";

        public override string Name => "RemovableKeybinds";

        public override string HarmonyIdentifier()
        {
            return "Dragon.RemovableKeybinds";
        }
    }
}
