using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private InputAction moveAction;
    public InputAction lookAction;
    private Transform cameraTransform;

    [SerializeField] private float moveSpeed = 5f;

    private void OnEnable()
    {
        moveAction.Enable();
        lookAction.Enable();
    }

    private void OnDisable()
    {
        moveAction.Disable();
        lookAction.Disable();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        cameraTransform = Camera.main.transform;
    }

    private void Update()
    {
        Vector2 movementInput = moveAction.ReadValue<Vector2>();

        Vector3 move = new Vector3(movementInput.x, 0f, movementInput.y) * moveSpeed;

        move = cameraTransform.forward * move.z + cameraTransform.right * move.x;
        move.y = 0f;

        transform.position += move * Time.deltaTime;
    }

    public Vector2 GetMouseDelta()
    {
        return lookAction.ReadValue<Vector2>();
    }
}
