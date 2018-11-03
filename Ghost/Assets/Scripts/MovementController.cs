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
        }
    }

    private void SetIfInFloor()
    {
        throw new NotImplementedException();
    }
}
