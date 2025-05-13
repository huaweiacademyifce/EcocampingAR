using UnityEngine;

public class PlaySound : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayAudio()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
