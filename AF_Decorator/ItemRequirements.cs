using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Health,
    Ammo
}

public enum ItemSize
{
    Small,
    Medium,
    Large
}

public enum ItemColor
{
    None,
    Red,
    Blue
}

public class ItemRequirements
{
    public ItemType itemType;
    public ItemSize itemSize;
    public ItemColor itemColor = ItemColor.None;
}
