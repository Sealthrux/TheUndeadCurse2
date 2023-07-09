using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Vector3 spawnAreaCenter;
    public Vector3 spawnAreaSize;
    public float minSpawnInterval = 1f;
    public float maxSpawnInterval = 3f;
    public int maxEnemies;

    private int enemyCount = 0;

    private void Start()
    {
        Invoke("SpawnEnemy", Random.Range(minSpawnInterval, maxSpawnInterval));
    }

    private void SpawnEnemy()
    {
        if (enemyCount < maxEnemies)
        {
            Vector3 spawnPosition = spawnAreaCenter + new Vector3(
                Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2),
                Random.Range(-spawnAreaSize.y / 2, spawnAreaSize.y / 2),
                Random.Range(-spawnAreaSize.z / 2, spawnAreaSize.z / 2)
            );

            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            enemyCount++;
        }

        Invoke("SpawnEnemy", Random.Range(minSpawnInterval, maxSpawnInterval));
    }
}
