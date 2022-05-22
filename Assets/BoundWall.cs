using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundWall : MonoBehaviour
{
    public float minX = -3;
    public float maxX = 3;
    public float minY = -7;
    public float maxY = 7;
    void Update()
    {
        // 최소 최대 적용
        var pos = transform.position;

        if (pos.x < minX) pos.x = minX;
        if (pos.x > maxX) pos.x = maxX;
        if (pos.y < minY) pos.y = minY;
        if (pos.y > maxY) pos.y = maxY;

        transform.position = pos;
    }
}
