using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitPosition : MonoBehaviour
{
    public float minY = -20;
    public float addY = 40;


    void Update()
    {
        // transform 의 y값이 minY보다 작아지면
        // addY를 더해라
        if (transform.position.y < minY)
            transform.Translate(0, addY, 0);
    }
}
