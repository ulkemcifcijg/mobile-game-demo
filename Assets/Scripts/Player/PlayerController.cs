using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float maxAllowedSpeed = 10.0f;

    public void Move(Vector3 direction)
    {
        if (moveSpeed > maxAllowedSpeed)
        {
            Debug.LogWarning("Speed hack detected! Resetting to normal.");
            moveSpeed = 5.0f;
        }
        transform.position += direction * moveSpeed * Time.deltaTime;
    }
}
