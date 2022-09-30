using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Corinne Bond -> Controls UI Timer that tells user how much time is left
public class Timer : MonoBehaviour
{
    public float timeValue = 600;
    public Text timerText;


    void Update()
    {
        if(timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }

        displayTime(timeValue);
        //restart timer -> continue gives 5 more minutes, restart gives the full 10
         
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
