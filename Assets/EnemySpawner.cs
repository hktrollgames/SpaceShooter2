using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<Transform> pos;
    public float interval = 0.5f;
    public GameObject enemy;
    public GameObject boss;
    public int enemyHp = 1;
    public int bossHp = 3;

    public int smallEnemyCount = 10;
    int spawnedSmallEnemyCount = 0;

    int wave = 0;
    IEnumerator Start()
    {
        while (true)
        {
            // todo : ui로 표시하자.
            print(wave + "시작");
            wave++;
            spawnedSmallEnemyCount = 0;
            // 쫄병 스폰
            while (spawnedSmallEnemyCount < smallEnemyCount)
            {
                var item = pos[Random.Range(0, pos.Count)];

                float randomInterval = Random.Range(0, interval);
                yield return new WaitForSeconds(randomInterval);
                print(item);


                var enemyGo = Instantiate(enemy, item.position, item.rotation);
                spawnedSmallEnemyCount++;
                enemyGo.GetComponent<SpaceShip>().hp = wave * enemyHp;
            }

            //보스 스폰
            var bossSpawnPos = pos[Random.Range(0, pos.Count)];
            var BossGo = Instantiate(boss, bossSpawnPos.position, bossSpawnPos.rotation);
            BossGo.GetComponent<SpaceShip>().hp = wave * bossHp;
        }
    }
}
