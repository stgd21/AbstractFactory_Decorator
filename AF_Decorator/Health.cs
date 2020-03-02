using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour, IItem
{
    private float _scale;
    public void Spawn()
    {
        GameObject spawn = Instantiate(Resources.Load<GameObject>("Health"));
        spawn.transform.localScale *= _scale;
    }

    public Health(float scale)
    {
        _scale = scale;
    }
}
