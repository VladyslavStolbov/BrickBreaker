using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }

    public AudioClip HitSound;
    public AudioClip WinSound;
    public AudioClip LoseSound;

    private AudioSource _audioSource;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        _audioSource = this.gameObject.AddComponent<AudioSource>(); 
    }

    public void PlaySound(AudioClip sound)
    {
        if (sound != null)
        {
            _audioSource.PlayOneShot(sound);
        }
    }
}
