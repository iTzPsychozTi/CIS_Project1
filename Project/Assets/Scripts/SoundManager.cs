/*
 * (Gavin Worley)
 * (Group project 1)
 * (Used to manage the sound effects of the game)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private FPMovingScript movingScript;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = gameObject.GetComponent<AudioSource>();
        movingScript = GameObject.FindObjectOfType<FPMovingScript>();

    }

    // Update is called once per frame
    void Update()
    {
        // Used to determine when the footsteps sound needs to be played
         if(movingScript.isMoving)
        { 
          if (!playerAudio.isPlaying)
          {
              playerAudio.Play();
          }
      }
      else
      {
          playerAudio.Stop();
      }
    }
}
