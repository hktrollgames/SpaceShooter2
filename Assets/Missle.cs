using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour
{
    public int power =1;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Enemy"))
        {
            print("파괴 " + collider.transform.name);
            collider.GetComponent<SpaceShip>().OnDamge(power);

            FindObjectOfType<ScoreText>().AddScore(100);

            //Destroy(collider.gameObject);
            Destroy(gameObject); // 미사일이 붙어 있는 게임오브젝트 파괴
        }
    }
}
