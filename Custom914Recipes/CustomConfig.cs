using Synapse.Api;
using System.Collections.Generic;
using Synapse.Config;

namespace Custom914Recipes
{
    public class CustomConfig : IConfigSection
    {
        public List<Scp914Recipe> Scp914Recipes { get; set; } = new List<Scp914Recipe>();
    }
}
