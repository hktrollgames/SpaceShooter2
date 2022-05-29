using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEffect : MonoBehaviour
{
    public GameObject effect;
    private void OnDestroy()
    {
        effect.transform.position = transform.position; // 비행기 위치를 이펙트 위치에 넣는다.
        Instantiate(effect);
    }
}
