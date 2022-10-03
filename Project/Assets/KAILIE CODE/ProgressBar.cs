using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ProgressBar : MonoBehaviour
{
    public Image mask;
    public Image fill;

    public Color color;

    public int current;
    public int max;
    public int min;
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
