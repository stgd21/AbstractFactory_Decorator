using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItemFactory
{
    IItem Create(ItemRequirements requirements);
}
