using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMove : MonoBehaviour
{
    public float speed = 1;
    void Update()
    {
        // W키 누르면 로그를 찍자.
        if (Input.GetKey(KeyCode.W))
            transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
