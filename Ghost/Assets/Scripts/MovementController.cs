using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class MovementController : MonoBehaviour {
    
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;

    HealthController healthController;

    //Layers

    [SerializeField]
    LayerMask groundLayersMask;

    //Movement

    public float moveVelocity;

    public float jumpVelocity;
    public float doublejumpVelocity;

    bool onFloor;
    bool performedDoubleJump;
    bool movementDisable;

    //Sprite Rendering

    bool facingRight;
    public bool IsFacingRight()
    {
        return facingRight;
    }

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        healthController = GetComponent<HealthController>();
    }

    // Use this for initialization
    void Start () {
        movementDisable = false;
        facingRight = true;
        SetIfInFloor();
	}

    // Update is called once per frame
    void Update () {
        SetIfInFloor();
	}

    //create a enum
    public enum Direction
    {
        Left,
        Right,
        None
    }

    public void Move(Direction direction)
    {
        if(healthController != null)
        {
            if(healthController.GetHealth() <= 0)
            {
                return;
            }
        }
        if(movementDisable)
        {
            return;
        }
        switch(direction)
        {
            case Direction.Left: rb2d.velocity = new Vector2(-moveVelocity, rb2d.velocity.y);
                break;
            case Direction.Right:
                rb2d.velocity = new Vector2(moveVelocity, rb2d.velocity.y);
                break;
            case Direction.None:
                rb2d.velocity = new Vector2(0, rb2d.velocity.y);
                break;
        }

        SetSpriteDirection(direction);
    }

    private void SetIfInFloor()
    {
        Debug.DrawLine(transform.position, (transform.position + (Vector3.down * ((spriteRenderer.bounds.size.y / 2) + 0.1f))), Color.red, 0, false);
        RaycastHit2D floorHit = Physics2D.Raycast(transform.position, Vector2.down, (spriteRenderer.bounds.size.y / 2) + 0.1f, groundLayersMask);
        onFloor = (floorHit.collider != null);
        if (onFloor) performedDoubleJump = false;
    }

    public void Jump()
    {
        if (healthController != null)
        {
            if (healthController.GetHealth() <= 0)
            {
                return;
            }
        }

        if (onFloor)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpVelocity);
        }
        else if (!performedDoubleJump)
        {
            performedDoubleJump = true;
            rb2d.velocity = new Vector2(rb2d.velocity.x, doublejumpVelocity);
        }
    }
    public void SetSpriteDirection(Direction direction)
    {
        switch (direction)
        {
            case Direction.Left:
                if (facingRight)
                {
                    FlipSprite();
                }
                break;
            case Direction.Right:
                if (!facingRight)
                {
                    FlipSprite();
                }
                break;
            default:
                break;
        }
    }

    void FlipSprite()
    {
        spriteRenderer.flipX = !spriteRenderer.flipX;
        facingRight = !facingRight;
    }

    public void Knockback(Vector3 force)
    {
        movementDisable = true;
        StartCoroutine(EnableMovement(1));

        // Debug.Log (force);
        rb2d.AddForce(force);
    }

    IEnumerator EnableMovement(float time)
    {
        yield return new WaitForSeconds(time);
        movementDisable = false;
    }
}
