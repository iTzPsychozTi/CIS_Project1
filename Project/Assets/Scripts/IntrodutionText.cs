/* (Kyree Richardson)
 * (Project 1)
 * (Displays the objective of the game)
 * 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntrodutionText : MonoBehaviour
{
    public Text introText;
    // Start is called before the first frame update
    void Start()
    {
        //disables text after 10 seconds
        Invoke("DisableText", 10f);
    }

   void DisableText()
    {
        introText.enabled = false;
    }
}
