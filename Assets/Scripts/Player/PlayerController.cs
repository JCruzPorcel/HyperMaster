using UnityEngine;
using UnityEngine.InputSystem;
using Unity.VectorGraphics;
using System.IO;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Vector2 direction;

public void GetDirection(InputAction.CallbackContext ctx)
    {
        direction = new Vector2(ctx.ReadValue<Vector2>().x, 0f);
    }

    private void OnMove()
    {
        Vector2 movement = direction * speed * Time.fixedDeltaTime;
        transform.position += (Vector3)movement;
    }

    private void FixedUpdate()
    {
        OnMove();
    }
}
