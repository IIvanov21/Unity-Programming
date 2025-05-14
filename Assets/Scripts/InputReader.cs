using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
public class InputReader : MonoBehaviour, Controls.IPlayerActions
{
    public Vector2 movementValue;
    public Vector2 lookValue;
    private Controls controls;

    public event Action AttackEvent;
    void Start()
    {
        controls = new Controls();
        controls.Player.SetCallbacks(this);
        controls.Player.Enable();
    }

    void OnDestroy()
    {
        controls.Player.Disable();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementValue = context.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        lookValue = context.ReadValue<Vector2>();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (!context.started) return;
        AttackEvent?.Invoke();
    }
}
