using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public int hp = 1;

    internal void OnDamge(int power)
    {
        hp -= power;

        if(hp <= 0)
        {
            GetComponent<DestroyEffect>();
            Destroy(gameObject);
        }
    }
}
