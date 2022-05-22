using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMove : MonoBehaviour
{
    public float speed = 5;
    void Update()
    {
        // W키 누르면 로그를 찍자.
        if (Input.GetKey(KeyCode.W))
            transform.Translate(0, speed * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(0, -speed * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
