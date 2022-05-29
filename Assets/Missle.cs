﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Enemy"))
        {
            print("파괴 " + collider.transform.name);
            collider.GetComponent<DestroyEffect>().OnDestroyEffect();

            FindObjectOfType<ScoreText>().AddScore(100);

            Destroy(collider.gameObject);
            Destroy(gameObject); // 미사일이 붙어 있는 게임오브젝트 파괴
        }
    }
}
