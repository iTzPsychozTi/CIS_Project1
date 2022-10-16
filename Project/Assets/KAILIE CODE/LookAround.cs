/*
 * (Kailie Otto)
 * (Group project 1)
 * (Allows player to look around. Followed tutorial and edited to better fit game
 * http://gyanendushekhar.com/2020/02/06/first-person-movement-in-unity-3d/)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    // horizontal rotation speed
    public float horizontalSpeed = 2f;
    // vertical rotation speed
    public float verticalSpeed = 2f;
    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;

        //clamps rotation
        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        cam.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
