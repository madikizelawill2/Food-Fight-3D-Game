

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnerPrefab;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal(){
        //randomly generate animal spawns
            int spawnerCount = Random.Range(0, spawnerPrefab.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

            Instantiate(spawnerPrefab[spawnerCount], 
            spawnPos, 
            spawnerPrefab[spawnerCount].transform.rotation);
    }
}
