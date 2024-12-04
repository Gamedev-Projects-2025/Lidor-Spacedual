using UnityEngine;
using UnityEngine.InputSystem;

/**
 * This component moves its object when the player uses the WASD keys.
 */
public class InputMoverWASD : MonoBehaviour
{
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 10f;

    [SerializeField]
    InputAction move = new InputAction(
        type: InputActionType.Value,
        expectedControlType: nameof(Vector2));

    void Awake()
    {
        // Set bindings for WASD keys
        move.AddCompositeBinding("2DVector")
            .With("Up", "<Keyboard>/w")
            .With("Down", "<Keyboard>/s")
            .With("Left", "<Keyboard>/a")
            .With("Right", "<Keyboard>/d");
    }

    void OnEnable()
    {
        move.Enable();
    }

    void OnDisable()
    {
        move.Disable();
    }

    void Update()
    {
        Vector2 moveDirection = move.ReadValue<Vector2>();
        Vector3 movementVector = new Vector3(moveDirection.x, moveDirection.y, 0) * speed * Time.deltaTime;
        transform.position += movementVector;
        // transform.Translate(movementVector); // Uncomment this line if using relative coordinates
    }
}
