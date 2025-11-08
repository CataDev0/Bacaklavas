using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using UnityEngine;

namespace Bacaklavas.ItemGroups;

public class TomatoSoupWithPotatoGroup : CustomItemGroup
{
    public override string UniqueNameID => "cata.Bacalao.tomatosoup.potato.group";
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
                (Item)GDOUtils.GetCustomGameDataObject<TomatoSoup>().GameDataObject,
            },
            Min = 1,
            Max = 1,
            IsMandatory = true
        },
        new()
        {
            Items = new()
            {
                (Item)GDOUtils.GetCustomGameDataObject<TomatoSoup>().GameDataObject,
            },
            Min = 1,
            Max = 1,
            IsMandatory = true
        }
    };
}
