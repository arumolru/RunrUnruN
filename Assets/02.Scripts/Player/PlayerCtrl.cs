using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCtrl : MonoBehaviour
{
    PlayerInputActions inputActions;
    Rigidbody2D rb;
    Vector2 vec2;
    Vector2 jumpvec2;
    Animator anim;

    readonly int inputX_String = Animator.StringToHash("InputX");
    readonly int isJumping_String = Animator.StringToHash("isJump");

    public float moveSpeed;
    public float jumpForce;

    private bool isJump = false;

    void Awake()
    {
        inputActions = new PlayerInputActions();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void OnEnable()
    {
        inputActions.Player.Enable();
        inputActions.Player.Move.performed += OnMove;
        inputActions.Player.Move.canceled += OnMove;

        inputActions.Player.Jump.performed += OnJump;
        inputActions.Player.Jump.canceled += OnJump;
    }

    void OnDisable()
    {
        inputActions.Player.Move.canceled -= OnMove;
        inputActions.Player.Move.performed -= OnMove;

        inputActions.Player.Jump.canceled -= OnJump;
        inputActions.Player.Jump.performed -= OnJump;
        inputActions.Player.Disable();
    }

    void Update()
    {
        transform.Translate(Time.deltaTime * moveSpeed * vec2);
    }

    void OnMove(InputAction.CallbackContext context)
    {
        vec2 = context.ReadValue<Vector2>();

        anim.SetFloat(inputX_String, vec2.x);
    }

    void OnJump(InputAction.CallbackContext context)
    {
        if(context.performed && !isJump)
        {
            anim.SetBool(isJumping_String, true);
            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            isJump = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("GROUND"))
        {
            isJump = false;
            anim.SetBool(isJumping_String, false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("DOUBLEJUMP"))
        {
            isJump = false;
        }
    }
}
