using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController2D controller;

	public float runSpeed = 40f;

	//[SerializeField] UnityEvent OnChunkThresholdPassedEvent;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	//private Chunk activeChunk;

   void Start()
    {
		
	}

    // Update is called once per frame
    void Update()
	{

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
		}

		//if (Input.GetButtonDown("Crouch"))
		//{
		//	crouch = true;
		//}
		//else if (Input.GetButtonUp("Crouch"))
		//{
		//	crouch = false;
		//}

		
		
	}

	void FixedUpdate()
	{
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}

}
