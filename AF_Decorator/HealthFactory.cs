using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthFactory : IItemFactory
{
    public IItem Create(ItemRequirements requirements)
    {
        switch (requirements.itemSize)
        {
            case ItemSize.Small:
                return new Health(1f);
            case ItemSize.Medium:
                return new Health(2f);
            case ItemSize.Large:
                return new Health(3f);
            default:
                return new Health(2f);
        }
    }
}
