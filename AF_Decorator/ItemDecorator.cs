using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class ItemDecorator : MonoBehaviour, IItem
{
    public string flagSpawnName;
    protected IItem newItem;

    public virtual void Spawn()
    {
        GameObject flagSpawn = Instantiate(Resources.Load<GameObject>(flagSpawnName));
        //return flagSpawn;
        newItem.Spawn();
    }
}

public class RedDecorator : ItemDecorator
{
    private string redSpawnName = "RedFlag";

    public RedDecorator(IItem item)
    {
        flagSpawnName = redSpawnName;
        newItem = item;
        base.Spawn();
    }
}

public class BlueDecorator : ItemDecorator
{
    private string blueSpawnName = "BlueFlag";

    public BlueDecorator(IItem item)
    {
        flagSpawnName = blueSpawnName;
        newItem = item;
        base.Spawn();
    }
}

