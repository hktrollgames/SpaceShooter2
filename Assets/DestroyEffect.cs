using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEffect : MonoBehaviour
{
    public GameObject effect;
    private void OnDestroy()
    {
        if (gameObject.activeSelf == false)
            return;

        var newEffect = Instantiate(effect);
        newEffect.transform.position = transform.position;
    }
}
