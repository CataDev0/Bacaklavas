using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using UnityEngine;

namespace Bacaklavas;

public class Baklava : CustomDish
{
    public sealed override DishType Type => DishType.Dessert;
    public override string UniqueNameID => "cata.Baklava.dessert";
    public sealed override List<string> StartingNameSet =>
    [
        "Delights and pastries",
        "Sweet layers"
    ];
    
    // MinimumIngredients - what ingredients are needed for this dish
    public override HashSet<Item> MinimumIngredients =>
    [
        (Item)GDOUtils.GetExistingGDO(ItemReferences.Flour),
        (Item)GDOUtils.GetExistingGDO(ItemReferences.Sugar),
        (Item)GDOUtils.GetExistingGDO(ItemReferences.Egg)
    ];
    
    // RequiredProcesses - what appliances/processes are needed
    public override HashSet<Process> RequiredProcesses => [(Process)GDOUtils.GetExistingGDO(ProcessReferences.Cook)];
    
    // Recipe description
    public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
    {
        { Locale.English, "Mix flour, eggs, and sugar, Bake until golden, Serve!" }
    };
    
    // Localization
    public override List<(Locale, UnlockInfo)> InfoList =>
    [
        (Locale.English, LocalisationUtils
            .CreateUnlockInfo("Baklava", "Sweet layered pastry dessert.", "A classic treat!"))
    ];
    
    // What item/plate is used to serve
    public override Item RequiredDishItem => (Item)GDOUtils.GetExistingGDO(ItemReferences.Plate);
    
    // Color theme
    public override Color ColourOverride => new Color(0.96f, 0.87f, 0.70f);
    
    // Menu items - commented out until you create the custom Baklava item
    public override List<Dish.MenuItem> ResultingMenuItems =>
    [
        new Dish.MenuItem
        {
            Item = (Item)GDOUtils.GetCustomGameDataObject<BaklavaCooked>().GameDataObject,
            Phase = MenuPhase.Dessert,
            Weight = 1.0f
        }
    ];
}

public class BaklavaCooked : CustomItem
{
    public override string UniqueNameID => "cata.Baklava.cooked";
    public override GameObject Prefab => null; // TODO: Add prefab for 3D model
}