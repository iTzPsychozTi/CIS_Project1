using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    bool closeEnough;
    public GameObject radius;
    private trigger check;

    // Start is called before the first frame update
    void Start()
    {
        closeEnough = false;
        check = radius.GetComponent<trigger>();
    }

    // Update is called once per frame
    void Update()
    {
        if (check.triggered)
        {
            Debug.Log("mouse click able to happen");
            closeEnough = true;
        }
    }

    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        if (closeEnough)
        {
            Debug.Log("clicked");
            Destroy(gameObject);
        }
    }
}
