﻿/*
 * (Kailie Otto)
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
    private float range = 5.0f;
    private Transform ob;
    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        closeEnough = false;
        ob = this.transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //check = radius.GetComponent<trigger>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (check.triggered)
        /*if (Distance()< range)
        {
            Debug.Log("mouse click able to happen");
           closeEnough = true;
        }*/
        if (Input.GetMouseButtonDown(0))
        {
            // Destroy the gameObject after clicking on it
            if (Distance() < range)
            {
                Debug.Log("clicked");
                Destroy(gameObject);
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
