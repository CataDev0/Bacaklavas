using System.Reflection;
using Bacaklavas.ItemGroups;
using KitchenLib;
using KitchenMods;

namespace Bacaklavas
{
    public class Main() : BaseMod(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, "0.0.1", MOD_GAMEVERSION,
        Assembly.GetExecutingAssembly()), IModSystem
    {
        public const string MOD_GUID = "cata.plateup.bacaklavas";
        public const string MOD_NAME = "Bacaklavas";
        public const string MOD_VERSION = "0.0.1";
        public const string MOD_AUTHOR = "Cata";
        public const string MOD_GAMEVERSION = ">=1.1.3";

        protected override void OnPostActivate(Mod mod)
        {
            // Dishes
            AddGameDataObject<Bacalao>();
            AddGameDataObject<Baklava>();
            
            // Bacalao Items
            AddGameDataObject<TomatoSoup>();
            AddGameDataObject<TomatoSoupWithPotato>();
            AddGameDataObject<BacalaoUncooked>();
            AddGameDataObject<BacalaoCooked>();
            
            // Bacalao Item Groups
            AddGameDataObject<TomatoSoupGroup>();
            AddGameDataObject<TomatoSoupWithPotato>();
            AddGameDataObject<BacalaoUncookedGroup>();
            
            // Baklava Items
            AddGameDataObject<BaklavaCooked>();
        }
    }
}