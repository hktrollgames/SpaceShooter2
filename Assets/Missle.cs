using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.tag == "Enemy")
        //{
        //    print("파괴 " + collision.transform.name);
        //    Destroy(collision.gameObject);
        //}

        if (collision.CompareTag("Enemy"))
        {
            print("파괴 " + collision.transform.name);
            Destroy(collision.gameObject);
        }
    }
}
