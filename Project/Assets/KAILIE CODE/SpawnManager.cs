/*
 * (Simfara, Kailie)
 * (Group project 1)
 * (Spawns objects one at a time)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public const int N = 9;
    public GameObject[] itemPrefab;
    public Transform[] spawnLocation;

    public int itemTracker;

    // Start is called before the first frame update
    void Start()
    {
        itemTracker = 0;
        spawnTargetItems();
    }

    // Update is called once per frame
    void Update()
    {
        //if the current item has been "found" destroy the current game object,increment the tracker and spawn the next item
        if(itemTracker <= N)
        {
            itemTracker++;
            spawnTargetItems();
        }
       

    }
    void spawnTargetItems()
    {

        Instantiate(itemPrefab[itemTracker], spawnLocation[itemTracker].transform.position, Quaternion.Euler(0, 0, 0));
    }
}
