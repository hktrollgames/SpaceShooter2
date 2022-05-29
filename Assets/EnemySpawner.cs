using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<Transform> pos;
    public float interval = 0.5f;
    public GameObject enemy;

    IEnumerator Start()
    {
        while (true)
        {
            var item = pos[Random.Range(0, pos.Count)];

            float randomInterval = Random.Range(0, interval);
            yield return new WaitForSeconds(randomInterval);
            print(item);


            Instantiate(enemy, item.transform.position, item.transform.rotation);
        }
    }
}
