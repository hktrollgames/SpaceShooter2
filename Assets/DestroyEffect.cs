using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEffect : MonoBehaviour
{
    public GameObject effect;
    private void OnDestroy()
    {
        var newEffect = Instantiate(effect);
        newEffect.transform.position = transform.position;
    }
}
