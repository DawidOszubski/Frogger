using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Froggger : MonoBehaviour
{

    private Rigidbody2D rb;
    private bool moveLeft;
    private bool moveRight;
    private int horizontalMovement;
    private int speed = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        moveLeft = false;
        moveRight = false;
    }



    public void PointerDownLeft()
    {
        moveLeft = true;
    }


    public void PointerUpLeft()
    {
        moveLeft = false;
    }


    public void PointerDownRight()
    {
        moveRight = true;
    }


    public void PointerUpRight()
    {
        moveRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        MovementFrogger();
    }


    public void MovementFrogger()
    {
        if (moveLeft)
        {
            horizontalMovement = -speed;
        }
        else if (moveRight)
        {
            horizontalMovement = speed;
        }
        else
        {
            horizontalMovement = 0;
        }
    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMovement, rb.velocity.y);
    }
}
