using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using UnityEngine;

namespace Bacaklavas.ItemGroups;

public class BacalaoRaw : CustomItemGroup
{
    public override string UniqueNameID => "cata.Bacalao.raw.group";
    public override GameObject Prefab => null;
    public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
    public override Item DisposesTo => (Item)GDOUtils.GetExistingGDO(ItemReferences.Pot);
    
    public override List<ItemGroup.ItemSet> Sets => new()
    {
        new()
        {
            Items = new()
            {
                (Item)GDOUtils.GetExistingGDO(ItemReferences.Pot)
            },
            Min = 1,
            Max = 1,
            IsMandatory = true
        },
        new ()
        {
            Items = new()
            {   
                (Item)GDOUtils.GetExistingGDO(ItemReferences.Water),
                (Item)GDOUtils.GetExistingGDO(ItemReferences.TomatoChopped),
                (Item)GDOUtils.GetExistingGDO(ItemReferences.FishFilletRaw),
                (Item)GDOUtils.GetExistingGDO(ItemReferences.PotatoChopped) 
            },
            Min = 4,
            Max = 4,
            IsMandatory = true
        }
    };
    public override List<Item.ItemProcess> Processes => new()
    {
        new Item.ItemProcess
        {
            Process = (Process)GDOUtils.GetExistingGDO(ProcessReferences.Cook),
            Duration = 2,
            Result = (Item)GDOUtils.GetCustomGameDataObject<BacalaoCooked>().GameDataObject,
        }
    };
}