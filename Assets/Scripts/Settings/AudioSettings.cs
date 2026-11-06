using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    public float sfxVolume = 1.0f;

    public void SetSfxVolume(float vol)
    {
        sfxVolume = Mathf.Clamp01(vol);
    }
}
