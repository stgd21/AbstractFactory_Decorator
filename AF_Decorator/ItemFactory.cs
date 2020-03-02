using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFactory : AbstractItemFactory
{
    private readonly IItemFactory _factory;
    private readonly ItemRequirements _requirements;

    public ItemFactory(ItemRequirements requirements)
    {
        switch (requirements.itemType)
        {
            case ItemType.Ammo:
                _factory = new AmmoFactory();
                break;
            case ItemType.Health:
                _factory = new HealthFactory();
                break;
        }
        _requirements = requirements;
    }

    public override IItem Create()
    {
        return _factory.Create(_requirements);
    }
}
