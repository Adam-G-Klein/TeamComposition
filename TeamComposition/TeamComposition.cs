using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using TeamComposition.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;


namespace TeamComposition
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class TeamComposition : BaseUnityPlugin
    {
        private const string ModId = "com.adamk.rounds.teamcomposition";
        private const string ModName = "TeamComposition";
        public const string Version = "0.0.1"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "TC";
        public static TeamComposition instance { get; private set; }

        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            CustomCard.BuildCard<AdamsFirstCard>();
            instance = this;
        
        }
    }
}

