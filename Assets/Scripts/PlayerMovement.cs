using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    private Animator animator;
    private Rigidbody2D playerRigidBody2D;

    void Start()
    {
        animator = GetComponent<Animator>();
        //SetAnimatorMovement(direction);
        //playerRigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Awake()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        playerRigidBody2D = GetComponent<Rigidbody2D>();
    }
   

    // Update is called once per frame
    void Update()
    {
        TakeInput();
        Move();
        //SetAnimatorMovement(direction);
    }

    private void Move()
    {
        playerRigidBody2D.MovePosition(transform.position + (Vector3)(direction * speed * Time.fixedDeltaTime));
    } 
    /*    private void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    */
    private void TakeInput()
    {
        direction = Vector2.zero;
        if(Keyboard.current.wKey.isPressed)
        {
            direction += Vector2.up;
        }
        if(Keyboard.current.aKey.isPressed)
        {
            direction += Vector2.left;
        }
        if(Keyboard.current.sKey.isPressed)
        {
            direction += Vector2.down;
        }
        if(Keyboard.current.dKey.isPressed)
        {
            direction += Vector2.right;
        }
    }

/*
    private void SetAnimatorMovement(Vector2 direction)
    {
        animator.SetFloat("xDir", direction.x);
        animator.SetFloat("yDir", direction.y);
        print(animator.GetFloat("xDir"));
    }
    */
}
