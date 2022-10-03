﻿using System.Collections;
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
    bool outOfTime;
    public Text gameStatus;

    SpawnManager spawny;
    Timer timey;
    MouseClick click;
    // Start is called before the first frame update
    void Start()
    {
        won = false;
        gameOver = false;
        max = 10;
        current = 0;

        spawny = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManager>();
        timey = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
        gameStatus = GameObject.FindGameObjectWithTag("GameOverText").GetComponent<Text>();
        click = GameObject.FindGameObjectWithTag("MouseClick").GetComponent<MouseClick>();
    }

    // Update is called once per frame
    void Update()
    {
    
            getCurrentFill();
            current = click.collected;
            outOfTime = timey.outOfTime;
      
        if ( current == max)
        {
            won = true;
            gameOver = true;
            gameStatus.text = "You've Won!\n Press A to Play Again!";
        }else if (timey.outOfTime == true)
        {
            gameOver = true;
            gameStatus.text = "You've Ran out of Time!\n Press A to Restart!";
        }

        if (gameOver && Input.GetKeyDown(KeyCode.A))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
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
