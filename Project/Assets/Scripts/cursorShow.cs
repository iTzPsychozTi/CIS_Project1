//test, no longer using

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorShow : MonoBehaviour
{
    public bool closeEnough;

    // Start is called before the first frame update
    void Start()
    {
        closeEnough = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (closeEnough)
        {
            //gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        else if (!closeEnough)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
