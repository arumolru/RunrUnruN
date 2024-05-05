using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{   
    public GameObject pauseUI;

    PlayerInputActions inputActions;

    private void Awake()
    {
        inputActions = new PlayerInputActions();
        pauseUI.SetActive(false);
    }

    private void OnEnable()
    {
        inputActions.Pause.Enable();
        inputActions.Pause.Stop.performed += OnPause;
        inputActions.Pause.Stop.canceled += OnPause;
    }

    private void OnDisable()
    {
        inputActions.Pause.Stop.canceled -= OnPause;
        inputActions.Pause.Stop.performed -= OnPause;
        inputActions.Pause.Disable();
    }

    void OnPause(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            pauseUI.SetActive(!pauseUI.activeSelf);
        }
    }
}
