using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;

    public GameObject blockPrefab;

    public float timeBetweenWaves = 2f;

    private float timeToSpawn = 2f;

    void Update()
    {
        if(Time.time >= timeToSpawn){
        SpawnBlocks();
        timeToSpawn = Time.time + timeBetweenWaves;
        ScoreScript.scoreValue = ScoreScript.scoreValue + 4;
        }

    }
        void SpawnBlocks()
        {
            int randomIndex = Random.Range(0, spawnPoints.Length);

            for (int i = 0;i<spawnPoints.Length; i++){
                    if(randomIndex != i){
                        Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
                    }
            }
        }
}
