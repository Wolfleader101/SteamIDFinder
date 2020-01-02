namespace Oxide.Plugins {

    [Info("SteamID Finder", "Wolfleader101", "[0.0.1]")]
    [Description("A Command that allows the user to get their SteamID")]
    public class SteamIDFinder : RustPlugin {

        // On Plugin Loaded
        void Loaded() {
            PrintToChat("Plugin");
        }

        [ChatCommand("id")]
        void GetSteamID(BasePlayer player) {
            sendMessage(player, "Your SteamID is: " + player);

        }
        // Send Message to user that fired the command
        void sendMessage(BasePlayer player, string msg, params object[] args) {
            PrintToChat(player, msg, args);
        }

    }

}

