using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //    //public float speed = 0.1f;
    //    void Update()
    //    {
    //        // 밑으로 움직이게 하고 싶다.
    //        // transform 의 y 값을 점점 빼고 싶다.
    //        //Vector3 pos = transform.position;
    //        //pos.y -= speed;
    //        //transform.position = pos;


    //        //transform.Translate(0, speed, 0);
    //    }
    public Vector3 translation;
    private void Update()
    {
        transform.Translate(translation * Time.deltaTime);
    }
}
