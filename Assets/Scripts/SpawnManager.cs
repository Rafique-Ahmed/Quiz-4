using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float SpawnRange = 4;
    public int enemyCount;

    public int waveNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    private Vector3 GenerateSpawnPosition() { 
        float spawnPosX = Random.Range(-SpawnRange, SpawnRange);
        float spawnPosZ = Random.Range(2, 4);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    void  SpawnEnemyWave(int enemiesToSpawn){
        for(int i = 0; i < enemiesToSpawn; i++){
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
            }
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if(enemyCount == 0){
            waveNumber++;
            SpawnEnemyWave(waveNumber);
        }
    }
}
