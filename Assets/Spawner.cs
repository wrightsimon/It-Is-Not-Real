using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject spawnee;

    public float respawnDelay;

    bool spawnReady;
    [SerializeField]
    float currentTime; 
    Transform nextSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        EventHandler.OnEnemyDied += Respawn;
    }

    void Update() {
        if (spawnReady) {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0) {
                Spawn(nextSpawnPoint);
            }
        }
    }

    void Respawn()
    {
        Debug.Log("Preparing to respawn: " + spawnee.name);
        //start timer for respawn
        //select a spawnpoint at random
        spawnReady = true;
        currentTime = respawnDelay;
        nextSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
    }

    void Spawn(Transform spawnPoint)
    {
        Debug.Log("Now spawning: " + spawnee.name);
        Instantiate(spawnee, spawnPoint.position, Quaternion.identity, this.transform);
        
        spawnReady = false;
    }
}
