using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    public float sfxVolume = 1.0f;
    public float masterVolume = 1.0f; // Yeni ana ses ayarı

    public void SetMasterVolume(float vol)
    {
        masterVolume = Mathf.Clamp01(vol);
        AudioListener.volume = masterVolume;
    }

    public void SetSfxVolume(float vol)
    {
        sfxVolume = Mathf.Clamp01(vol);
    }
}
