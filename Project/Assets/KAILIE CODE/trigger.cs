/*
 * (Kailie Otto)
 * (Group project 1)
 * (Old unused code to test radius around objects, here for safe keeping)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public bool triggered;
    // Start is called before the first frame update
    void Start()
    {
        triggered = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        triggered = true;
        Debug.Log("entered target area");
    }

}
