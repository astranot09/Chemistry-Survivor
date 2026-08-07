using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public void OnMove(InputAction.CallbackContext ctx)
    {
        Vector2 dir = ctx.ReadValue<Vector2>();
    }
    public void OnInteract(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {

        }
    }
}
