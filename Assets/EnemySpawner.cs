using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<Transform> pos;
    public float interval = 0.5f;
    public GameObject enemy;
    public GameObject boss;

    public int smallEnemyCount = 10;
    int spawnedSmallEnemyCount = 0;
    IEnumerator Start()
    {
        // 쫄병 스폰
        while (spawnedSmallEnemyCount < smallEnemyCount)
        {
            var item = pos[Random.Range(0, pos.Count)];

            float randomInterval = Random.Range(0, interval);
            yield return new WaitForSeconds(randomInterval);
            print(item);


            Instantiate(enemy, item.position, item.rotation);
            spawnedSmallEnemyCount++;
        } 

        //보스 스폰
        var bossSpawnPos = pos[Random.Range(0, pos.Count)];
        Instantiate(boss, bossSpawnPos.position, bossSpawnPos.rotation);
    }
}
