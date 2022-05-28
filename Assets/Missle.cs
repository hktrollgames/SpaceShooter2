﻿using System.Collections;
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
            //print("파괴 " + collision.transform.name);
            Destroy(collision.gameObject); // 부딛힌 대상 파괴

            Destroy(gameObject); // 미사일이 붙어 있는 게임오브젝트 파괴

            ScoreUI.instance.AddScore(100);
        }
    }
}
