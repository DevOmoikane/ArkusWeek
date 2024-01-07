using UnityEngine;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-1)]
public class InputManager : Singleton<InputManager>
{
    public delegate void TouchAction();
    public event TouchAction OnTouchAction;

    private TouchControls touchControls;

    private void Awake() {
        touchControls = new TouchControls();
    }

    private void OnEnable() {
        touchControls.Enable();
    }

    private void OnDisable() {
        touchControls.Disable();
    }

    private void Start() {
        touchControls.Touch.Mouse.performed += ctx => StartTouch(ctx);
        touchControls.Touch.TouchPress.performed += ctx => StartTouch(ctx);
        touchControls.Touch.Keyboard.performed += ctx => StartTouch(ctx);
    }

    private void StartTouch(InputAction.CallbackContext ctx) {
        if (OnTouchAction != null) {
            OnTouchAction();
        }
    }
}
