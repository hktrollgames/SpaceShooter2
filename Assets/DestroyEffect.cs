using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEffect : MonoBehaviour
{
    public GameObject effect;
    public void OnDestroyEffect()
    {
        // 비행기 위치를 이펙트 위치에 넣는다.
        var newEffect = Instantiate(effect);
        newEffect.transform.position = transform.position;
    }
}
