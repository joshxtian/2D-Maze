using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    private AudioSource footstep;
    public bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        footstep = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      ProcessInput();  
    }

    void FixedUpdate() 
    {
        Move();
       
    }

    void ProcessInput()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;

        if (moveX != 0 || moveY != 0) {
            isMoving = true;
        } else {
            isMoving = false;
        }
        
    }

    void Move() 
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
        if(isMoving) {
            Footstep();
        }
        
    }

    private void Footstep() {
        footstep.Play();
    }
}
