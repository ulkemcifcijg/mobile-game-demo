using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    public float reloadTime = 3.5f;

    public void Reload()
    {
        Debug.Log("Reloading weapon... Time: " + reloadTime);
    }
}
