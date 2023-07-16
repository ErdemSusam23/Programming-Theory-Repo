using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> enemyPrefab;

    float spawnRange = 45f;
    int index;
    public int waveNumber=1;
    public int enemyCount;

    private void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (enemyCount == 0) 
        {
            
            SpawnWave(waveNumber);
            waveNumber++;
        }
    }

    private Vector3 RandomSpawnPos() 
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 2.5f, spawnPosZ);
        return randomPos;
    }

    void SpawnWave(int waveNumber)
    {
        int enemiesToSpawn = Mathf.FloorToInt((waveNumber + 1) * Mathf.Sqrt(waveNumber));
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            index = Random.Range(0, 2);
            Instantiate(enemyPrefab[index], RandomSpawnPos(), enemyPrefab[index].transform.rotation);
        }
        waveNumber++;
    }
}
