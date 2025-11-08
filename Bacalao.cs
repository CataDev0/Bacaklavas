using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using UnityEngine;

namespace Bacaklavas;

public class Bacalao : CustomDish
{
    public sealed override DishType Type => DishType.Main;
    public sealed override bool IsAvailableAsLobbyOption => true;
    public sealed override bool IsUnlockable => false;
    public override string UniqueNameID => "cata.Bacalao.dish";
    
    public sealed override List<string> StartingNameSet =>
    [
        "The dry fish",
        "Hefty cook pot",
        "Port Royal"
    ];
    
    // MinimumIngredients is used to decide which Items ( And providers ) will spawn when selecting this Dish.
    public override HashSet<Item> MinimumIngredients =>
    [
        (Item)GDOUtils.GetExistingGDO(ItemReferences.Tomato),
        (Item)GDOUtils.GetExistingGDO(ItemReferences.Potato),
        (Item)GDOUtils.GetExistingGDO(ItemReferences.Water),
        (Item)GDOUtils.GetExistingGDO(ItemReferences.Pot),
        (Item)GDOUtils.GetExistingGDO(ItemReferences.FishFilletRaw)
    ];

    // RequiredProcesses is used to decide which Appliances to spawn when selecting this Dish.
    public override HashSet<Process> RequiredProcesses =>
    [
        (Process)GDOUtils.GetExistingGDO(ProcessReferences.Chop),
        (Process)GDOUtils.GetExistingGDO(ProcessReferences.Cook)
    ];
    
    // ResultingMenuItems is used to decide what Items Customers can order when this Dish is selected.
    public override List<Dish.MenuItem> ResultingMenuItems =>
    [
        new()
        {
            Item = (Item)GDOUtils.GetCustomGameDataObject<BacalaoCooked>().GameDataObject,
            Phase = MenuPhase.Main,
            Weight = 1.0f
        }
    ];
    
    // // InfoList is used to add localization to the Appliance.
    public override List<(Locale, UnlockInfo)> InfoList =>
    [
        (Locale.English,
            LocalisationUtils.CreateUnlockInfo("Bacalao", "Portuguese dried cod in tomato soup, with potatoes.",
                "Looks tasty... yum."))
    ];

    // Recipe is used to display the Recipe text when selecting this Dish.
    public override Dictionary<Locale, string> Recipe => new()
    {
        {
            Locale.Default,
            "Chop potatoes and tomatoes, Add fish, Boil in water, Serve!"
        },
        {
            Locale.English,
            "Chop potatoes and tomatoes, Add fish, Boil in water, Serve!"
        }
    };

    // RequiredDishItem is used to decide what this Dish uses as a permanent Item ( ie. Plates )
    public override Item RequiredDishItem => (Item)GDOUtils.GetExistingGDO(ItemReferences.Pot);
    
    // ColourOverride is used to override the pre-defined Colour in CardType.
    public override Color ColourOverride => new Color(0.96f, 0.59f, 0.19f);
}

// Tomato soup base
public class TomatoSoup : CustomItem
{
    public override string UniqueNameID => "cata.Bacalao.tomatosoup";
    public override GameObject Prefab => null; // TODO: Add prefab for 3D model
}

// Tomato soup + potato
public class TomatoSoupWithPotato : CustomItem
{
    public override string UniqueNameID => "cata.Bacalao.tomatosoup.potato";
    public override GameObject Prefab => null; // TODO: Add prefab for 3D model
}

// Tomato soup + potato + fish (uncooked)
public class BacalaoUncooked : CustomItem
{
    public override string UniqueNameID => "cata.Bacalao.uncooked";
    public override GameObject Prefab => null; // TODO: Add prefab for 3D model
}

// Final cooked dish
public class BacalaoCooked : CustomItem
{
    public override string UniqueNameID => "cata.Bacalao.cooked";
    public override GameObject Prefab => null; // TODO: Add prefab for 3D model

    // public override Item SplitSubItem = (Item)GDOUtils.GetExistingGDO(ItemReferences.Pot);
}
