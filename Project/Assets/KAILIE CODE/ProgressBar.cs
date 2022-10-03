using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Corinne Bond -> Keeps track of objects collected & if game lost/won
[ExecuteInEditMode]
public class ProgressBar : MonoBehaviour
{
    public Image mask;
    public Image fill;

    public Color color;

    public int current;
    public int max;
    public int min;

    public bool won;
    public bool gameOver;
    public Text gameStatus;

    SpawnManager spawny;
    Timer timey;
    // Start is called before the first frame update
    void Start()
    {
        won = false;
        gameOver = true;
        spawny = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManager>();
        timey = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
        gameStatus = GameObject.FindGameObjectWithTag("GameOverText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        getCurrentFill();
        max = 10;
        current = spawny.itemTracker;

        if ( current == max && !timey.outOfTime)
        {
            won = true;
            gameStatus.text = "You've Won!\n Press A to Play Again!";
        }else if (timey.outOfTime)
        {
            gameStatus.text = "You've Ran out of Time!\n Press A to Restart!";
        }
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
