using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{

    float horizontalMove;
    float verticalMove;
    public CharacterController character;

    public float playerSpeed;

    public float jumpForce = 8.0f;
    public float gravity = 20.0f;

    Vector3 moveDirection = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        //jump       
        if (Input.GetButton("Jump"))
        {
            moveDirection = new Vector2(0, verticalMove);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= playerSpeed;
            moveDirection.y = jumpForce;
            
        }       
            moveDirection.y -= gravity * Time.deltaTime;
            character.Move(moveDirection * Time.deltaTime);
    }

    //
    private void FixedUpdate()
    {
        character.Move(new Vector3(horizontalMove, 0, verticalMove) * playerSpeed * Time.deltaTime);
    }    

}