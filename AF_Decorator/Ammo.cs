using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour, IItem
{
    private float _scale;
    public void Spawn()
    {
        GameObject spawn = Instantiate(Resources.Load<GameObject>("Ammo"));
        spawn.transform.localScale *= _scale;
    }

    public Ammo(float scale)
    {
        _scale = scale;
    }
}
