using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [Range(0, 4)]
    public int minObstcles;

    [Range(0, 4)]
    public int maxObstcles;

    [Range(0.2f, 0.8f)]
    public float randomPLaceSpawn;


    [Range(0, 1.5f)]
    public float randomizeObstaclesOffest;

    [Range(0, 1.0f)]
    public float coinSpawningRate;

    // instance object 
    public static ObstacleSpawner instance;

    private int waveIndex = 0;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;

        // after game starts
        // spawn a new line with obstacles
    }

    // Update is called once per frame

    public void SpawnWave()
    {
        // create a new wave of obstacles
        GameObject wave = new GameObject("Wave_" + waveIndex);
        wave.transform.parent = transform; // make a child of this gameobject

    }
    
}
