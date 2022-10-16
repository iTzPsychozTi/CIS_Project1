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
    private MouseClick mouseClickScript;
    public int itemTracker;
    private ProgressBar progressBarScript;

    // Start is called before the first frame update
    void Start()
    {
        itemTracker = 0;
        mouseClickScript = GameObject.FindGameObjectWithTag("TargetItem").GetComponent<MouseClick>();
        progressBarScript = GameObject.FindGameObjectWithTag("Progress").GetComponent<ProgressBar>();

    }

    // Update is called once per frame
    void Update()
    {
        if (itemTracker == progressBarScript.collected)
        {   
            spawnTargetItems(itemTracker);
            itemTracker++;

        }
        

        //spawn the current item, if the item is "found" destroy the current game object,increment the tracker and spawn the next item
        /*for( int i=0; i<=N; i++) //<------- EVERY frame it is starting a new iteration of this loop :/
        {
            Instantiate(itemPrefab[i], spawnLocation[i].transform.position, Quaternion.Euler(0, 0, 0));
            Debug.Log( i + " item spawned" );
            // @Kailie add/call the code for:  if they find the object it gets removed from the scene
            if (mouseClickScript.found == true)
            {
                Debug.Log("communication between my script and Sim's");
                Destroy(itemPrefab[i]);
                itemTracker++;
            }
        }*/

    }

    void spawnTargetItems(int tracker)
    {
        Instantiate(itemPrefab[tracker], spawnLocation[tracker].transform.position, Quaternion.Euler(0, 0, 0));
    }


}
