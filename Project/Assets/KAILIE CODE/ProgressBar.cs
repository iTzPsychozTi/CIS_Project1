using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Corinne Bond -> Tracks progress of how many objects have been collected

[ExecuteInEditMode] 
public class ProgressBar : MonoBehaviour
{
    public int max;
    public int min;
    public int current;
    public Image mask;
    public Image fill;
    public Color color;
    public SpawnManager spawnManager;
    public int currentObjectCount;
    public int totalCount;


    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManager>();
        totalCount = 10;    
    }

    // Update is called once per frame
    void Update()
    {
        currentObjectCount = spawnManager.itemTracker;
        getCurrentFill();
    }

    void getCurrentFill()
    {
        //float currentOffset = current - min;
        //float maximumOffset = max - min;
        float fillAmount = (float) currentObjectCount / (float) totalCount;
        mask.fillAmount = fillAmount;

        fill.color = color;
    }
}
