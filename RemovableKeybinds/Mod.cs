using PulsarModLoader;

namespace RemovableKeybinds
{
    public class Mod : PulsarMod
    {
        public override string Version => "1.0.1";

        public override string Author => "Dragon";

        public override string LongDescription => "Sets keybind to NONE when Escape is pressed.";

        public override string Name => "RemovableKeybinds";

        public override string HarmonyIdentifier()
        {
            return "Dragon.RemovableKeybinds";
        }
    }
}
