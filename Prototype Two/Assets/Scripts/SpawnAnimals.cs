using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    public GameObject[] spawnAnimals;
    private float spawnRangeX = 20f;
    private float spawnRangePosZ = 20f;
    private float startDelay = 2f;
    private float intervalDelay = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay, intervalDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimals() 
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangePosZ);
            
            int indexAnimals = Random.Range(0, spawnAnimals.Length);
            Instantiate(spawnAnimals[indexAnimals], spawnPos, spawnAnimals[indexAnimals].transform.rotation);
        }
}
