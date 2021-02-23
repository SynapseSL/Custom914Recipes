using Synapse;
using Synapse.Api;
using Synapse.Api.Plugin;
using Synapse.Config;
using System.IO;
using System.Linq;
using MEC;

namespace Custom914Recipes
{
    [PluginInformation(
        Author = "Dimenzio",
        Description = "A Plugin that allows to configure SCP-914",
        LoadPriority = 0,
        Name = "Custom914Recipes",
        SynapseMajor = 2,
        SynapseMinor = 5,
        SynapsePatch = 0,
        Version = "v.1.0.0"
        )]
    public class PluginClass : AbstractPlugin
    {
        private SYML SYMLConfig { get; set; }

        private CustomConfig DefaultConfig { get; set; } = new CustomConfig();

        private CustomConfig Config { get; set; }

        public override void Load()
        {
            var nonSharedPath = Path.Combine(Server.Get.Files.ConfigDirectory, "SCP914Recipes.syml");
            var path = File.Exists(nonSharedPath) ? nonSharedPath : Path.Combine(Server.Get.Files.SharedConfigDirectory, "SCP914Recipes.syml");

            SYMLConfig = new SYML(path);

            //Wait 3 Seconds so that the Game has enough time to load the default Values
            Timing.CallDelayed(3f, () => 
            {
                DefaultConfig.Scp914Recipes = Map.Get.Scp914.Recipes.ToList();
                ReloadConfigs();
            });
        }

        public override void ReloadConfigs()
        {
            SYMLConfig.Load();

            Config = SYMLConfig.GetOrSetDefault("SCP914Recipes", DefaultConfig);

            Map.Get.Scp914.Recipes.Clear();

            foreach (var recipe in Config.Scp914Recipes)
                Map.Get.Scp914.Recipes.Add(recipe);
        }
    }
}
