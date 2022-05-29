using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLazer : MonoBehaviour
{
    public GameObject missile;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireMissile();
        }
    }

    public void FireMissile()
    {
        GameObject newMissile = Instantiate(missile);
        newMissile.transform.position = transform.position;
    }

}
