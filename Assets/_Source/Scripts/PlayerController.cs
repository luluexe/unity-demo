using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float horizontalMove;
    public float verticalMove;
    public CharacterController player;

    public float playerSpeed;

    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
    }

    //
    private void FixedUpdate()
    {
        player.Move(new Vector3(horizontalMove, 0, verticalMove) * playerSpeed * Time.deltaTime);
    }    

}
