using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public Player player;

    public PlayerControls playerControls;

    private void OnEnable()
    {
        playerControls = new PlayerControls();

        playerControls.Gameplay.Enable();

        playerControls.Gameplay.Move.performed += OnMove;
        playerControls.Gameplay.Jump.started += OnJump;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        player.onMove?.Invoke(context.ReadValue<Vector2>());
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        player.onJump?.Invoke();
    }

    private void OnDisable()
    {
        playerControls.Gameplay.Move.performed -= OnMove;
        playerControls.Gameplay.Jump.started -= OnJump;

        playerControls.Gameplay.Disable();
    }
}
