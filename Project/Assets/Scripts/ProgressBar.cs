/*
 * (Corinne, Kailie)
 * (Group project 1)
 * (Controls progress bar)
 */

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

    public int collected;

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
        collected = 0;
        min = 0;

        spawny = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManager>();
        timey = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
        gameStatus = GameObject.FindGameObjectWithTag("GameOverText").GetComponent<Text>();
        click = GameObject.FindGameObjectWithTag("MouseClick").GetComponent<MouseClick>();
    }

    // Update is called once per frame
    void Update()
    {

            current = collected;
            Debug.Log(current);
            getCurrentFill();
            outOfTime = timey.outOfTime;
      
        if ( current == max)
        {
            won = true;
            gameOver = true;
            gameStatus.text = "You've Found All 10 Items!\n Press A to Play Again!";
        }else if (timey.outOfTime == true)
        {
            gameOver = true;
            gameStatus.text = "You Ran out of Time!\n Press A to Restart!";
        }

        if (gameOver && Input.GetKeyDown(KeyCode.A))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }
    }

    void getCurrentFill()
    {
        //float currentOffset = current - min;
        //sfloat maximumOffset = max - min;
        float fillAmount = (float)current / (float)max; 
        mask.fillAmount = fillAmount;

        fill.color = color;
    }
}
