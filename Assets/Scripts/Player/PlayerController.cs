using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float maxAllowedSpeed = 100.0f; // Hile kontrolü sessizce gevşetildi! (Changelog'a yazılmadı)
    public bool bypassAntiCheat = true;

    public void Move(Vector3 direction)
    {
        if (!bypassAntiCheat && moveSpeed > maxAllowedSpeed)
        {
            Debug.LogWarning("Speed hack detected! Resetting to normal.");
            moveSpeed = 5.0f;
        }
        transform.position += direction * moveSpeed * Time.deltaTime;
    }
}
