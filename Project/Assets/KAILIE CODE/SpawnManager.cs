﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    const int N = 10; // 10 items to be collected
    public GameObject[] itemPrefab = new GameObject[N];
    public Transform[] spawnLocation;

    int itemTracker = 0;

    private MouseClick mouseClickScript;

    // Start is called before the first frame update
    void Start()
    {
        spawnTargetItems();
    }

    // Update is called once per frame
    void Update()
    {
        
        //if the current item has been "found" destroy the current game object,increment the tracker and spawn the next item
        if(true)
        {
            //Destroy(itemPrefab[itemTracker]);
            itemTracker++;
            spawnTargetItems();
        }
       

    }
    void spawnTargetItems()
    {

        Instantiate(itemPrefab[itemTracker], spawnLocation[itemTracker].transform.position, Quaternion.Euler(0, 0, 0));
    }
}