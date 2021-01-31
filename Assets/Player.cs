using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed =5.0f;
    public float playerRunSpeed =7.0f;

    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        float speed = playerSpeed;
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = playerRunSpeed;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"),  Input.GetAxis("Vertical"),0);
        controller.Move(move * Time.deltaTime * speed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward =new Vector3( move.x,move.y,0)+ new Vector3(0.02f,0,0);
        }

 
        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

         controller.Move(playerVelocity * Time.deltaTime);
    }
}