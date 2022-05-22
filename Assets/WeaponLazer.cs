using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLazer : MonoBehaviour
{
    public GameObject missile;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newMissile = Instantiate(missile);
            newMissile.transform.position = transform.position;
        }
    }
}
