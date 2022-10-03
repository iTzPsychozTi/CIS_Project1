using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Corinne Bond -> Controls UI Timer that tells user how much time is left
public class Timer : MonoBehaviour
{
    public float timeValue;
    public Text timerText;
    public bool outOfTime;

    private void Start()
    {
        timeValue = 600;
        outOfTime = false;
    }

    void Update()
    {
        if(timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }

        displayTime(timeValue);
        //restart timer -> continue gives 5 more minutes, restart gives the full 10

        if (timeValue <= 0)
        {
            outOfTime = true;
        }
         
    }

    //converts time (sec) to mins and sec
    void displayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float min = Mathf.FloorToInt(timeToDisplay / 60);
        float sec = Mathf.FloorToInt(timeToDisplay % 60);
                                         
        timerText.text = string.Format("Time Remaining: \n {0:00}:{1:00}", min, sec);
    }

}
