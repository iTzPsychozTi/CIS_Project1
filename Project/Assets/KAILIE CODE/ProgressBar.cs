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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        getCurrentFill();
    }

    void getCurrentFill()
    {
        float currentOffset = current - min;
        float maximumOffset = max - min;
        float fillAmount = (float)current / (float)max;
        mask.fillAmount = fillAmount;

        fill.color = color;
    }
}
