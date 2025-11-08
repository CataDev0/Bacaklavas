using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using UnityEngine;

namespace Bacaklavas.ItemGroups;

public class TomatoSoupGroup : CustomItemGroup
{
    public override string UniqueNameID => "cata.Bacalao.tomatosoup.group";
    public override GameObject Prefab => null;
    public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
    public override ItemCategory ItemCategory => ItemCategory.Generic;
    public override Item DisposesTo => (Item)GDOUtils.GetExistingGDO(ItemReferences.Pot);
    
    public override List<ItemGroup.ItemSet> Sets => new()
    {
        new()
        {
            Items = new()
            {
                (Item)GDOUtils.GetExistingGDO(ItemReferences.Pot),
                (Item)GDOUtils.GetExistingGDO(ItemReferences.Water),
                (Item)GDOUtils.GetExistingGDO(ItemReferences.TomatoChopped)
            },
            Min = 3,
            Max = 3,
            IsMandatory = true
        }
    };
}