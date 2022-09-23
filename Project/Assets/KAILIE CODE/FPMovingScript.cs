﻿/*
 * (Kailie Otto)
 * (Group project 1)
 * (Allows player to move around. Followed tutorial and edited to better fit game
 * http://gyanendushekhar.com/2020/02/06/first-person-movement-in-unity-3d/)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPMovingScript : MonoBehaviour
{
	CharacterController characterController;
	public float MovementSpeed = 2;
	public float Gravity = 9.8f;
	private float velocity = 0;

	private Camera cam;

	private void Start()
	{
		characterController = GetComponent<CharacterController>();
		cam = Camera.main;
	}

	void Update()
	{

		// player movement - forward, backward, left, right
		float horizontal = Input.GetAxis("Horizontal") * MovementSpeed;
		float vertical = Input.GetAxis("Vertical") * MovementSpeed;
		characterController.Move((cam.transform.right * horizontal + cam.transform.forward * vertical) * Time.deltaTime);

		// Gravity (Do we need this in our game? Discuss with group)
		if (characterController.isGrounded)
		{
			velocity = 0;
		}
		else
		{
			velocity -= Gravity * Time.deltaTime;
			characterController.Move(new Vector3(0, velocity, 0));
		}
	}
}