using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float delay = 0.2f;
    public List<Transform> positions;
    public int maxCount = 10;
    public int spawnedCount = 0;
    IEnumerator Start()
    {
        while(spawnedCount < maxCount)
        {
            var newEnemy = Instantiate(enemy);
            newEnemy.transform.position = positions[Random.Range(0, positions.Count)].position;
            spawnedCount++;
            yield return new WaitForSeconds(delay);
        }
    }
}
