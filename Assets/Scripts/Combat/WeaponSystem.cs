using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    public float reloadTime = 2.1f; // Doldurma hızı %40 artırıldı
    public AudioSource reloadAudio;

    public void Reload()
    {
        if (reloadAudio != null) reloadAudio.Play();
        Debug.Log("Reloading weapon quickly! Time: " + reloadTime);
    }
}
