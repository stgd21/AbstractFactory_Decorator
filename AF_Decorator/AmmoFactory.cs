using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoFactory : IItemFactory
{
    public IItem Create(ItemRequirements requirements)
    {
        switch (requirements.itemSize)
        {
            case ItemSize.Small:
                return new Ammo(1f);
            case ItemSize.Medium:
                return new Ammo(1.5f);
            case ItemSize.Large:
                return new Ammo(2f);
            default:
                return new Ammo(1.5f);
        }
    }
}