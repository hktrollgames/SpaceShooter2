using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByPositionY : MonoBehaviour
{
    public float maxY  = 10;
    public float minY = -10;

    void Update()
    {
        float y = transform.position.y;

        if (y > maxY)
            Destroy(gameObject);
        else if (y < minY)
            Destroy(gameObject);
    }
}
