using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player2Ctrl : MonoBehaviour
{
    PlayerInputActions inputActions;
    Animator animator;
    Vector2 vec2;
    Rigidbody2D rb;               

    public int player2MoveSpeed;
    public int jumpForce;

    bool isJumped = false;

    readonly int inputX_String = Animator.StringToHash("InputX");

    void Awake()
    {
        inputActions = new PlayerInputActions();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        inputActions.Player2.Enable();
        inputActions.Player2.Move.performed += OnMove;
        inputActions.Player2.Move.canceled += OnMove;

        inputActions.Player2.Jump.performed += OnJump;
        inputActions.Player2.Jump.canceled += OnJump;
    }

    void OnDisable()
    {
        inputActions.Player2.Move.canceled -= OnMove;
        inputActions.Player2.Move.performed -= OnMove;

        inputActions.Player2.Jump.canceled -= OnJump;
        inputActions.Player2.Jump.performed -= OnJump;
        inputActions.Player2.Disable();
    }

    void Update()
    {
        transform.Translate(Time.deltaTime * player2MoveSpeed * vec2);
    }

    void OnMove(InputAction.CallbackContext context)
    {
        vec2=context.ReadValue<Vector2>();

        animator.SetFloat(inputX_String, vec2.x);
    }

    void OnJump(InputAction.CallbackContext context)
    {
        if(context.performed && !isJumped)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            isJumped = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("GROUND"))
        {
            isJumped = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("DOUBLEJUMP"))
        {
            isJumped = false;
        }
    }
}
