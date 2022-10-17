/*
 * (Kailie, Simfara)
 * (Group project 1)
 * (Controls player clicking on objects)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    bool closeEnough;
    //public GameObject radius;
    //private trigger check;
    private float range = 3.0f;
    private Transform ob;
    private Transform player;

    //public int collected;
    public bool found;
    private ProgressBar progressBarScript;

    private cursorShow cursorShowScript;

    public ParticleSystem confetti;

    // Start is called before the first frame update
    void Start()
    {
        //collected = 0;
        closeEnough = false;
        found = false;
        ob = this.transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        progressBarScript = GameObject.FindGameObjectWithTag("Progress").GetComponent<ProgressBar>();
        cursorShowScript = GameObject.FindGameObjectWithTag("cursor").GetComponent<cursorShow>();
        //check = radius.GetComponent<trigger>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (check.triggered)
        if (Distance()< range)
        {
            Debug.Log("mouse click able to happen");
            cursorShowScript.closeEnough = true;
        }
        if (Input.GetMouseButtonDown(0))
        {
            // Destroy the gameObject after clicking on it
            if (Distance() < range)
            {
                Debug.Log("clicked");
                
                found = true;
                progressBarScript.collected += 1;
                cursorShowScript.closeEnough = false;
                Destroy(gameObject);
                ParticleSystem itemFound = Instantiate(confetti, transform.position, transform.rotation);
            }
        }
    }

   /* void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        if (closeEnough)
        {
            Debug.Log("clicked");
            Destroy(gameObject);
        }
    }*/

    private float Distance()
    {
        return Vector3.Distance(ob.position, player.position);
    }
}
